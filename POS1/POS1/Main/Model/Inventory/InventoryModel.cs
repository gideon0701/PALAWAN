using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Main.Model.Inventory
{
    class InventoryModel
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? WHOLESALEPRICE { get; set; }
        public int? QTY { get; set; }

        public List<InventoryModel> getAllInventory()
        {
            using (var db = new TestEntities())
            {
                return db.Items
                    .AsNoTracking()
                    .Select(s => new InventoryModel()
                    {
                        ID = s.ID,
                        NAME = s.NAME,
                        PRICE = s.PRICE,
                        QTY = s.QTY,
                        WHOLESALEPRICE = s.WHOLESALEPRICE
                    }).ToList();
            }
               
        }

        public List<InventoryModel> searchInventory(string keyword)
        {
            using (var db = new TestEntities())
            {
                return db.Items
                    .AsNoTracking()
                    .Where(s => s.NAME.ToLower().Contains(keyword.ToLower()))
                    .Select(s => new InventoryModel()
                    {
                        ID = s.ID,
                        NAME = s.NAME,
                        PRICE = s.PRICE,
                        QTY = s.QTY,
                        WHOLESALEPRICE = s.WHOLESALEPRICE
                    }).ToList();
            }
        }

        public void doAdd(Items item)
        {
            using (var db = new TestEntities())
            {
                db.Items.Add(item);
                db.SaveChanges();
            }
            
        }

        public void doEdit(Items item)
        {
            using (var db = new TestEntities())
            {
                var model = db.Items.Find(item.ID);
                db.Entry(model).CurrentValues.SetValues(item);
                db.SaveChanges();
            }
           
        }

        public void deleteItem(InventoryModel item)
        {
            using (var db = new TestEntities())
            {
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
}