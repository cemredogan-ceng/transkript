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
    public partial class dersleriGoruntule : Form
    {
        public dersleriGoruntule()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DERS; user Id=postgres; password=1234");
        private void bttnGoruntule_Click(object sender, EventArgs e)
        {
           
            
                string sorgu = " SELECT * FROM derstablosu";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            
        }
    }
}
