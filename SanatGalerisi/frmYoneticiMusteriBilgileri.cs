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
    public partial class frmYoneticiMusteriBilgileri : Form
    {
        public frmYoneticiMusteriBilgileri()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmYoneticiMuzayedeEkle_Load(object sender, EventArgs e)
        {

        }
        private void verileriGoster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from GorevliMusteri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mstrID"].ToString();
                ekle.SubItems.Add(oku["mstrAd"].ToString());
                ekle.SubItems.Add(oku["mstrSoyad"].ToString());
                ekle.SubItems.Add(oku["mstrTC"].ToString());
                ekle.SubItems.Add(oku["mstrTelefon"].ToString());
                ekle.SubItems.Add(oku["mstrEmail"].ToString());
                ekle.SubItems.Add(oku["mstrMuzayedeAdi"].ToString());
                ekle.SubItems.Add(oku["mstrMuzayedeBaslangic"].ToString());
                ekle.SubItems.Add(oku["mstrMuzayedeBitis"].ToString());
                ekle.SubItems.Add(oku["mstrUcret"].ToString());
                ekle.SubItems.Add(oku["mstrUcretBilgisi"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYoneticiSayfasi yoneticiSayfasi = new frmYoneticiSayfasi();
            yoneticiSayfasi.Show();
            this.Hide();
        }
    }
}
