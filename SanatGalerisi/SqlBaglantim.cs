using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SanatGalerisi
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-3L67VG5;Initial Catalog=SanatGalerisi;Integrated Security=True");
            baglan.Open();
           

            return baglan;

        }
    }
}
