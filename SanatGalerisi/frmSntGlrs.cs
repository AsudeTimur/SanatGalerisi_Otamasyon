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
    public partial class frmSntGlrs : Form
    {
        public frmSntGlrs()
        {
            InitializeComponent();
        }

        private void SanatGalerisi_Load(object sender, EventArgs e)
        {

        }
        SqlBaglantim bgl = new SqlBaglantim();

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmSntGlrs sanatGalerisi = new frmSntGlrs();
            sanatGalerisi.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            loadform(new frmSytRsm());
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            loadform(new frmMnzrRsm());
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            loadform(new frmHyvnRsm());

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            loadform(new frmİnsnRsm());

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            loadform(new frmGlrKrl());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            frmSntGlrs sntGlrs = new frmSntGlrs();
            sntGlrs.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAnaSyf anaSyf = new frmAnaSyf();
            anaSyf.Show();
            this.Hide();
        }

        private void btnMstr_Click(object sender, EventArgs e)
        {
            loadform(new frmYeniMuzayede());
        }
    }
}
