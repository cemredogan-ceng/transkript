
namespace öğrenci_transkript
{
    partial class dersSilme
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
            this.dersSilmeTxt = new System.Windows.Forms.TextBox();
            this.dersSilBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek istediğiniz ders kodunu giriniz\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders kodu:\r\n";
            // 
            // dersSilmeTxt
            // 
            this.dersSilmeTxt.Location = new System.Drawing.Point(172, 106);
            this.dersSilmeTxt.Name = "dersSilmeTxt";
            this.dersSilmeTxt.Size = new System.Drawing.Size(100, 26);
            this.dersSilmeTxt.TabIndex = 2;
            // 
            // dersSilBttn
            // 
            this.dersSilBttn.BackColor = System.Drawing.Color.LightPink;
            this.dersSilBttn.Location = new System.Drawing.Point(420, 161);
            this.dersSilBttn.Name = "dersSilBttn";
            this.dersSilBttn.Size = new System.Drawing.Size(124, 55);
            this.dersSilBttn.TabIndex = 3;
            this.dersSilBttn.Text = "Ders Silme";
            this.dersSilBttn.UseVisualStyleBackColor = false;
            this.dersSilBttn.Click += new System.EventHandler(this.dersSilBttn_Click);
            // 
            // dersSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dersSilBttn);
            this.Controls.Add(this.dersSilmeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dersSilme";
            this.Text = "dersSilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dersSilBttn;
        public System.Windows.Forms.TextBox dersSilmeTxt;
    }
}