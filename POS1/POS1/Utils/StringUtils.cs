﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Utils
{
    class StringUtils
    {

        public static string decimalToCurrency(decimal money)
        {
            return money.ToString("#,##0.00");
        }

        public static decimal currencyToDecimal(string currency)
        {
            return decimal.Parse(currency, NumberStyles.Currency);
        }

        public static string shortGUID()
        {
            string guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray())
                .Substring(0, 22)
                .Replace("+", "-")
                .Replace("/","_");
            return guid;
        }

    }
}