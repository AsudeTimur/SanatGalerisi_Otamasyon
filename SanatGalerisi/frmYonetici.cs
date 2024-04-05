using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SanatGalerisi
{
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
        }

        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();
        

        

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
        public string yoneticiAd;

        private void btnAdminGiris_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AdminGiris where yoneticiAdSoyad='" + txtAdminAd.Text + "' AND yoneticiSifre='" + txtAdminSifre.Text+ "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                frmYoneticiSayfasi yoneticiSayfasi = new frmYoneticiSayfasi();
                yoneticiSayfasi.ad = txtAdminAd.Text;
                yoneticiSayfasi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Bilgi Girişi. Tekrar Deneyiniz.");

            }

            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGirisSayfasi girisSayfasi = new frmGirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGirisSayfasi girisSayfasi = new frmGirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSifreUnutuum_Click(object sender, EventArgs e)
        {
            frmYoneticiSifremiUnuttum sifremiUnuttum = new frmYoneticiSifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();

        }
    }
}
