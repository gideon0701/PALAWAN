using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1.Main.View.Inventory
{
    interface IInventoryView
    {
        DataGridView inventoryDataGrid { get; set; }
        string inventoryID { get; set; }
        string inventoryName { get; set; }
        string inventoryPrice { get; set; }

        string inventorySearch { get; set; }

        int inventoryQty { get; set; }

        void onDbActionResult(string action, bool isSuccess);

    }
}
