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
    public partial class guncellemeEkranı : Form
    {
        public guncellemeEkranı()
        {
            InitializeComponent();
        }

        private void guncellemeEkranı_Load(object sender, EventArgs e)
        {

        }

        private void guncellemeEkranıBttn_Click(object sender, EventArgs e)
        {
            

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update derstablosu set ders_adi=@p1,akts=@p2,ders_kredisi=@p3,Öğretim_üyesi=@p4,yıl_dönem=@p5,harf_notu=@p6 where ders_kodu=@derskodu", baglanti);
            komut1.Parameters.AddWithValue("@p1", GuncelleDersAdıTxt.Text);
            komut1.Parameters.AddWithValue("@p2", int.Parse(GuncelleAktsTxt.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(GuncelleDersKredisiTxt.Text));
            komut1.Parameters.AddWithValue("@p4", OgrUyesiTxt.Text);
            komut1.Parameters.AddWithValue("@p5", yılDönemTxt.Text);
            komut1.Parameters.AddWithValue("@p6", harfNotuTxt.Text);
            komut1.Parameters.AddWithValue("@derskodu", GuncelleDersKoduTxt.Text);


            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ders güncelleme başarıyla tamamlandı");
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DERS; user Id=postgres; password=1234");
       
        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GuncelleDersKoduTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


