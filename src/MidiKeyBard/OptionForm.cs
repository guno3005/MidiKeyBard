﻿using System;
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
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            //Setting.NoteDelay
            nudNoteDelay.Value = Setting.NoteDelay;
            nudNoteOffVelocity.Value = Setting.NoteOffThreshold;
            chbArpeggiatorEnable.Checked = Setting.EnableArpeggiator;
            nudArpegDelay.Value = Setting.ArpeggiatorDelay; 

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
            Setting.ArpeggiatorDelay = Math.Max((int)nudArpegDelay.Value, Setting.NoteDelay);
            Setting.SaveFile();

            KeySetting.SetKeyMap(KeySettingMap);
            KeySetting.SaveFile();
            Close();

            Arpeggiator.Instance.SetEnable(Setting.EnableArpeggiator);
            
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

    }
}