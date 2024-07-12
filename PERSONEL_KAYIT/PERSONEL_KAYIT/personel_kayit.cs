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
    public partial class personel_kayit : Form
    {
        public personel_kayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=YoNiS\\SQLEXPRESS01;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True;Encrypt=False");

        void temizle()
        {

            txtid.Text = ("");
            txtad.Text = ("");
            txtsoyad.Text = ("");
            txtmeslek.Text = ("");
            cmbsehir.Text = ("");
            mskmaas.Text = ("");
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtad.Focus();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_Veri_TabaniDataSet1.Tbl_Personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (perad, persoyad, persehir, permaas, permeslek, perdurum)values(@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbsehir.Text);
            komut.Parameters.AddWithValue("@p4", mskmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Personel Bilgileri Eklendi.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
            
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "true";
            }
                       
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "false";
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {

            if (label8.Text == "true")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "false")
            {
                radioButton2.Checked = false;
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Personel Kaydı Silindi.");


        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1, PerSoyad=@a2, PerSehir=@a3, PerMaas=@a4, PerDurum=@a5, PerMeslek=@a6 Where Perid=@a7 ", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Personel Bilgileri Güncellendi.");

        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            personel_kayit_istatistik pki=new personel_kayit_istatistik();

            pki.Show();

        }
        private void btngrafikler_Click(object sender, EventArgs e)
        {
            personel_kayit_grafik pkg = new personel_kayit_grafik();
            pkg.Show();
        }
    }
}

