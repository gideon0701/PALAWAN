using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScannerSampleLab1.Cashier.View;
using ScannerSampleLab1.Cashier.Presenter;

namespace ScannerSampleLab1.Cashier
{
    public partial class MainForm : MetroForm, ICashierView
    {
        CashierPresenter cashierPresenter;
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
            cashierPresenter.itemSelectedChanged(itemListView);
        }

        private void button_addCart_Click(object sender, EventArgs e)
        {
            cashierPresenter.addToCart(itemListView, decimal.ToInt32(input_qty.Value));
            panel_add.Visible = false;
        }

        //CALLBACK WHEN ALL ITEMS IN THE INVENTORY WERE GET
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

        //CALLBACK WHEN THE SELECTED ITEM IN THE ITEM LIST WAS CHANGED
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

        //ON ITEM ADDING TO CART
        public void onItemAddToCart(bool result, ListViewItem list)
        {
            if (result) {
                cashierPresenter.getAllItems();
                var i = new ListViewItem(new[] {
                   list.SubItems[0].Text,
                   list.SubItems[1].Text,
                   list.SubItems[2].Text,
                   list.SubItems[3].Text
               });
                cartListView.Items.Add(i);
            }
        }

    }
}

