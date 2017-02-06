namespace lab2
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
            this.button_check = new System.Windows.Forms.Button();
            this.richTextBox_input_text = new System.Windows.Forms.RichTextBox();
            this.richTextBox_resArr = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(12, 197);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(260, 23);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // richTextBox_input_text
            // 
            this.richTextBox_input_text.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_input_text.Name = "richTextBox_input_text";
            this.richTextBox_input_text.Size = new System.Drawing.Size(260, 179);
            this.richTextBox_input_text.TabIndex = 1;
            this.richTextBox_input_text.Text = resources.GetString("richTextBox_input_text.Text");
            // 
            // richTextBox_resArr
            // 
            this.richTextBox_resArr.Location = new System.Drawing.Point(278, 12);
            this.richTextBox_resArr.Name = "richTextBox_resArr";
            this.richTextBox_resArr.Size = new System.Drawing.Size(260, 179);
            this.richTextBox_resArr.TabIndex = 2;
            this.richTextBox_resArr.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 232);
            this.Controls.Add(this.richTextBox_resArr);
            this.Controls.Add(this.richTextBox_input_text);
            this.Controls.Add(this.button_check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.RichTextBox richTextBox_input_text;
        private System.Windows.Forms.RichTextBox richTextBox_resArr;
    }
}

