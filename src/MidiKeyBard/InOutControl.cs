using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiKeyBard
{
    class InOutControl
    {
        private static Midi _midi;
        private bool _cancel = false;
        private bool _canceled = false;

        public InOutControl()
        {
            _midi = new Midi();
        }

        public void Stop()
        {
            _cancel = true;
            while (!_canceled)
            {
                Task.Delay(100).Wait();
            }
            _cancel = false;
        }

        public void StartMainLoop()
        {
            _canceled = false;
            Arpeggiator.Instance.SetEnable(Setting.EnableArpeggiator);

            Task.Factory.StartNew(() =>
            {
                var swNoteDelay = new System.Diagnostics.Stopwatch();
                swNoteDelay.Start();
                short inputKey = 0;
                NoteEvent inputNote = null;
                while (!_cancel)
                {
                    for (var i = 0; i < 10; i++)
                    {
                        if (_cancel)
                        {
                            break;
                        }

                        _midi.ReceiveMIDIMessage();

                        Arpeggiator.Instance.Update();


                        if (inputKey == 0)
                        {
                            inputNote = Channel.Instance.Get();
                            if (inputNote != null)
                            {
                                inputKey = KeySetting.NoteToKeyCode(inputNote.Note);
                            }
                        }

                        if (inputKey != 0 && inputNote != null)
                        {
                            if (inputNote.IsOn)
                            {
                                var elapse = swNoteDelay.ElapsedMilliseconds;
                                if (elapse >= Setting.NoteDelay)
                                {
                                    Keyboard.SendKey(inputKey, inputNote.IsOn);
                                    swNoteDelay.Restart();
                                    inputKey = 0;
                                    inputNote = null;
                                }
                            }
                            else
                            {
                                Keyboard.SendKey(inputKey, inputNote.IsOn);
                                inputKey = 0;
                            }
                        }
                    }

                    Task.Delay(1).Wait();
                }
                _canceled = true;
            });
        }

        internal void CloseMidiOut()
        {
            _midi.CloseOutPort();
        }

        internal void CloseMidiIn()
        {
            _midi.CloseInPort();
        }

        internal void CloseDevices()
        {
            _midi.CloseInPort();
            _midi.CloseOutPort();
        }

        internal void OpenMidiIn(string item)
        {
            _midi.OpenInPort(item);
        }

        internal void OpenMidiOut(string item)
        {
            _midi.OpenOutPort(item);
        }
    }
}
