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
    public partial class frmGirisSayfasi : Form
    {
        public frmGirisSayfasi()
        {
            InitializeComponent();
        }

        private void GirisSayfasi1_Load(object sender, EventArgs e)
        {

        }

        private void btnKllnc_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmYonetici admin = new frmYonetici();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGörevliGiris görevliGiris = new frmGörevliGiris();
            görevliGiris.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            frmGörevliGiris görevliGiris = new frmGörevliGiris();
            görevliGiris.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            frmYonetici admin = new frmYonetici();
            admin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGirisSayfasi girisSayfasi = new frmGirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmGirisSayfasi girisSayfasi = new frmGirisSayfasi();
            girisSayfasi.Show();
            this.Hide();
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
