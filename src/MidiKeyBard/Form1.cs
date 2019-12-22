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
            if (comboBox1.Items.Count > 0)
            {
                if(comboBox1.Items.Count== Setting.MidiInCount)
                {
                    comboBox1.SelectedIndex = Setting.SelectedMidiInIndex;
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                    Setting.SelectedMidiInIndex = comboBox1.SelectedIndex;
                }
            }
            Setting.MidiInCount = comboBox1.Items.Count;

            mainLoop();
            Arpeggiator.Instance.SetEnable(Setting.EnableArpeggiator);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CloseMidi();
            _midi.ClosePort();
            var item = comboBox1.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(item))
            {
                return;
            }

            //_midi = new Midi();
            _midi.OpenPort(item);
            Setting.SelectedMidiInIndex = comboBox1.SelectedIndex;
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
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list.ToArray<string>());

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
        }
    }
}
