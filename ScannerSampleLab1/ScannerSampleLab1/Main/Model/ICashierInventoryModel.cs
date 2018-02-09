using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerSampleLab1.Cashier.Model
{
    interface ICashierInventoryModel
    {
        int ID { get; set; }
        string NAME { get; set; }
        int QTY { get; set; }
        float PRICE { get; set; }

        bool addToCart(int id , int qty);
        List<Items> getAllItems();
    }
}
