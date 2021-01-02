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

        private Queue<NoteEvent> _noteQueue;  // MIDI入力された音符
        private Queue<byte> _noteOffQueue;  // 出力OFF待ちの音符
        private byte _lastOnNote = byte.MaxValue;
        private bool[] _inputNotes = new bool[Midi.NoteNumberMax + 1];  // 入力音符テーブル。押されたままの音符はtrue
        private int _inputNotesOnCount = 0; // 押されたままの音符の数（trueの数）
        private System.Diagnostics.Stopwatch _swLastNoteOn = new System.Diagnostics.Stopwatch();
        private int _noteIndex = 0;
        private bool _enable = false;

        private const int MinInterval = 50; // 連打の最小間隔。りすこさん研究による

        private Arpeggiator()
        {
            _noteQueue = new Queue<NoteEvent>();
            _noteOffQueue = new Queue<byte>();
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
            else if (!enable)
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

            int hasTableOnNote = UpdateNoteTableAndPutNote();
            if (hasTableOnNote == 0)
            {
                _lastOnNote = byte.MaxValue;
                return;
            }

            byte noteNum = Byte.MaxValue;
            for (var i = 0; i < _inputNotes.Length; i++)
            {
                noteNum = (byte)((_noteIndex + i) % _inputNotes.Length);
                if (_inputNotes[noteNum] == true)
                {
                    break;
                }
            }

            if (noteNum < _inputNotes.Length)
            {
                bool done = PutArpeggioNotes(noteNum, hasTableOnNote);
                if (done)
                {   // 音符の出力が完了したのでIndexを次へすすめる
                    _noteIndex = noteNum + 1;
                }
                // else: delay待ちのため出力しない。同じIndexでもう一度処理する
            }
            else
            {
                _noteIndex = 0;
            }

        }
        public void Put(NoteEvent note)
        {
            _noteQueue.Enqueue(note);
        }

        private int UpdateNoteTableAndPutNote()
        {
            if (_noteQueue.Count <= 0)
            {
                return _inputNotesOnCount;
            }

            NoteEvent note = _noteQueue.Dequeue();

            if (note.IsOn)
            {
                // note ON
                Channel.Instance.Put(note);
                _swLastNoteOn.Restart();
                _inputNotes[note.Note] = true;
                _noteOffQueue.Enqueue(note.Note);
                _lastOnNote = note.Note;
            }
            else
            {
                // note.Off
                Channel.Instance.Put(note);
                _inputNotes[note.Note] = false;
            }

            _inputNotesOnCount = _inputNotes.Where((noteOn) => noteOn).Count();
            return _inputNotesOnCount;
        }

        private enum ArpgEvent
        {
            None,
            OtherNote,
            Tremolo
        }

        private bool PutArpeggioNotes(byte noteNum, int noteOnCount)
        {
            ArpgEvent arpgEvent;


            if (_lastOnNote == noteNum)
            {
                if (Setting.EnableTremolo && (noteOnCount == 1))
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

            if (arpgEvent == ArpgEvent.OtherNote)
            {   // 最後に出力した音と異なる音高
                var arpgValue = CalcArpgTimeValue(Setting.ArpeggiatorInterval, Setting.NoteDelay, noteOnCount);
                if ((_swLastNoteOn.ElapsedMilliseconds > arpgValue)
                    && (_noteOffQueue.Count > 0))
                {
                    while (_noteOffQueue.Count > 0)
                    {
                        var oldNote = _noteOffQueue.Dequeue();
                        Channel.Instance.Put(new NoteEvent(oldNote, false));
                    }
                }

                if (_swLastNoteOn.ElapsedMilliseconds > arpgValue)
                {
                    Channel.Instance.Put(new NoteEvent(noteNum, true));
                    _noteOffQueue.Enqueue(noteNum);
                    _lastOnNote = noteNum;
                    _swLastNoteOn.Restart();
                    return true;
                }
                return false;
            }
            else if (arpgEvent == ArpgEvent.Tremolo)
            {   // 最後に出力した音と同じ音高 & トレモロ有効
                var tremoloValue = CalcTremoloTimeValue(Setting.ArpeggiatorInterval, Setting.NoteDelay);
                if ((_swLastNoteOn.ElapsedMilliseconds > tremoloValue)
                    && (_noteOffQueue.Count > 0))
                {
                    while (_noteOffQueue.Count > 0)
                    {
                        var oldNote = _noteOffQueue.Dequeue();
                        Channel.Instance.Put(new NoteEvent(oldNote, false));
                    }
                }
                if (_swLastNoteOn.ElapsedMilliseconds > (tremoloValue + Setting.NoteDelay))
                {
                    Channel.Instance.Put(new NoteEvent(noteNum, true));
                    _noteOffQueue.Enqueue(noteNum);
                    _lastOnNote = noteNum;
                    _swLastNoteOn.Restart();
                    return true;
                }
                return false;
            }
            else
            {   // 最後に出力した音と同じ音高 & トレモロ無効
                // do nothing
                return true;
            }
        }

        private static long CalcArpgTimeValue(long interval, long noteDelay, long count)
        {
            if (count < 2)
            {
                return CalcTremoloTimeValue(interval, noteDelay);
            }
            else
            {
                long tmp = (long)(interval / count);
                return Math.Max(Math.Max(tmp, noteDelay), MinInterval);
            }
        }
        private static long CalcTremoloTimeValue(long interval, long noteDelay)
        {
            return (Math.Max(interval, MinInterval) - noteDelay);
        }
    }
}
