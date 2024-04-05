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
    public partial class frmGeriDonusler : Form
    {
        public frmGeriDonusler()
        {
            InitializeComponent();
        }

        private void frmGeriDonusler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanatGalerisiDataSet11.iletisim' table. You can move, or remove it, as needed.
            this.iletisimTableAdapter.Fill(this.sanatGalerisiDataSet11.iletisim);

        }
    }
}
