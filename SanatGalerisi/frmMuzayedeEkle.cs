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
    public partial class frmMuzayedeEkle : Form
    {
        public frmMuzayedeEkle()
        {
            InitializeComponent();
        }


        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(txtBaslangic.Text);
            DateTime buyukTarih = Convert.ToDateTime(txtBitis.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;

            lblUcret.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(lblUcret.Text) * 400;
            lblUcret.Text = ucret.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand komutKaydet = new SqlCommand("insert into GorevliMusteri (mstrAd,mstrSoyad,mstrTC,mstrTelefon,mstrEmail,mstrMuzayedeAdi,mstrMuzayedeBaslangic,mstrMuzayedeBitis,mstrUcret,mstrUcretBilgisi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
                komutKaydet.Parameters.AddWithValue("@p1", txtAdi.Text);
                komutKaydet.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p3", txtTC.Text);
                komutKaydet.Parameters.AddWithValue("@p4", txtTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p5", txtEmail.Text);
                komutKaydet.Parameters.AddWithValue("@p6", txtMuzayedeAdi.Text);
                komutKaydet.Parameters.AddWithValue("@p7", txtMuzayedeBaslangic.Text);
                komutKaydet.Parameters.AddWithValue("@p8", txtMuzayedeBitis.Text);
                komutKaydet.Parameters.AddWithValue("@p9", txtUcret.Text);
                if (radioButton1.Checked)
                {
                    komutKaydet.Parameters.AddWithValue("@p10", "1");
                }
                else
                {
                    komutKaydet.Parameters.AddWithValue("@p10", "0");
                }
                komutKaydet.ExecuteNonQuery();
                MessageBox.Show("Müzayede Başarılı Bir Şekilde Eklendi.");
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMuzayedeEkle_Load(object sender, EventArgs e)
        {

        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
