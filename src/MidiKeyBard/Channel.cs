using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace MidiKeyBard
{
    class Channel
    {
        private ConcurrentQueue<NoteEvent> _queue;
        private static Channel _channel = new Channel();

        public static Channel Instance = _channel;

        private Channel()
        {
            _queue = new ConcurrentQueue<NoteEvent>();
        }


        public void Put(NoteEvent note)
        {
            _queue.Enqueue(note);
        }

        public NoteEvent Get()
        {
            NoteEvent note;

            while (_queue.Count == 0)
            {
                System.Threading.Thread.Sleep(1);
            }

            if (_queue.TryDequeue(out note))
            {
                return note;
            }
            else
            {
                //TODO:
                throw new InvalidOperationException("NoteEvent Queue is empty.");
            }
        }
    }
}
