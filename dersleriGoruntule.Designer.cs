
namespace öğrenci_transkript
{
    partial class dersleriGoruntule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(616, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // bttnGoruntule
            // 
            this.bttnGoruntule.BackColor = System.Drawing.Color.LightPink;
            this.bttnGoruntule.Location = new System.Drawing.Point(561, 353);
            this.bttnGoruntule.Name = "bttnGoruntule";
            this.bttnGoruntule.Size = new System.Drawing.Size(153, 75);
            this.bttnGoruntule.TabIndex = 1;
            this.bttnGoruntule.Text = "Dersleri Görüntüle\r\n";
            this.bttnGoruntule.UseVisualStyleBackColor = false;
            this.bttnGoruntule.Click += new System.EventHandler(this.bttnGoruntule_Click);
            // 
            // dersleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnGoruntule);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dersleriGoruntule";
            this.Text = "dersleriGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnGoruntule;
    }
}