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
        public string price { get; set; }
        public int qty { get; set; }

        public InventoryModel()
        {
            db = new TestEntities();
        }

        public List<Items> getAllInventory()
        {
            return db.Items.ToList();
        }
        
    }
}
