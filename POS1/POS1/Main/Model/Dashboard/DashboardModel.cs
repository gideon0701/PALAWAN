using POS1.Main.Presenter.Dashboard;
using POS1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POS1.Main.Model.Dashboard
{
    class DashboardModel
    {
        //SALES
        public int Id { get; set; }
        public decimal dateOfTransaction { get; set; }
        public decimal subtotalAmount { get; set; }
        public decimal taxAmount { get; set; }
        public decimal totalPriceAmount { get; set; }
        public decimal totalDiscountAmount { get; set; }
        public decimal moneyPaid { get; set; }

        //SALES ITEM
        public string itemID { get; set; }
        public int totalQuantity { get; set; }
        public string productName { get; set; }
        public decimal totalPrice { get; set; }

        public List<string> getAllYear()
        {
            List<string> years = new List<string>();
            using (var db = new TestEntities())
            {
                var query = db.Sales
                    .AsNoTracking()
                    .Select(y => y.dateOfTransaction).ToList();

                foreach (var year in query)
                {
                    if (!years.Contains(year.ToString().Substring(0, 4)))
                    {
                        years.Add(year.ToString().Substring(0, 4));
                    }

                }
            }

            return years;
        }

        public List<string> getAllMonths(string year)
        {
            double startYear = double.Parse(year + "0101");
            double endYear = double.Parse(year + "1231");
            List<string> months = new List<string>();
            using (var db = new TestEntities())
            {
                var query = db.Sales
                    .AsNoTracking()
                    .Where(y => y.dateOfTransaction >= startYear && y.dateOfTransaction <= endYear)
                    .Select(s => s.dateOfTransaction).ToList();

                foreach (var month in query)
                {
                    if (!months.Contains(month.ToString().Substring(4, 2)))
                    {
                        months.Add(month.ToString().Substring(4, 2));
                    }

                }
            }
            return months;
        }

        public decimal getSalesNow()
        {
            using (var db = new TestEntities())
            {
                double dateNow = double.Parse(DateUtils.getStringDateNow("yyyyMMdd"));
                var totalSales = db.Sales
                    .AsNoTracking()
                    .Where(d => d.dateOfTransaction == dateNow)
                    .Sum(s => (decimal?)s.subtotalAmount) ?? 0;

                return totalSales;
            }
        }

        public List<decimal> getMonthlySales(string year)
        {
            string[] months = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
         
            string monthDayStartPattern = "{0}01";
            string monthDayEndPattern = "{0}31";
            double dateStart = 0;
            double dateEnd = 0;

            List<decimal> monthlySales = new List<decimal>();
            using (var db = new TestEntities())
            {
                for (int i = 0; i < 12; i++)
                {
                    decimal totalSales = 0;
                    string monthDayStart = string.Format(monthDayStartPattern, months[i]);
                    string monthDayEnd = string.Format(monthDayEndPattern, months[i]);
                    dateStart = double.Parse(year + monthDayStart);
                    dateEnd = double.Parse(year + monthDayEnd);

                    var query = db.Sales
                        .AsNoTracking()
                        .Where(y => y.dateOfTransaction >= dateStart && y.dateOfTransaction <= dateEnd)
                    .Select(s => s.subtotalAmount).ToList();
                    foreach (var q in query)
                    {
                        totalSales += q;
                    }

                    monthlySales.Add(totalSales);
                }
            }

            return monthlySales;
        }

        public List<decimal> getWeeklySales(string month, string year)
        {

            List<decimal> weeklySales = new List<decimal>();
            if (month == "")
            {
                return weeklySales;
            }
            using (var db = new TestEntities())
            {
                int maxWeek = DateUtils.getWeeksInMonth(int.Parse(year),int.Parse(month));
                int chooseDate = int.Parse(year + month + "01");
                for (int i = 0; i < maxWeek; i++)
                {
                    decimal totalSales = 0;
                    var startDay = 0;
                    var endDay = 0;
                    startDay = int.Parse(DateUtils.FirstDateOfWeek(int.Parse(year), int.Parse(month), i));

                    endDay = startDay + 6;
                    if (startDay < chooseDate) {
                        var nextStartDay = int.Parse(DateUtils.FirstDateOfWeek(int.Parse(year), int.Parse(month), i + 1));
                        endDay = nextStartDay - 1;
                        startDay = chooseDate;
                    }

                    var query = db.Sales
                        .AsNoTracking()
                        .Where(y => y.dateOfTransaction >= startDay && y.dateOfTransaction <= endDay)
                        .Select(s => s.subtotalAmount).ToList();
                        foreach (var q in query)
                        {
                            totalSales += q;
                        }

                        weeklySales.Add(totalSales);
                }
            }
              
            return weeklySales;
        }

        public List<DashboardModel> getAllSalesItemYearly(string year)
        {
            
            double startYear =double.Parse(year + "0101");
            double endYear = double.Parse(year + "1231");
            List<SalesItem> salesItems = new List<SalesItem>();
            List<DashboardModel> list = new List<DashboardModel>();
            using (var db = new TestEntities())
            {
                var res = db.Sales
                    .AsNoTracking()
                    .Where(y => y.dateOfTransaction >= startYear && y.dateOfTransaction <= endYear)
                    .Select(s => s.SalesItem).ToList();
                foreach (var sales in res)
                {
                    foreach (var items in sales)
                    {
                        salesItems.Add(items);
                    }
                }

                var groups =  salesItems.GroupBy(s => s.itemsID).ToList();

                foreach (var group in groups)
                {
                    decimal total = 0;
                    int totalQty = 0;
                    var s = "";
                    string name = "";
                    foreach (var item in group)
                    {
                        s = item.itemsID;
                        total += item.pricePerUnit * item.quantitySold;
                        totalQty += item.quantitySold;
                        name = item.Items.NAME;
                    }
                    list.Add(new DashboardModel
                    {
                        itemID = s,
                        totalQuantity = totalQty,
                        totalPrice = total,
                        productName = name

                    });
                }
                list = list.OrderByDescending(q => q.totalQuantity).Take(3).ToList();
                return list;
            }
        }

    }

}
