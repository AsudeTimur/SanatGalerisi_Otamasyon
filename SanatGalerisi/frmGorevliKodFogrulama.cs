using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatGalerisi
{
    public partial class frmGorevliKodFogrulama : Form
    {
        public frmGorevliKodFogrulama()
        {
            InitializeComponent();
        }
        public string kod = "";

        private void btnDogrulamaKodu_Click(object sender, EventArgs e)
        {
            if (kod == txtKod.Text)
            {
                frmGorevliYeniSifre yeniSifre = new frmGorevliYeniSifre();
                yeniSifre.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kod.Tekrar deneyiniz");
                txtKod.Text = " ";
            }
        }

        private void frmGorevliKodFogrulama_Load(object sender, EventArgs e)
        {

        }
    }
}
