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
    public partial class frmMuzayedeIslemleri : Form
    {
        public frmMuzayedeIslemleri()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl =new BaglantiSinif();
        private void frmMuzayedeIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanatGalerisiDataSet6.GorevliMusteri' table. You can move, or remove it, as needed.
            this.gorevliMusteriTableAdapter.Fill(this.sanatGalerisiDataSet6.GorevliMusteri);


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into GorevliMusteri (mstrAd, mstrSoyad, mstrTC, mstrTelefon, mstrEmail, mstrMuzayedeAdi, mstrMuzayedeBaslangic, mstrMuzayedeBitis, mstrUcret, mstrUcretBilgisi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtTC.Text);
            komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtEmail.Text);
            komut.Parameters.AddWithValue("@p6", txtMuzayedeAdi.Text);
            komut.Parameters.AddWithValue("@p7", txtMuzayedeBaslangic.Text);
            komut.Parameters.AddWithValue("@p8", txtMuzayedeBitis.Text);
            komut.Parameters.AddWithValue("@p9", txtUcret.Text);
            komut.Parameters.AddWithValue("@p10", txtUcretBilgisi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müzayede Eklendi.");
            this.gorevliMusteriTableAdapter.Fill(this.sanatGalerisiDataSet6.GorevliMusteri);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from GorevliMusteri where mstrID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müzayede Silindi.");
            this.gorevliMusteriTableAdapter.Fill(this.sanatGalerisiDataSet6.GorevliMusteri);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update GorevliMusteri set mstrAd=@p2, mstrSoyad=@p3, mstrTC=@p4, mstrTelefon=@p5, mstrEmail=@p6, mstrMuzayedeAdi=@p7, mstrMuzayedeBaslangic=@p8, mstrMuzayedeBitis=@p9, mstrUcret=@p10, mstrUcretBilgisi=@p11 where mstrID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p2", txtAdi.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtTC.Text);
            komut.Parameters.AddWithValue("@p5", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtEmail.Text);
            komut.Parameters.AddWithValue("@p7", txtMuzayedeAdi.Text);
            komut.Parameters.AddWithValue("@p8", txtMuzayedeBaslangic.Text);
            komut.Parameters.AddWithValue("@p9", txtMuzayedeBitis.Text);
            komut.Parameters.AddWithValue("@p10", txtUcret.Text);
            komut.Parameters.AddWithValue("@p11", txtUcretBilgisi.Text);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi.");
            this.gorevliMusteriTableAdapter.Fill(this.sanatGalerisiDataSet6.GorevliMusteri);

        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, soyad, TC, telefon, email, muzayedeAdi, muzayedeBaslangic, muzayedeBitis, ucret, ucretBilgisi;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            email = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            muzayedeAdi = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            muzayedeBaslangic = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            muzayedeBitis = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            ucret = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            ucretBilgisi = dataGridView1.Rows[secilen].Cells[10].Value.ToString();

            txtID.Text = id;
            txtAdi.Text = ad;
            txtSoyad.Text = soyad;
            txtTC.Text = TC;
            txtTelefon.Text = telefon;
            txtEmail.Text = email;
            txtMuzayedeAdi.Text = muzayedeAdi;
            txtMuzayedeBaslangic.Text = muzayedeBaslangic;
            txtMuzayedeBitis.Text = muzayedeBitis;
            txtUcret.Text = ucret;
            txtUcretBilgisi.Text = ucretBilgisi;
        }
    }
}
