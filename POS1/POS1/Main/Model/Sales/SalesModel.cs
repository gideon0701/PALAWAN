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
        //Tuple<string,int,decimal>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="salesId"></param>
        /// <returns></returns>
        public List<string> getAllItems(int salesId)
        {
            using (var db = new TestEntities())
            {

                //var list = db.SalesItem
                //    .AsNoTracking()
                //    .Where(s => s.SalesId == salesId)
                //    .Select(i => new { i.Items.NAME, i.quantitySold, i.pricePerUnit })
                //    .AsEnumerable()
                //    .Select(i => new Tuple<string,int,decimal>(i.NAME, i.quantitySold, i.pricePerUnit))
                //    .ToList();

                var list = db.SalesItem
                   .AsNoTracking()
                   .Where(s => s.SalesId == salesId)
                   .Select(i => i.Items.NAME)
                   .ToList();

                return list;
            }     
        }
    }
}
