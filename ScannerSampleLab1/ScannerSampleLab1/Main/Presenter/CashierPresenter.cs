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

        public void getAllItems() {
            
            view.onGetAllItems(model.getAllItems());
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

        public void addToCart(ListView list, int qty)
        {
            bool result = false;
            float price = 0;
            int item_id = int.Parse(list.SelectedItems[0].SubItems[0].Text);
            if (model.addToCart(item_id, qty))
            {
                result = true;
                price = int.Parse(list.SelectedItems[0].SubItems[2].Text);
                list.SelectedItems[0].SubItems[2].Text = NumberUtils.computePrice(price, qty).ToString();
                list.SelectedItems[0].SubItems[3].Text = qty.ToString();
            }

            view.onItemAddToCart(result, list.SelectedItems[0]);
        }

    }

}
