using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiKeyBard
{
    public partial class Form1 : Form
    {
        private static Midi _midi;

        public Form1()
        {
            InitializeComponent();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
            _midi = new Midi();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "  " + Application.ProductVersion ;

            if (KeySetting.LoadSettingFile() == false)
            {
                var map = KeySetting.GetPresetA();
                KeySetting.SetKeyMap(map);
            }
            Setting.LoadSettingFile();

            ResetComboBox();
            if (comboBoxMidiIn.Items.Count > 0)
            {
                if(comboBoxMidiIn.Items.Count== Setting.MidiInCount)
                {
                    comboBoxMidiIn.SelectedIndex = Setting.SelectedMidiInIndex;
                }
                else
                {
                    comboBoxMidiIn.SelectedIndex = 0;
                    Setting.SelectedMidiInIndex = comboBoxMidiIn.SelectedIndex;
                }
            }
            Setting.MidiInCount = comboBoxMidiIn.Items.Count;

            resetMidiOut();


            mainLoop();
            Arpeggiator.Instance.SetEnable(Setting.EnableArpeggiator);

            UpdateDisplay();
        }

        private void resetMidiOut()
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
                _midi.CloseOutPort();
            }
        }

        private void mainLoop()
        {
            Task.Factory.StartNew(() =>
            {
                var sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                while (true)
                {
                    var note = Channel.Instance.Get();
                    var key = KeySetting.NoteToKeyCode(note.Note);
                    if (key == 0)
                    {
                        continue;
                    }

                    if (Setting.NoteDelay > 0)
                    {
                        if (note.IsOn)
                        {
                            var elapse = sw.ElapsedMilliseconds;
                            if (elapse < Setting.NoteDelay)
                            {
                                System.Threading.Thread.Sleep((int)(Setting.NoteDelay - elapse));
                            }
                            sw.Restart();
                        }
                    }
                    Keyboard.SendKey(key, note.IsOn);
                }


            });
        }

        private void comboBoxMidiIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CloseMidi();
            _midi.ClosePort();
            var item = comboBoxMidiIn.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(item))
            {
                comboBoxMidiIn.BackColor = Color.Empty;
                return;
            }

            //_midi = new Midi();
            labelStatus.Text = String.Empty;
            try
            {
                _midi.OpenPort(item);
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

        // Midiデバイスの再取得ができないので断念…
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            _midi.ClosePort();
            ResetComboBox();
        }

        private void ResetComboBox()
        {
            var list = Midi.EnumInput();
            comboBoxMidiIn.Items.Clear();
            comboBoxMidiIn.Items.AddRange(list.ToArray<string>());

            var outList = Midi.EnumOutput();
            outList.Insert(0, String.Empty);    //MidiOutしない場合用の選択肢を追加
            comboBoxMidiOut.Items.Clear();
            comboBoxMidiOut.Items.AddRange(outList.ToArray<string>());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //CloseMidis();
            if (_midi != null)
            {
                _midi.ClosePort();
            }

            Setting.SaveState();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            new OptionForm().ShowDialog();
            resetMidiOut();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (Setting.EnebleMidiOut)
            {
                labelMidiOut.Visible = true;
                comboBoxMidiOut.Visible = true;
                this.Size = new Size(369,170);
                labelStatus.Location = new Point(8, 92);
            }
            else
            {
                labelMidiOut.Visible = false;
                comboBoxMidiOut.Visible = false;
                this.Size = new Size(369,145);
                labelStatus.Location = new Point(8, 67);
            }
        }

        private void comboBoxMidiOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelStatus.Text = String.Empty;

            _midi.CloseOutPort();
            var item = comboBoxMidiOut.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(item))
            {
                comboBoxMidiOut.BackColor = Color.Empty;
                return;
            }

            try
            {
                _midi.OpenOutPort(item);
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
    }
}
