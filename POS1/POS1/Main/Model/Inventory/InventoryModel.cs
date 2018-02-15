using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Main.Model.Inventory
{
    class InventoryModel
    {
        private TestEntities db;

        public int ID { get; set; }
        public string NAME { get; set; }
        public double? PRICE { get; set; }
        public int? QTY { get; set; }

        public InventoryModel()
        {

        }

        public List<InventoryModel> getAllInventory()
        {
            db = new TestEntities();
            return db.Items.Select(s => new InventoryModel()
            {
                ID = s.ID,
                NAME = s.NAME,
<<<<<<< HEAD
                PRICE =  s.PRICE,
                QTY =  s.QTY
=======
                PRICE = s.PRICE,
                QTY = s.QTY
>>>>>>> gideon
            }).ToList();
        }

        public List<InventoryModel> searchInventory(string keyword)
        {
            db = new TestEntities();
            return db.Items.Where(s => s.NAME.ToLower().Contains(keyword.ToLower()))
                .Select(s => new InventoryModel()
                {
                    ID = s.ID,
                    NAME = s.NAME,
                    PRICE = s.PRICE,
<<<<<<< HEAD
                    QTY =s.QTY
=======
                    QTY = s.QTY
>>>>>>> gideon
                }).ToList();
        }

        public void doAdd(Items item)
        {
            db = new TestEntities();
            db.Items.Add(item);
            db.SaveChanges();
        }

        public void doEdit(Items item)
        {

            db = new TestEntities();
            var model = db.Items.Find(item.ID);
            db.Entry(model).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void deleteItem(InventoryModel item)
        {
            db = new TestEntities();
            Items i = new Items()
            {
                ID = item.ID,
            };
            db.Items.Attach(i);
            db.Items.Remove(i);
            db.SaveChanges();
        }

    }
}