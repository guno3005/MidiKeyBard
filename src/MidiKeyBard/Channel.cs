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
            if (_queue.Count == 0)
            {
                return null;
            }

            if (_queue.TryDequeue(out NoteEvent note))
            {
                return note;
            }
            else
            {
                //TODO:
                throw new InvalidOperationException("NoteEvent Queue is empty.");
            }
        }

        //public NoteEvent WaitforMessage()
        //{
        //    while (_queue.Count == 0)
        //    {   // 受信するまで永久ループ
        //        DebugLog.WriteLine("");
        //        System.Threading.Thread.Sleep(1);   // CPU負荷軽減のため100回毎にSleep 1ms
        //        for (var i = 0; i < 100; i++)
        //    {
        //            System.Threading.Thread.Sleep(0);
        //            if (_queue.Count != 0)
        //            {
        //                break;
        //            }
        //        }
        //    }

        //    if (_queue.TryDequeue(out NoteEvent note))
        //    {
        //        return note;
        //    }
        //    else
        //    {
        //        //TODO:
        //        throw new InvalidOperationException("NoteEvent Queue is empty.");
        //    }
        //}
    }
}
