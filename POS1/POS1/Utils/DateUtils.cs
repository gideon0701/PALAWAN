using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Utils
{
    class DateUtils
    {
        public static string getStringDateNow(string pattern)
        {
            var now = DateTime.Today;
            return now.ToString(pattern);
        }

        public static string changeDateStringFormat(string date, string oldPattern,string newPattern)
        {
            return DateTime.ParseExact(date, oldPattern, CultureInfo.InvariantCulture).ToString(newPattern);
        }

        public static string getMonthName(string month)
        {

            DateTime date = new DateTime(2010, int.Parse(month), 1);
            return date.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
        }

        public static string getMonthNumber(string month)
        {
            if (month != "")
            {
                return DateTime.ParseExact(month, "MMMM", CultureInfo.InvariantCulture).ToString("MM");
            }
            else
            {
                return "";
            }
           
        }

        public static int getWeeksInMonth(int year,int month)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);

            DateTime firstOfMonth = new DateTime(year, month, 1);
            int firstDayOfMonth = (int)firstOfMonth.DayOfWeek;
            int weeksInMonth = (int)Math.Ceiling((firstDayOfMonth + daysInMonth) / 7.0);

            return weeksInMonth;
        }

        public static string FirstDateOfWeek(int year,int month, int weekOfYear)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            DateTime month1 = new DateTime(year, month, 1);
            int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)month1.DayOfWeek;
            DateTime firstWeekDay = month1.AddDays(daysOffset);
            int firstWeek = ci.Calendar.GetWeekOfYear(month1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
            {
                weekOfYear -= 1;
            }
            return firstWeekDay.AddDays(weekOfYear * 7).ToString("yyyyMMdd");
        }
    }
}
