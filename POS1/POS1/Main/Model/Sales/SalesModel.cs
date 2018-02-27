using POS1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS1.Main.Model.Sales
{
    class SalesModel
    {
        public int Id { get; set; }
        public double dateOfTransaction { get; set; }
        public decimal subtotalAmount { get; set; }
        public decimal taxAmount { get; set; }
        public decimal totalPriceAmount { get; set; }
        public decimal totalDiscountAmount { get; set; }
        public decimal moneyPaid { get; set; }

        public List<SalesModel> getAllSales()
        {
            using (var db = new TestEntities())
            {
                var list = db.Sales
                    .AsNoTracking()
                    .Select(s => new SalesModel {
                        Id = s.Id,
                        dateOfTransaction = s.dateOfTransaction,
                        subtotalAmount = s.subtotalAmount,
                        taxAmount = s.taxAmount,
                        totalPriceAmount = s.totalPriceAmount,
                        totalDiscountAmount = s.totalDiscountAmount,
                        moneyPaid = s.moneyPaid
                    })
                    .ToList();

                return list;
            }
        }

        public string getAllItems(int salesId)
        {
            using (var db = new TestEntities())
            {
                StringBuilder sb = new StringBuilder();
                var list = db.SalesItem
                    .AsNoTracking()
                    .Where(s => s.SalesId == salesId)
                    .Select(i => new { i.Items.NAME, i.quantitySold, i.pricePerUnit })
                    .ToList();

                foreach (var i in list)
                {
                    sb.Append(i.NAME);
                    sb.Append("(");
                    sb.Append(StringUtils.decimalToCurrency(i.pricePerUnit));
                    sb.Append(")");
                    sb.Append("    ");
                    sb.Append(i.quantitySold);
                    sb.Append("x");
                    sb.AppendLine();
                }

                return sb.ToString();
            }     
        }
    }
}
