﻿using POS1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POS1.Main.Model.Dashboard
{
    class DashboardModel
    {
        private TestEntities db;

        public int Id { get; set; }
        public double dateOfTransaction { get; set; }
        public double subtotalAmount { get; set; }
        public double taxAmount { get; set; }
        public double totalPriceAmount { get; set; }
        public double totalDiscountAmount { get; set; }
        public double moneyPaid { get; set; }

        public List<string> getAllYear()
        {
            db = new TestEntities();
            List<string> years = new List<string>();
            var query = db.Sales.Select(y => y.dateOfTransaction).ToList();

            foreach (var year in query)
            {
                if (!years.Contains(year.ToString().Substring(0, 4)))
                {
                    years.Add(year.ToString().Substring(0, 4));
                }
              
            }
            return years;
        }

        public List<string> getAllMonths()
        {
            db = new TestEntities();
            List<string> months = new List<string>();
            var query = db.Sales.Select(y => y.dateOfTransaction).ToList();

            foreach (var month in query)
            {
                if (!months.Contains(month.ToString().Substring(4, 2)))
                {
                    months.Add(month.ToString().Substring(4, 2));
                }

            }
            return months;
        }

        public List<double> getMonthlySales(string year)
        {
            string[] months = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
         
            string monthDayStartPattern = "{0}01";
            string monthDayEndPattern = "{0}31";
            double dateStart = 0;
            double dateEnd = 0;

            List<double> monthlySales = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                double totalSales = 0;
                string monthDayStart = string.Format(monthDayStartPattern, months[i]);
                string monthDayEnd = string.Format(monthDayEndPattern, months[i]);
                dateStart = double.Parse(year + monthDayStart);
                dateEnd = double.Parse(year + monthDayEnd);

                var query = db.Sales.Where(y => y.dateOfTransaction >= dateStart && y.dateOfTransaction <= dateEnd)
                .Select(s => s.subtotalAmount).ToList();
                foreach (var q in query)
                {
                    totalSales += q;
                }

                monthlySales.Add(totalSales);
            }

            return monthlySales;
        }

        public List<double> getWeeklySales(string month)
        {

            List<double> weeklySales = new List<double>();
            if (month == "")
            {
                return weeklySales;
            }
            for (int i = 1; i <= 4; i++)
            {
                double totalSales = 0;
                var startDay = int.Parse(DateUtils.FirstDateOfWeek(2018, int.Parse(month), i));
                var endDay = startDay + 6;

                var query = db.Sales.Where(y => y.dateOfTransaction >= startDay && y.dateOfTransaction <= endDay)
                .Select(s => s.subtotalAmount).ToList();
                foreach (var q in query)
                {
                    totalSales += q;
                }

                weeklySales.Add(totalSales);

            }
            return weeklySales;
        }

    }
}
