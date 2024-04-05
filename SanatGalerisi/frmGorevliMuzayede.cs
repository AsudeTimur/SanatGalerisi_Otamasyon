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
    public partial class frmGorevliMuzayede : Form
    {
        public frmGorevliMuzayede()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            frmGörevliGiris görevliGiris = new frmGörevliGiris();
            görevliGiris.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string ad = "";
        public void loadform(object Form)
        {
            label1.Text = ad.ToString();
            if (this.GorevliMainPanel.Controls.Count > 0)
                this.GorevliMainPanel.Controls.RemoveAt(0);
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.GorevliMainPanel.Controls.Add(frm);
            this.GorevliMainPanel.Tag = frm;
            frm.Show();
        }

        private void btnMuzayedeEkle_Click(object sender, EventArgs e)
        {
        }

        private void btnMuzayedeGoster_Click(object sender, EventArgs e)
        {
            loadform(new frmMuzayedeListele());
        }

        private void btnMuzayedeEkle_Click_1(object sender, EventArgs e)
        {
            loadform(new frmMuzayedeEkle());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGorevliMuzayede gorevliMuzayede = new frmGorevliMuzayede();
            gorevliMuzayede.Show();
            this.Hide();
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
