using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScannerSampleLab1.Cashier.View;
using ScannerSampleLab1.Cashier.Presenter;
using ScannerSampleLab1.Utils;
using MetroFramework.Controls;
using ScannerSampleLab1.Main.View.Inventory;
using ScannerSampleLab1.Main.Presenter.Inventory;

namespace ScannerSampleLab1.Cashier
{
    public partial class MainForm : MetroForm, ICashierView, IInventoryView
    {
        CashierPresenter cashierPresenter;
        InventoryPresenter inventoryPresenter;
        int errorCount = 0;
        
        public ListView cashierInventoryListView
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

        public ListView cashierCartListView
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

        public string cashierItemSearch
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

        public string cashierTotalPrice
        {
            get
            {
                return textboxt_total.Text;
            }

            set
            {
                textboxt_total.Text = value;
            }
        }

        public DataGridView inventoryDataGrid
        {
            get
            {
                return inventoryGrid;
            }

            set
            {
                inventoryGrid = (MetroGrid) value;
            }
        }

        public string inventoryID
        {
            get
            {
                return textbox_inventory_id.Text;
            }

            set
            {
                textbox_inventory_id.Text = value;
            }
        }

        public string inventoryName
        {
            get
            {
                return textbox_inventory_name.Text;
            }

            set
            {
                textbox_inventory_name.Text = value;
            }
        }

        public string inventoryPrice
        {
            get
            {
                return textbox_inventory_price.Text;
            }

            set
            {
                textbox_inventory_price.Text = value;
            }
        }

        public int inventoryQty
        {
            get
            {
                return (int) numeric_inventory_qty.Value;
            }

            set
            {
                numeric_inventory_qty.Value = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            cashierPresenter = new CashierPresenter(this);
            inventoryPresenter = new InventoryPresenter(this);
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            cashierPresenter.getAllItems();
            inventoryPresenter.getAllInventory();


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

        private void btn_inventory_addupdate_Click(object sender, EventArgs e)
        {
            validateInputs();
            if (errorCount == 0)
            {
                inventoryPresenter.doAddUpdate();
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }

        }

        private void btn_inventory_edit_Click(object sender, EventArgs e)
        {
            inventoryPresenter.doEdit();
        }

        private void btn_inventory_delete_Click(object sender, EventArgs e)
        {
            inventoryPresenter.deleteItem();
        }

        private void validateInputs()
        {
            errorCount = 0;
            //validate name
            if (ValidateUtil.isStringEmpty(inventoryName))
            {
                errorMessage.SetError(textbox_inventory_name, "Name is required");
                errorCount++;
            }
            else 
            {
                errorMessage.SetError(textbox_inventory_name,null);
            }

            //validate price
            if (ValidateUtil.isStringEmpty(inventoryPrice))
            {
                errorMessage.SetError(textbox_inventory_price, "Price is required");
                errorCount++;
            }
            else if (!ValidateUtil.isFloat(inventoryPrice))
            {
                errorMessage.SetError(textbox_inventory_price, "Invalid Input");
                errorCount++;

            }
            else
            {
                errorMessage.SetError(textbox_inventory_price, null);
          
            }

            //Validate Quantity
            if (inventoryQty == 0)
            {
                errorMessage.SetError(numeric_inventory_qty, "Quantity should be greater than 0");
                errorCount++;

            }
            else
            {
                errorMessage.SetError(numeric_inventory_qty, null);
            
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

        public void onDbActionResult(string action, bool result)
        {
            if (action == "delete" && result)
            {
                MessageBox.Show("Item Deleted Successfully");
            }

            if (action == "add" && result)
            {
                MessageBox.Show("Item Added Successfully");
            }

            if (action == "edit" && result)
            {
                MessageBox.Show("Item Changed Successfully");
            }
        }
    }
}

