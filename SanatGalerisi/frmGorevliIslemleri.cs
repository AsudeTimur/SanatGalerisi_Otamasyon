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
    public partial class frmGorevliIslemleri : Form
    {
        public frmGorevliIslemleri()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();
        private void frmGorevliIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanatGalerisiDataSet4.GorevliGiris' table. You can move, or remove it, as needed.
            this.gorevliGirisTableAdapter.Fill(this.sanatGalerisiDataSet4.GorevliGiris);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into GorevliGiris (gorevliAdiSoyadi, gorevliSifre) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdiSoyadi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görevli Eklendi.");
            this.gorevliGirisTableAdapter.Fill(this.sanatGalerisiDataSet4.GorevliGiris);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from GorevliGiris where gorevliID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görevli Silindi.");
            this.gorevliGirisTableAdapter.Fill(this.sanatGalerisiDataSet4.GorevliGiris);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update GorevliGiris set gorevliAdiSoyadi=@p1, gorevliSifre=@p2 where gorevliID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdiSoyadi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi.");
            this.gorevliGirisTableAdapter.Fill(this.sanatGalerisiDataSet4.GorevliGiris);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtAdiSoyadi.Text = ad;
            txtSifre.Text = sifre;
            txtID.Text = id;
        }
    }
}
