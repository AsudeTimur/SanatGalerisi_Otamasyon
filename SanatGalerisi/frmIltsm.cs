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
    public partial class frmIltsm : Form
    {
        public frmIltsm()
        {
            InitializeComponent();
        }

        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();

        private void frmIltsm_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Show();
        }

        private void btnIltsmGonder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                baglanti.Open();
                SqlCommand komutGonder = new SqlCommand("insert into iletisim (adSoyad,email,konu,mesaj) values (@p1,@p2,@p3,@p4)", baglanti);
                komutGonder.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                komutGonder.Parameters.AddWithValue("@p2", txtEmail.Text);
                komutGonder.Parameters.AddWithValue("@p3", txtKonu.Text);
                komutGonder.Parameters.AddWithValue("@p4", txtMesaj.Text);
                komutGonder.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Mesajınız Başarılı Bir Şekilde Gönderildi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
