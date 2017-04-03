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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_genKey = new System.Windows.Forms.Button();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.label_status_text = new System.Windows.Forms.Label();
            this.richTextBox_output_decode = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_genKey
            // 
            this.button_genKey.Location = new System.Drawing.Point(12, 318);
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
            this.richTextBox_input.Size = new System.Drawing.Size(714, 96);
            this.richTextBox_input.TabIndex = 1;
            this.richTextBox_input.Text = "";
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(12, 114);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(714, 96);
            this.richTextBox_output.TabIndex = 2;
            this.richTextBox_output.Text = "";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(168, 318);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(176, 23);
            this.button_encrypt.TabIndex = 3;
            this.button_encrypt.Text = "encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(350, 318);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(176, 23);
            this.button_decrypt.TabIndex = 4;
            this.button_decrypt.Text = "decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(12, 363);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(35, 13);
            this.label_info.TabIndex = 5;
            this.label_info.Text = "label1";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(532, 318);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(176, 23);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(347, 424);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(54, 13);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "label_time";
            // 
            // label_status_text
            // 
            this.label_status_text.AutoSize = true;
            this.label_status_text.Location = new System.Drawing.Point(347, 363);
            this.label_status_text.Name = "label_status_text";
            this.label_status_text.Size = new System.Drawing.Size(86, 13);
            this.label_status_text.TabIndex = 8;
            this.label_status_text.Text = "label_status_text";
            // 
            // richTextBox_output_decode
            // 
            this.richTextBox_output_decode.Location = new System.Drawing.Point(12, 216);
            this.richTextBox_output_decode.Name = "richTextBox_output_decode";
            this.richTextBox_output_decode.Size = new System.Drawing.Size(714, 96);
            this.richTextBox_output_decode.TabIndex = 9;
            this.richTextBox_output_decode.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 479);
            this.Controls.Add(this.richTextBox_output_decode);
            this.Controls.Add(this.label_status_text);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.richTextBox_input);
            this.Controls.Add(this.button_genKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_genKey;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_status_text;
        private System.Windows.Forms.RichTextBox richTextBox_output_decode;
    }
}

