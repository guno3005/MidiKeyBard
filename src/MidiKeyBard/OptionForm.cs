using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiKeyBard
{
    public partial class OptionForm : Form
    {
        short[] KeySettingMap;


        public OptionForm()
        {
            InitializeComponent();
            InitializeComboMidiInItems();
        }
        private void InitializeComboMidiInItems()
        {
            const string ColValue = "Value";
            const string ColText = "Text";

            var midiInItems = new DataTable();
            midiInItems.Columns.Add(ColText, typeof(string));
            midiInItems.Columns.Add(ColValue, typeof(int));
            var items = new Dictionary<string, int>()
            {
                { "ALL",  Setting.MidiInChAll },
                { "1",  0 },
                { "2",  1 },
                { "3",  2 },
                { "4",  3 },
                { "5",  4 },
                { "6",  5 },
                { "7",  6 },
                { "8",  7 },
                { "9",  8 },
                { "10",  9 },
                { "11",  10 },
                { "12",  11 },
                { "13",  12 },
                { "14",  13 },
                { "15",  14 },
                { "16",  15 },
            };
            foreach (var i in items)
            {
                var row = midiInItems.NewRow();
                row[ColText] = i.Key;
                row[ColValue] = i.Value;

                midiInItems.Rows.Add(row);
            }
            midiInItems.AcceptChanges();
            comboMidiInCh.DataSource = midiInItems;
            comboMidiInCh.DisplayMember = ColText;
            comboMidiInCh.ValueMember = ColValue;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            //Setting.NoteDelay
            nudNoteDelay.Value = Setting.NoteDelay;
            nudNoteOffVelocity.Value = Setting.NoteOffThreshold;
            chbArpeggiatorEnable.Checked = Setting.EnableArpeggiator;
            chbTremoloEnable.Checked = Setting.EnableTremolo;
            nudArpegDelay.Value = Setting.ArpeggiatorDelay;
            comboMidiInCh.SelectedValue = Setting.MidiInCh;
            checkBoxEnableMidiOut.Checked = Setting.EnebleMidiOut;

            KeySettingMap = KeySetting.GetKeyMap();
        }

        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Setting.NoteDelay = (int)nudNoteDelay.Value;
            Setting.NoteOffThreshold = (int)nudNoteOffVelocity.Value;
            Setting.EnableArpeggiator = chbArpeggiatorEnable.Checked;
            Setting.EnableTremolo = chbTremoloEnable.Checked;
            Setting.ArpeggiatorDelay = Math.Max((int)nudArpegDelay.Value, Setting.NoteDelay);
            Setting.MidiInCh = (int)comboMidiInCh.SelectedValue;
            Setting.EnebleMidiOut = checkBoxEnableMidiOut.Checked;
            Setting.SaveFile();

            KeySetting.SetKeyMap(KeySettingMap);
            KeySetting.SaveFile();
            Close();
        }
    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var config = MidiKeyUtilityConfig.LoadFile(dialog.FileName);
                    //MidiKeyUtilityConfig.SetConfig(config);
                    var map = MidiKeyUtilityConfig.ToKeyMap(config);
                    KeySettingMap = map;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Failed to load config");
                    return;
                    //throw;
                }
                MessageBox.Show("Complete");
                return;
            }
        }

        private void btnPresetA_Click(object sender, EventArgs e)
        {
            var map = KeySetting.GetPresetA();
            KeySettingMap = map;
            MessageBox.Show("Complete");
            return;
        }

        private void btnPresetB_Click(object sender, EventArgs e)
        {
            var map = KeySetting.GetPresetB();
            KeySettingMap = map;
            MessageBox.Show("Complete");
            return;
        }

        private void chbArpeggiatorEnable_CheckedChanged(object sender, EventArgs e)
        {
            chbTremoloEnable.Enabled = chbArpeggiatorEnable.Checked;
        }
    }
}
