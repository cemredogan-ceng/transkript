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
    public partial class dersEkle : Form
    {
        public dersEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DERS; user Id=postgres; password=1234");

        private void bttnEkle_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into derstablosu(ders_kodu,ders_adi,akts,ders_kredisi,Öğretim_üyesi,yıl_dönem,harf_notu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut1.Parameters.AddWithValue("@p1", dersKoduTxt.Text);
                komut1.Parameters.AddWithValue("@p2", dersAdıTxt.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(aktsTxt.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(dersKredisiTxt.Text));
            komut1.Parameters.AddWithValue("@p5", öğrtUyesiTxt.Text);
            komut1.Parameters.AddWithValue("@p6", yılDonemTxt.Text);
            komut1.Parameters.AddWithValue("@p7", harfNotuTxt.Text);
         

            komut1.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ders Ekleme başarıyla tamamlandı");
            
        }
    }
}
