using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerSampleLab1.Cashier.View
{
    interface ICashierView
    {
        ListView inventoryListView { get; set; }
        ListView myCartListView { get; set; }
        string itemSearch { get; set; }
        float buyTotal { get; set; }

        void onSelectedIndexChanged(int numOfSelected, int qty);
        
    }
}
