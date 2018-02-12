namespace ScannerSampleLab1.Cashier
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
            this.tabpage_inventory = new MetroFramework.Controls.MetroTabPage();
            this.tabpage_DashBoard = new MetroFramework.Controls.MetroTabPage();
            this.tabpage_Cashier = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.itemListView = new MetroFramework.Controls.MetroListView();
            this.itemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_add = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.button_addCart = new MetroFramework.Controls.MetroButton();
            this.input_qty = new System.Windows.Forms.NumericUpDown();
            this.textbox_item_search = new MetroFramework.Controls.MetroTextBox();
            this.btn_item_search = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cartListView = new MetroFramework.Controls.MetroListView();
            this.cart_item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cart_item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cart_id_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cart_id_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cart_clear = new MetroFramework.Controls.MetroButton();
            this.btn_item_transact = new MetroFramework.Controls.MetroButton();
            this.lbl_total = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_change = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_received = new MetroFramework.Drawing.Html.HtmlLabel();
            this.textbox_recieved = new MetroFramework.Controls.MetroTextBox();
            this.textboxt_total = new MetroFramework.Controls.MetroTextBox();
            this.textbox_change = new MetroFramework.Controls.MetroTextBox();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabpage_Cashier.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panel_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_qty)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpage_inventory
            // 
            this.tabpage_inventory.HorizontalScrollbarBarColor = true;
            this.tabpage_inventory.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpage_inventory.HorizontalScrollbarSize = 10;
            this.tabpage_inventory.Location = new System.Drawing.Point(4, 38);
            this.tabpage_inventory.Name = "tabpage_inventory";
            this.tabpage_inventory.Size = new System.Drawing.Size(757, 452);
            this.tabpage_inventory.TabIndex = 2;
            this.tabpage_inventory.Text = "Inventory";
            this.tabpage_inventory.VerticalScrollbarBarColor = true;
            this.tabpage_inventory.VerticalScrollbarHighlightOnWheel = false;
            this.tabpage_inventory.VerticalScrollbarSize = 10;
            // 
            // tabpage_DashBoard
            // 
            this.tabpage_DashBoard.HorizontalScrollbarBarColor = true;
            this.tabpage_DashBoard.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpage_DashBoard.HorizontalScrollbarSize = 10;
            this.tabpage_DashBoard.Location = new System.Drawing.Point(4, 38);
            this.tabpage_DashBoard.Name = "tabpage_DashBoard";
            this.tabpage_DashBoard.Size = new System.Drawing.Size(757, 452);
            this.tabpage_DashBoard.TabIndex = 0;
            this.tabpage_DashBoard.Text = "Dashboard";
            this.tabpage_DashBoard.VerticalScrollbarBarColor = true;
            this.tabpage_DashBoard.VerticalScrollbarHighlightOnWheel = false;
            this.tabpage_DashBoard.VerticalScrollbarSize = 10;
            // 
            // tabpage_Cashier
            // 
            this.tabpage_Cashier.Controls.Add(this.textbox_change);
            this.tabpage_Cashier.Controls.Add(this.textboxt_total);
            this.tabpage_Cashier.Controls.Add(this.textbox_recieved);
            this.tabpage_Cashier.Controls.Add(this.lbl_received);
            this.tabpage_Cashier.Controls.Add(this.lbl_change);
            this.tabpage_Cashier.Controls.Add(this.lbl_total);
            this.tabpage_Cashier.Controls.Add(this.btn_item_transact);
            this.tabpage_Cashier.Controls.Add(this.metroPanel2);
            this.tabpage_Cashier.Controls.Add(this.metroPanel1);
            this.tabpage_Cashier.HorizontalScrollbarBarColor = true;
            this.tabpage_Cashier.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpage_Cashier.HorizontalScrollbarSize = 10;
            this.tabpage_Cashier.Location = new System.Drawing.Point(4, 38);
            this.tabpage_Cashier.Name = "tabpage_Cashier";
            this.tabpage_Cashier.Size = new System.Drawing.Size(757, 452);
            this.tabpage_Cashier.TabIndex = 1;
            this.tabpage_Cashier.Text = "Cash Register";
            this.tabpage_Cashier.VerticalScrollbarBarColor = true;
            this.tabpage_Cashier.VerticalScrollbarHighlightOnWheel = false;
            this.tabpage_Cashier.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_item_search);
            this.metroPanel1.Controls.Add(this.textbox_item_search);
            this.metroPanel1.Controls.Add(this.panel_add);
            this.metroPanel1.Controls.Add(this.itemListView);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Item List";
            // 
            // itemListView
            // 
            this.itemListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemID,
            this.itemName,
            this.itemPrice,
            this.itemQty});
            this.itemListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.itemListView.FullRowSelect = true;
            this.itemListView.GridLines = true;
            this.itemListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemListView.LabelWrap = false;
            this.itemListView.Location = new System.Drawing.Point(12, 61);
            this.itemListView.MultiSelect = false;
            this.itemListView.Name = "itemListView";
            this.itemListView.OwnerDraw = true;
            this.itemListView.Size = new System.Drawing.Size(463, 190);
            this.itemListView.TabIndex = 3;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.UseSelectable = true;
            this.itemListView.View = System.Windows.Forms.View.Details;
            this.itemListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.itemListView_ColumnWidthChanging);
            this.itemListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.itemListView_ItemSelectionChanged);
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
            // panel_add
            // 
            this.panel_add.Controls.Add(this.input_qty);
            this.panel_add.Controls.Add(this.button_addCart);
            this.panel_add.Controls.Add(this.metroLabel3);
            this.panel_add.HorizontalScrollbarBarColor = true;
            this.panel_add.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_add.HorizontalScrollbarSize = 10;
            this.panel_add.Location = new System.Drawing.Point(477, 143);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(83, 89);
            this.panel_add.TabIndex = 8;
            this.panel_add.VerticalScrollbarBarColor = true;
            this.panel_add.VerticalScrollbarHighlightOnWheel = false;
            this.panel_add.VerticalScrollbarSize = 10;
            this.panel_add.Visible = false;
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
            // button_addCart
            // 
            this.button_addCart.Location = new System.Drawing.Point(4, 53);
            this.button_addCart.Name = "button_addCart";
            this.button_addCart.Size = new System.Drawing.Size(75, 23);
            this.button_addCart.TabIndex = 4;
            this.button_addCart.Text = "Add To Cart";
            this.button_addCart.UseSelectable = true;
            this.button_addCart.Click += new System.EventHandler(this.button_addCart_Click);
            // 
            // input_qty
            // 
            this.input_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_qty.Location = new System.Drawing.Point(38, 11);
            this.input_qty.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.input_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_qty.Name = "input_qty";
            this.input_qty.Size = new System.Drawing.Size(42, 20);
            this.input_qty.TabIndex = 7;
            this.input_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textbox_item_search
            // 
            // 
            // 
            // 
            this.textbox_item_search.CustomButton.Image = null;
            this.textbox_item_search.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.textbox_item_search.CustomButton.Name = "";
            this.textbox_item_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_item_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_item_search.CustomButton.TabIndex = 1;
            this.textbox_item_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_item_search.CustomButton.UseSelectable = true;
            this.textbox_item_search.CustomButton.Visible = false;
            this.textbox_item_search.Lines = new string[0];
            this.textbox_item_search.Location = new System.Drawing.Point(12, 32);
            this.textbox_item_search.MaxLength = 32767;
            this.textbox_item_search.Name = "textbox_item_search";
            this.textbox_item_search.PasswordChar = '\0';
            this.textbox_item_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_item_search.SelectedText = "";
            this.textbox_item_search.SelectionLength = 0;
            this.textbox_item_search.SelectionStart = 0;
            this.textbox_item_search.ShortcutsEnabled = true;
            this.textbox_item_search.Size = new System.Drawing.Size(222, 23);
            this.textbox_item_search.TabIndex = 9;
            this.textbox_item_search.UseSelectable = true;
            this.textbox_item_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_item_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_item_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_item_search_KeyDown);
            // 
            // btn_item_search
            // 
            this.btn_item_search.Location = new System.Drawing.Point(233, 32);
            this.btn_item_search.Name = "btn_item_search";
            this.btn_item_search.Size = new System.Drawing.Size(75, 23);
            this.btn_item_search.TabIndex = 10;
            this.btn_item_search.Text = "Search";
            this.btn_item_search.UseSelectable = true;
            this.btn_item_search.Click += new System.EventHandler(this.btn_item_search_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btn_cart_clear);
            this.metroPanel2.Controls.Add(this.cartListView);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Cart";
            // 
            // cartListView
            // 
            this.cartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cart_item_id,
            this.cart_item_name,
            this.cart_id_price,
            this.cart_id_qty});
            this.cartListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cartListView.FullRowSelect = true;
            this.cartListView.GridLines = true;
            this.cartListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.cartListView.LabelWrap = false;
            this.cartListView.Location = new System.Drawing.Point(12, 26);
            this.cartListView.MultiSelect = false;
            this.cartListView.Name = "cartListView";
            this.cartListView.OwnerDraw = true;
            this.cartListView.Size = new System.Drawing.Size(459, 131);
            this.cartListView.TabIndex = 3;
            this.cartListView.UseCompatibleStateImageBehavior = false;
            this.cartListView.UseSelectable = true;
            this.cartListView.View = System.Windows.Forms.View.Details;
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
            // btn_cart_clear
            // 
            this.btn_cart_clear.Location = new System.Drawing.Point(477, 97);
            this.btn_cart_clear.Name = "btn_cart_clear";
            this.btn_cart_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_cart_clear.TabIndex = 4;
            this.btn_cart_clear.Text = "Clear Cart";
            this.btn_cart_clear.UseSelectable = true;
            this.btn_cart_clear.Click += new System.EventHandler(this.btn_cart_clear_Click);
            // 
            // btn_item_transact
            // 
            this.btn_item_transact.Location = new System.Drawing.Point(626, 382);
            this.btn_item_transact.Name = "btn_item_transact";
            this.btn_item_transact.Size = new System.Drawing.Size(75, 23);
            this.btn_item_transact.TabIndex = 4;
            this.btn_item_transact.Text = "Transact";
            this.btn_item_transact.UseSelectable = true;
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
            // textbox_recieved
            // 
            // 
            // 
            // 
            this.textbox_recieved.CustomButton.Image = null;
            this.textbox_recieved.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.textbox_recieved.CustomButton.Name = "";
            this.textbox_recieved.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_recieved.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_recieved.CustomButton.TabIndex = 1;
            this.textbox_recieved.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_recieved.CustomButton.UseSelectable = true;
            this.textbox_recieved.CustomButton.Visible = false;
            this.textbox_recieved.Lines = new string[] {
        "0"};
            this.textbox_recieved.Location = new System.Drawing.Point(644, 299);
            this.textbox_recieved.MaxLength = 32767;
            this.textbox_recieved.Name = "textbox_recieved";
            this.textbox_recieved.PasswordChar = '\0';
            this.textbox_recieved.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_recieved.SelectedText = "";
            this.textbox_recieved.SelectionLength = 0;
            this.textbox_recieved.SelectionStart = 0;
            this.textbox_recieved.ShortcutsEnabled = true;
            this.textbox_recieved.Size = new System.Drawing.Size(75, 23);
            this.textbox_recieved.TabIndex = 8;
            this.textbox_recieved.Text = "0";
            this.textbox_recieved.UseSelectable = true;
            this.textbox_recieved.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_recieved.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxt_total
            // 
            // 
            // 
            // 
            this.textboxt_total.CustomButton.Image = null;
            this.textboxt_total.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.textboxt_total.CustomButton.Name = "";
            this.textboxt_total.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxt_total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxt_total.CustomButton.TabIndex = 1;
            this.textboxt_total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxt_total.CustomButton.UseSelectable = true;
            this.textboxt_total.CustomButton.Visible = false;
            this.textboxt_total.Lines = new string[] {
        "0"};
            this.textboxt_total.Location = new System.Drawing.Point(643, 270);
            this.textboxt_total.MaxLength = 32767;
            this.textboxt_total.Name = "textboxt_total";
            this.textboxt_total.PasswordChar = '\0';
            this.textboxt_total.ReadOnly = true;
            this.textboxt_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxt_total.SelectedText = "";
            this.textboxt_total.SelectionLength = 0;
            this.textboxt_total.SelectionStart = 0;
            this.textboxt_total.ShortcutsEnabled = true;
            this.textboxt_total.Size = new System.Drawing.Size(75, 23);
            this.textboxt_total.TabIndex = 9;
            this.textboxt_total.Text = "0";
            this.textboxt_total.UseSelectable = true;
            this.textboxt_total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxt_total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_change
            // 
            // 
            // 
            // 
            this.textbox_change.CustomButton.Image = null;
            this.textbox_change.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.textbox_change.CustomButton.Name = "";
            this.textbox_change.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_change.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_change.CustomButton.TabIndex = 1;
            this.textbox_change.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_change.CustomButton.UseSelectable = true;
            this.textbox_change.CustomButton.Visible = false;
            this.textbox_change.Lines = new string[] {
        "0"};
            this.textbox_change.Location = new System.Drawing.Point(644, 326);
            this.textbox_change.MaxLength = 32767;
            this.textbox_change.Name = "textbox_change";
            this.textbox_change.PasswordChar = '\0';
            this.textbox_change.ReadOnly = true;
            this.textbox_change.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_change.SelectedText = "";
            this.textbox_change.SelectionLength = 0;
            this.textbox_change.SelectionStart = 0;
            this.textbox_change.ShortcutsEnabled = true;
            this.textbox_change.Size = new System.Drawing.Size(75, 23);
            this.textbox_change.TabIndex = 10;
            this.textbox_change.Text = "0";
            this.textbox_change.UseSelectable = true;
            this.textbox_change.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_change.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpage_Cashier);
            this.tabControl.Controls.Add(this.tabpage_DashBoard);
            this.tabControl.Controls.Add(this.tabpage_inventory);
            this.tabControl.Location = new System.Drawing.Point(7, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(765, 494);
            this.tabControl.TabIndex = 0;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl.UseSelectable = true;
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
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.tabpage_Cashier.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_qty)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tabpage_inventory;
        private MetroFramework.Controls.MetroTabPage tabpage_DashBoard;
        private MetroFramework.Controls.MetroTabPage tabpage_Cashier;
        private MetroFramework.Controls.MetroTextBox textbox_change;
        private MetroFramework.Controls.MetroTextBox textboxt_total;
        private MetroFramework.Controls.MetroTextBox textbox_recieved;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_received;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_change;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_total;
        private MetroFramework.Controls.MetroButton btn_item_transact;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btn_cart_clear;
        private MetroFramework.Controls.MetroListView cartListView;
        private System.Windows.Forms.ColumnHeader cart_item_id;
        private System.Windows.Forms.ColumnHeader cart_item_name;
        private System.Windows.Forms.ColumnHeader cart_id_price;
        private System.Windows.Forms.ColumnHeader cart_id_qty;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_item_search;
        private MetroFramework.Controls.MetroTextBox textbox_item_search;
        private MetroFramework.Controls.MetroPanel panel_add;
        private System.Windows.Forms.NumericUpDown input_qty;
        private MetroFramework.Controls.MetroButton button_addCart;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroListView itemListView;
        private System.Windows.Forms.ColumnHeader itemID;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.ColumnHeader itemQty;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl tabControl;
    }
}