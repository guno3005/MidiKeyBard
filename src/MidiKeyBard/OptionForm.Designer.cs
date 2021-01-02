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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPresetA = new System.Windows.Forms.Button();
            this.btnPresetB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxKeyConfig = new System.Windows.Forms.GroupBox();
            this.gboxArpeggiator = new System.Windows.Forms.GroupBox();
            this.chbTremoloEnable = new System.Windows.Forms.CheckBox();
            this.chbArpeggiatorEnable = new System.Windows.Forms.CheckBox();
            this.nudArpegDelay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxMidiIn = new System.Windows.Forms.GroupBox();
            this.lblMidiInCh = new System.Windows.Forms.Label();
            this.comboMidiInCh = new System.Windows.Forms.ComboBox();
            this.checkBoxEnableMidiOut = new System.Windows.Forms.CheckBox();
            this.groupBoxMidiOut = new System.Windows.Forms.GroupBox();
            this.groupBoxNoteControl = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteOffVelocity)).BeginInit();
            this.gboxKeyConfig.SuspendLayout();
            this.gboxArpeggiator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpegDelay)).BeginInit();
            this.gboxMidiIn.SuspendLayout();
            this.groupBoxMidiOut.SuspendLayout();
            this.groupBoxNoteControl.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note Delay [0-1000 ms]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note Off Velocity [0-127]";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(376, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Import MidiKeyUtility Config.ini";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Load Preset";
            // 
            // gboxKeyConfig
            // 
            this.gboxKeyConfig.Controls.Add(this.label3);
            this.gboxKeyConfig.Controls.Add(this.btnPresetB);
            this.gboxKeyConfig.Controls.Add(this.label4);
            this.gboxKeyConfig.Controls.Add(this.btnPresetA);
            this.gboxKeyConfig.Controls.Add(this.btnImport);
            this.gboxKeyConfig.Location = new System.Drawing.Point(278, 154);
            this.gboxKeyConfig.Name = "gboxKeyConfig";
            this.gboxKeyConfig.Size = new System.Drawing.Size(260, 90);
            this.gboxKeyConfig.TabIndex = 6;
            this.gboxKeyConfig.TabStop = false;
            this.gboxKeyConfig.Text = "Key Config";
            // 
            // gboxArpeggiator
            // 
            this.gboxArpeggiator.Controls.Add(this.chbTremoloEnable);
            this.gboxArpeggiator.Controls.Add(this.chbArpeggiatorEnable);
            this.gboxArpeggiator.Controls.Add(this.nudArpegDelay);
            this.gboxArpeggiator.Controls.Add(this.label5);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Interval [50-1000 ms]";
            // 
            // gboxMidiIn
            // 
            this.gboxMidiIn.Controls.Add(this.lblMidiInCh);
            this.gboxMidiIn.Controls.Add(this.comboMidiInCh);
            this.gboxMidiIn.Location = new System.Drawing.Point(278, 22);
            this.gboxMidiIn.Name = "gboxMidiIn";
            this.gboxMidiIn.Size = new System.Drawing.Size(260, 60);
            this.gboxMidiIn.TabIndex = 7;
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
            this.groupBoxMidiOut.Controls.Add(this.checkBoxEnableMidiOut);
            this.groupBoxMidiOut.Location = new System.Drawing.Point(278, 88);
            this.groupBoxMidiOut.Name = "groupBoxMidiOut";
            this.groupBoxMidiOut.Size = new System.Drawing.Size(260, 60);
            this.groupBoxMidiOut.TabIndex = 8;
            this.groupBoxMidiOut.TabStop = false;
            this.groupBoxMidiOut.Text = "MIDI Out";
            // 
            // groupBoxNoteControl
            // 
            this.groupBoxNoteControl.Controls.Add(this.label1);
            this.groupBoxNoteControl.Controls.Add(this.nudNoteDelay);
            this.groupBoxNoteControl.Controls.Add(this.nudNoteOffVelocity);
            this.groupBoxNoteControl.Controls.Add(this.label2);
            this.groupBoxNoteControl.Location = new System.Drawing.Point(6, 22);
            this.groupBoxNoteControl.Name = "groupBoxNoteControl";
            this.groupBoxNoteControl.Size = new System.Drawing.Size(260, 90);
            this.groupBoxNoteControl.TabIndex = 9;
            this.groupBoxNoteControl.TabStop = false;
            this.groupBoxNoteControl.Text = "Note Control";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 285);
            this.Controls.Add(this.groupBoxNoteControl);
            this.Controls.Add(this.groupBoxMidiOut);
            this.Controls.Add(this.gboxMidiIn);
            this.Controls.Add(this.gboxArpeggiator);
            this.Controls.Add(this.gboxKeyConfig);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteOffVelocity)).EndInit();
            this.gboxKeyConfig.ResumeLayout(false);
            this.gboxKeyConfig.PerformLayout();
            this.gboxArpeggiator.ResumeLayout(false);
            this.gboxArpeggiator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpegDelay)).EndInit();
            this.gboxMidiIn.ResumeLayout(false);
            this.gboxMidiIn.PerformLayout();
            this.groupBoxMidiOut.ResumeLayout(false);
            this.groupBoxMidiOut.PerformLayout();
            this.groupBoxNoteControl.ResumeLayout(false);
            this.groupBoxNoteControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNoteDelay;
        private System.Windows.Forms.NumericUpDown nudNoteOffVelocity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPresetA;
        private System.Windows.Forms.Button btnPresetB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboxKeyConfig;
        private System.Windows.Forms.GroupBox gboxArpeggiator;
        private System.Windows.Forms.CheckBox chbArpeggiatorEnable;
        private System.Windows.Forms.NumericUpDown nudArpegDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboxMidiIn;
        private System.Windows.Forms.Label lblMidiInCh;
        private System.Windows.Forms.ComboBox comboMidiInCh;
        private System.Windows.Forms.CheckBox checkBoxEnableMidiOut;
        private System.Windows.Forms.GroupBox groupBoxMidiOut;
        private System.Windows.Forms.GroupBox groupBoxNoteControl;
        private System.Windows.Forms.CheckBox chbTremoloEnable;
    }
}