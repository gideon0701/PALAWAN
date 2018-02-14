using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Utils
{
    class NumberUtils
    {
        public static float computePrice(float price, int qty)
        {
            return price * qty;
        }
    }
}
