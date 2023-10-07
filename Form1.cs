using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace öğrenci_transkript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DERS; user Id=postgres; password=1234");
        

        private void dersEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dersEkle dersEkle = new dersEkle();
            dersEkle.MdiParent = this;
            dersEkle.Show();
        }

        private void dersSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersleriGoruntule derslerigoruntule = new dersleriGoruntule();
            derslerigoruntule.MdiParent = this;
            derslerigoruntule.Show();

        }

        private void dersSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dersSilme dersSilme = new dersSilme();
            dersSilme.MdiParent = this;
            dersSilme.Show();
        }

        private void dersGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersGuncelle dersGuncelle = new dersGuncelle();
            dersGuncelle.MdiParent = this;
            dersGuncelle.Show();
        }

        private void transkriptGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transkriptGoruntule transkriptGoruntule = new transkriptGoruntule();
            transkriptGoruntule.MdiParent = this;
            transkriptGoruntule.Show();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.MdiParent = this;
            anaMenu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
