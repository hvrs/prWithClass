﻿
namespace PR19
{
    partial class addForm
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
            this.tbMark = new System.Windows.Forms.TextBox();
            this.tbVdvg = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPowerfl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(27, 38);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(122, 20);
            this.tbMark.TabIndex = 0;
            // 
            // tbVdvg
            // 
            this.tbVdvg.Location = new System.Drawing.Point(27, 76);
            this.tbVdvg.Name = "tbVdvg";
            this.tbVdvg.Size = new System.Drawing.Size(122, 20);
            this.tbVdvg.TabIndex = 1;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(27, 114);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(122, 20);
            this.tbSpeed.TabIndex = 2;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(27, 149);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(122, 20);
            this.tbYear.TabIndex = 3;
            // 
            // tbPowerfl
            // 
            this.tbPowerfl.Location = new System.Drawing.Point(27, 184);
            this.tbPowerfl.Name = "tbPowerfl";
            this.tbPowerfl.Size = new System.Drawing.Size(122, 20);
            this.tbPowerfl.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Объем";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Максимальная скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Мощность";
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 255);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPowerfl);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbVdvg);
            this.Controls.Add(this.tbMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addForm";
            this.Text = "addForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.TextBox tbVdvg;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPowerfl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}