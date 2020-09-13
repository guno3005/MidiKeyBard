namespace MidiKeyBard
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxMidiIn = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxMidiOut = new System.Windows.Forms.ComboBox();
            this.labelMidiIn = new System.Windows.Forms.Label();
            this.labelMidiOut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSettingsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMidiIn
            // 
            this.comboBoxMidiIn.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMidiIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMidiIn.FormattingEnabled = true;
            this.comboBoxMidiIn.Location = new System.Drawing.Point(56, 37);
            this.comboBoxMidiIn.Name = "comboBoxMidiIn";
            this.comboBoxMidiIn.Size = new System.Drawing.Size(220, 20);
            this.comboBoxMidiIn.TabIndex = 0;
            this.comboBoxMidiIn.SelectedIndexChanged += new System.EventHandler(this.comboBoxMidiIn_SelectedIndexChanged);
            this.comboBoxMidiIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxMidiIn_KeyPress);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStatus.Location = new System.Drawing.Point(8, 67);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(326, 30);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Error : No MIDI IN device.";
            // 
            // comboBoxMidiOut
            // 
            this.comboBoxMidiOut.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMidiOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMidiOut.FormattingEnabled = true;
            this.comboBoxMidiOut.Location = new System.Drawing.Point(56, 63);
            this.comboBoxMidiOut.Name = "comboBoxMidiOut";
            this.comboBoxMidiOut.Size = new System.Drawing.Size(220, 20);
            this.comboBoxMidiOut.TabIndex = 3;
            this.comboBoxMidiOut.SelectedIndexChanged += new System.EventHandler(this.comboBoxMidiOut_SelectedIndexChanged);
            this.comboBoxMidiOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxMidiOut_KeyPress);
            // 
            // labelMidiIn
            // 
            this.labelMidiIn.AutoSize = true;
            this.labelMidiIn.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMidiIn.Location = new System.Drawing.Point(33, 41);
            this.labelMidiIn.Name = "labelMidiIn";
            this.labelMidiIn.Size = new System.Drawing.Size(17, 11);
            this.labelMidiIn.TabIndex = 2;
            this.labelMidiIn.Text = "IN";
            this.labelMidiIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMidiOut
            // 
            this.labelMidiOut.AutoSize = true;
            this.labelMidiOut.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMidiOut.Location = new System.Drawing.Point(24, 67);
            this.labelMidiOut.Name = "labelMidiOut";
            this.labelMidiOut.Size = new System.Drawing.Size(26, 11);
            this.labelMidiOut.TabIndex = 2;
            this.labelMidiOut.Text = "Out";
            this.labelMidiOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveSettingsAsToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Option";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // saveSettingsAsToolStripMenuItem
            // 
            this.saveSettingsAsToolStripMenuItem.Name = "saveSettingsAsToolStripMenuItem";
            this.saveSettingsAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveSettingsAsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveSettingsAsToolStripMenuItem.Text = "Save As";
            this.saveSettingsAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MidiKeyBard.ini";
            this.openFileDialog1.Filter = "Option File|*.ini";
            this.openFileDialog1.InitialDirectory = ".\\";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ini";
            this.saveFileDialog1.Filter = "Option File|*.ini";
            this.saveFileDialog1.InitialDirectory = ".\\";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.comboBoxMidiOut);
            this.Controls.Add(this.labelMidiOut);
            this.Controls.Add(this.labelMidiIn);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxMidiIn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MidiKeyBird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMidiIn;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxMidiOut;
        private System.Windows.Forms.Label labelMidiIn;
        private System.Windows.Forms.Label labelMidiOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

