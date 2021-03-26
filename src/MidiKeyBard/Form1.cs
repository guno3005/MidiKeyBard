using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiKeyBard
{
    public partial class Form1 : Form
    {
        private static InOutControl _inOutControl;
        private List<System.Diagnostics.Process> _processList = null;

        public Form1()
        {
            InitializeComponent();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
            _inOutControl = new InOutControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "  " + Application.ProductVersion;
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);


            if (KeySetting.LoadSettingFile() == false)
            {
                var map = KeySetting.GetPresetA();
                KeySetting.SetKeyMap(map);
            }
            Setting.LoadSettingFile();

            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = Setting.GetPriorityClass();

            ResetComboBox();
            ResetMidiOut();
            ResetMidiIn();

            _inOutControl.StartMainLoop();

            if (Setting.EnableTarget)
            {
                _processList = ProcessCatcher.GetWindowProcess();
                ResetComboTargetWindow(_processList, Setting.TargetName, Setting.TargetSelected);
            }
            UpdateDisplay();
        }

        private void ResetMidiIn()
        {
            if (comboBoxMidiIn.Items.Count == Setting.MidiInCount)
            {
                comboBoxMidiIn.SelectedIndex = Setting.SelectedMidiInIndex;
            }
            else
            {
                if(comboBoxMidiIn.Items.Count > 1)
                {
                    comboBoxMidiIn.SelectedIndex = 1;
                }
                else
                {
                    comboBoxMidiIn.SelectedIndex = 0;
                }
                Setting.SelectedMidiInIndex = comboBoxMidiIn.SelectedIndex;
            }
            Setting.MidiInCount = comboBoxMidiIn.Items.Count;
        }

        private void ResetMidiOut()
        {
            if (Setting.EnebleMidiOut)
            {
                if (comboBoxMidiOut.Items.Count > 0)
                {
                    if (comboBoxMidiOut.Items.Count == Setting.MidiOutCount)
                    {
                        comboBoxMidiOut.SelectedIndex = Setting.SelectedMidiOutIndex;
                    }
                    else
                    {
                        comboBoxMidiOut.SelectedIndex = 0;
                        Setting.SelectedMidiOutIndex = comboBoxMidiOut.SelectedIndex;
                    }
                }
                Setting.MidiOutCount = comboBoxMidiOut.Items.Count;
            }
            else
            {
                // disable MidiOut
                _inOutControl.CloseMidiOut();
            }
        }

        private void comboBoxMidiIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReopenSelectedMidiIn();
        }

        private void ReopenSelectedMidiIn()
        {
            _inOutControl.CloseMidiIn();
            var item = comboBoxMidiIn.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(item))
            {
                comboBoxMidiIn.BackColor = Color.Empty;
                Setting.SelectedMidiInIndex = comboBoxMidiIn.SelectedIndex;
                return;
            }

            labelStatus.Text = String.Empty;
            try
            {
                _inOutControl.OpenMidiIn(item);
                comboBoxMidiIn.BackColor = Color.Empty;
            }
            catch (Exception ex)
            {
                //MIDIIOが複数行のex.Messageを返すので1行目のみ表示
                //例:"Could not Open nanoKEY2 (MIDI Input Device).\nMIDIIO_cpp.cpp(241) CMIDIIn::Reopen"
                var exLines = ex.Message.Split(new[] { '\n' });
                labelStatus.Text = "Error! : " + exLines[0];
                comboBoxMidiIn.BackColor = Color.Red;
            }
            Setting.SelectedMidiInIndex = comboBoxMidiIn.SelectedIndex;

        }

        private void ResetComboBox()
        {
            var inList = Midi.EnumInput();
            inList.Insert(0, String.Empty);    //MidiInしない場合用の選択肢を追加
            comboBoxMidiIn.Items.Clear();
            comboBoxMidiIn.Items.AddRange(inList.ToArray<string>());

            var outList = Midi.EnumOutput();
            outList.Insert(0, String.Empty);    //MidiOutしない場合用の選択肢を追加
            comboBoxMidiOut.Items.Clear();
            comboBoxMidiOut.Items.AddRange(outList.ToArray<string>());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //CloseMidis();
            if (_inOutControl != null)
            {
                _inOutControl.CloseMidiIn();
                _inOutControl.CloseMidiOut();
            }

            Setting.SaveState();
        }

        private void ShowOptionForm()
        {
            _inOutControl.Stop();
            
            Arpeggiator.Instance.SetEnable(false);
            new OptionForm().ShowDialog();

            ResetMidiIn();
            ReopenSelectedMidiIn();
            ResetMidiOut();
            ReopenSelectedMidiOut();
            UpdateDisplay();

            if(Setting.EnableTarget)
            {
                _processList = ProcessCatcher.GetWindowProcess();
                ResetComboTargetWindow(_processList, Setting.TargetName, Setting.TargetSelected);
            }

            _inOutControl.StartMainLoop();
        }

        private void UpdateDisplay()
        {
            panelMidiOut.Visible = Setting.EnebleMidiOut;
            panelTarget.Visible = Setting.EnableTarget;
        }

        private void comboBoxMidiOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReopenSelectedMidiOut();
        }

        private void ReopenSelectedMidiOut()
        {
            if (Setting.EnebleMidiOut == false)
            {
                _inOutControl.CloseMidiOut();
                return;
            }

            _inOutControl.CloseMidiOut();
            var item = comboBoxMidiOut.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(item))
            {
                comboBoxMidiOut.BackColor = Color.Empty;
                Setting.SelectedMidiOutIndex = comboBoxMidiOut.SelectedIndex;
                return;
            }

            try
            {
                _inOutControl.OpenMidiOut(item);
                comboBoxMidiOut.BackColor = Color.Empty;
            }
            catch (Exception ex)
            {
                //MIDIIOが複数行のex.Messageを返すので1行目のみ表示
                //例:"Could not Open nanoKEY2 (MIDI Output Device).\nMIDIIO_cpp.cpp(492) CMIDIOut::Reopen"
                var exLines = ex.Message.Split(new[] { '\n' });
                labelStatus.Text = "Error! : " + exLines[0];
                comboBoxMidiOut.BackColor = Color.Red;
            }
            Setting.SelectedMidiOutIndex = comboBoxMidiOut.SelectedIndex;
        }

        private void comboBoxMidiIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //当アプリにフォーカスがある場合のMIDI入力で
            //うっかりデバイスが変更されないように、ComboBoxへのキー入力を無効化
            e.Handled = true;
        }

        private void comboBoxMidiOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            //当アプリにフォーカスがある場合のMIDI入力で
            //うっかりデバイスが変更されないように、ComboBoxへのキー入力を無効化
            e.Handled = true;
        }
        private void comboBoxTargetWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            //当アプリにフォーカスがある場合のMIDI入力で
            //うっかりデバイスが変更されないように、ComboBoxへのキー入力を無効化
            e.Handled = true;
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOptionForm();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ret = saveFileDialog1.ShowDialog();
            if (ret != DialogResult.OK)
            {
                return;
            }
            var dstFile = saveFileDialog1.FileName;

            try
            {
                Setting.SaveState();
                File.Copy(Setting.IniFilePath, dstFile, true);
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Error! : Failed to save file.\n" + ex.Message;
                return;
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ret = openFileDialog1.ShowDialog();
            if(ret != DialogResult.OK)
            {
                return;
            }
            var iniFile = openFileDialog1.FileName;

            try
            {
                File.Copy(iniFile, Setting.IniFilePath,true);
            }
            catch(Exception ex)
            {
                labelStatus.Text = "Error! : Failed to load file.\n" + ex.Message;
                return;
            }
            _inOutControl.Stop();

            if (KeySetting.LoadSettingFile() == false)
            {
                var map = KeySetting.GetPresetA();
                KeySetting.SetKeyMap(map);
            }
            Setting.LoadSettingFile();
            ResetComboBox();
            ResetMidiIn();
            ReopenSelectedMidiIn();
            ResetMidiOut();
            ReopenSelectedMidiOut();
            UpdateDisplay();

            _inOutControl.StartMainLoop();

        }

        private void comboBoxTargetWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntPtr _SelectedHandle = IntPtr.Zero;
            string _SelectedProcessName = "";
            var item = comboBoxTargetWindow.SelectedItem;
            if (item.GetType() == typeof(ProcessItem))
            {
                var pItem = ((ProcessItem)item);
                if (pItem.Process != null)
                {
                    _SelectedHandle = pItem.Process.MainWindowHandle;
                    _SelectedProcessName = pItem.GetWindowTitleWithIndex();
                    //return;
                }

            }
            //_SelectedHandle = IntPtr.Zero;
            //_SelectedProcessName = "";

            Setting.TargetHandle = _SelectedHandle;
            Setting.TargetSelected = _SelectedProcessName;

            return;
        }

        private void buttonRefreshProcessList_Click(object sender, EventArgs e)
        {
            _processList = ProcessCatcher.GetWindowProcess();
            ResetComboTargetWindow(_processList, Setting.TargetName, Setting.TargetSelected);
        }

        private void buttonProcessPopup_Click(object sender, EventArgs e)
        {
            if(Setting.TargetHandle == IntPtr.Zero)
            {
                return;
            }
            ProcessCatcher.PopupWindowProcess(Setting.TargetHandle);
        }

        private void ResetComboTargetWindow(List<System.Diagnostics.Process> processList, string targetName, string selectedName)
        {
            //const string AppNameFF14 = "ffxiv";
            int selectedIndex = 0;
            bool showsAll = String.IsNullOrWhiteSpace(targetName);
            comboBoxTargetWindow.Items.Clear();
            comboBoxTargetWindow.Items.Add(new ProcessItem(null));
            foreach (var p in processList)
            {
                if ((showsAll == false) && (p.ProcessName.ToUpper().Contains(targetName.ToUpper()) == false))
                {
                    continue;
                }
                int countSameName = comboBoxTargetWindow.Items.Cast<ProcessItem>().Where((item) => {
                    if(item.Process == null)
                    {
                        return false;
                    }
                    else
                    {
                        return (item.Process.MainWindowTitle) == (p.MainWindowTitle);
                    }
                }).Count();

                var pItem = new ProcessItem(p, countSameName);
                comboBoxTargetWindow.Items.Add(pItem);
                if ((pItem.GetWindowTitleWithIndex() == selectedName) && (selectedIndex == 0))
                {
                    selectedIndex = comboBoxTargetWindow.Items.Count - 1;
                }
            }

            comboBoxTargetWindow.SelectedIndex = selectedIndex;
        }

    }
}
