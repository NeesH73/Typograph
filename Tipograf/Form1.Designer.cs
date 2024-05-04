namespace Tipograf
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
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.textBoxoutput = new System.Windows.Forms.TextBox();
            this.btntip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(1, 0);
            this.textBoxinput.Multiline = true;
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(337, 447);
            this.textBoxinput.TabIndex = 0;
            // 
            // textBoxoutput
            // 
            this.textBoxoutput.Location = new System.Drawing.Point(447, 0);
            this.textBoxoutput.Multiline = true;
            this.textBoxoutput.Name = "textBoxoutput";
            this.textBoxoutput.Size = new System.Drawing.Size(353, 447);
            this.textBoxoutput.TabIndex = 1;
            // 
            // btntip
            // 
            this.btntip.Location = new System.Drawing.Point(344, 12);
            this.btntip.Name = "btntip";
            this.btntip.Size = new System.Drawing.Size(97, 23);
            this.btntip.TabIndex = 2;
            this.btntip.Text = "Оттипографить";
            this.btntip.UseVisualStyleBackColor = true;
            this.btntip.Click += new System.EventHandler(this.btntip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntip);
            this.Controls.Add(this.textBoxoutput);
            this.Controls.Add(this.textBoxinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.TextBox textBoxoutput;
        private System.Windows.Forms.Button btntip;
    }
}

