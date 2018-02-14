using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Cashier.Model
{
    interface ICashierInventoryModel
    {
        int ID { get; set; }
        string NAME { get; set; }
        int QTY { get; set; }
        float PRICE { get; set; }

        bool substractItemQty(int id , int qty);
        List<Items> getAllItems();
        List<Items> getSearchItems(string keyword);
        bool addItemQty(int id, int qty);
    }
}
