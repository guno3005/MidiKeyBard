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
        CMIDIOut _outPort;

        public Midi()
        {
            CMIDIIOLib.SetLanguage(CMIDIIOLib.English);
            CMIDIIOLib.SetIsShowDetail(true);
        }

        public void ReceiveMIDIMessage()
        {
            if(_inPort == null)
            {
                return;
            }

            byte[] message = _inPort.GetMIDIMessage();
            var len = message.Length;
            if (len > 0)
            {
                _outPort?.PutMIDIMessage(message);
                MidiInReceived(message);
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

        public void OpenInPort(string name)
        {
            _inPort = new CMIDIIn();
            try
            {
                _inPort.Reopen(name);
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
        }

        public void CloseInPort()
        {
            if (_inPort == null)
            {
                return;
            }

            try
            {
                _inPort.Close();
                _inPort = null;
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
        }

        private static void MidiInReceived(byte[] message)
        {
            try
            {
                if (message.Length < 2)
                {
                    return;
                }

                var ch = ByteToMidiCh(message[0]);
                if ((Setting.MidiInCh != Setting.MidiInChAll) && (Setting.MidiInCh != ch))
                {
                    return;
                }

                var type = ByteToMidiEventType(message[0]);
                switch (type)
                {
                    case MidiEventType.NOTE_ON:
                        DebugLog.WriteLine(message[0].ToString() + " " + message[1].ToString() + " ON");
                        SubReceivedNoteOn(message);
                        break;
                    case MidiEventType.NOTE_OFF:
                        DebugLog.WriteLine(message[0].ToString() + " " + message[1].ToString() + " OFF");
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
            int velocity = GetMidiMessageVelocity(message, VelocityMax);
            if (velocity > Setting.NoteOffThreshold)
            {
                PutNoteOn(message[1]);
            }
            else
            {
                PutNoteOff(message[1]);
            }
        }

        private static void SubReceivedNoteOff(byte[] message)
        {
            PutNoteOff(message[1]);
        }

        private static void PutNoteOn(byte noteNum)
        {
            if (Setting.EnableArpeggiator)
            {
                Arpeggiator.Instance.Put(new NoteEvent(noteNum, true));
            }
            else
            {
                Channel.Instance.Put(new NoteEvent(noteNum, true));
            }
        }
        
        private static void PutNoteOff(byte noteNum)
        {
            if (Setting.EnableArpeggiator)
            {
                Arpeggiator.Instance.Put(new NoteEvent(noteNum, false));
            }
            else
            {
                Channel.Instance.Put(new NoteEvent(noteNum, false));
            }
        }

        public static List<string> EnumOutput()
        {
            int count = CMIDIOut.GetDeviceNum();
            var list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                list.Add(CMIDIOut.GetDeviceName(i));
            }
            return list;
        }


        public void OpenOutPort(string name)
        {
            _outPort = new CMIDIOut();
            try
            {
                _outPort.Reopen(name);
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }

        }
        public void CloseOutPort()
        {

            if (_outPort == null)
            {
                return;
            }

            try
            {
                _outPort.Close();
                _outPort = null;
            }
            catch (Exception)
            {
                //TODO:
                throw;
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

        private enum MidiEventType
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
