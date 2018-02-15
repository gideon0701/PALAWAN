using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1.Cashier.View
{
    interface ICashierView
    {
        DataGridView cashierItems { get; set; }
        DataGridView cashierCart { get; set; }
        string cashierItemSearch { get; set; }
        string cashierTotalPrice { get; set; }
        string cashierSubtotalPrice { get; set; }
        string cashierVatPrice { get; set; }

        void onSelectedIndexChanged(int numOfSelected, int qty);
        
    }
}
