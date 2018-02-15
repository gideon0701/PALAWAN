using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Utils
{
    class DateUtils
    {
        public static string getStringDateNow()
        {
            var now = DateTime.Today;

            return now.ToString("yyyyMMdd");
        }
    }
}
