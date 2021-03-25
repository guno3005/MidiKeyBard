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
        private bool _isRunning = false;

        public InOutControl()
        {
            _midi = new Midi();
        }

        public void Stop()
        {
            _cancel = true;
            while (_isRunning)  // StartMainLoopの完了を待つ
            {
                Task.Delay(100).Wait();
            }
            _cancel = false;
        }

        public void StartMainLoop()
        {
            Arpeggiator.Instance.SetEnable(Setting.EnableArpeggiator);

            Task.Factory.StartNew(() =>
            {
                var swNoteDelay = new System.Diagnostics.Stopwatch();
                swNoteDelay.Start();
                short inputKey = 0;
                NoteEvent inputNote = null;

                try
                {
                    _isRunning = true;

                    while (!_cancel)
                    {
                        for (var i = 0; i < 10; i++)    // CPUの負荷軽減のため10回ごとにDelay
                        {
                            if (_cancel)
                            {
                                break;
                            }

                            _midi.ReceiveMIDIMessage();

                            Arpeggiator.Instance.Update();


                            if (inputKey == 0)  // 出力待ちのKey(音符)が無い場合
                            {
                                inputNote = Channel.Instance.Get();
                                if (inputNote != null)
                                {
                                    inputKey = KeySetting.NoteToKeyCode(inputNote.Note);
                                }
                            }

                            if (inputKey != 0 && inputNote != null) // 出力待ちのKey(音符)がある場合
                            {
                                if (inputNote.IsOn)
                                {   // ON のKeyはNoteDelayを経過したら出力する
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
                                {   // OFF のKeyは直ちに出力する
                                    Keyboard.SendKey(Setting.TargetHandle, inputKey, inputNote.IsOn);
                                    inputKey = 0;
                                }
                            }
                        }

                        Task.Delay(1).Wait();   // CPUの負荷軽減のためDelay
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    _isRunning = false;
                }
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
