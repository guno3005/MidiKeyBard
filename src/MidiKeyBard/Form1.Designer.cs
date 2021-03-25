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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSettingsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelMidiIn = new System.Windows.Forms.Panel();
            this.panelMidiOut = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTarget = new System.Windows.Forms.Panel();
            this.buttonRefreshProcessList = new System.Windows.Forms.Button();
            this.comboBoxTargetWindow = new System.Windows.Forms.ComboBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMidiIn.SuspendLayout();
            this.panelMidiOut.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.panelTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMidiIn
            // 
            this.comboBoxMidiIn.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMidiIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMidiIn.FormattingEnabled = true;
            this.comboBoxMidiIn.Location = new System.Drawing.Point(61, 13);
            this.comboBoxMidiIn.Name = "comboBoxMidiIn";
            this.comboBoxMidiIn.Size = new System.Drawing.Size(220, 20);
            this.comboBoxMidiIn.TabIndex = 0;
            this.comboBoxMidiIn.SelectedIndexChanged += new System.EventHandler(this.comboBoxMidiIn_SelectedIndexChanged);
            this.comboBoxMidiIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxMidiIn_KeyPress);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStatus.Location = new System.Drawing.Point(10, 148);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(319, 30);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Error : No MIDI IN device.";
            // 
            // comboBoxMidiOut
            // 
            this.comboBoxMidiOut.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMidiOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMidiOut.FormattingEnabled = true;
            this.comboBoxMidiOut.Location = new System.Drawing.Point(61, 3);
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
            this.labelMidiIn.Location = new System.Drawing.Point(33, 17);
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
            this.labelMidiOut.Location = new System.Drawing.Point(24, 7);
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
            this.toolStripSeparator1,
            this.optionToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveSettingsAsToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Option";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
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
            // panelMidiIn
            // 
            this.panelMidiIn.Controls.Add(this.labelMidiIn);
            this.panelMidiIn.Controls.Add(this.comboBoxMidiIn);
            this.panelMidiIn.Location = new System.Drawing.Point(3, 3);
            this.panelMidiIn.Name = "panelMidiIn";
            this.panelMidiIn.Size = new System.Drawing.Size(326, 40);
            this.panelMidiIn.TabIndex = 5;
            // 
            // panelMidiOut
            // 
            this.panelMidiOut.Controls.Add(this.comboBoxMidiOut);
            this.panelMidiOut.Controls.Add(this.labelMidiOut);
            this.panelMidiOut.Location = new System.Drawing.Point(3, 49);
            this.panelMidiOut.Name = "panelMidiOut";
            this.panelMidiOut.Size = new System.Drawing.Size(326, 30);
            this.panelMidiOut.TabIndex = 6;
            this.panelMidiOut.Visible = false;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoSize = true;
            this.flowLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelMain.Controls.Add(this.panelMidiIn);
            this.flowLayoutPanelMain.Controls.Add(this.panelMidiOut);
            this.flowLayoutPanelMain.Controls.Add(this.panelTarget);
            this.flowLayoutPanelMain.Controls.Add(this.labelStatus);
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(332, 178);
            this.flowLayoutPanelMain.TabIndex = 7;
            // 
            // panelTarget
            // 
            this.panelTarget.Controls.Add(this.buttonRefreshProcessList);
            this.panelTarget.Controls.Add(this.comboBoxTargetWindow);
            this.panelTarget.Controls.Add(this.labelTarget);
            this.panelTarget.Location = new System.Drawing.Point(3, 85);
            this.panelTarget.Name = "panelTarget";
            this.panelTarget.Size = new System.Drawing.Size(326, 60);
            this.panelTarget.TabIndex = 6;
            this.panelTarget.Visible = false;
            // 
            // buttonRefreshProcessList
            // 
            this.buttonRefreshProcessList.Location = new System.Drawing.Point(206, 29);
            this.buttonRefreshProcessList.Name = "buttonRefreshProcessList";
            this.buttonRefreshProcessList.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshProcessList.TabIndex = 17;
            this.buttonRefreshProcessList.Text = "Refresh";
            this.buttonRefreshProcessList.UseVisualStyleBackColor = true;
            this.buttonRefreshProcessList.Click += new System.EventHandler(this.buttonRefreshProcessList_Click);
            // 
            // comboBoxTargetWindow
            // 
            this.comboBoxTargetWindow.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTargetWindow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTargetWindow.FormattingEnabled = true;
            this.comboBoxTargetWindow.Location = new System.Drawing.Point(61, 3);
            this.comboBoxTargetWindow.Name = "comboBoxTargetWindow";
            this.comboBoxTargetWindow.Size = new System.Drawing.Size(220, 20);
            this.comboBoxTargetWindow.TabIndex = 15;
            this.comboBoxTargetWindow.SelectedIndexChanged += new System.EventHandler(this.comboBoxTargetWindow_SelectedIndexChanged);
            this.comboBoxTargetWindow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTargetWindow_KeyPress);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTarget.Location = new System.Drawing.Point(9, 7);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(41, 11);
            this.labelTarget.TabIndex = 2;
            this.labelTarget.Text = "Target";
            this.labelTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 217);
            this.Controls.Add(this.flowLayoutPanelMain);
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
            this.panelMidiIn.ResumeLayout(false);
            this.panelMidiIn.PerformLayout();
            this.panelMidiOut.ResumeLayout(false);
            this.panelMidiOut.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.panelTarget.ResumeLayout(false);
            this.panelTarget.PerformLayout();
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
        private System.Windows.Forms.Panel panelMidiIn;
        private System.Windows.Forms.Panel panelMidiOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Panel panelTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Button buttonRefreshProcessList;
        private System.Windows.Forms.ComboBox comboBoxTargetWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

