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
    public partial class frmYoneticiKodDogrulama : Form
    {
        public frmYoneticiKodDogrulama()
        {
            InitializeComponent();
        }
 
        public string kod = "";

        private void btnDogrulamaKodu_Click(object sender, EventArgs e)
        {
            if (kod == txtKod.Text)
            {
                frmYoneticiYeniSifre yoneticiYeniSifre = new frmYoneticiYeniSifre();
                yoneticiYeniSifre.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kod.Tekrar deneyiniz");
                txtKod.Text = " ";
            }
            
        }

        private void frmYoneticiKodDogrulama_Load(object sender, EventArgs e)
        {

        }
    }
}
