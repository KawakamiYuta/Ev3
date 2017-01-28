namespace ev3Logger
{
    partial class RecvDataForm
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
            this.RecvDataBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RecvDataBox
            // 
            this.RecvDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecvDataBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RecvDataBox.ForeColor = System.Drawing.SystemColors.Info;
            this.RecvDataBox.Location = new System.Drawing.Point(-2, 0);
            this.RecvDataBox.Multiline = true;
            this.RecvDataBox.Name = "RecvDataBox";
            this.RecvDataBox.ReadOnly = true;
            this.RecvDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RecvDataBox.Size = new System.Drawing.Size(606, 331);
            this.RecvDataBox.TabIndex = 0;
            this.RecvDataBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(RecvDataBox_KeyPress);
            // 
            // RecvDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 332);
            this.Controls.Add(this.RecvDataBox);
            this.Name = "RecvDataForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox RecvDataBox;
    }
}