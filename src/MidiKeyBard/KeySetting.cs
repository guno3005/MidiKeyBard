using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MidiKeyBard
{
    class Setting
    {
        public static string IniFilePath = System.IO.Path.ChangeExtension(Assembly.GetExecutingAssembly().Location, "ini");
        public static int NoteDelay = 0;
        public static int NoteOffThreshold = 0;
        public static int SelectedMidiInIndex = 0;
        public static int MidiInCount = 0;
        public static bool EnableArpeggiator = false;
        public static bool EnableTremolo = false;
        public static int ArpeggiatorInterval = 50;
        public static int MidiInCh = MidiInChAll;
        public const int MidiInChAll = -1;
        public static bool EnebleMidiOut = false;
        public static int SelectedMidiOutIndex = 0;
        public static int MidiOutCount = 0;
        public static bool EnableTarget = false;
        public static IntPtr TargetHandle = IntPtr.Zero;
        public static string TargetSelected = "";
        public static string TargetName = "";
        public static ProcessPriority Priority = 0;

        internal static void SaveFile()
        {
            try
            {
                var ini = new InifileUtils(IniFilePath);
                ini.setValue(AppSetting.Section, AppSetting.ValueSelectedMidiInIndex, SelectedMidiInIndex);
                ini.setValue(AppSetting.Section, AppSetting.ValueMidiInCount, MidiInCount);
                ini.setValue(AppSetting.Section, AppSetting.ValueSelectedMidiOutIndex, SelectedMidiOutIndex);
                ini.setValue(AppSetting.Section, AppSetting.ValueMidiOutCount, MidiOutCount);
                ini.setValue(AppSetting.Section, AppSetting.ValueNoteDelay, NoteDelay);
                ini.setValue(AppSetting.Section, AppSetting.ValueNoteOffThreshold, NoteOffThreshold);
                ini.setValue(AppSetting.Section, AppSetting.ArpeggiatorInterval, ArpeggiatorInterval);
                ini.setValue(AppSetting.Section, AppSetting.ArpeggiatorEnable, EnableArpeggiator);
                ini.setValue(AppSetting.Section, AppSetting.TremoloEnable, EnableTremolo);
                ini.setValue(AppSetting.Section, AppSetting.MidiInCh, MidiInCh);
                ini.setValue(AppSetting.Section, AppSetting.EnebleMidiOut, EnebleMidiOut);
                ini.setValue(AppSetting.Section, AppSetting.EnebleTargettingProcess, EnableTarget);
                ini.setValue(AppSetting.Section, AppSetting.TargetName, TargetName);
                //ini.setValue(AppSetting.Section, AppSetting.Priority, (int)Priority); // read only
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
        }

        internal static void SaveState()
        {
            try
            {
                var ini = new InifileUtils(IniFilePath);
                ini.setValue(AppSetting.Section, AppSetting.ValueSelectedMidiInIndex, SelectedMidiInIndex);
                ini.setValue(AppSetting.Section, AppSetting.ValueMidiInCount, MidiInCount);
                ini.setValue(AppSetting.Section, AppSetting.ValueSelectedMidiOutIndex, SelectedMidiOutIndex);
                ini.setValue(AppSetting.Section, AppSetting.ValueMidiOutCount, MidiOutCount);
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
        }

        internal static void LoadSettingFile()
        {
            LoadSettingFile(Setting.IniFilePath);
        }
       internal static void LoadSettingFile(string iniFilePath)
        {
            if(System.IO.File.Exists(iniFilePath) == false)
            {
                return;
            }
            try
            {
                var ini = new InifileUtils(iniFilePath);
                NoteDelay = ini.getValueInt(AppSetting.Section, AppSetting.ValueNoteDelay);
                NoteOffThreshold = ini.getValueInt(AppSetting.Section, AppSetting.ValueNoteOffThreshold);
                SelectedMidiInIndex = ini.getValueInt(AppSetting.Section, AppSetting.ValueSelectedMidiInIndex);
                MidiInCount = ini.getValueInt(AppSetting.Section, AppSetting.ValueMidiInCount);
                EnableArpeggiator = ini.getValueBool(AppSetting.Section, AppSetting.ArpeggiatorEnable);
                EnableTremolo = ini.getValueBool(AppSetting.Section, AppSetting.TremoloEnable);
                ArpeggiatorInterval = ini.getValueInt(AppSetting.Section, AppSetting.ArpeggiatorInterval, 50);
                MidiInCh = ini.getValueInt(AppSetting.Section, AppSetting.MidiInCh, MidiInChAll);
                EnebleMidiOut = ini.getValueBool(AppSetting.Section, AppSetting.EnebleMidiOut);
                SelectedMidiOutIndex = ini.getValueInt(AppSetting.Section, AppSetting.ValueSelectedMidiOutIndex);
                MidiOutCount = ini.getValueInt(AppSetting.Section, AppSetting.ValueMidiOutCount);
                EnableTarget = ini.getValueBool(AppSetting.Section, AppSetting.EnebleTargettingProcess);
                TargetName = ini.getValueString(AppSetting.Section, AppSetting.TargetName);
                Priority = getValuePriority(ini.getValueInt(AppSetting.Section, AppSetting.Priority, (int)ProcessPriority.Default));
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
        }

        private static ProcessPriority getValuePriority(int valInt)
        {
            switch (valInt)
            {
                case (int)ProcessPriority.RealTime:
                    return ProcessPriority.RealTime;
                case (int)ProcessPriority.High:
                    return ProcessPriority.High;
                case (int)ProcessPriority.AboveNormal:
                    return ProcessPriority.AboveNormal;
                case (int)ProcessPriority.Normal:
                    return ProcessPriority.Normal;
                default:
                    return ProcessPriority.Default;
            }
        }

        internal static ProcessPriorityClass GetPriorityClass()
        {
            switch(Priority){
                case ProcessPriority.Normal:
                    return System.Diagnostics.ProcessPriorityClass.Normal;
                case ProcessPriority.AboveNormal:
                    return System.Diagnostics.ProcessPriorityClass.AboveNormal;
                case ProcessPriority.High:
                    return System.Diagnostics.ProcessPriorityClass.High;
                case ProcessPriority.RealTime:
                    return System.Diagnostics.ProcessPriorityClass.RealTime;
                default:
                    return System.Diagnostics.ProcessPriorityClass.High;
            }
        }

        private class AppSetting
        {
            public const String Section = "AppSetting";
            public const String ValueNoteDelay = "NoteDelay";
            public const String ValueNoteOffThreshold = "NoteOffThreshold";
            public const String ValueSelectedMidiInIndex = "SelectedMidiInIndex";
            public const String ValueMidiInCount = "MidiInCount";
            public const String ArpeggiatorInterval = "ArpeggiatorInterval";
            public const String ArpeggiatorEnable = "ArpeggiatorEnable";
            public const String TremoloEnable = "TremoloEnable";
            public const String MidiInCh = "MidiInCh";
            public const String EnebleMidiOut = "EnebleMidiOut";
            public const String ValueSelectedMidiOutIndex = "SelectedMidiOutIndex";
            public const String ValueMidiOutCount = "MidiOutCount";
            public const String EnebleTargettingProcess = "EnebleTargettingProcess";
            public const String TargetName = "TargetName";
            public const String Priority = "Priority";
        }
    }

    class KeySetting
    {
        public const int KeyMapSize = 0x80;
        private static short[] NoteKeyMap = new short[KeyMapSize];

        public static void Clear()
        {
            for( int i = 0; i<NoteKeyMap.Length; i++)
            {
                NoteKeyMap[i] = 0;
            }
        }

        public static void SetKeyMap(short[] map)
        {
            if(map.Length != NoteKeyMap.Length)
            {
                throw new FormatException();
            }
            for(int i=0; i<NoteKeyMap.Length; i++)
            {
                NoteKeyMap[i] = map[i];
            }
        }
        public static short[] GetKeyMap()
        {
            short[] keyMap = new short[KeyMapSize];
            for (int i = 0; i < NoteKeyMap.Length; i++)
            {
                keyMap[i] = NoteKeyMap[i];
            }
            return keyMap;
        }

        public static short[] GetPresetB()
        {
            short[] keyMap = new short[KeyMapSize];
            keyMap[0x30]=CharToKeycode('Z');
            keyMap[0x31]=CharToKeycode('S');
            keyMap[0x32]=CharToKeycode('X');
            keyMap[0x33]=CharToKeycode('D');
            keyMap[0x34]=CharToKeycode('C');
            keyMap[0x35]=CharToKeycode('V');
            keyMap[0x36]=CharToKeycode('G');
            keyMap[0x37]=CharToKeycode('B');
            keyMap[0x38]=CharToKeycode('H');
            keyMap[0x39]=CharToKeycode('N');
            keyMap[0x3a]=CharToKeycode('J');
            keyMap[0x3b]=CharToKeycode('M');
            keyMap[0x3c]=CharToKeycode(',');
            keyMap[0x3d]=CharToKeycode('L');
            keyMap[0x3e]=CharToKeycode('.');
            keyMap[0x3f]=CharToKeycode(';');
            keyMap[0x40]=CharToKeycode('/');
            keyMap[0x41]=CharToKeycode('Q');
            keyMap[0x42]=CharToKeycode('2');
            keyMap[0x43]=CharToKeycode('W');
            keyMap[0x44]=CharToKeycode('3');
            keyMap[0x45]=CharToKeycode('E');
            keyMap[0x46]=CharToKeycode('4');
            keyMap[0x47]=CharToKeycode('R');
            keyMap[0x48]=CharToKeycode('T');
            keyMap[0x49]=CharToKeycode('6');
            keyMap[0x4a]=CharToKeycode('Y');
            keyMap[0x4b]=CharToKeycode('7');
            keyMap[0x4c]=CharToKeycode('U');
            keyMap[0x4d]=CharToKeycode('I');
            keyMap[0x4e]=CharToKeycode('9');
            keyMap[0x4f]=CharToKeycode('O');
            keyMap[0x50]=CharToKeycode('0');
            keyMap[0x51]=CharToKeycode('P');
            keyMap[0x52]=CharToKeycode('-');
            keyMap[0x53]=CharToKeycode('@');
            keyMap[0x54]=CharToKeycode('[');

            return keyMap;
        }

        public static short[] GetPresetA()
        {
            short[] keyMap = new short[KeyMapSize];
            keyMap[0x30] = CharToKeycode('Z');
            keyMap[0x31] = CharToKeycode('S');
            keyMap[0x32] = CharToKeycode('X');
            keyMap[0x33] = CharToKeycode('D');
            keyMap[0x34] = CharToKeycode('C');
            keyMap[0x35] = CharToKeycode('V');
            keyMap[0x36] = CharToKeycode('G');
            keyMap[0x37] = CharToKeycode('B');
            keyMap[0x38] = CharToKeycode('H');
            keyMap[0x39] = CharToKeycode('N');
            keyMap[0x3a] = CharToKeycode('J');
            keyMap[0x3b] = CharToKeycode('M');
            keyMap[0x3c] = CharToKeycode('Q');
            keyMap[0x3d] = CharToKeycode('2');
            keyMap[0x3e] = CharToKeycode('W');
            keyMap[0x3f] = CharToKeycode('3');
            keyMap[0x40] = CharToKeycode('E');
            keyMap[0x41] = CharToKeycode('R');
            keyMap[0x42] = CharToKeycode('5');
            keyMap[0x43] = CharToKeycode('T');
            keyMap[0x44] = CharToKeycode('6');
            keyMap[0x45] = CharToKeycode('Y');
            keyMap[0x46] = CharToKeycode('7');
            keyMap[0x47] = CharToKeycode('U');
            keyMap[0x48] = CharToKeycode('I');
            keyMap[0x49] = CharToKeycode('9');
            keyMap[0x4a] = CharToKeycode('O');
            keyMap[0x4b] = CharToKeycode('0');
            keyMap[0x4c] = CharToKeycode('P');
            keyMap[0x4d] = CharToKeycode('@');
            keyMap[0x4e] = CharToKeycode('^');
            keyMap[0x4f] = CharToKeycode('[');
            keyMap[0x50] = CharToKeycode('L');
            keyMap[0x51] = CharToKeycode('.');
            keyMap[0x52] = CharToKeycode(';');
            keyMap[0x53] = CharToKeycode('/');
            keyMap[0x54] = CharToKeycode('_');

            return keyMap;
        }

        public static short NoteToKeyCode(int note)
        {
            return NoteKeyMap[note];
        }

        public static short CharToKeycode(char c)
        {
            short code;
            if (('A' <= c) && (c <= 'Z')
                || ('a' <= c) && (c <= 'z')
                || ('0' <= c) && (c <= '9'))
            {
                code = (short)char.ToUpper(c);
            }
            else
            {
                switch (c)
                {
                    case ':': code = 0xBA; break;
                    case '*': code = 0xBA; break;
                    case ';': code = 0xBB; break;
                    case '+': code = 0xBB; break;
                    case ',': code = 0xBC; break;
                    case '<': code = 0xBC; break;
                    case '-': code = 0xBD; break;
                    case '=': code = 0xBD; break;
                    case '.': code = 0xBE; break;
                    case '>': code = 0xBE; break;
                    case '/': code = 0xBF; break;
                    case '?': code = 0xBF; break;
                    case '@': code = 0xC0; break;
                    case '`': code = 0xC0; break;
                    case '[': code = 0xDB; break;
                    case '{': code = 0xDB; break;
                    case '\\': code = 0xDC; break;
                    case '|': code = 0xDC; break;
                    case ']': code = 0xDD; break;
                    case '}': code = 0xDD; break;
                    case '^': code = 0xDE; break;
                    case '~': code = 0xDE; break;
                    //case '\\': code = 0xE2; break;
                    case '_': code = 0xE2; break;
                    default: code = 0; break;
                }
            }

            return code;

        }

        internal static void SaveFile()
        {
            try
            {
                var ini = new InifileUtils(Setting.IniFilePath);
                for (int i = 0; i < KeyMapSize; i++)
                {
                    var buf = NoteKeyMap[i];
                    ini.setValue(KeyConfig.Section, KeyConfig.ValueNote(i), buf);
                }
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
            
        }

        internal static bool LoadSettingFile()
        {
            return LoadSettingFile(Setting.IniFilePath);
        }

        internal static bool LoadSettingFile(string iniFilePath)
        {
            if (System.IO.File.Exists(iniFilePath) == false)
            {
                return false;
            }
            try
            {
                var ini = new InifileUtils(Setting.IniFilePath);
                for(int i=0; i<KeyMapSize; i++)
                {
                    var buf = ini.getValueInt(KeyConfig.Section, KeyConfig.ValueNote(i));
                    NoteKeyMap[i] = (short)buf;
                }
                return true;
            }
            catch (Exception)
            {
                //TODO:
                throw;
            }
        }

        private class KeyConfig
        {
            public const String Section = "KeyConfig";
            public static String ValueNote(int note)
            {
                return String.Format("Note{0:D3}", note);
            }
        }      
    }

    class MidiKeyUtilityConfig
    {
        List<TableItem> TableItems;

        public static MidiKeyUtilityConfig LoadFile(string path)
        {
            var items = new List<TableItem>();

            var ini = new InifileUtils(path);
            var itemCount = ini.getValueInt(General.Section, General.ValueTableItemCount, KeySetting.KeyMapSize);

            for (int i = 0; i < itemCount; i++)
            {
                int note = ini.getValueInt(TableItem.Section(i), TableItem.ValueNoteNumber);
                int code = ini.getValueInt(TableItem.Section(i), TableItem.ValueKeyCode);
                int flag = ini.getValueInt(TableItem.Section(i), TableItem.ValueKeyFlag);
                if ((note == 0) && (code == 0))
                {
                    continue;
                }
                items.Add(new TableItem(note, code, flag));
            }

            var config = new MidiKeyUtilityConfig();
            config.TableItems = items;
            return config;
            
        }

        internal static short[] ToKeyMap(MidiKeyUtilityConfig config)
        {
            short[] keyMap = new short[KeySetting.KeyMapSize];
            foreach (var item in config.TableItems)
            {
                var note = item.NoteNumber;
                if (note < 0 || keyMap.Length <= note)
                {
                    Console.WriteLine("A note out of range.");
                    throw new ArgumentException(string.Format("A note out of range. note:{0}", note));
                }
                if((item.KeyCode > 0)&&(item.KeyCode < 255))    //0と255は無効なKeyCode
                {
                    keyMap[item.NoteNumber] = (short)item.KeyCode;
                }
            }

            return keyMap;
        }

        private class General
        {
            public const String Section = "General";
            public const String ValueMidiInDevice = "MidiInDevice";
            public const String ValueTableItemCount = "TableItemCount";
        }

        private class TableItem
        {
            public static String Section(int index)
            {
                return string.Format("TableItem{0:D3}", index);
            }

            public const String ValueNoteNumber = "NoteNumber";
            public const String ValueKeyCode = "KeyCode";
            public const String ValueKeyFlag = "KeyFlag";

            public int NoteNumber { private set; get; }
            public int KeyCode { private set; get; }
            public int KeyFlag { private set; get; }

            public TableItem(int note, int code, int flag)
            {
                NoteNumber = note;
                KeyCode = code;
                KeyFlag = flag;
            }

        }

    }

    public enum ProcessPriority
    {
        //Idle = -2,
        //BelowNormal = -1,
        Default = -1,
        Normal = 0,
        AboveNormal = 1,
        High = 2,
        RealTime = 3,
    }

}
