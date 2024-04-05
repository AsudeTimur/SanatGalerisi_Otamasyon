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
    public partial class frmGorevliYeniSifre : Form
    {
        public frmGorevliYeniSifre()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update GorevliGiris set gorevliSifre=@p1 where gorevliAdiSoyadi='" + txtAdSoyad.Text + "'", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Sifre Güncellendi");
            baglanti.Close();
            frmGörevliGiris görevliGiris = new frmGörevliGiris();
            görevliGiris.Show();
            this.Hide();
        }

        private void frmGorevliYeniSifre_Load(object sender, EventArgs e)
        {

        }
    }
}
