using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace MidiKeyBard
{
    class Arpeggiator
    {
        private static Arpeggiator _instance = new Arpeggiator();
        public static Arpeggiator Instance = _instance;

        private ConcurrentQueue<NoteEvent> _noteQueue;  // MIDI入力された音符
        private Stack<byte> _noteOffStack;  // 出力OFF待ちの音符
        private bool[] _inputNotes = new bool[Midi.NoteNumberMax + 1];  // 押されたままの音符はtrue
        private int _inputNotesOnCount = 0; // 押されたままの音符の数（trueの数）
        private System.Diagnostics.Stopwatch _swLastNoteOn = new System.Diagnostics.Stopwatch();
        private int _noteIndex = 0;
        private bool _enable = false;

        private Arpeggiator()
        {
            _noteQueue = new ConcurrentQueue<NoteEvent>();
            _noteOffStack = new Stack<byte>();
        }

        public void SetEnable(bool enable)
        {
            if (enable && !_enable)
            {
                // Start
                _enable = true;
                _inputNotes.Initialize();
                _swLastNoteOn.Start();
            }
            else if(!enable)
            {
                // Stop
                _enable = false;
                _inputNotes.Initialize();
                _swLastNoteOn.Reset();
            }
            else
            {
                ; //do nothing

            }
        }


        public void Update()
        {
            if (_enable == false)
            {
                return;
            }

            var hasTableOnNote = UpdateChordNotesAndPutNote();
            if (hasTableOnNote == 0)
            {
                //if (_lastAutoOnNote <= Midi.NoteNumberMax)
                //{
                //    DebugLog.WriteLine(_lastAutoOnNote.ToString() + " OFF");
                //    Channel.Instance.Put(new NoteEvent(_lastAutoOnNote, false));
                //    _outputNotes[_lastAutoOnNote] = false;
                //    _lastAutoOnNote = Byte.MaxValue;
                //}
                return;
            }

            var noteNum = Byte.MaxValue;
            for (var i = 0; i < _inputNotes.Length; i++)
            {
                noteNum = (Byte)((_noteIndex + i) % _inputNotes.Length);
                if (_inputNotes[noteNum] == true)
                {
                    break;
                }
            }

            if (noteNum < _inputNotes.Length)
            {
                DebugLog.WriteLine("noteNum:" + noteNum.ToString());
                var done = PutArpeggioNotes(noteNum, hasTableOnNote);
                if (done)
                {
                    _noteIndex = noteNum + 1;
                }
            }
            else
            {
                _noteIndex = 0;
            }

        }

        enum ArpgEvent
        {
            None,
            OtherNote,
            Tremolo
        }


        private bool PutArpeggioNotes(byte noteNum, int noteOnCount)
        {
            ArpgEvent arpgEvent;
            if (_noteOffStack.Count == 0)
            {
                arpgEvent = ArpgEvent.OtherNote;
            }
            else
            {
                var lastNote = _noteOffStack.Peek();
                if (lastNote == noteNum)
                {
                    if (Setting.EnableTremolo)
                    {
                        arpgEvent = ArpgEvent.Tremolo;
                    }
                    else
                    {
                        arpgEvent = ArpgEvent.None;
                    }
                }
                else
                {
                    arpgEvent = ArpgEvent.OtherNote;
                }
            }


            if (arpgEvent == ArpgEvent.OtherNote)
            {   // 異なる音高
                var delay = CalcArpgDelay(Setting.ArpeggiatorDelay, noteOnCount, Setting.NoteDelay);
                if ((_swLastNoteOn.ElapsedMilliseconds > (delay - Setting.NoteDelay))
                    && (_noteOffStack.Count > 0))
                {
                    while (_noteOffStack.Count > 0)
                    {
                        var oldNote = _noteOffStack.Pop();
                        DebugLog.WriteLine(oldNote.ToString() + " OFF");
                        Channel.Instance.Put(new NoteEvent(oldNote, false));
                    }
                }

                if (_swLastNoteOn.ElapsedMilliseconds > delay)
                {
                    DebugLog.WriteLine(noteNum.ToString() + " ON");
                    Channel.Instance.Put(new NoteEvent(noteNum, true));
                    _noteOffStack.Push(noteNum);
                    _swLastNoteOn.Restart();
                    return true;
                }
                return false;
            }
            else if (arpgEvent == ArpgEvent.Tremolo)
            {   // 同じ音高 & トレモロ有効
                var delay = CalcArpgDelay(Setting.ArpeggiatorDelay, 0, Setting.NoteDelay);
                if ((_swLastNoteOn.ElapsedMilliseconds > (delay - Setting.NoteDelay))
                    && (_noteOffStack.Count > 0))
                {
                    while (_noteOffStack.Count > 0)
                    {
                        var oldNote = _noteOffStack.Pop();
                        DebugLog.WriteLine(oldNote.ToString() + " OFF");
                        Channel.Instance.Put(new NoteEvent(oldNote, false));
                    }
                }
                if (_swLastNoteOn.ElapsedMilliseconds > delay)
                {
                    DebugLog.WriteLine(noteNum.ToString() + " ON");
                    Channel.Instance.Put(new NoteEvent(noteNum, true));
                    _noteOffStack.Push(noteNum);
                    _swLastNoteOn.Restart();
                    return true;
                }
                return false;
            }
            else
            {
                // (note == _lastOnNote)
                // do nothing
                return false;
            }
        }

        private int UpdateChordNotesAndPutNote()
        {
            if (_noteQueue.Count <= 0)
            {
                return _inputNotesOnCount;
            }

            bool changed = false;
            NoteEvent note;

            if (_noteQueue.TryDequeue(out note))
            {
                changed = true;
                if (note.IsOn)
                {
                    // note ON
                    DebugLog.WriteLine(note.Note.ToString() + " ON");
                    Channel.Instance.Put(note);
                    _swLastNoteOn.Restart();
                    _inputNotes[note.Note] = true;
                    _noteOffStack.Push(note.Note);
                }
                else
                {
                    // note.Off
                    DebugLog.WriteLine(note.Note.ToString() + " OFF");
                    Channel.Instance.Put(note);
                    _inputNotes[note.Note] = false;
                }
            }
            else
            {
                //TODO:
                throw new InvalidOperationException("noteQueue is empty.");
            }


            if (changed)
            {
                _inputNotesOnCount = _inputNotes.Where((noteOn) => noteOn).Count();
            }
            return _inputNotesOnCount;
        }

        public void Put(NoteEvent note)
        {
            _noteQueue.Enqueue(note);
        }

        private static long CalcArpgDelay(long arpgDelay, long count, long noteDelay)
        {
            if (count < 2)
            {
                return Math.Max(arpgDelay, noteDelay);
            }
            else
            {
                var arpgCut1 = (int)(arpgDelay * 2 / count);
                return Math.Max(arpgCut1, noteDelay);
            }
        }
    }
}
