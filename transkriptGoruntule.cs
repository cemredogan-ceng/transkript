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
    public partial class transkriptGoruntule : Form
    {
        public transkriptGoruntule()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DERS; user Id=postgres; password=1234");
        
       public string deneme; private void transkriptGoruntule_Load(object sender, EventArgs e)
        {
            string sorgu = " SELECT * FROM derstablosu";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            transkriptDataGridview.DataSource = ds.Tables[0];

           
       
        }

        private void GanoHesaplaBttn_Click(object sender, EventArgs e)
        {

           hesapgano hesapgano = new hesapgano();
            hesapgano.listboxGano.Items.Clear();
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select  harf_notu_karsılıgı, ders_kredisi from ganohesaptablosu", baglanti);
            DataTable datatable = new DataTable();
            adtr.Fill(datatable);
            float toplam = 0;
            float toplamKredi = 0;
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                hesapgano.listboxGano.Items.Add(datatable.Rows[i][0] + "   " + datatable.Rows[i][1]);
                toplam += Convert.ToInt64(datatable.Rows[i][0]) * Convert.ToInt64(datatable.Rows[i][1]);
                toplamKredi += Convert.ToInt64(datatable.Rows[i][1]);
            }
            toplam /= toplamKredi;
            textBox1.Text = toplam.ToString();
            baglanti.Close();

        }
    }
}
