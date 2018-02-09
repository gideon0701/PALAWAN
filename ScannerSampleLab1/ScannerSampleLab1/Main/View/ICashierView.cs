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
        void onGetAllItems(List<Items> items);
        void onSelectedIndexChanged(int numOfSelected, int qty);
        void onItemAddToCart(bool result, ListViewItem list);
        void onClearCart(bool result);
    }
}
