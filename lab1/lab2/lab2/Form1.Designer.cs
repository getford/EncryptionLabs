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
            this.richTextBox_resPassword = new System.Windows.Forms.RichTextBox();
            this.button_genPassword = new System.Windows.Forms.Button();
            this.richTextBox_entropiya = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(12, 364);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(526, 27);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // richTextBox_input_text
            // 
            this.richTextBox_input_text.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_input_text.Name = "richTextBox_input_text";
            this.richTextBox_input_text.Size = new System.Drawing.Size(382, 346);
            this.richTextBox_input_text.TabIndex = 1;
            this.richTextBox_input_text.Text = resources.GetString("richTextBox_input_text.Text");
            // 
            // richTextBox_resArr
            // 
            this.richTextBox_resArr.Location = new System.Drawing.Point(400, 12);
            this.richTextBox_resArr.Name = "richTextBox_resArr";
            this.richTextBox_resArr.Size = new System.Drawing.Size(103, 346);
            this.richTextBox_resArr.TabIndex = 2;
            this.richTextBox_resArr.Text = "";
            // 
            // richTextBox_resPassword
            // 
            this.richTextBox_resPassword.Location = new System.Drawing.Point(12, 434);
            this.richTextBox_resPassword.Name = "richTextBox_resPassword";
            this.richTextBox_resPassword.Size = new System.Drawing.Size(328, 29);
            this.richTextBox_resPassword.TabIndex = 3;
            this.richTextBox_resPassword.Text = "";
            // 
            // button_genPassword
            // 
            this.button_genPassword.Location = new System.Drawing.Point(346, 436);
            this.button_genPassword.Name = "button_genPassword";
            this.button_genPassword.Size = new System.Drawing.Size(192, 27);
            this.button_genPassword.TabIndex = 4;
            this.button_genPassword.Text = "generation";
            this.button_genPassword.UseVisualStyleBackColor = true;
            this.button_genPassword.Click += new System.EventHandler(this.button_genPassword_Click);
            // 
            // richTextBox_entropiya
            // 
            this.richTextBox_entropiya.Location = new System.Drawing.Point(509, 12);
            this.richTextBox_entropiya.Name = "richTextBox_entropiya";
            this.richTextBox_entropiya.Size = new System.Drawing.Size(47, 346);
            this.richTextBox_entropiya.TabIndex = 5;
            this.richTextBox_entropiya.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 576);
            this.Controls.Add(this.richTextBox_entropiya);
            this.Controls.Add(this.button_genPassword);
            this.Controls.Add(this.richTextBox_resPassword);
            this.Controls.Add(this.richTextBox_resArr);
            this.Controls.Add(this.richTextBox_input_text);
            this.Controls.Add(this.button_check);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.RichTextBox richTextBox_input_text;
        private System.Windows.Forms.RichTextBox richTextBox_resArr;
        private System.Windows.Forms.RichTextBox richTextBox_resPassword;
        private System.Windows.Forms.Button button_genPassword;
        private System.Windows.Forms.RichTextBox richTextBox_entropiya;
    }
}

