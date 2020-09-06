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
            this.btnOption = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxMidiOut = new System.Windows.Forms.ComboBox();
            this.labelMidiIn = new System.Windows.Forms.Label();
            this.labelMidiOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMidiIn
            // 
            this.comboBoxMidiIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiIn.FormattingEnabled = true;
            this.comboBoxMidiIn.Location = new System.Drawing.Point(40, 37);
            this.comboBoxMidiIn.Name = "comboBoxMidiIn";
            this.comboBoxMidiIn.Size = new System.Drawing.Size(220, 20);
            this.comboBoxMidiIn.TabIndex = 0;
            this.comboBoxMidiIn.SelectedIndexChanged += new System.EventHandler(this.comboBoxMidiIn_SelectedIndexChanged);
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(266, 37);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(75, 23);
            this.btnOption.TabIndex = 1;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStatus.Location = new System.Drawing.Point(8, 67);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(343, 30);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Error : No MIDI IN device.";
            // 
            // comboBoxMidiOut
            // 
            this.comboBoxMidiOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMidiOut.FormattingEnabled = true;
            this.comboBoxMidiOut.Location = new System.Drawing.Point(40, 63);
            this.comboBoxMidiOut.Name = "comboBoxMidiOut";
            this.comboBoxMidiOut.Size = new System.Drawing.Size(220, 20);
            this.comboBoxMidiOut.TabIndex = 3;
            this.comboBoxMidiOut.SelectedIndexChanged += new System.EventHandler(this.comboBoxMidiOut_SelectedIndexChanged);
            // 
            // labelMidiIn
            // 
            this.labelMidiIn.AutoSize = true;
            this.labelMidiIn.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMidiIn.Location = new System.Drawing.Point(17, 41);
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
            this.labelMidiOut.Location = new System.Drawing.Point(8, 67);
            this.labelMidiOut.Name = "labelMidiOut";
            this.labelMidiOut.Size = new System.Drawing.Size(26, 11);
            this.labelMidiOut.TabIndex = 2;
            this.labelMidiOut.Text = "Out";
            this.labelMidiOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 106);
            this.Controls.Add(this.comboBoxMidiOut);
            this.Controls.Add(this.labelMidiOut);
            this.Controls.Add(this.labelMidiIn);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.comboBoxMidiIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MidiKeyBird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMidiIn;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxMidiOut;
        private System.Windows.Forms.Label labelMidiIn;
        private System.Windows.Forms.Label labelMidiOut;
    }
}

