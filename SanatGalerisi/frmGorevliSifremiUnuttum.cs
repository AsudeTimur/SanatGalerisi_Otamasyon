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
using System.Net.Mail;

namespace SanatGalerisi
{
    public partial class frmGorevliSifremiUnuttum : Form
    {
        public frmGorevliSifremiUnuttum()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("E-posta adresi boş bırakılamaz!");

            }
            else
            {
                RandomKod kodumuz = new RandomKod();
                string gonderilecek_kod = kodumuz.kod();

                MailMessage mail_mesaji = new MailMessage();
                SmtpClient istemci = new SmtpClient();

                istemci.Credentials = new System.Net.NetworkCredential("info.8290.info@gmail.com", "txeacnummdoakjpm");
                istemci.Port = 587;
                istemci.EnableSsl = true;
                istemci.Host = "smtp.gmail.com";
                mail_mesaji.To.Add(txtEmail.Text);
                mail_mesaji.From = new MailAddress("info.8290.info@gmail.com");
                mail_mesaji.Subject = "Şifremi Unuttum";
                mail_mesaji.Body = "Şifre unuttum talebi gönderdiniz.Tek seferlik şifreniz: " + gonderilecek_kod;
                istemci.Send(mail_mesaji);
                MessageBox.Show("Mail Gönderildi");

                frmGorevliKodFogrulama kodDogrula = new frmGorevliKodFogrulama();
                kodDogrula.kod = gonderilecek_kod;
                kodDogrula.Show();
                this.Hide();

            }
        }

        private void frmGorevliSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
