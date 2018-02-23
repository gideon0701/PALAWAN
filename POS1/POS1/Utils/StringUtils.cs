using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Utils
{
    class StringUtils
    {

        public static string doubleToCurrency(double money)
        {
            return money.ToString("#,##0.00");
        }

        public static double currencyTodouble(string currency)
        {
            return double.Parse(currency, NumberStyles.Currency);
        }

    }
}