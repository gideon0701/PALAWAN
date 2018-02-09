using ScannerSampleLab1.Cashier.Model;
using ScannerSampleLab1.Cashier.View;
using ScannerSampleLab1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerSampleLab1.Cashier.Presenter
{
    class CashierPresenter
    {
        private ICashierView view;
        private ICashierInventoryModel model;

        public CashierPresenter(ICashierView view) {
            model = new CashierInventoryModel();
            this.view = view;

        }

        public void getAllItems(string keyword) {

            if (keyword == null)
            {
                view.onGetAllItems(model.getAllItems());
            }
            else
            {
                view.onGetAllItems(model.getSearchItems(keyword));
            }
        }

        public void itemSelectedChanged(ListView list)
        {
            int count = 0;
            int max = 0;
            foreach (ListViewItem li in list.Items )
            {
                if (li.Selected)
                {
                    max = int.Parse(li.SubItems[3].Text);
                    count++;
                }
            }
            view.onSelectedIndexChanged(count, max);
        }

        public void addToCart(ListView itemList, int qty)
        {
            bool result = false;
           
            float price = 0;
            int item_id = int.Parse(itemList.SelectedItems[0].SubItems[0].Text);

            if (model.substractItemQty(item_id, qty))
            {
                result = true;
                price = int.Parse(itemList.SelectedItems[0].SubItems[2].Text);
                itemList.SelectedItems[0].SubItems[3].Text = qty.ToString();
            }

            view.onItemAddToCart(result, itemList.SelectedItems[0]);
        }

        public void clearCart(ListView cartList) {
            bool result = true;
            foreach (ListViewItem li in cartList.Items)
            {
                if (!model.addItemQty(int.Parse(li.SubItems[0].Text), int.Parse(li.SubItems[3].Text)))
                {
                    result = false;
                }
            }

            view.onClearCart(result);
        }

    }

}
