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
    public partial class frmYeniMuzayede : Form
    {
        //SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-3L67VG5;Initial Catalog=SanatGalerisi;Integrated Security=True");
        BaglantiSinif bgl = new BaglantiSinif();
        public frmYeniMuzayede()
        {
            InitializeComponent();
        }
       
        private void frmYeniMuzayede_Load(object sender, EventArgs e)
        {
        //    for (int i = 0; i < 6; i++)
        //    {
                FilmAfişiGoster(1);
             //}
        }
        private void FilmAfişiGoster(int i)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("select* from ResimEkleme where resimID='" + 8 + "'",baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["mzydAd"].ToString();
                
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select* from ResimEkleme where resimID='" + 9 + "'", baglan);
            SqlDataReader read1 = komut1.ExecuteReader();
            while (read1.Read())
            {

                pictureBox2.ImageLocation = read1["mzydAd"].ToString();

            }
            baglan.Close();
            baglan.Open();

            SqlCommand komut2 = new SqlCommand("select* from ResimEkleme where resimID='" + 10 + "'", baglan);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {

                pictureBox3.ImageLocation = read2["mzydAd"].ToString();

            }
            baglan.Close();


            baglan.Open();
            SqlCommand komut3 = new SqlCommand("select* from ResimEkleme where resimID='" + 11 + "'", baglan);
            SqlDataReader read3 = komut3.ExecuteReader();
            while (read3.Read())
            {
                pictureBox4.ImageLocation = read3["mzydAd"].ToString();

            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("select* from ResimEkleme where resimID='" + 12 + "'", baglan);
            SqlDataReader read4 = komut4.ExecuteReader();
            while (read4.Read())
            {

                pictureBox5.ImageLocation = read4["mzydAd"].ToString();

            }
            baglan.Close();
            baglan.Open();

            SqlCommand komut5 = new SqlCommand("select* from ResimEkleme where resimID='" + 13 + "'", baglan);
            SqlDataReader read5 = komut5.ExecuteReader();
            while (read5.Read())
            {

                pictureBox6.ImageLocation = read5["mzydAd"].ToString();

            }
            baglan.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
