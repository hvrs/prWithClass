
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
            this.butn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lbl_s = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.tb_delete = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tbMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbMain.Location = new System.Drawing.Point(28, 12);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
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
            // butn_search
            // 
            this.butn_search.Location = new System.Drawing.Point(514, 54);
            this.butn_search.Name = "butn_search";
            this.butn_search.Size = new System.Drawing.Size(100, 21);
            this.butn_search.TabIndex = 7;
            this.butn_search.Text = "Поиск";
            this.butn_search.UseVisualStyleBackColor = true;
            this.butn_search.Click += new System.EventHandler(this.butn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(514, 18);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 8;
            // 
            // lbl_s
            // 
            this.lbl_s.AutoSize = true;
            this.lbl_s.Location = new System.Drawing.Point(468, 21);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(40, 13);
            this.lbl_s.TabIndex = 9;
            this.lbl_s.Text = "Марка";
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(310, 280);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(88, 34);
            this.btn_reload.TabIndex = 10;
            this.btn_reload.Text = "Обновить список";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // tb_delete
            // 
            this.tb_delete.Location = new System.Drawing.Point(514, 113);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(100, 20);
            this.tb_delete.TabIndex = 11;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(514, 160);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 21);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Поиск";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Марка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tb_delete);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.lbl_s);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.butn_search);
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
        private System.Windows.Forms.Button butn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_s;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.TextBox tb_delete;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
    }
}

