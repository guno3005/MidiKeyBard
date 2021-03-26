namespace MidiKeyBard
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudNoteDelay = new System.Windows.Forms.NumericUpDown();
            this.nudNoteOffVelocity = new System.Windows.Forms.NumericUpDown();
            this.labelNoteDelay = new System.Windows.Forms.Label();
            this.labelNoteOffVel = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboxArpeggiator = new System.Windows.Forms.GroupBox();
            this.chbTremoloEnable = new System.Windows.Forms.CheckBox();
            this.chbArpeggiatorEnable = new System.Windows.Forms.CheckBox();
            this.nudArpegDelay = new System.Windows.Forms.NumericUpDown();
            this.labelArpgInterval = new System.Windows.Forms.Label();
            this.checkBoxEnableMidiOut = new System.Windows.Forms.CheckBox();
            this.groupBoxMidiOut = new System.Windows.Forms.GroupBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.checkBoxEnableTarget = new System.Windows.Forms.CheckBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.groupBoxNoteControl = new System.Windows.Forms.GroupBox();
            this.groupBoxPriority = new System.Windows.Forms.GroupBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.gboxMidiIn = new System.Windows.Forms.GroupBox();
            this.lblMidiInCh = new System.Windows.Forms.Label();
            this.comboMidiInCh = new System.Windows.Forms.ComboBox();
            this.gboxKeyConfig = new System.Windows.Forms.GroupBox();
            this.labelImport = new System.Windows.Forms.Label();
            this.btnPresetB = new System.Windows.Forms.Button();
            this.labelLoadPreset = new System.Windows.Forms.Label();
            this.btnPresetA = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteOffVelocity)).BeginInit();
            this.gboxArpeggiator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpegDelay)).BeginInit();
            this.groupBoxMidiOut.SuspendLayout();
            this.groupBoxNoteControl.SuspendLayout();
            this.groupBoxPriority.SuspendLayout();
            this.gboxMidiIn.SuspendLayout();
            this.gboxKeyConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudNoteDelay
            // 
            this.nudNoteDelay.Location = new System.Drawing.Point(166, 20);
            this.nudNoteDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNoteDelay.Name = "nudNoteDelay";
            this.nudNoteDelay.Size = new System.Drawing.Size(88, 19);
            this.nudNoteDelay.TabIndex = 0;
            // 
            // nudNoteOffVelocity
            // 
            this.nudNoteOffVelocity.Location = new System.Drawing.Point(166, 54);
            this.nudNoteOffVelocity.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudNoteOffVelocity.Name = "nudNoteOffVelocity";
            this.nudNoteOffVelocity.Size = new System.Drawing.Size(88, 19);
            this.nudNoteOffVelocity.TabIndex = 1;
            // 
            // labelNoteDelay
            // 
            this.labelNoteDelay.AutoSize = true;
            this.labelNoteDelay.Location = new System.Drawing.Point(6, 22);
            this.labelNoteDelay.Name = "labelNoteDelay";
            this.labelNoteDelay.Size = new System.Drawing.Size(129, 12);
            this.labelNoteDelay.TabIndex = 2;
            this.labelNoteDelay.Text = "Note Delay [0-1000 ms]";
            // 
            // labelNoteOffVel
            // 
            this.labelNoteOffVel.AutoSize = true;
            this.labelNoteOffVel.Location = new System.Drawing.Point(6, 56);
            this.labelNoteOffVel.Name = "labelNoteOffVel";
            this.labelNoteOffVel.Size = new System.Drawing.Size(137, 12);
            this.labelNoteOffVel.TabIndex = 3;
            this.labelNoteOffVel.Text = "Note Off Velocity [0-127]";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(371, 295);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(464, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gboxArpeggiator
            // 
            this.gboxArpeggiator.Controls.Add(this.chbTremoloEnable);
            this.gboxArpeggiator.Controls.Add(this.chbArpeggiatorEnable);
            this.gboxArpeggiator.Controls.Add(this.nudArpegDelay);
            this.gboxArpeggiator.Controls.Add(this.labelArpgInterval);
            this.gboxArpeggiator.Location = new System.Drawing.Point(6, 118);
            this.gboxArpeggiator.Name = "gboxArpeggiator";
            this.gboxArpeggiator.Size = new System.Drawing.Size(260, 109);
            this.gboxArpeggiator.TabIndex = 6;
            this.gboxArpeggiator.TabStop = false;
            this.gboxArpeggiator.Text = "Arpeggiator";
            // 
            // chbTremoloEnable
            // 
            this.chbTremoloEnable.AutoSize = true;
            this.chbTremoloEnable.Enabled = false;
            this.chbTremoloEnable.Location = new System.Drawing.Point(30, 46);
            this.chbTremoloEnable.Name = "chbTremoloEnable";
            this.chbTremoloEnable.Size = new System.Drawing.Size(103, 16);
            this.chbTremoloEnable.TabIndex = 5;
            this.chbTremoloEnable.Text = "Enable Tremolo";
            this.chbTremoloEnable.UseVisualStyleBackColor = true;
            // 
            // chbArpeggiatorEnable
            // 
            this.chbArpeggiatorEnable.AutoSize = true;
            this.chbArpeggiatorEnable.Location = new System.Drawing.Point(15, 24);
            this.chbArpeggiatorEnable.Name = "chbArpeggiatorEnable";
            this.chbArpeggiatorEnable.Size = new System.Drawing.Size(121, 16);
            this.chbArpeggiatorEnable.TabIndex = 5;
            this.chbArpeggiatorEnable.Text = "Enable Arpeggiator";
            this.chbArpeggiatorEnable.UseVisualStyleBackColor = true;
            this.chbArpeggiatorEnable.CheckedChanged += new System.EventHandler(this.chbArpeggiatorEnable_CheckedChanged);
            // 
            // nudArpegDelay
            // 
            this.nudArpegDelay.Location = new System.Drawing.Point(166, 75);
            this.nudArpegDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudArpegDelay.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudArpegDelay.Name = "nudArpegDelay";
            this.nudArpegDelay.Size = new System.Drawing.Size(88, 19);
            this.nudArpegDelay.TabIndex = 4;
            this.nudArpegDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelArpgInterval
            // 
            this.labelArpgInterval.AutoSize = true;
            this.labelArpgInterval.Location = new System.Drawing.Point(13, 77);
            this.labelArpgInterval.Name = "labelArpgInterval";
            this.labelArpgInterval.Size = new System.Drawing.Size(116, 12);
            this.labelArpgInterval.TabIndex = 2;
            this.labelArpgInterval.Text = "Interval [50-1000 ms]";
            // 
            // checkBoxEnableMidiOut
            // 
            this.checkBoxEnableMidiOut.AutoSize = true;
            this.checkBoxEnableMidiOut.Location = new System.Drawing.Point(15, 24);
            this.checkBoxEnableMidiOut.Name = "checkBoxEnableMidiOut";
            this.checkBoxEnableMidiOut.Size = new System.Drawing.Size(112, 16);
            this.checkBoxEnableMidiOut.TabIndex = 6;
            this.checkBoxEnableMidiOut.Text = "Enable MIDI OUT";
            this.checkBoxEnableMidiOut.UseVisualStyleBackColor = true;
            // 
            // groupBoxMidiOut
            // 
            this.groupBoxMidiOut.Controls.Add(this.textBoxTarget);
            this.groupBoxMidiOut.Controls.Add(this.checkBoxEnableTarget);
            this.groupBoxMidiOut.Controls.Add(this.checkBoxEnableMidiOut);
            this.groupBoxMidiOut.Controls.Add(this.labelTarget);
            this.groupBoxMidiOut.Location = new System.Drawing.Point(279, 88);
            this.groupBoxMidiOut.Name = "groupBoxMidiOut";
            this.groupBoxMidiOut.Size = new System.Drawing.Size(260, 95);
            this.groupBoxMidiOut.TabIndex = 8;
            this.groupBoxMidiOut.TabStop = false;
            this.groupBoxMidiOut.Text = "Output";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Enabled = false;
            this.textBoxTarget.Location = new System.Drawing.Point(118, 68);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(136, 19);
            this.textBoxTarget.TabIndex = 7;
            this.textBoxTarget.Text = "ffxiv";
            // 
            // checkBoxEnableTarget
            // 
            this.checkBoxEnableTarget.AutoSize = true;
            this.checkBoxEnableTarget.Location = new System.Drawing.Point(15, 46);
            this.checkBoxEnableTarget.Name = "checkBoxEnableTarget";
            this.checkBoxEnableTarget.Size = new System.Drawing.Size(155, 16);
            this.checkBoxEnableTarget.TabIndex = 6;
            this.checkBoxEnableTarget.Text = "Enable Targeting Process";
            this.checkBoxEnableTarget.UseVisualStyleBackColor = true;
            this.checkBoxEnableTarget.CheckedChanged += new System.EventHandler(this.checkBoxEnableTarget_CheckedChanged);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(33, 71);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(79, 12);
            this.labelTarget.TabIndex = 2;
            this.labelTarget.Text = "Process Name";
            // 
            // groupBoxNoteControl
            // 
            this.groupBoxNoteControl.Controls.Add(this.labelNoteDelay);
            this.groupBoxNoteControl.Controls.Add(this.nudNoteDelay);
            this.groupBoxNoteControl.Controls.Add(this.nudNoteOffVelocity);
            this.groupBoxNoteControl.Controls.Add(this.labelNoteOffVel);
            this.groupBoxNoteControl.Location = new System.Drawing.Point(6, 22);
            this.groupBoxNoteControl.Name = "groupBoxNoteControl";
            this.groupBoxNoteControl.Size = new System.Drawing.Size(260, 90);
            this.groupBoxNoteControl.TabIndex = 9;
            this.groupBoxNoteControl.TabStop = false;
            this.groupBoxNoteControl.Text = "Note Control";
            // 
            // groupBoxPriority
            // 
            this.groupBoxPriority.Controls.Add(this.comboBoxPriority);
            this.groupBoxPriority.Location = new System.Drawing.Point(6, 233);
            this.groupBoxPriority.Name = "groupBoxPriority";
            this.groupBoxPriority.Size = new System.Drawing.Size(260, 46);
            this.groupBoxPriority.TabIndex = 8;
            this.groupBoxPriority.TabStop = false;
            this.groupBoxPriority.Text = "Process Priority";
            this.groupBoxPriority.Visible = false;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.Enabled = false;
            this.comboBoxPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(85, 18);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(169, 20);
            this.comboBoxPriority.TabIndex = 12;
            // 
            // gboxMidiIn
            // 
            this.gboxMidiIn.Controls.Add(this.lblMidiInCh);
            this.gboxMidiIn.Controls.Add(this.comboMidiInCh);
            this.gboxMidiIn.Location = new System.Drawing.Point(279, 22);
            this.gboxMidiIn.Name = "gboxMidiIn";
            this.gboxMidiIn.Size = new System.Drawing.Size(260, 60);
            this.gboxMidiIn.TabIndex = 10;
            this.gboxMidiIn.TabStop = false;
            this.gboxMidiIn.Text = "MIDI In";
            // 
            // lblMidiInCh
            // 
            this.lblMidiInCh.AutoSize = true;
            this.lblMidiInCh.Location = new System.Drawing.Point(15, 24);
            this.lblMidiInCh.Name = "lblMidiInCh";
            this.lblMidiInCh.Size = new System.Drawing.Size(88, 12);
            this.lblMidiInCh.TabIndex = 4;
            this.lblMidiInCh.Text = "MIDI IN Channel";
            // 
            // comboMidiInCh
            // 
            this.comboMidiInCh.FormattingEnabled = true;
            this.comboMidiInCh.Location = new System.Drawing.Point(166, 20);
            this.comboMidiInCh.Name = "comboMidiInCh";
            this.comboMidiInCh.Size = new System.Drawing.Size(87, 20);
            this.comboMidiInCh.TabIndex = 0;
            // 
            // gboxKeyConfig
            // 
            this.gboxKeyConfig.Controls.Add(this.labelImport);
            this.gboxKeyConfig.Controls.Add(this.btnPresetB);
            this.gboxKeyConfig.Controls.Add(this.labelLoadPreset);
            this.gboxKeyConfig.Controls.Add(this.btnPresetA);
            this.gboxKeyConfig.Controls.Add(this.btnImport);
            this.gboxKeyConfig.Location = new System.Drawing.Point(279, 189);
            this.gboxKeyConfig.Name = "gboxKeyConfig";
            this.gboxKeyConfig.Size = new System.Drawing.Size(260, 90);
            this.gboxKeyConfig.TabIndex = 11;
            this.gboxKeyConfig.TabStop = false;
            this.gboxKeyConfig.Text = "Key Config";
            // 
            // labelImport
            // 
            this.labelImport.AutoSize = true;
            this.labelImport.Location = new System.Drawing.Point(13, 61);
            this.labelImport.Name = "labelImport";
            this.labelImport.Size = new System.Drawing.Size(163, 12);
            this.labelImport.TabIndex = 3;
            this.labelImport.Text = "Import MidiKeyUtility Config.ini";
            // 
            // btnPresetB
            // 
            this.btnPresetB.Location = new System.Drawing.Point(179, 18);
            this.btnPresetB.Name = "btnPresetB";
            this.btnPresetB.Size = new System.Drawing.Size(75, 23);
            this.btnPresetB.TabIndex = 5;
            this.btnPresetB.Text = "Preset B";
            this.btnPresetB.UseVisualStyleBackColor = true;
            this.btnPresetB.Click += new System.EventHandler(this.btnPresetB_Click);
            // 
            // labelLoadPreset
            // 
            this.labelLoadPreset.AutoSize = true;
            this.labelLoadPreset.Location = new System.Drawing.Point(13, 23);
            this.labelLoadPreset.Name = "labelLoadPreset";
            this.labelLoadPreset.Size = new System.Drawing.Size(66, 12);
            this.labelLoadPreset.TabIndex = 3;
            this.labelLoadPreset.Text = "Load Preset";
            // 
            // btnPresetA
            // 
            this.btnPresetA.Location = new System.Drawing.Point(101, 18);
            this.btnPresetA.Name = "btnPresetA";
            this.btnPresetA.Size = new System.Drawing.Size(75, 23);
            this.btnPresetA.TabIndex = 5;
            this.btnPresetA.Text = "Preset A";
            this.btnPresetA.UseVisualStyleBackColor = true;
            this.btnPresetA.Click += new System.EventHandler(this.btnPresetA_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(179, 56);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 326);
            this.Controls.Add(this.gboxKeyConfig);
            this.Controls.Add(this.gboxMidiIn);
            this.Controls.Add(this.groupBoxNoteControl);
            this.Controls.Add(this.groupBoxPriority);
            this.Controls.Add(this.groupBoxMidiOut);
            this.Controls.Add(this.gboxArpeggiator);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteOffVelocity)).EndInit();
            this.gboxArpeggiator.ResumeLayout(false);
            this.gboxArpeggiator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpegDelay)).EndInit();
            this.groupBoxMidiOut.ResumeLayout(false);
            this.groupBoxMidiOut.PerformLayout();
            this.groupBoxNoteControl.ResumeLayout(false);
            this.groupBoxNoteControl.PerformLayout();
            this.groupBoxPriority.ResumeLayout(false);
            this.gboxMidiIn.ResumeLayout(false);
            this.gboxMidiIn.PerformLayout();
            this.gboxKeyConfig.ResumeLayout(false);
            this.gboxKeyConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNoteDelay;
        private System.Windows.Forms.NumericUpDown nudNoteOffVelocity;
        private System.Windows.Forms.Label labelNoteDelay;
        private System.Windows.Forms.Label labelNoteOffVel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gboxArpeggiator;
        private System.Windows.Forms.CheckBox chbArpeggiatorEnable;
        private System.Windows.Forms.NumericUpDown nudArpegDelay;
        private System.Windows.Forms.Label labelArpgInterval;
        private System.Windows.Forms.CheckBox checkBoxEnableMidiOut;
        private System.Windows.Forms.GroupBox groupBoxMidiOut;
        private System.Windows.Forms.GroupBox groupBoxNoteControl;
        private System.Windows.Forms.CheckBox chbTremoloEnable;
        private System.Windows.Forms.GroupBox groupBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.CheckBox checkBoxEnableTarget;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.GroupBox gboxMidiIn;
        private System.Windows.Forms.Label lblMidiInCh;
        private System.Windows.Forms.ComboBox comboMidiInCh;
        private System.Windows.Forms.GroupBox gboxKeyConfig;
        private System.Windows.Forms.Label labelImport;
        private System.Windows.Forms.Button btnPresetB;
        private System.Windows.Forms.Label labelLoadPreset;
        private System.Windows.Forms.Button btnPresetA;
        private System.Windows.Forms.Button btnImport;
    }
}