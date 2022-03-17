
namespace PR19
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
            this.btnCrt = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrt
            // 
            this.btnCrt.Location = new System.Drawing.Point(84, 280);
            this.btnCrt.Name = "btnCrt";
            this.btnCrt.Size = new System.Drawing.Size(88, 34);
            this.btnCrt.TabIndex = 1;
            this.btnCrt.Text = "Создать";
            this.btnCrt.UseVisualStyleBackColor = true;
            this.btnCrt.Click += new System.EventHandler(this.btnCrt_Click);
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(84, 12);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(432, 233);
            this.tbMain.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(200, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 359);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.btnCrt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrt;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnAdd;
    }
}

