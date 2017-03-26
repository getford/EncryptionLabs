namespace lb4_RSA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_genKey = new System.Windows.Forms.Button();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_genKey
            // 
            this.button_genKey.Location = new System.Drawing.Point(12, 216);
            this.button_genKey.Name = "button_genKey";
            this.button_genKey.Size = new System.Drawing.Size(150, 23);
            this.button_genKey.TabIndex = 0;
            this.button_genKey.Text = "generation key";
            this.button_genKey.UseVisualStyleBackColor = true;
            this.button_genKey.Click += new System.EventHandler(this.button_genKey_Click);
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(514, 96);
            this.richTextBox_input.TabIndex = 1;
            this.richTextBox_input.Text = "";
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(12, 114);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(514, 96);
            this.richTextBox_output.TabIndex = 2;
            this.richTextBox_output.Text = "";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(168, 216);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(176, 23);
            this.button_encrypt.TabIndex = 3;
            this.button_encrypt.Text = "encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(350, 216);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(176, 23);
            this.button_decrypt.TabIndex = 4;
            this.button_decrypt.Text = "decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 255);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.richTextBox_input);
            this.Controls.Add(this.button_genKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_genKey;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
    }
}

