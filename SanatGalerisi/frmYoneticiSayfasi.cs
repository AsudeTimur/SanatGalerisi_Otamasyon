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
    public partial class frmYoneticiSayfasi : Form
    {
        public frmYoneticiSayfasi()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        public string ad = "";
        public void loadform(object Form)
        {
            label1.Text = ad.ToString();
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frm);
            this.mainPanel.Tag = frm;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmYoneticiSayfasi yoneticiSayfasi = new frmYoneticiSayfasi();
            yoneticiSayfasi.Show();
            this.Hide();
        }

        private void btnMuzayedeEkle_Click(object sender, EventArgs e)
        {
            loadform(new frmYoneticiMusteriBilgileri());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYonetici admin = new frmYonetici();
            admin.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmYoneticiSayfasi yoneticiSayfasi = new frmYoneticiSayfasi();
            yoneticiSayfasi.Show();
            this.Hide();
        }

        

        private void btnYoneticiIslemleri_Click(object sender, EventArgs e)
        {
            loadform(new frmYoneticiIslemleri());
        }

        private void btnMuzayedeSil_Click(object sender, EventArgs e)
        {
            loadform(new frmGorevliIslemleri());
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            loadform(new frmMuzayedeIslemleri());
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            loadform(new frmGelirler());
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            loadform(new frmGiderler());

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            loadform(new frmGeriDonusler());
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            loadform(new frmResimEkleme());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
