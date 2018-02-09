using ScannerSampleLab1.Cashier.Model;
using ScannerSampleLab1.Cashier.View;
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
        public void getAllItems(string keyword) {

            if (keyword == null)
            {
                mVIew.onGetAllItems(mMOdel.getAllItems());
            }
            else
            {
                mVIew.onGetAllItems(mMOdel.getSearchItems(keyword));
            }
        }

        /// <summary>
        /// For the change of the selected item of the itemlistview
        /// </summary>
        /// <param name="list"></param>
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
            mVIew.onSelectedIndexChanged(count, max);
        }

        /// <summary>
        /// For the adding of the item in the cart
        /// </summary>
        /// <param name="itemList"></param>
        /// <param name="qty"></param>
        public void addToCart(ListView itemList, int qty)
        {
            bool result = false;
           
            float price = 0;
            int item_id = int.Parse(itemList.SelectedItems[0].SubItems[0].Text);

            if (mMOdel.substractItemQty(item_id, qty))
            {
                result = true;
                price = int.Parse(itemList.SelectedItems[0].SubItems[2].Text);
                itemList.SelectedItems[0].SubItems[3].Text = qty.ToString();
            }

            mVIew.onItemAddToCart(result, itemList.SelectedItems[0]);
        }

        /// <summary>
        /// To clear the cart and updating the item database for the qty
        /// </summary>
        /// <param name="cartList"></param>
        public void clearCart(ListView cartList)
        {
            bool result = true;
            foreach (ListViewItem li in cartList.Items)
            {
                if (!mMOdel.addItemQty(int.Parse(li.SubItems[0].Text), int.Parse(li.SubItems[3].Text)))
                {
                    result = false;
                }
            }

            mVIew.onClearCart(result);
        }

        /// <summary>
        /// To show the total price of the transaction
        /// </summary>
        /// <param name="cartList"></param>
        public void showTotal(ListView cartList)
        {
            int total = 0;
            foreach (ListViewItem li in cartList.Items)
            {
                total += int.Parse(li.SubItems[2].Text);
            }

            mVIew.onShowTotal(total);
        }

    }

}
