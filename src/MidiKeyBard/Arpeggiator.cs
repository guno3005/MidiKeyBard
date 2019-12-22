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
        private ConcurrentQueue<byte> _offQueue;
        private ConcurrentQueue<byte> _onQueue;
        private static Arpeggiator _instance = new Arpeggiator();
        private List<Byte> _chordNotes;
        private bool _enable = false;
        public static Arpeggiator Instance = _instance;

        private Arpeggiator()
        {
            _chordNotes = new List<Byte>();
            _offQueue = new ConcurrentQueue<byte>();
            _onQueue = new ConcurrentQueue<byte>();
        }

        public void SetEnable(bool enable)
        {
            if(enable){
                Start();
            }else{
                Stop();
            }
        }

        public void Start()
        {
            if (_enable)
            {
                ; //do nothing
            }
            else
            {
                _enable = true;
                Task.Run(() => { MainLoop(); });
            }
        }
        public void Stop()
        {
            _enable = false;
        }
        public void MainLoop()
        { 
            while(_enable)
            {
                foreach (var note in _chordNotes)
                {
                    Channel.Instance.Put(new NoteEvent(note, true));
                    System.Threading.Thread.Sleep((int)(Setting.ArpeggiatorDelay));
                    Channel.Instance.Put(new NoteEvent(note, false));
                }

                UpdateChordNotes();

                System.Threading.Thread.Sleep(1);
            }
        }

        private void UpdateChordNotes()
        {
            while (_onQueue.Count > 0)
            {
                byte note;
                if (_onQueue.TryDequeue(out note))
                {
                    if (_chordNotes.Contains(note))
                    {
                        ; //do nothing
                    }
                    else
                    {
                        _chordNotes.Add(note);
                    }
                }
                else
                {
                    //TODO:
                    throw new InvalidOperationException("onQueue is empty.");
                }

            }
            while (_offQueue.Count > 0)
            {
                byte note;
                if (_offQueue.TryDequeue(out note))
                {
                    if (_chordNotes.Contains(note))
                    {
                        _chordNotes.Remove(note);
                    }
                    else
                    {
                        ; //do nothing
                    }
                }
                else
                {
                    //TODO:
                    throw new InvalidOperationException("offQueue is empty.");
                }


            }
        }

        public void PutOn(byte note)
        {
            if (_onQueue.Contains(note))
            {
                ; //do nothing
            }
            else
            {
                _onQueue.Enqueue(note);
            }            
        }
        public void TakeOff(byte note)
        {
            if (_offQueue.Contains(note))
            {
                ; //do nothing
            }
            else
            {
                _offQueue.Enqueue(note); 
            }
        }
    }
}
