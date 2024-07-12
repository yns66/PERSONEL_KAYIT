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
    public partial class personel_kayit_istatistik : Form
    {
        public personel_kayit_istatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=YoNiS\\SQLEXPRESS01;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True;Encrypt=False");

        private void personel_kayit_istatistik_Load(object sender, EventArgs e)
        {
            //toplam personel sayısı

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count (*) from tbl_personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplampersonel.Text= dr1[0].ToString();
            }

            baglanti.Close();


            //evli personel sayısı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count (*) from tbl_personel where perdurum=1",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblevlisayisi.Text= dr2[0].ToString();
            }

            baglanti.Close();


            //bekar personel sayısı

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count (*) from tbl_personel where perdurum=0", baglanti);
            SqlDataReader dr3=komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekarsayisi.Text=dr3[0].ToString();
            }

            baglanti.Close();


            //toplam şehir sayısı

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count (distinct(persehir)) from tbl_personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblsehirsayisi.Text=dr4[0].ToString();
            }

            baglanti.Close();

            //toplam maaş

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(permaas) from tbl_personel", baglanti); 
            SqlDataReader dr5 =komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltoplammaas.Text=dr5[0].ToString();
            }
            baglanti.Close();


            //ortalama maaş

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(permaas) from tbl_personel",baglanti);
            SqlDataReader dr6=komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblortmaas.Text=dr6[0].ToString();
            }


            baglanti.Close();


        }
    }
}
