
namespace öğrenci_transkript
{
    partial class transkriptGoruntule
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
            this.transkriptDataGridview = new System.Windows.Forms.DataGridView();
            this.GanoHesaplaBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transkriptDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // transkriptDataGridview
            // 
            this.transkriptDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transkriptDataGridview.Location = new System.Drawing.Point(62, 25);
            this.transkriptDataGridview.Name = "transkriptDataGridview";
            this.transkriptDataGridview.RowHeadersWidth = 62;
            this.transkriptDataGridview.RowTemplate.Height = 28;
            this.transkriptDataGridview.Size = new System.Drawing.Size(815, 301);
            this.transkriptDataGridview.TabIndex = 1;
            // 
            // GanoHesaplaBttn
            // 
            this.GanoHesaplaBttn.BackColor = System.Drawing.Color.LightPink;
            this.GanoHesaplaBttn.Location = new System.Drawing.Point(741, 369);
            this.GanoHesaplaBttn.Name = "GanoHesaplaBttn";
            this.GanoHesaplaBttn.Size = new System.Drawing.Size(146, 60);
            this.GanoHesaplaBttn.TabIndex = 3;
            this.GanoHesaplaBttn.Text = "Gano Hesapla";
            this.GanoHesaplaBttn.UseVisualStyleBackColor = false;
            this.GanoHesaplaBttn.Click += new System.EventHandler(this.GanoHesaplaBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "GANO:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 26);
            this.textBox1.TabIndex = 5;
            // 
            // transkriptGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GanoHesaplaBttn);
            this.Controls.Add(this.transkriptDataGridview);
            this.Controls.Add(this.label1);
            this.Name = "transkriptGoruntule";
            this.Text = "transkriptGoruntule";
            this.Load += new System.EventHandler(this.transkriptGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transkriptDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView transkriptDataGridview;
        private System.Windows.Forms.Button GanoHesaplaBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}