using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerSampleLab1.Cashier.Model
{
    class CashierInventoryModel : ICashierInventoryModel
    {
        private TestEntities db;

        public CashierInventoryModel()
        {

        }

        public CashierInventoryModel(int ID, string NAME, float PRICE, int QTY) {
            this.ID = ID;
            this.NAME = NAME;
            this.PRICE = PRICE;
            this.QTY = QTY;
        }

        public int ID
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string NAME
        {
            get
            {
                return NAME;
            }

            set
            {
                NAME = value;
            }
        }

        public float PRICE
        {
            get
            {
                return PRICE;
            }

            set
            {
                PRICE = value;
            }
        }

        public int QTY
        {
            get
            {
                return QTY;
            }

            set
            {
                QTY = value;
            }
        }


        public List<Items> getAllItems()
        {
            db = new TestEntities();
            return db.Items.ToList();
        }

        public List<Items> getSearchItems(string keyword)
        {
            db = new TestEntities();
            return db.Items.Where(s => s.NAME.ToLower().Contains(keyword.ToLower())).ToList();
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

      
    }
}
