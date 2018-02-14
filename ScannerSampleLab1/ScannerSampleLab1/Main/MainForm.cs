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
               return lvwItem;
            }

            set
            {
                lvwItem = (MetroListView) value;
            }
        }

        public ListView cashierCartListView
        {
            get
            {
                return lvwCart;
            }

            set
            {
                lvwCart = (MetroListView) value;
            }
        }

        public string cashierItemSearch
        {
            get
            {
                return txtItemSearch.Text.Length > 0 ? txtItemSearch.Text : null;
            }

            set
            {
                txtItemSearch.Text = value;
            }
        }

        public string cashierTotalPrice
        {
            get
            {
                return txtTotal.Text;
            }

            set
            {
                txtTotal.Text = value;
            }
        }

        public DataGridView inventoryDataGrid
        {
            get
            {
                return grdInventory;
            }

            set
            {
                grdInventory = (MetroGrid) value;
            }
        }

        public string inventoryID
        {
            get
            {
                return txtInventoryId.Text;
            }

            set
            {
                txtInventoryId.Text = value;
            }
        }

        public string inventoryName
        {
            get
            {
                return txtInventoryName.Text;
            }

            set
            {
                txtInventoryName.Text = value;
            }
        }

        public string inventoryPrice
        {
            get
            {
                return txtInventoryPrice.Text;
            }

            set
            {
                txtInventoryPrice.Text = value;
            }
        }

        public int inventoryQty
        {
            get
            {
                return (int) txtInventoryQty.Value;
            }

            set
            {
                txtInventoryQty.Value = value;
            }
        }

        public string inventorySearch
        {
            get
            {
                return txtInventorySearch.Text.Length > 0 ? txtInventorySearch.Text : null;
            }

            set
            {
                txtInventorySearch.Text = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            cashierPresenter = new CashierPresenter(this);
            inventoryPresenter = new InventoryPresenter(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cashierPresenter.getAllItems();
            inventoryPresenter.getAllInventory();


        }

        private void itemListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwItem.Columns[e.ColumnIndex].Width;
        }

        private void itemListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            cashierPresenter.itemSelectedChanged();
        }

        private void button_addCart_Click(object sender, EventArgs e)
        {
            cashierPresenter.addToCart(decimal.ToInt32(inputQty.Value));
            pnlAdd.Visible = false;
        }

        private void btn_cart_clear_Click(object sender, EventArgs e)
        {
            if (lvwCart.Items.Count != 0)
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
                btnItemSearch.PerformClick();
            }
        }

        private void btnInventorySearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInventorySearch.PerformClick();
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

        private void btnInventorySearch_Click(object sender, EventArgs e)
        {
            inventoryPresenter.getAllInventory();
        }

        private void validateInputs()
        {
            errorCount = 0;
            //validate name
            if (ValidateUtil.isStringEmpty(inventoryName))
            {
                errorMessage.SetError(txtInventoryName, "Name is required");
                errorCount++;
            }
            else 
            {
                errorMessage.SetError(txtInventoryName,null);
            }

            //validate price
            if (ValidateUtil.isStringEmpty(inventoryPrice))
            {
                errorMessage.SetError(txtInventoryPrice, "Price is required");
                errorCount++;
            }
            else if (!ValidateUtil.isFloat(inventoryPrice))
            {
                errorMessage.SetError(txtInventoryPrice, "Invalid Input");
                errorCount++;

            }
            else
            {
                errorMessage.SetError(txtInventoryPrice, null);
          
            }

            //Validate Quantity
            if (inventoryQty == 0)
            {
                errorMessage.SetError(txtInventoryQty, "Quantity should be greater than 0");
                errorCount++;

            }
            else
            {
                errorMessage.SetError(txtInventoryQty, null);
            
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
                pnlAdd.Visible = true;
                inputQty.Maximum = qty;
            }
            else
            {
                pnlAdd.Visible = false;
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

