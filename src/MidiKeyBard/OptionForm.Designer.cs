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
            this.chbArpeggiatorEnable = new System.Windows.Forms.CheckBox();
            this.nudArpegDelay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoteOffVelocity)).BeginInit();
            this.gboxKeyConfig.SuspendLayout();
            this.gboxArpeggiator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArpegDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNoteDelay
            // 
            this.nudNoteDelay.Location = new System.Drawing.Point(178, 22);
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
            this.nudNoteOffVelocity.Location = new System.Drawing.Point(178, 56);
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
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note Delay [0-1000 ms]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note Off Velocity [0-127]";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 286);
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
            this.gboxKeyConfig.Location = new System.Drawing.Point(12, 179);
            this.gboxKeyConfig.Name = "gboxKeyConfig";
            this.gboxKeyConfig.Size = new System.Drawing.Size(260, 85);
            this.gboxKeyConfig.TabIndex = 6;
            this.gboxKeyConfig.TabStop = false;
            this.gboxKeyConfig.Text = "Key Config";
            // 
            // gboxArpeggiator
            // 
            this.gboxArpeggiator.Controls.Add(this.chbArpeggiatorEnable);
            this.gboxArpeggiator.Controls.Add(this.nudArpegDelay);
            this.gboxArpeggiator.Controls.Add(this.label5);
            this.gboxArpeggiator.Location = new System.Drawing.Point(12, 81);
            this.gboxArpeggiator.Name = "gboxArpeggiator";
            this.gboxArpeggiator.Size = new System.Drawing.Size(260, 77);
            this.gboxArpeggiator.TabIndex = 6;
            this.gboxArpeggiator.TabStop = false;
            this.gboxArpeggiator.Text = "Arpeggiator";
            // 
            // chbArpeggiatorEnable
            // 
            this.chbArpeggiatorEnable.AutoSize = true;
            this.chbArpeggiatorEnable.Location = new System.Drawing.Point(15, 24);
            this.chbArpeggiatorEnable.Name = "chbArpeggiatorEnable";
            this.chbArpeggiatorEnable.Size = new System.Drawing.Size(58, 16);
            this.chbArpeggiatorEnable.TabIndex = 5;
            this.chbArpeggiatorEnable.Text = "Enable";
            this.chbArpeggiatorEnable.UseVisualStyleBackColor = true;
            // 
            // nudArpegDelay
            // 
            this.nudArpegDelay.Location = new System.Drawing.Point(166, 48);
            this.nudArpegDelay.Maximum = new decimal(new int[] {
            1000,
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
            this.label5.Location = new System.Drawing.Point(28, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Interval [0-1000 ms]";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.gboxArpeggiator);
            this.Controls.Add(this.gboxKeyConfig);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNoteOffVelocity);
            this.Controls.Add(this.nudNoteDelay);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}