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
    public partial class dersGuncelle : Form
    {
        public dersGuncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DERS; user Id=postgres; password=1234");

        public string yazi;

        private void button1_Click(object sender, EventArgs e)
        {
            guncellemeEkranı guncellemeekranı = new guncellemeEkranı();
            baglanti.Open();

            string kayit = "Select * From derstablosu  Where ders_kodu=@derskodu";
            NpgsqlCommand komut = new NpgsqlCommand(kayit, baglanti);

            komut.Parameters.AddWithValue("@derskodu", dersGuncelleTxt.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guncellemeekranı.dataGridView2.DataSource = dt;
            baglanti.Close();

            yazi = dersGuncelleTxt.Text;
            guncellemeekranı.GuncelleDersKoduTxt.Text = yazi;

            guncellemeekranı.Show();
            //
      

        }
    }
}
