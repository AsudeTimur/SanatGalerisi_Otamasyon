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
    public partial class frmMuzayedeListele : Form
    {
        public frmMuzayedeListele()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();


        private void frmMuzayedeListele_Load(object sender, EventArgs e)
        {

        }
        
        private void verileriGoster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KullaniciDB", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kullaniciid"].ToString();
                ekle.SubItems.Add(oku["KullaniciIsim"].ToString());
                ekle.SubItems.Add(oku["KullniciSoyad"].ToString());
                ekle.SubItems.Add(oku["KullaniciTc"].ToString());
                ekle.SubItems.Add(oku["KullaniciTelefon"].ToString());
                ekle.SubItems.Add(oku["KullaniciBaslangic"].ToString());
                ekle.SubItems.Add(oku["KullaniciBitis"].ToString());
                ekle.SubItems.Add(oku["KullaniciMuzakareIsmi"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KullaniciDB where KullaniciTc like '%" + txtAra.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kullaniciid"].ToString();
                ekle.SubItems.Add(oku["KullaniciIsim"].ToString());
                ekle.SubItems.Add(oku["KullniciSoyad"].ToString());
                ekle.SubItems.Add(oku["KullaniciTc"].ToString());
                ekle.SubItems.Add(oku["KullaniciTelefon"].ToString());
                ekle.SubItems.Add(oku["KullaniciBaslangic"].ToString());
                ekle.SubItems.Add(oku["KullaniciBitis"].ToString());
                ekle.SubItems.Add(oku["KullaniciMuzakareIsmi"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}
