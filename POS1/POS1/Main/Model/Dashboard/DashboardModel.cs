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
        public double dateOfTransaction { get; set; }
        public double subtotalAmount { get; set; }
        public double taxAmount { get; set; }
        public double totalPriceAmount { get; set; }
        public double totalDiscountAmount { get; set; }
        public double moneyPaid { get; set; }

        //SALES ITEM
        public int itemID { get; set; }
        public int totalQuantity { get; set; }
        public string productName { get; set; }
        public double totalPrice { get; set; }

        public List<string> getAllYear()
        {
            List<string> years = new List<string>();
            using (var db = new TestEntities())
            {
                var query = db.Sales.Select(y => y.dateOfTransaction).ToList();

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

        public List<string> getAllMonths()
        {
            List<string> months = new List<string>();
            using (var db = new TestEntities())
            {
                var query = db.Sales.Select(y => y.dateOfTransaction).ToList();

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

        public List<double> getMonthlySales(string year)
        {
            string[] months = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
         
            string monthDayStartPattern = "{0}01";
            string monthDayEndPattern = "{0}31";
            double dateStart = 0;
            double dateEnd = 0;

            List<double> monthlySales = new List<double>();
            using (var db = new TestEntities())
            {
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
            }

            return monthlySales;
        }

        public List<double> getWeeklySales(string month, string year)
        {

            List<double> weeklySales = new List<double>();
            if (month == "")
            {
                return weeklySales;
            }
            using (var db = new TestEntities())
            {
                for (int i = 1; i <= 4; i++)
                {
                    double totalSales = 0;
                    var startDay = int.Parse(DateUtils.FirstDateOfWeek(int.Parse(year), int.Parse(month), i));
                    var endDay = startDay + 6;

                    var query = db.Sales.Where(y => y.dateOfTransaction >= startDay && y.dateOfTransaction <= endDay)
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
                var res = db.Sales.Where(y => y.dateOfTransaction >= startYear && y.dateOfTransaction <= endYear)
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
                    double total = 0;
                    int totalQty = 0;
                    var s = 0;
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
                list = list.OrderByDescending(q => q.totalQuantity).ToList();
                return list;
            }
        }

    }

}
