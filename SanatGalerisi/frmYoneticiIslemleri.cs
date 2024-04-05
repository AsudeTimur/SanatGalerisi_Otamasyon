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

namespace SanatGalerisi
{
    public partial class frmYoneticiIslemleri : Form
    {
        public frmYoneticiIslemleri()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();

        private void frmYoneticiIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanatGalerisiDataSet3.AdminGiris' table. You can move, or remove it, as needed.
            this.adminGirisTableAdapter.Fill(this.sanatGalerisiDataSet3.AdminGiris);
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AdminGiris (yoneticiAdSoyad,yoneticiSifre) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdiSoyadi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici Eklendi.");
            this.adminGirisTableAdapter.Fill(this.sanatGalerisiDataSet3.AdminGiris);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtAdiSoyadi.Text = ad;
            txtSifre.Text = sifre;
            txtID.Text = id;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from AdminGiris where yoneticiID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici Silindi.");
            this.adminGirisTableAdapter.Fill(this.sanatGalerisiDataSet3.AdminGiris);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set yoneticiAdSoyad=@p1, yoneticiSifre=@p2 where yoneticiID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdiSoyadi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi.");
            this.adminGirisTableAdapter.Fill(this.sanatGalerisiDataSet3.AdminGiris);


        }
    }
}
