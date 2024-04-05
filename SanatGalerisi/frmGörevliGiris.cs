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
    public partial class frmGörevliGiris : Form
    {
        public frmGörevliGiris()
        {
            InitializeComponent();
        }

        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();


        private void btnGörevliGrs_Click(object sender, EventArgs e)
        {
            frmGorevliMuzayede form = new frmGorevliMuzayede();
            form.Show();
            this.Hide();
        }

        private void frmGörevliGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komutGorevli = new SqlCommand("select * from GorevliGiris where gorevliAdiSoyadi='" + txtAdSoyad.Text + "' AND gorevliSifre='" + txtSifre.Text + "'", baglanti);
            SqlDataReader oku2 = komutGorevli.ExecuteReader();
            if (oku2.Read())
            {
                frmGorevliMuzayede gorevliMuzayede = new frmGorevliMuzayede();
                gorevliMuzayede.ad = txtAdSoyad.Text;
                gorevliMuzayede.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Bilgi Girişi. Tekrar Deneyiniz.");

            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGirisSayfasi girisSayfasi = new frmGirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGirisSayfasi girisSayfasi = new frmGirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            frmGorevliSifremiUnuttum sifremiUnuttum = new frmGorevliSifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }
    }
}
