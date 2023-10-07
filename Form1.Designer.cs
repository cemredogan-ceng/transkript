
namespace öğrenci_transkript
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dersSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dersGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transkriptGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenüToolStripMenuItem,
            this.dersEkleToolStripMenuItem,
            this.dersSilToolStripMenuItem,
            this.transkriptGörüntüleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.anaMenüToolStripMenuItem.Text = "Ana Menü";
            this.anaMenüToolStripMenuItem.Click += new System.EventHandler(this.anaMenüToolStripMenuItem_Click);
            // 
            // dersEkleToolStripMenuItem
            // 
            this.dersEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersEkleToolStripMenuItem1,
            this.dersSilToolStripMenuItem1,
            this.dersGüncelleToolStripMenuItem});
            this.dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            this.dersEkleToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.dersEkleToolStripMenuItem.Text = "Ders İşlemleri";
            // 
            // dersEkleToolStripMenuItem1
            // 
            this.dersEkleToolStripMenuItem1.Name = "dersEkleToolStripMenuItem1";
            this.dersEkleToolStripMenuItem1.Size = new System.Drawing.Size(221, 34);
            this.dersEkleToolStripMenuItem1.Text = "Ders Ekle";
            this.dersEkleToolStripMenuItem1.Click += new System.EventHandler(this.dersEkleToolStripMenuItem1_Click);
            // 
            // dersSilToolStripMenuItem1
            // 
            this.dersSilToolStripMenuItem1.Name = "dersSilToolStripMenuItem1";
            this.dersSilToolStripMenuItem1.Size = new System.Drawing.Size(221, 34);
            this.dersSilToolStripMenuItem1.Text = "Ders Sil";
            this.dersSilToolStripMenuItem1.Click += new System.EventHandler(this.dersSilToolStripMenuItem1_Click);
            // 
            // dersGüncelleToolStripMenuItem
            // 
            this.dersGüncelleToolStripMenuItem.Name = "dersGüncelleToolStripMenuItem";
            this.dersGüncelleToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.dersGüncelleToolStripMenuItem.Text = "Ders Güncelle";
            this.dersGüncelleToolStripMenuItem.Click += new System.EventHandler(this.dersGüncelleToolStripMenuItem_Click);
            // 
            // dersSilToolStripMenuItem
            // 
            this.dersSilToolStripMenuItem.Name = "dersSilToolStripMenuItem";
            this.dersSilToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.dersSilToolStripMenuItem.Text = "Dersleri Görüntüle";
            this.dersSilToolStripMenuItem.Click += new System.EventHandler(this.dersSilToolStripMenuItem_Click);
            // 
            // transkriptGörüntüleToolStripMenuItem
            // 
            this.transkriptGörüntüleToolStripMenuItem.Name = "transkriptGörüntüleToolStripMenuItem";
            this.transkriptGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(187, 29);
            this.transkriptGörüntüleToolStripMenuItem.Text = "Transkript Görüntüle";
            this.transkriptGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.transkriptGörüntüleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dersSilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dersGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transkriptGörüntüleToolStripMenuItem;
    }
}

