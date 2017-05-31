namespace Antivirus
{
    partial class Form1
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
            this.scanButton = new System.Windows.Forms.Button();
            this.virusListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(12, 152);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(204, 23);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Сканировать";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // virusListBox
            // 
            this.virusListBox.FormattingEnabled = true;
            this.virusListBox.Location = new System.Drawing.Point(12, 12);
            this.virusListBox.Name = "virusListBox";
            this.virusListBox.Size = new System.Drawing.Size(204, 134);
            this.virusListBox.TabIndex = 3;
            this.virusListBox.DoubleClick += new System.EventHandler(this.virusListBox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 193);
            this.Controls.Add(this.virusListBox);
            this.Controls.Add(this.scanButton);
            this.Name = "Form1";
            this.Text = "Antivirus";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.ListBox virusListBox;
    }
}

