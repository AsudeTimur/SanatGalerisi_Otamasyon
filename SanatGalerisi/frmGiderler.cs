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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }
        //SqlBaglantim bgl = new SqlBaglantim();
        BaglantiSinif bgl = new BaglantiSinif();
        private void frmGiderler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanatGalerisiDataSet7.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.sanatGalerisiDataSet7.Giderler);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Giderler (elektrik, su, dogalgaz, digerGiderler) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
            komut.Parameters.AddWithValue("@p2", txtSu.Text);
            komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
            komut.Parameters.AddWithValue("@p4", txtDigerGiderler.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Giderler Eklendi.");
            this.giderlerTableAdapter.Fill(this.sanatGalerisiDataSet7.Giderler);

        }

        

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Giderler where odemeID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Giderler Silindi.");
            this.giderlerTableAdapter.Fill(this.sanatGalerisiDataSet7.Giderler);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Giderler set elektrik=@p1, su=@p2, dogalGaz=@p3, digerGiderler=@p4 where odemeID=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
            komut.Parameters.AddWithValue("@p2", txtSu.Text);
            komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
            komut.Parameters.AddWithValue("@p4", txtDigerGiderler.Text);
            komut.Parameters.AddWithValue("@p5", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi.");
            this.giderlerTableAdapter.Fill(this.sanatGalerisiDataSet7.Giderler);

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, elektrik, su, dogalgaz, digerGiderler;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            digerGiderler = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            txtID.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtDigerGiderler.Text = digerGiderler;
        }
    }
}
