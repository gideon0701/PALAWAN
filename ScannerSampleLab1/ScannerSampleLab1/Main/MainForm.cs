using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScannerSampleLab1.Cashier.View;
using ScannerSampleLab1.Cashier.Presenter;
using ScannerSampleLab1.Utils;
using MetroFramework.Controls;

namespace ScannerSampleLab1.Cashier
{
    public partial class MainForm : MetroForm, ICashierView
    {
        CashierPresenter cashierPresenter;

        public ListView inventoryListView
        {
            get
            {
               return itemListView;
            }

            set
            {
                itemListView = (MetroListView) value;
            }
        }

        public ListView myCartListView
        {
            get
            {
                return cartListView;
            }

            set
            {
                cartListView = (MetroListView) value;
            }
        }

        public string itemSearch
        {
            get
            {
                return textbox_item_search.Text.Length > 0 ? textbox_item_search.Text : null;
            }

            set
            {
                textbox_item_search.Text = value;
            }
        }

        public float buyTotal
        {
            get
            {
                return float.Parse(textboxt_total.Text);
            }

            set
            {
                textboxt_total.Text = value.ToString();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            cashierPresenter = new CashierPresenter(this);
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            cashierPresenter.getAllItems();
        }

        private void itemListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = itemListView.Columns[e.ColumnIndex].Width;
        }

        private void itemListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            cashierPresenter.itemSelectedChanged();
        }

        private void button_addCart_Click(object sender, EventArgs e)
        {
            cashierPresenter.addToCart(decimal.ToInt32(input_qty.Value));
            panel_add.Visible = false;
        }

        private void btn_cart_clear_Click(object sender, EventArgs e)
        {
            if (cartListView.Items.Count != 0)
            {
                cashierPresenter.clearCart();
                cashierPresenter.getAllItems();
            }
        }

        private void btn_item_search_Click(object sender, EventArgs e)
        {
            cashierPresenter.getAllItems();
        }

        private void textbox_item_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_item_search.PerformClick();
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

    }
}

