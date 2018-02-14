using ScannerSampleLab1.Cashier.Model;
using ScannerSampleLab1.Cashier.View;
using ScannerSampleLab1.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScannerSampleLab1.Cashier.Presenter
{
    class CashierPresenter
    {
        private ICashierView mVIew;
        private ICashierInventoryModel mMOdel;

        public CashierPresenter(ICashierView view) {
            mMOdel = new CashierInventoryModel();
            this.mVIew = view;

        }

        /// <summary>
        ///To get all items in the search depends on the keyword 
        /// </summary>
        /// <param name="keyword"></param>
        public void getAllItems() {
            ListView itemList = mVIew.cashierInventoryListView;
            List<Items> items;
            string keyword = mVIew.cashierItemSearch;
            if (keyword == null)
            {
                items =mMOdel.getAllItems();
            }
            else
            {
               items = mMOdel.getSearchItems(keyword);
            }

            itemList.Items.Clear();
            foreach (Items item in items)
            {
                var i = new ListViewItem(new[] {
                   item.ID.ToString(),
                   item.NAME,
                   item.PRICE.ToString(),
                   item.QTY.ToString()
               });
                itemList.Items.Add(i);
            }

            mVIew.cashierInventoryListView = itemList;
        }

        /// <summary>
        /// For the change of the selected item of the itemlistview
        /// </summary>
        /// <param name="list"></param>
        public void itemSelectedChanged()
        {
            int count = 0;
            int max = 0;
            ListView list = mVIew.cashierInventoryListView;
            foreach (ListViewItem li in list.Items )
            {
                if (li.Selected)
                {
                    max = int.Parse(li.SubItems[3].Text);
                    count++;
                }
            }
            mVIew.onSelectedIndexChanged(count, max);
        }

        /// <summary>
        /// For the adding of the item in the cart
        /// </summary>
        /// <param name="itemList"></param>
        /// <param name="qty"></param>
        public void addToCart(int qty)
        {
            bool result = false;
            ListView itemList = mVIew.cashierInventoryListView;
            float price = 0;
            int item_id = int.Parse(itemList.SelectedItems[0].SubItems[0].Text);

            if (mMOdel.substractItemQty(item_id, qty))
            {
                result = true;
                price = int.Parse(itemList.SelectedItems[0].SubItems[2].Text);
                itemList.SelectedItems[0].SubItems[3].Text = qty.ToString();
            }

            ListViewItem list = itemList.SelectedItems[0];
            bool isThereItemAlready = false;

            foreach (ListViewItem li in mVIew.cashierCartListView.Items) //To check if the item adding to cart is in there already
            {
                if (list.SubItems[0].Text == li.SubItems[0].Text)
                {
                    int newQty = int.Parse(li.SubItems[3].Text) + int.Parse(list.SubItems[3].Text);
                    li.SubItems[2].Text = NumberUtils.computePrice(float.Parse(list.SubItems[2].Text), newQty).ToString();
                    li.SubItems[3].Text = newQty.ToString();
                    isThereItemAlready = true;

                }
            }

            if (result && !isThereItemAlready) //Add item to the cart
            {
                float newPrice = NumberUtils.computePrice(float.Parse(list.SubItems[2].Text), int.Parse(list.SubItems[3].Text));
                var i = new ListViewItem(new[] {
                   list.SubItems[0].Text,
                   list.SubItems[1].Text,
                   newPrice.ToString(),
                list.SubItems[3].Text
               });
                mVIew.cashierCartListView.Items.Add(i);
            }
            showTotal();
            getAllItems();
        }

        /// <summary>
        /// To clear the cart and updating the item database for the qty
        /// </summary>
        /// <param name="cartList"></param>
        public void clearCart()
        {
            ListView cartList = mVIew.cashierCartListView;
            bool result = true;
            foreach (ListViewItem li in cartList.Items)
            {
                if (!mMOdel.addItemQty(int.Parse(li.SubItems[0].Text), int.Parse(li.SubItems[3].Text)))
                {
                    result = false;
                }
            }

            if (result) {
                mVIew.cashierTotalPrice = "0";
                mVIew.cashierCartListView.Items.Clear();
            }
           
        }

        /// <summary>
        /// To show the total price of the transaction
        /// </summary>
        /// <param name="cartList"></param>
        public void showTotal()
        {
            ListView cartList = mVIew.cashierCartListView;
            double total = 0;
            double vat = 0;
            double subtotal = 0;
            foreach (ListViewItem li in cartList.Items)
            {
                total += double.Parse(li.SubItems[2].Text);
            }
            vat = (total * 0.12);
            subtotal = total - vat;

            mVIew.cashierTotalPrice = total.ToString();
            mVIew.cashierSubtotalPrice = subtotal.ToString();
            mVIew.cashierVatPrice = vat.ToString();
        }

    }

}
