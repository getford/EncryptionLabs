namespace lb5_SHF
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
            this.button_shf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_shf
            // 
            this.button_shf.Location = new System.Drawing.Point(231, 132);
            this.button_shf.Name = "button_shf";
            this.button_shf.Size = new System.Drawing.Size(75, 23);
            this.button_shf.TabIndex = 0;
            this.button_shf.Text = "click";
            this.button_shf.UseVisualStyleBackColor = true;
            this.button_shf.Click += new System.EventHandler(this.button_shf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 329);
            this.Controls.Add(this.button_shf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_shf;
    }
}

