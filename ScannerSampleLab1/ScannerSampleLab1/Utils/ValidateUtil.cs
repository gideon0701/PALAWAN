using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerSampleLab1.Utils
{
    class ValidateUtil
    {
        public static bool isFloat(string s)
        {
            try
            {
                float.Parse(s);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool isStringEmpty(string s)
        {
            if (s == "" || s == null)
            {
                return true; 
            }

            return false;
        }
    }
}
