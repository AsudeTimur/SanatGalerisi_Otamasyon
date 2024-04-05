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
    public partial class frmAnaSyf : Form
    {
        public frmAnaSyf()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmGirisSayfasi girisSayfasi = new frmGirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void btnASAnaSayfa_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void btnASSanatGalerisi_Click(object sender, EventArgs e)
        {
            frmSntGlrs sntGlrs = new frmSntGlrs();
            sntGlrs.Show();
            this.Hide();
        }

        private void btnASGaleriKiralama_Click(object sender, EventArgs e)
        {
            frmGlrKrl form = new frmGlrKrl();
            form.Show();
            this.Hide();
        }

        private void btnASIletisim_Click(object sender, EventArgs e)
        {
            frmIltsm iltsm = new frmIltsm();
            iltsm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
