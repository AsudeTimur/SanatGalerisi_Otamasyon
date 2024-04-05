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
    public partial class frmResimEkleme : Form
    {
        public frmResimEkleme()
        {
            InitializeComponent();
        }


        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmResimEkleme_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResimUzantisi.Text = openFileDialog1.FileName;
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut= new SqlCommand("insert into ResimEkleme (mzydAd,resimler) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtResimUzantisi.Text);
            komut.Parameters.AddWithValue("@p2", txtMuzayedeAdi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi.");

        }
    }
}
