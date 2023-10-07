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
using System.Diagnostics;

namespace öğrenci_transkript

{

    public partial class dersSilme : Form
    {
      
        public dersSilme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DERS; user Id=postgres; password=1234");

        private void dersSilBttn_Click(object sender, EventArgs e)
        {
            //dersSilme2 dersSilme2 = new dersSilme();
        

            if(MessageBox.Show("Dersi silmek istiyor musunuz?","sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("Delete From derstablosu where ders_kodu=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", dersSilmeTxt.Text);

                komut2.ExecuteNonQuery();
                baglanti.Close();

            }

            

           

        }
    }
}
