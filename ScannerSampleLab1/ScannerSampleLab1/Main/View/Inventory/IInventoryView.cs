using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerSampleLab1.Main.View.Inventory
{
    interface IInventoryView
    {
        DataGridView inventoryDataGrid { get; set; }

    }
}
