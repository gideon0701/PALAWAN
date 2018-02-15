using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Cashier.Model
{
    class CashierInventoryModel 
    {
        private TestEntities db;

        public int ID { get; set; }
        public string NAME { get; set; }
        public double? PRICE { get; set; }
        public int? QTY { get; set; }

        public CashierInventoryModel()
        {

        }

        public List<CashierInventoryModel> getAllItems()
        {
            db = new TestEntities();
            return db.Items.Select(s => new CashierInventoryModel()
            {
                ID = s.ID,
                NAME = s.NAME,
                PRICE = s.PRICE,
                QTY = s.QTY
            }).ToList();
        }

        public List<CashierInventoryModel> getSearchItems(string keyword)
        {
            db = new TestEntities();
            return db.Items.Where(s => s.NAME.ToLower().Contains(keyword.ToLower()))
                .Select(s => new CashierInventoryModel()
                {
                    ID = s.ID,
                    NAME = s.NAME,
                    PRICE = s.PRICE,
                    QTY = s.QTY
                }).ToList();
        }

        public bool substractItemQty(int id, int qty)
        {
            db = new TestEntities();
            var item = db.Items.Find(id);

            if (item != null)
            {
                item.QTY = item.QTY - qty;
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool addItemQty(int id, int qty)
        {
            db = new TestEntities();
            var item = db.Items.Find(id);
            if (item != null)
            {
                item.QTY = item.QTY + qty;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public void addSales(Sales sales)
        {
            db = new TestEntities();
            db.Sales.Add(sales);
            db.SaveChanges();
        }


    }
}
