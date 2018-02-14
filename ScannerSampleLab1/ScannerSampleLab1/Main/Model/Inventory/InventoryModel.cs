using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerSampleLab1.Main.Model.Inventory
{
    class InventoryModel
    {
        private TestEntities db;

        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int qty { get; set; }

        public InventoryModel()
        {
            db = new TestEntities();
        }

        public List<Items> getAllInventory()
        {
            return db.Items.ToList();
        }

        public void doAdd(Items item)
        {
           db.Items.Add(item);
           db.SaveChanges();
        }

        public void doEdit(Items item)
        {
            var model = db.Items.Find(item.ID);
            db.Entry(model).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void deleteItem(Items item)
        {
            
            db.Items.Remove(item);
            db.SaveChanges();
        }
        
    }
}
