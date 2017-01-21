namespace ev3Logger
{
    partial class Ev3Lover
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.ConnectButton = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.LogFileWriterThread = new System.ComponentModel.BackgroundWorker();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(150, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(102, 20);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(12, 12);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(121, 20);
            this.cmbPortName.TabIndex = 1;
            // 
            // LogFileWriterThread
            // 
            this.LogFileWriterThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LogFileWriterThread_DoWork);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(150, 59);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(102, 24);
            this.SelectFileButton.TabIndex = 2;
            this.SelectFileButton.Text = "SelectFile";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 59);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(121, 24);
            this.FileNameLabel.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(97, 216);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(95, 33);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Ev3Lover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.cmbPortName);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Ev3Lover";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.ComponentModel.BackgroundWorker LogFileWriterThread;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button Start;
    }
}

