namespace ce
{
    partial class ce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ce));
            this.button_decode = new System.Windows.Forms.Button();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.textBox_number_sdvig = new System.Windows.Forms.TextBox();
            this.button_gen_alfpf = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.label_count_symbols = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_decode
            // 
            this.button_decode.Location = new System.Drawing.Point(12, 242);
            this.button_decode.Name = "button_decode";
            this.button_decode.Size = new System.Drawing.Size(326, 23);
            this.button_decode.TabIndex = 0;
            this.button_decode.Text = "decode";
            this.button_decode.UseVisualStyleBackColor = true;
            this.button_decode.Click += new System.EventHandler(this.button_decode_Click);
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(326, 96);
            this.richTextBox_input.TabIndex = 1;
            this.richTextBox_input.Text = "";
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(12, 114);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(326, 96);
            this.richTextBox_output.TabIndex = 2;
            this.richTextBox_output.Text = "";
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(12, 213);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(326, 23);
            this.button_encrypt.TabIndex = 3;
            this.button_encrypt.Text = "code";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // textBox_number_sdvig
            // 
            this.textBox_number_sdvig.Location = new System.Drawing.Point(12, 273);
            this.textBox_number_sdvig.Name = "textBox_number_sdvig";
            this.textBox_number_sdvig.Size = new System.Drawing.Size(33, 20);
            this.textBox_number_sdvig.TabIndex = 5;
            // 
            // button_gen_alfpf
            // 
            this.button_gen_alfpf.Location = new System.Drawing.Point(51, 271);
            this.button_gen_alfpf.Name = "button_gen_alfpf";
            this.button_gen_alfpf.Size = new System.Drawing.Size(287, 23);
            this.button_gen_alfpf.TabIndex = 6;
            this.button_gen_alfpf.Text = "generation alp";
            this.button_gen_alfpf.UseVisualStyleBackColor = true;
            this.button_gen_alfpf.Click += new System.EventHandler(this.button_gen_alfpf_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 326);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(60, 13);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "label status";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 300);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(326, 23);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(12, 339);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(53, 13);
            this.label_error.TabIndex = 9;
            this.label_error.Text = "label error";
            // 
            // label_count_symbols
            // 
            this.label_count_symbols.AutoSize = true;
            this.label_count_symbols.Location = new System.Drawing.Point(12, 352);
            this.label_count_symbols.Name = "label_count_symbols";
            this.label_count_symbols.Size = new System.Drawing.Size(59, 13);
            this.label_count_symbols.TabIndex = 10;
            this.label_count_symbols.Text = "label count";
            // 
            // ce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 377);
            this.Controls.Add(this.label_count_symbols);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_gen_alfpf);
            this.Controls.Add(this.textBox_number_sdvig);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.richTextBox_input);
            this.Controls.Add(this.button_decode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ce";
            this.Text = "Cesar";
            this.Load += new System.EventHandler(this.ce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_decode;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.TextBox textBox_number_sdvig;
        private System.Windows.Forms.Button button_gen_alfpf;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_count_symbols;
    }
}

