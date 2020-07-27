using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiKeyBard
{
    public class Midi
    {
        const int VelocityMax = 127;
        public const int NoteNumberMax = 127;

        CMIDIIn _inPort;
        System.Timers.Timer _recvTimer;

        public Midi()
        {
            CMIDIIOLib.SetLanguage(CMIDIIOLib.Japanese);
            CMIDIIOLib.SetIsShowDetail(true);
            _recvTimer = new System.Timers.Timer();
            _recvTimer.Elapsed += _recvTimer_Elapsed;
            _recvTimer.Interval = 1;
        }

        void _recvTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            byte[] message = _inPort.GetMIDIMessage();

            var len = message.Length;
            if (len > 0)
            {
                inPort_Received(message);
            } 
        }

        public static List<string> EnumInput()
        {

            int count = CMIDIIn.GetDeviceNum();
            var list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                list.Add(CMIDIIn.GetDeviceName(i));
            }
            return list;
        }

        public void OpenPort(string name)
        {
            _recvTimer.Stop();

            _inPort = new CMIDIIn();
            try
            {
                _inPort.Reopen(name);
                _recvTimer.Start();
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
            
        }
        public void ClosePort()
        {

            if (_inPort == null)
            {
                return;
            }

            try
            {
                _recvTimer.Stop();
                _inPort.Close();
                _inPort = null;
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }

        }

        public static void inPort_Received(byte[] message)
        {
            try
            {
                if (message.Length < 2)
                {
                    return;
                }

                var ch = ByteToMidiCh(message[0]);
                if ((Setting.MidiInCh != -1) && (Setting.MidiInCh != ch))
                {
                    return;
                }

                var type = ByteToMidiEventType(message[0]);
                switch (type)
                {
                    case MidiEventType.NOTE_ON:
                        SubReceivedNoteOn(message);
                        break;
                    case MidiEventType.NOTE_OFF:
                        SubReceivedNoteOff(message);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }

            return;
        }

        private static void SubReceivedNoteOn(byte[] message)
        {
            int velocity = GetMidiMessageVelocity(message,VelocityMax);
            if (velocity > Setting.NoteOffThreshold)
            {
                PutNoteOn(message);
            }
            else
            {
                PutNoteOff(message);
            }
        }

        private static void SubReceivedNoteOff(byte[] message)
        {
            PutNoteOff(message);
        }

        private static void PutNoteOn(byte[] message)
        {
            if (Setting.EnableArpeggiator)
            {
                Arpeggiator.Instance.PutOn(message[1]);
            }
            else
            {
                Channel.Instance.Put(new NoteEvent(message[1], true));
            }
        }
        
        private static void PutNoteOff(byte[] message)
        {
            if (Setting.EnableArpeggiator)
            {
                Arpeggiator.Instance.TakeOff(message[1]);
            }
            else
            {
                Channel.Instance.Put(new NoteEvent(message[1], false));
            }
        }

        private static int GetMidiMessageVelocity(byte[] message, int defaultVelocity)
        {
            int velocity = defaultVelocity;
            if (message.Length > 2)
            {
                velocity = message[2];
            }
            return velocity;
        }

        private bool enableArpeggiator = false;
        public void SetEnableArpeggiator(bool enable)
        {
            enableArpeggiator = enable;
        }

        enum MidiEventType
        {
            NOTE_ON = 0x90,
            NOTE_OFF = 0x80,
            OTHER = 0x00
        }

        private static MidiEventType ByteToMidiEventType(byte message)
        {

            byte type = (byte)(0xF0 & message);
            switch (type)
            {
                case (byte)MidiEventType.NOTE_ON:
                    return MidiEventType.NOTE_ON;
                case (byte)MidiEventType.NOTE_OFF:
                    return MidiEventType.NOTE_OFF;
                default:
                    return MidiEventType.OTHER;
            }
 
        }

        private static int ByteToMidiCh(byte message)
        {
            return (0x0F & message);
        }
    }
}
