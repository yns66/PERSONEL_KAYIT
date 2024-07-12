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
    public partial class personel_kayit_grafik : Form
    {
        public personel_kayit_grafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=YoNiS\\SQLEXPRESS01;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True;Encrypt=False");


        private void personel_kayit_grafik_Load(object sender, EventArgs e)
        {
            //1. grafik 

            baglanti.Open();

            SqlCommand komutg1 = new SqlCommand("select persehir, count(*) from tbl_personel group by persehir", baglanti);
            SqlDataReader gr1 = komutg1.ExecuteReader();
            while (gr1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(gr1[0], gr1[1]);

            }           
            baglanti.Close();



            //2. grafik

            baglanti.Open();

            SqlCommand komutg2 = new SqlCommand("select permeslek, avg(permaas) from tbl_personel group by permeslek", baglanti);
            SqlDataReader gr2 = komutg2.ExecuteReader();
            while (gr2.Read())
            {
                chart2.Series["Meslek-Maaş"].Points.AddXY(gr2[0], gr2[1]);
            }



        }
    }
}
