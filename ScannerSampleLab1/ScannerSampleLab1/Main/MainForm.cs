using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScannerSampleLab1.Cashier.View;
using ScannerSampleLab1.Cashier.Presenter;
using ScannerSampleLab1.Utils;

namespace ScannerSampleLab1.Cashier
{
    public partial class MainForm : MetroForm, ICashierView
    {
        string mKeyword = null;
        CashierPresenter cashierPresenter;
        public MainForm()
        {
            InitializeComponent();
            cashierPresenter = new CashierPresenter(this);
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            cashierPresenter.getAllItems(mKeyword);
        }

        private void itemListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = itemListView.Columns[e.ColumnIndex].Width;
        }

        private void itemListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            cashierPresenter.itemSelectedChanged(itemListView);
        }

        private void button_addCart_Click(object sender, EventArgs e)
        {
            cashierPresenter.addToCart(itemListView, decimal.ToInt32(input_qty.Value));
            panel_add.Visible = false;
        }

        private void btn_cart_clear_Click(object sender, EventArgs e)
        {
            if (cartListView.Items.Count != 0)
            {
                cashierPresenter.clearCart(cartListView);
                cashierPresenter.getAllItems(mKeyword);
            }
        }

        private void btn_item_search_Click(object sender, EventArgs e)
        {
            mKeyword = textbox_item_search.Text.Length > 0 ? textbox_item_search.Text : null;
            cashierPresenter.getAllItems(mKeyword);
        }

        private void textbox_item_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_item_search.PerformClick();
            }
        }

        /// <summary>
        /// CALLBACK WHEN ALL ITEMS IN THE INVENTORY WERE GET
        /// </summary>
        /// <param name="items"></param>
        public void onGetAllItems(List<Items> items)
        {
            itemListView.Items.Clear();
            foreach (Items item in items) {
               var i = new ListViewItem(new[] {
                   item.ID.ToString(),
                   item.NAME,
                   item.PRICE.ToString(),
                   item.QTY.ToString()
               });
                itemListView.Items.Add(i);
                
            }
        }

        /// <summary>
        /// CALLBACK WHEN THE SELECTED ITEM IN THE ITEM LIST WAS CHANGED
        /// </summary>
        /// <param name="numOfSelected"></param>
        /// <param name="qty"></param>
        public void onSelectedIndexChanged(int numOfSelected, int qty)
        {
            if (numOfSelected > 0)
            {
                panel_add.Visible = true;
                input_qty.Maximum = qty;
            }
            else
            {
                panel_add.Visible = false;
            }
           
        }

        /// <summary>
        /// ON ITEM ADDING TO CART
        /// </summary>
        /// <param name="result"></param>
        /// <param name="list"></param>
        public void onItemAddToCart(bool result, ListViewItem list)
        {
            bool isThereItemAlready = false;

            foreach (ListViewItem li in cartListView.Items) //To check if the item adding to cart is in there already
            {
                if (list.SubItems[0].Text == li.SubItems[0].Text)
                {
                    int newQty = int.Parse(li.SubItems[3].Text) + int.Parse(list.SubItems[3].Text);
                    li.SubItems[2].Text = NumberUtils.computePrice(float.Parse(list.SubItems[2].Text), newQty).ToString();
                    li.SubItems[3].Text = newQty.ToString();
                    isThereItemAlready = true;

                }
            }
            if (result && !isThereItemAlready)
            {
                float newPrice = NumberUtils.computePrice(float.Parse(list.SubItems[2].Text), int.Parse(list.SubItems[3].Text));
                var i = new ListViewItem(new[] {
                   list.SubItems[0].Text,
                   list.SubItems[1].Text,
                   newPrice.ToString(),
                list.SubItems[3].Text
               });
                cartListView.Items.Add(i);
            }
            cashierPresenter.showTotal(cartListView);
            cashierPresenter.getAllItems(mKeyword);
        }

        /// <summary>
        /// CALLBACK WHEN CLEARING THE CART
        /// </summary>
        /// <param name="result"></param>
        public void onClearCart(bool result)
        {
            cartListView.Items.Clear();

        }

        /// <summary>
        /// Callback for show total function 
        /// </summary>
        /// <param name="total"></param>
        public void onShowTotal(int total)
        {
            textboxt_total.Text = total.ToString();
        }
    }
}

