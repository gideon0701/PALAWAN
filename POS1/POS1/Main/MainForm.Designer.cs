namespace POS1.Cashier
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabpageInventory = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnInventorySearch = new MetroFramework.Controls.MetroButton();
            this.txtInventorySearch = new MetroFramework.Controls.MetroTextBox();
            this.btnInventoryDelete = new MetroFramework.Controls.MetroButton();
            this.grdInventory = new MetroFramework.Controls.MetroGrid();
            this.btnInventoryEdit = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtInventoryQty = new System.Windows.Forms.NumericUpDown();
            this.txtInventoryPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtInventoryName = new MetroFramework.Controls.MetroTextBox();
            this.txtInventoryId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnInventoryAddUpdate = new MetroFramework.Controls.MetroButton();
            this.tabpageDashboard = new MetroFramework.Controls.MetroTabPage();
            this.tabpageCashier = new MetroFramework.Controls.MetroTabPage();
            this.txtChange = new MetroFramework.Controls.MetroTextBox();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtReceived = new MetroFramework.Controls.MetroTextBox();
            this.lbl_received = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_change = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_total = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnItemTransact = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnClearCart = new MetroFramework.Controls.MetroButton();
            this.lvwCart = new MetroFramework.Controls.MetroListView();
            this.cart_item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cart_item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cart_id_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cart_id_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnItemSearch = new MetroFramework.Controls.MetroButton();
            this.txtItemSearch = new MetroFramework.Controls.MetroTextBox();
            this.pnlAdd = new MetroFramework.Controls.MetroPanel();
            this.inputQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddCart = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lvwItem = new MetroFramework.Controls.MetroListView();
            this.itemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.errorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtVat = new MetroFramework.Controls.MetroTextBox();
            this.lblVat = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.lblSubtotal = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tabpageInventory.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryQty)).BeginInit();
            this.tabpageCashier.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputQty)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabpageInventory
            // 
            this.tabpageInventory.Controls.Add(this.metroPanel4);
            this.tabpageInventory.Controls.Add(this.metroPanel3);
            this.tabpageInventory.HorizontalScrollbarBarColor = true;
            this.tabpageInventory.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpageInventory.HorizontalScrollbarSize = 10;
            this.tabpageInventory.Location = new System.Drawing.Point(4, 38);
            this.tabpageInventory.Name = "tabpageInventory";
            this.tabpageInventory.Size = new System.Drawing.Size(757, 452);
            this.tabpageInventory.TabIndex = 2;
            this.tabpageInventory.Text = "Inventory";
            this.tabpageInventory.VerticalScrollbarBarColor = true;
            this.tabpageInventory.VerticalScrollbarHighlightOnWheel = false;
            this.tabpageInventory.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.btnInventorySearch);
            this.metroPanel4.Controls.Add(this.txtInventorySearch);
            this.metroPanel4.Controls.Add(this.btnInventoryDelete);
            this.metroPanel4.Controls.Add(this.grdInventory);
            this.metroPanel4.Controls.Add(this.btnInventoryEdit);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(12, 17);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(466, 409);
            this.metroPanel4.TabIndex = 5;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnInventorySearch
            // 
            this.btnInventorySearch.Location = new System.Drawing.Point(236, 30);
            this.btnInventorySearch.Name = "btnInventorySearch";
            this.btnInventorySearch.Size = new System.Drawing.Size(75, 23);
            this.btnInventorySearch.TabIndex = 12;
            this.btnInventorySearch.Text = "Search";
            this.btnInventorySearch.UseSelectable = true;
            this.btnInventorySearch.Click += new System.EventHandler(this.btnInventorySearch_Click);
            this.btnInventorySearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnInventorySearch_KeyDown);
            // 
            // txtInventorySearch
            // 
            // 
            // 
            // 
            this.txtInventorySearch.CustomButton.Image = null;
            this.txtInventorySearch.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtInventorySearch.CustomButton.Name = "";
            this.txtInventorySearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventorySearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventorySearch.CustomButton.TabIndex = 1;
            this.txtInventorySearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventorySearch.CustomButton.UseSelectable = true;
            this.txtInventorySearch.CustomButton.Visible = false;
            this.txtInventorySearch.Lines = new string[0];
            this.txtInventorySearch.Location = new System.Drawing.Point(15, 30);
            this.txtInventorySearch.MaxLength = 32767;
            this.txtInventorySearch.Name = "txtInventorySearch";
            this.txtInventorySearch.PasswordChar = '\0';
            this.txtInventorySearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventorySearch.SelectedText = "";
            this.txtInventorySearch.SelectionLength = 0;
            this.txtInventorySearch.SelectionStart = 0;
            this.txtInventorySearch.ShortcutsEnabled = true;
            this.txtInventorySearch.Size = new System.Drawing.Size(222, 23);
            this.txtInventorySearch.TabIndex = 11;
            this.txtInventorySearch.UseSelectable = true;
            this.txtInventorySearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventorySearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.Location = new System.Drawing.Point(201, 373);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryDelete.TabIndex = 4;
            this.btnInventoryDelete.Text = "Delete";
            this.btnInventoryDelete.UseSelectable = true;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btn_inventory_delete_Click);
            // 
            // grdInventory
            // 
            this.grdInventory.AllowUserToAddRows = false;
            this.grdInventory.AllowUserToDeleteRows = false;
            this.grdInventory.AllowUserToResizeColumns = false;
            this.grdInventory.AllowUserToResizeRows = false;
            this.grdInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInventory.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdInventory.EnableHeadersVisualStyles = false;
            this.grdInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdInventory.Location = new System.Drawing.Point(15, 67);
            this.grdInventory.MultiSelect = false;
            this.grdInventory.Name = "grdInventory";
            this.grdInventory.ReadOnly = true;
            this.grdInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInventory.Size = new System.Drawing.Size(437, 280);
            this.grdInventory.Style = MetroFramework.MetroColorStyle.Green;
            this.grdInventory.TabIndex = 2;
            this.grdInventory.UseStyleColors = true;
            // 
            // btnInventoryEdit
            // 
            this.btnInventoryEdit.Location = new System.Drawing.Point(292, 373);
            this.btnInventoryEdit.Name = "btnInventoryEdit";
            this.btnInventoryEdit.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryEdit.TabIndex = 3;
            this.btnInventoryEdit.Text = "Edit";
            this.btnInventoryEdit.UseSelectable = true;
            this.btnInventoryEdit.Click += new System.EventHandler(this.btn_inventory_edit_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.txtInventoryQty);
            this.metroPanel3.Controls.Add(this.txtInventoryPrice);
            this.metroPanel3.Controls.Add(this.txtInventoryName);
            this.metroPanel3.Controls.Add(this.txtInventoryId);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.btnInventoryAddUpdate);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(498, 17);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(210, 230);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtInventoryQty
            // 
            this.txtInventoryQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInventoryQty.Location = new System.Drawing.Point(48, 152);
            this.txtInventoryQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtInventoryQty.Name = "txtInventoryQty";
            this.txtInventoryQty.Size = new System.Drawing.Size(75, 20);
            this.txtInventoryQty.TabIndex = 11;
            // 
            // txtInventoryPrice
            // 
            // 
            // 
            // 
            this.txtInventoryPrice.CustomButton.Image = null;
            this.txtInventoryPrice.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtInventoryPrice.CustomButton.Name = "";
            this.txtInventoryPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryPrice.CustomButton.TabIndex = 1;
            this.txtInventoryPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryPrice.CustomButton.UseSelectable = true;
            this.txtInventoryPrice.CustomButton.Visible = false;
            this.txtInventoryPrice.Lines = new string[0];
            this.txtInventoryPrice.Location = new System.Drawing.Point(48, 114);
            this.txtInventoryPrice.MaxLength = 32767;
            this.txtInventoryPrice.Name = "txtInventoryPrice";
            this.txtInventoryPrice.PasswordChar = '\0';
            this.txtInventoryPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryPrice.SelectedText = "";
            this.txtInventoryPrice.SelectionLength = 0;
            this.txtInventoryPrice.SelectionStart = 0;
            this.txtInventoryPrice.ShortcutsEnabled = true;
            this.txtInventoryPrice.Size = new System.Drawing.Size(75, 23);
            this.txtInventoryPrice.TabIndex = 9;
            this.txtInventoryPrice.UseSelectable = true;
            this.txtInventoryPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInventoryName
            // 
            // 
            // 
            // 
            this.txtInventoryName.CustomButton.Image = null;
            this.txtInventoryName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtInventoryName.CustomButton.Name = "";
            this.txtInventoryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryName.CustomButton.TabIndex = 1;
            this.txtInventoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryName.CustomButton.UseSelectable = true;
            this.txtInventoryName.CustomButton.Visible = false;
            this.txtInventoryName.Lines = new string[0];
            this.txtInventoryName.Location = new System.Drawing.Point(48, 80);
            this.txtInventoryName.MaxLength = 32767;
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.PasswordChar = '\0';
            this.txtInventoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryName.SelectedText = "";
            this.txtInventoryName.SelectionLength = 0;
            this.txtInventoryName.SelectionStart = 0;
            this.txtInventoryName.ShortcutsEnabled = true;
            this.txtInventoryName.Size = new System.Drawing.Size(75, 23);
            this.txtInventoryName.TabIndex = 8;
            this.txtInventoryName.UseSelectable = true;
            this.txtInventoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInventoryId
            // 
            // 
            // 
            // 
            this.txtInventoryId.CustomButton.Image = null;
            this.txtInventoryId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtInventoryId.CustomButton.Name = "";
            this.txtInventoryId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInventoryId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInventoryId.CustomButton.TabIndex = 1;
            this.txtInventoryId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInventoryId.CustomButton.UseSelectable = true;
            this.txtInventoryId.CustomButton.Visible = false;
            this.txtInventoryId.Lines = new string[0];
            this.txtInventoryId.Location = new System.Drawing.Point(48, 50);
            this.txtInventoryId.MaxLength = 32767;
            this.txtInventoryId.Name = "txtInventoryId";
            this.txtInventoryId.PasswordChar = '\0';
            this.txtInventoryId.ReadOnly = true;
            this.txtInventoryId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInventoryId.SelectedText = "";
            this.txtInventoryId.SelectionLength = 0;
            this.txtInventoryId.SelectionStart = 0;
            this.txtInventoryId.ShortcutsEnabled = true;
            this.txtInventoryId.Size = new System.Drawing.Size(75, 23);
            this.txtInventoryId.TabIndex = 7;
            this.txtInventoryId.UseSelectable = true;
            this.txtInventoryId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInventoryId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 153);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "QTY:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 118);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "PRICE: ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 84);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "NAME:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 54);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(28, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "ID: ";
            // 
            // btnInventoryAddUpdate
            // 
            this.btnInventoryAddUpdate.Location = new System.Drawing.Point(96, 190);
            this.btnInventoryAddUpdate.Name = "btnInventoryAddUpdate";
            this.btnInventoryAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryAddUpdate.TabIndex = 2;
            this.btnInventoryAddUpdate.Text = "Add/Update";
            this.btnInventoryAddUpdate.UseSelectable = true;
            this.btnInventoryAddUpdate.Click += new System.EventHandler(this.btn_inventory_addupdate_Click);
            // 
            // tabpageDashboard
            // 
            this.tabpageDashboard.HorizontalScrollbarBarColor = true;
            this.tabpageDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpageDashboard.HorizontalScrollbarSize = 10;
            this.tabpageDashboard.Location = new System.Drawing.Point(4, 38);
            this.tabpageDashboard.Name = "tabpageDashboard";
            this.tabpageDashboard.Size = new System.Drawing.Size(757, 452);
            this.tabpageDashboard.TabIndex = 0;
            this.tabpageDashboard.Text = "Dashboard";
            this.tabpageDashboard.VerticalScrollbarBarColor = true;
            this.tabpageDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.tabpageDashboard.VerticalScrollbarSize = 10;
            // 
            // tabpageCashier
            // 
            this.tabpageCashier.Controls.Add(this.txtSubtotal);
            this.tabpageCashier.Controls.Add(this.lblSubtotal);
            this.tabpageCashier.Controls.Add(this.txtVat);
            this.tabpageCashier.Controls.Add(this.lblVat);
            this.tabpageCashier.Controls.Add(this.txtChange);
            this.tabpageCashier.Controls.Add(this.txtTotal);
            this.tabpageCashier.Controls.Add(this.txtReceived);
            this.tabpageCashier.Controls.Add(this.lbl_received);
            this.tabpageCashier.Controls.Add(this.lbl_change);
            this.tabpageCashier.Controls.Add(this.lbl_total);
            this.tabpageCashier.Controls.Add(this.btnItemTransact);
            this.tabpageCashier.Controls.Add(this.metroPanel2);
            this.tabpageCashier.Controls.Add(this.metroPanel1);
            this.tabpageCashier.HorizontalScrollbarBarColor = true;
            this.tabpageCashier.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpageCashier.HorizontalScrollbarSize = 10;
            this.tabpageCashier.Location = new System.Drawing.Point(4, 38);
            this.tabpageCashier.Name = "tabpageCashier";
            this.tabpageCashier.Size = new System.Drawing.Size(757, 452);
            this.tabpageCashier.TabIndex = 1;
            this.tabpageCashier.Text = "Cash Register";
            this.tabpageCashier.VerticalScrollbarBarColor = true;
            this.tabpageCashier.VerticalScrollbarHighlightOnWheel = false;
            this.tabpageCashier.VerticalScrollbarSize = 10;
            // 
            // txtChange
            // 
            // 
            // 
            // 
            this.txtChange.CustomButton.Image = null;
            this.txtChange.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtChange.CustomButton.Name = "";
            this.txtChange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChange.CustomButton.TabIndex = 1;
            this.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChange.CustomButton.UseSelectable = true;
            this.txtChange.CustomButton.Visible = false;
            this.txtChange.Lines = new string[] {
        "0"};
            this.txtChange.Location = new System.Drawing.Point(644, 326);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ReadOnly = true;
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(75, 23);
            this.txtChange.TabIndex = 10;
            this.txtChange.Text = "0";
            this.txtChange.UseSelectable = true;
            this.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Lines = new string[] {
        "0"};
            this.txtTotal.Location = new System.Drawing.Point(643, 270);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(75, 23);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "0";
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReceived
            // 
            // 
            // 
            // 
            this.txtReceived.CustomButton.Image = null;
            this.txtReceived.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtReceived.CustomButton.Name = "";
            this.txtReceived.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReceived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReceived.CustomButton.TabIndex = 1;
            this.txtReceived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReceived.CustomButton.UseSelectable = true;
            this.txtReceived.CustomButton.Visible = false;
            this.txtReceived.Lines = new string[] {
        "0"};
            this.txtReceived.Location = new System.Drawing.Point(644, 299);
            this.txtReceived.MaxLength = 32767;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.PasswordChar = '\0';
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceived.SelectedText = "";
            this.txtReceived.SelectionLength = 0;
            this.txtReceived.SelectionStart = 0;
            this.txtReceived.ShortcutsEnabled = true;
            this.txtReceived.Size = new System.Drawing.Size(75, 23);
            this.txtReceived.TabIndex = 8;
            this.txtReceived.Text = "0";
            this.txtReceived.UseSelectable = true;
            this.txtReceived.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReceived.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_received
            // 
            this.lbl_received.AutoScroll = true;
            this.lbl_received.AutoScrollMinSize = new System.Drawing.Size(60, 23);
            this.lbl_received.AutoSize = false;
            this.lbl_received.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_received.Location = new System.Drawing.Point(584, 299);
            this.lbl_received.Name = "lbl_received";
            this.lbl_received.Size = new System.Drawing.Size(75, 23);
            this.lbl_received.TabIndex = 7;
            this.lbl_received.Text = "Received:";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoScroll = true;
            this.lbl_change.AutoScrollMinSize = new System.Drawing.Size(51, 23);
            this.lbl_change.AutoSize = false;
            this.lbl_change.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_change.Location = new System.Drawing.Point(584, 326);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(75, 23);
            this.lbl_change.TabIndex = 6;
            this.lbl_change.Text = "Change:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoScroll = true;
            this.lbl_total.AutoScrollMinSize = new System.Drawing.Size(38, 23);
            this.lbl_total.AutoSize = false;
            this.lbl_total.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_total.Location = new System.Drawing.Point(584, 272);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(75, 23);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total:";
            // 
            // btnItemTransact
            // 
            this.btnItemTransact.Location = new System.Drawing.Point(626, 382);
            this.btnItemTransact.Name = "btnItemTransact";
            this.btnItemTransact.Size = new System.Drawing.Size(75, 23);
            this.btnItemTransact.TabIndex = 4;
            this.btnItemTransact.Text = "Transact";
            this.btnItemTransact.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnClearCart);
            this.metroPanel2.Controls.Add(this.lvwCart);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 272);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(563, 177);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(477, 97);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(75, 23);
            this.btnClearCart.TabIndex = 4;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseSelectable = true;
            this.btnClearCart.Click += new System.EventHandler(this.btn_cart_clear_Click);
            // 
            // lvwCart
            // 
            this.lvwCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cart_item_id,
            this.cart_item_name,
            this.cart_id_price,
            this.cart_id_qty});
            this.lvwCart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwCart.FullRowSelect = true;
            this.lvwCart.GridLines = true;
            this.lvwCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwCart.LabelWrap = false;
            this.lvwCart.Location = new System.Drawing.Point(12, 26);
            this.lvwCart.MultiSelect = false;
            this.lvwCart.Name = "lvwCart";
            this.lvwCart.OwnerDraw = true;
            this.lvwCart.Size = new System.Drawing.Size(459, 131);
            this.lvwCart.TabIndex = 3;
            this.lvwCart.UseCompatibleStateImageBehavior = false;
            this.lvwCart.UseSelectable = true;
            this.lvwCart.View = System.Windows.Forms.View.Details;
            // 
            // cart_item_id
            // 
            this.cart_item_id.Text = "ID";
            this.cart_item_id.Width = 36;
            // 
            // cart_item_name
            // 
            this.cart_item_name.Text = "Name";
            this.cart_item_name.Width = 226;
            // 
            // cart_id_price
            // 
            this.cart_id_price.Text = "Price";
            this.cart_id_price.Width = 112;
            // 
            // cart_id_qty
            // 
            this.cart_id_qty.Text = "Qty";
            this.cart_id_qty.Width = 80;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Cart";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnItemSearch);
            this.metroPanel1.Controls.Add(this.txtItemSearch);
            this.metroPanel1.Controls.Add(this.pnlAdd);
            this.metroPanel1.Controls.Add(this.lvwItem);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(563, 256);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Location = new System.Drawing.Point(233, 32);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(75, 23);
            this.btnItemSearch.TabIndex = 10;
            this.btnItemSearch.Text = "Search";
            this.btnItemSearch.UseSelectable = true;
            this.btnItemSearch.Click += new System.EventHandler(this.btn_item_search_Click);
            // 
            // txtItemSearch
            // 
            // 
            // 
            // 
            this.txtItemSearch.CustomButton.Image = null;
            this.txtItemSearch.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtItemSearch.CustomButton.Name = "";
            this.txtItemSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemSearch.CustomButton.TabIndex = 1;
            this.txtItemSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemSearch.CustomButton.UseSelectable = true;
            this.txtItemSearch.CustomButton.Visible = false;
            this.txtItemSearch.Lines = new string[0];
            this.txtItemSearch.Location = new System.Drawing.Point(12, 32);
            this.txtItemSearch.MaxLength = 32767;
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.PasswordChar = '\0';
            this.txtItemSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemSearch.SelectedText = "";
            this.txtItemSearch.SelectionLength = 0;
            this.txtItemSearch.SelectionStart = 0;
            this.txtItemSearch.ShortcutsEnabled = true;
            this.txtItemSearch.Size = new System.Drawing.Size(222, 23);
            this.txtItemSearch.TabIndex = 9;
            this.txtItemSearch.UseSelectable = true;
            this.txtItemSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_item_search_KeyDown);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.inputQty);
            this.pnlAdd.Controls.Add(this.btnAddCart);
            this.pnlAdd.Controls.Add(this.metroLabel3);
            this.pnlAdd.HorizontalScrollbarBarColor = true;
            this.pnlAdd.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdd.HorizontalScrollbarSize = 10;
            this.pnlAdd.Location = new System.Drawing.Point(477, 143);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(83, 89);
            this.pnlAdd.TabIndex = 8;
            this.pnlAdd.VerticalScrollbarBarColor = true;
            this.pnlAdd.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdd.VerticalScrollbarSize = 10;
            this.pnlAdd.Visible = false;
            // 
            // inputQty
            // 
            this.inputQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputQty.Location = new System.Drawing.Point(38, 11);
            this.inputQty.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputQty.Name = "inputQty";
            this.inputQty.Size = new System.Drawing.Size(42, 20);
            this.inputQty.TabIndex = 7;
            this.inputQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(4, 53);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddCart.TabIndex = 4;
            this.btnAddCart.Text = "Add To Cart";
            this.btnAddCart.UseSelectable = true;
            this.btnAddCart.Click += new System.EventHandler(this.button_addCart_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "QTY:";
            // 
            // lvwItem
            // 
            this.lvwItem.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvwItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemID,
            this.itemName,
            this.itemPrice,
            this.itemQty});
            this.lvwItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwItem.FullRowSelect = true;
            this.lvwItem.GridLines = true;
            this.lvwItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwItem.LabelWrap = false;
            this.lvwItem.Location = new System.Drawing.Point(12, 61);
            this.lvwItem.MultiSelect = false;
            this.lvwItem.Name = "lvwItem";
            this.lvwItem.OwnerDraw = true;
            this.lvwItem.Size = new System.Drawing.Size(463, 190);
            this.lvwItem.TabIndex = 3;
            this.lvwItem.UseCompatibleStateImageBehavior = false;
            this.lvwItem.UseSelectable = true;
            this.lvwItem.View = System.Windows.Forms.View.Details;
            this.lvwItem.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.itemListView_ColumnWidthChanging);
            this.lvwItem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.itemListView_ItemSelectionChanged);
            // 
            // itemID
            // 
            this.itemID.Text = "ID";
            this.itemID.Width = 43;
            // 
            // itemName
            // 
            this.itemName.Text = "Name";
            this.itemName.Width = 223;
            // 
            // itemPrice
            // 
            this.itemPrice.Text = "Price ";
            this.itemPrice.Width = 113;
            // 
            // itemQty
            // 
            this.itemQty.Text = "Available";
            this.itemQty.Width = 79;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Item List";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpageCashier);
            this.tabControl.Controls.Add(this.tabpageDashboard);
            this.tabControl.Controls.Add(this.tabpageInventory);
            this.tabControl.Location = new System.Drawing.Point(7, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(765, 494);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Green;
            this.tabControl.TabIndex = 0;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl.UseSelectable = true;
            this.tabControl.UseStyleColors = true;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // errorMessage
            // 
            this.errorMessage.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtVat
            // 
            // 
            // 
            // 
            this.txtVat.CustomButton.Image = null;
            this.txtVat.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtVat.CustomButton.Name = "";
            this.txtVat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVat.CustomButton.TabIndex = 1;
            this.txtVat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVat.CustomButton.UseSelectable = true;
            this.txtVat.CustomButton.Visible = false;
            this.txtVat.Lines = new string[] {
        "0"};
            this.txtVat.Location = new System.Drawing.Point(643, 239);
            this.txtVat.MaxLength = 32767;
            this.txtVat.Name = "txtVat";
            this.txtVat.PasswordChar = '\0';
            this.txtVat.ReadOnly = true;
            this.txtVat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVat.SelectedText = "";
            this.txtVat.SelectionLength = 0;
            this.txtVat.SelectionStart = 0;
            this.txtVat.ShortcutsEnabled = true;
            this.txtVat.Size = new System.Drawing.Size(75, 23);
            this.txtVat.TabIndex = 12;
            this.txtVat.Text = "0";
            this.txtVat.UseSelectable = true;
            this.txtVat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblVat
            // 
            this.lblVat.AutoScroll = true;
            this.lblVat.AutoScrollMinSize = new System.Drawing.Size(34, 23);
            this.lblVat.AutoSize = false;
            this.lblVat.BackColor = System.Drawing.SystemColors.Window;
            this.lblVat.Location = new System.Drawing.Point(584, 241);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(75, 23);
            this.lblVat.TabIndex = 11;
            this.lblVat.Text = "VAT:";
            // 
            // txtSubtotal
            // 
            // 
            // 
            // 
            this.txtSubtotal.CustomButton.Image = null;
            this.txtSubtotal.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtSubtotal.CustomButton.Name = "";
            this.txtSubtotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubtotal.CustomButton.TabIndex = 1;
            this.txtSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtotal.CustomButton.UseSelectable = true;
            this.txtSubtotal.CustomButton.Visible = false;
            this.txtSubtotal.Lines = new string[] {
        "0"};
            this.txtSubtotal.Location = new System.Drawing.Point(643, 210);
            this.txtSubtotal.MaxLength = 32767;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.ShortcutsEnabled = true;
            this.txtSubtotal.Size = new System.Drawing.Size(75, 23);
            this.txtSubtotal.TabIndex = 14;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.UseSelectable = true;
            this.txtSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoScroll = true;
            this.lblSubtotal.AutoScrollMinSize = new System.Drawing.Size(53, 23);
            this.lblSubtotal.AutoSize = false;
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblSubtotal.Location = new System.Drawing.Point(584, 212);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(75, 23);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 535);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabpageInventory.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventoryQty)).EndInit();
            this.tabpageCashier.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputQty)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tabpageInventory;
        private MetroFramework.Controls.MetroTabPage tabpageDashboard;
        private MetroFramework.Controls.MetroTabPage tabpageCashier;
        private MetroFramework.Controls.MetroTextBox txtChange;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroTextBox txtReceived;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_received;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_change;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_total;
        private MetroFramework.Controls.MetroButton btnItemTransact;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnClearCart;
        private MetroFramework.Controls.MetroListView lvwCart;
        private System.Windows.Forms.ColumnHeader cart_item_id;
        private System.Windows.Forms.ColumnHeader cart_item_name;
        private System.Windows.Forms.ColumnHeader cart_id_price;
        private System.Windows.Forms.ColumnHeader cart_id_qty;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnItemSearch;
        private MetroFramework.Controls.MetroTextBox txtItemSearch;
        private MetroFramework.Controls.MetroPanel pnlAdd;
        private System.Windows.Forms.NumericUpDown inputQty;
        private MetroFramework.Controls.MetroButton btnAddCart;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroListView lvwItem;
        private System.Windows.Forms.ColumnHeader itemID;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.ColumnHeader itemQty;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroGrid grdInventory;
        private MetroFramework.Controls.MetroButton btnInventoryEdit;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnInventoryAddUpdate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnInventoryDelete;
        private MetroFramework.Controls.MetroTextBox txtInventoryPrice;
        private MetroFramework.Controls.MetroTextBox txtInventoryName;
        private MetroFramework.Controls.MetroTextBox txtInventoryId;
        private System.Windows.Forms.NumericUpDown txtInventoryQty;
        private System.Windows.Forms.ErrorProvider errorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton btnInventorySearch;
        private MetroFramework.Controls.MetroTextBox txtInventorySearch;
        private MetroFramework.Controls.MetroTextBox txtSubtotal;
        private MetroFramework.Drawing.Html.HtmlLabel lblSubtotal;
        private MetroFramework.Controls.MetroTextBox txtVat;
        private MetroFramework.Drawing.Html.HtmlLabel lblVat;
    }
}