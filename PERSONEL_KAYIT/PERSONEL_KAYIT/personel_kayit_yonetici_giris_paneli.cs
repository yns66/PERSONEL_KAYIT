using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PERSONEL_KAYIT
{
    public partial class personel_kayit_yonetici_giris_paneli : Form
    {
        public personel_kayit_yonetici_giris_paneli()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=YoNiS\\SQLEXPRESS01;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komutyonetgiris = new SqlCommand("select * from Tbl_Personel_Yetkili_Girisi where kullaniciadi= @p1 and sifre=@p2",baglanti);
            komutyonetgiris.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komutyonetgiris.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader giriskomut=komutyonetgiris.ExecuteReader();
            if (giriskomut.Read())
            {

                personel_kayit perskayit = new personel_kayit();
                perskayit.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("YANLIŞ KULLANICI ADI YA DA ŞİFRE!");
            }
            baglanti.Close();




        }
    }
}
