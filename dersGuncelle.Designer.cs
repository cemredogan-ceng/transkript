﻿
namespace öğrenci_transkript
{
    partial class dersGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dersGuncelleTxt = new System.Windows.Forms.TextBox();
            this.DersGuncelleBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellenecek dersin kodunu giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders kodu:\r\n";
            // 
            // dersGuncelleTxt
            // 
            this.dersGuncelleTxt.Location = new System.Drawing.Point(206, 110);
            this.dersGuncelleTxt.Name = "dersGuncelleTxt";
            this.dersGuncelleTxt.Size = new System.Drawing.Size(130, 26);
            this.dersGuncelleTxt.TabIndex = 2;
            // 
            // DersGuncelleBttn
            // 
            this.DersGuncelleBttn.BackColor = System.Drawing.Color.LightPink;
            this.DersGuncelleBttn.Location = new System.Drawing.Point(352, 153);
            this.DersGuncelleBttn.Name = "DersGuncelleBttn";
            this.DersGuncelleBttn.Size = new System.Drawing.Size(322, 73);
            this.DersGuncelleBttn.TabIndex = 3;
            this.DersGuncelleBttn.Text = "Güncellenecek ders bilgilerini görüntüle";
            this.DersGuncelleBttn.UseVisualStyleBackColor = false;
            this.DersGuncelleBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dersGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DersGuncelleBttn);
            this.Controls.Add(this.dersGuncelleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dersGuncelle";
            this.Text = "dersGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DersGuncelleBttn;
        public System.Windows.Forms.TextBox dersGuncelleTxt;
    }
}