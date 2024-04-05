using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatGalerisi
{
    class RandomKod

    {
        public string kod()
        {
            Random random_kod = new Random();
            string kod = "";

            for(int i = 0; i < 6; i++)
            {
                kod = kod + random_kod.Next(0, 10);
            }
            return kod;
        }
    }
}
