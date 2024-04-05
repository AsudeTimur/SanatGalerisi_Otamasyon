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
    public partial class frmGelirler : Form
    {
        public frmGelirler()
        {
            InitializeComponent();
        }

        private void frmGelirler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanatGalerisiDataSet10.GorevliMusteri' table. You can move, or remove it, as needed.
            this.gorevliMusteriTableAdapter2.Fill(this.sanatGalerisiDataSet10.GorevliMusteri);
        }
        BaglantiSinif bgl = new BaglantiSinif();
        //SqlBaglantim bgl = new SqlBaglantim();

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from gorevliMusteri where mstrID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kazançlar Silindi.");
            this.gorevliMusteriTableAdapter2.Fill(this.sanatGalerisiDataSet10.GorevliMusteri);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, kazanc;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kazanc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtID.Text = id;
            txtKazanc.Text = kazanc;
        }

    }
}
