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
    public partial class frmGlrKrl : Form
    {
        public frmGlrKrl()
        {
            InitializeComponent();
        }

        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();
        private void frmGlrKrl_Load(object sender, EventArgs e)
        {

        }

        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmGlrKrl glrKrl = new frmGlrKrl();
            glrKrl.Show();
            this.Hide();
        }

        private void btnGaleriKirala_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand komutKirala = new SqlCommand("insert into KullaniciDB (KullaniciIsim,KullniciSoyad,KullaniciTc,KullaniciTelefon,KullaniciBaslangic,KullaniciBitis,KullaniciMuzakareIsmi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komutKirala.Parameters.AddWithValue("@p1", txtAd.Text);
                komutKirala.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komutKirala.Parameters.AddWithValue("@p3", txtTC.Text);
                komutKirala.Parameters.AddWithValue("@p4", txtTelefon.Text);
                komutKirala.Parameters.AddWithValue("@p5", txtBaslangicTarihSaat.Text);
                komutKirala.Parameters.AddWithValue("@p6", txtBitisTarihSaat.Text);
                komutKirala.Parameters.AddWithValue("@p7", txtMuzayedeAdi.Text);
                komutKirala.ExecuteNonQuery();
                MessageBox.Show("Müzayede Rezervasyonu Yapıldı.");
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTelefon.Text = "";
            txtBaslangicTarihSaat.Text = "";
            txtBitisTarihSaat.Text = "";
            txtMuzayedeAdi.Text = "";

        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }
    }
}
