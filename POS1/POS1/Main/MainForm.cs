using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS1.Cashier.View;
using POS1.Cashier.Presenter;
using POS1.Utils;
using MetroFramework.Controls;
using POS1.Main.View.Inventory;
using POS1.Main.Presenter.Inventory;
using POS1.Main.View.Dashboard;
using System.Windows.Forms.DataVisualization.Charting;
using POS1.Main.Presenter.Dashboard;

namespace POS1.Cashier
{
    public partial class MainForm : MetroForm, ICashierView, IInventoryView, IDashboardView
    {
        CashierPresenter cashierPresenter;
        InventoryPresenter inventoryPresenter;
        DashboardPresenter dashboardPresenter;

        int errorCount = 0;

        public DataGridView cashierItems
        {
            get
            {
                return  dgdCashierItems;
            }

            set
            {
                dgdCashierItems = (MetroGrid) value;
            }
        }

        public DataGridView cashierCart
        {
            get
            {
                return dgdCashierCart;
            }

            set
            {
                dgdCashierCart = (MetroGrid) value;
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

        public string cashierSubtotalPrice
        {
            get
            {
                return txtSubtotal.Text;
            }

            set
            {
                txtSubtotal.Text = value;
            }
        }

        public string cashierVatPrice
        {
            get
            {
                return txtVat.Text;
            }

            set
            {
                txtVat.Text = value;
            }
        }

        public string cashierAmountPaid
        {
            get
            {
                return txtReceived.Text;
            }

            set
            {
                txtReceived.Text = value;
            }
        }

        public string cashierAmountChange
        {
            get
            {
                return txtChange.Text;
            }

            set
            {
                txtChange.Text = value;
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

        public Chart dashboardChartYearly
        {
            get
            {
                return chDashboardYearly;
            }

            set
            {
                chDashboardYearly = value;
            }
        }

        public ComboBox dashboardDropdownYearly
        {
            get
            {
                return cboDashboardYearlyChart;
            }

            set
            {
                cboDashboardYearlyChart = (MetroComboBox) value;
            }
        }

        public Chart dashboardChartMonthly
        {
            get
            {
                return chDashboardMonthly;
            }

            set
            {
                chDashboardMonthly = value;
            }
        }

        public ComboBox dashboardDropdownMonthly
        {
            get
            {
                return cboDashboardMonthlyChart;
            }

            set
            {
                cboDashboardMonthlyChart = (MetroComboBox) value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            cashierPresenter = new CashierPresenter(this);
            inventoryPresenter = new InventoryPresenter(this);
            dashboardPresenter = new DashboardPresenter(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cashierPresenter.initTables();
            cashierPresenter.getAllItems();

            inventoryPresenter.getAllInventory();

            dashboardPresenter.initDashboard();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierPresenter.getAllItems();

            inventoryPresenter.getAllInventory();

            dashboardPresenter.initDashboard();
        }

        private void dgdCashierItems_SelectionChanged(object sender, EventArgs e)
        {
            cashierPresenter.itemSelectedChanged();
         
        }

        private void button_addCart_Click(object sender, EventArgs e)
        {
            cashierPresenter.addToCart(decimal.ToInt32(inputQty.Value));
            pnlAdd.Visible = false;
            btnItemTransact.Enabled = false;
        }

        private void btn_cart_clear_Click(object sender, EventArgs e)
        {
            cashierPresenter.clearCart(false);
        }

        private void btn_item_search_Click(object sender, EventArgs e)
        {
            cashierPresenter.getAllItems();
        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double amountPaid = double.Parse(cashierAmountPaid);
                double amountTotal = double.Parse(cashierTotalPrice);
                if (amountPaid >= amountTotal)
                {
                    btnItemTransact.Enabled = true;
                }
                else
                {
                    btnItemTransact.Enabled = false;
                }
            }
            catch
            {
                btnItemTransact.Enabled = false;
            }
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

        private void btnItemTransact_Click(object sender, EventArgs e)
        {
            cashierPresenter.doTransact();
        }

        private void cboDashboardYearlyChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            dashboardPresenter.fillYearlyChart();
        }

        /// <summary>
        /// TO VALIDATE THE INPUTS FROM THE INVENTORY CRUD
        /// </summary>
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
            inputQty.Value = 1;
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

        /// <summary>
        /// FOR THE CRUD OPERATIONS IN INVENTORY
        /// </summary>
        /// <param name="action"></param>
        /// <param name="result"></param>
        public void onDbActionResult(string action, bool result)
        {
            if (action == "delete" && result)
            {
                MessageBox.Show("Item Deleted Successfully");
            }
            else if (action == "delete" && !result)
            {
                MessageBox.Show("Cant Delete This Item");
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

        /// <summary>
        /// CALLS WHEN TRANSACTION DONE
        /// </summary>
        public void onTransactDone()
        {
            MessageBox.Show("Tansaction Done");
        }

    }
}

