using POS1.Cashier.Model;
using POS1.Cashier.View;
using POS1.Utils;
using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POS1.Cashier.Presenter
{
    class CashierPresenter
    {
        private ICashierView mVIew;
        private CashierInventoryModel mMOdel;

        public CashierPresenter(ICashierView view)
        {
            mMOdel = new CashierInventoryModel();
            this.mVIew = view;

        }

        public void initTables()
        {
            DataGridView grid = mVIew.cashierItems;

            //CASHIER ITEM TABLE
            grid.ColumnCount = 4;
            grid.Columns[0].Name = "PRODUCT ID";
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[1].Name = "NAME";
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[2].Name = "PRICE PER UNIT";
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[3].Name = "STOCK";
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //CASHIER CART TABLE
            grid = mVIew.cashierCart;
            grid.ColumnCount = 5;
            grid.Columns[0].Name = "PRODUCT ID";
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[1].Name = "NAME";
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[2].Name = "PRICE";
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[3].Name = "QTY";
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewButtonColumn btnAddQty = new DataGridViewButtonColumn();
            btnAddQty.Text = "Add";
            btnAddQty.Width = 40;
            btnAddQty.UseColumnTextForButtonValue = true;
            grid.Columns.Insert(4, btnAddQty);
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewButtonColumn btnMinusQty = new DataGridViewButtonColumn();
            btnMinusQty.Text = "Minus";
            btnMinusQty.Width = 40;
            btnMinusQty.UseColumnTextForButtonValue = true;
            grid.Columns.Insert(5, btnMinusQty);
            grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
        /// <summary>
        ///To get all items in the search depends on the keyword 
        /// </summary>
        /// <param name="keyword"></param>
        public void getAllItems()
        {
            List<CashierInventoryModel> items;
            DataGridView grid = mVIew.cashierItems;

            grid.Rows.Clear();
            string keyword = mVIew.cashierItemSearch;
            if (keyword == null)
            {
                items = mMOdel.getAllItems();
            }
            else
            {
                items = mMOdel.getSearchItems(keyword);
            }

            foreach (CashierInventoryModel model in items)
            {
                string price = mVIew.cashierOptionIsRetail ? model.PRICE.ToString() : model.WHOLESALEPRICE.ToString();
                string[] row = new string[] {
                    model.ID.ToString(),
                    model.NAME,
                    price,
                    model.QTY.ToString()
                };
                grid.Rows.Add(row);
            }

        }

        /// <summary>
        /// For the change of the selected item of the itemlistview
        /// </summary>
        /// <param name="list"></param>
        public void itemSelectedChanged()
        {
            int count = 0;
            int max = 0;
            var list = mVIew.cashierItems.Rows;
            foreach (DataGridViewRow li in list)
            {
                if (li.Selected)
                {
                    max = int.Parse(li.Cells[3].Value.ToString());
                    count++;
                }
            }
            mVIew.onSelectedIndexChanged(count, max);
        }

        /// <summary>
        /// Event for add or minus qty in the cart.
        /// 1 for add
        /// 0 for minus
        /// </summary>
        /// <param name="action"></param>
        public void btnAddMinusQty(int action)
        {
            var cart = mVIew.cashierCart;
            var items = mVIew.cashierItems;

            var idSelected = cart.SelectedRows[0].Cells[0].Value.ToString();
            var qty = int.Parse(cart.SelectedRows[0].Cells[3].Value.ToString());
            try
            {
                var test = items.Rows
               .Cast<DataGridViewRow>()
               .Where(r => r.Cells[0].Value.ToString().Equals(idSelected) && !r.Cells[3].Value.ToString().Equals("0"))
               .First();

                if (action == 1)
                {
                    items.Rows[test.Index].Selected = true;
                    addToCart(1);
                }
                else if (action == -1 && qty > 1)
                {
                    items.Rows[test.Index].Selected = true;
                    addToCart(-1);
                }
            }
            catch
            {
                return;
            }
           
        }

        /// <summary>
        /// For the adding of the item in the cart
        /// </summary>
        /// <param name="itemList"></param>
        /// <param name="qty"></param>
        public void addToCart(int qty)
        {
            bool result = false;
            decimal price = 0;
            DataGridView grid = mVIew.cashierItems;
            int item_id = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());

            if (mMOdel.substractItemQty(item_id, qty))
            {
                result = true;
                price = decimal.Parse(grid.SelectedRows[0].Cells[2].Value.ToString());
                grid.SelectedRows[0].Cells[3].Value = qty.ToString();
            }

            var list = grid.SelectedRows[0];
            bool isThereItemAlready = false;

            foreach (DataGridViewRow li in mVIew.cashierCart.Rows) //To check if the item adding to cart is in there already
            {
                if (list.Cells[0].Value.ToString() == li.Cells[0].Value.ToString())
                {
                    int newQty = int.Parse(li.Cells[3].Value.ToString()) + int.Parse(list.Cells[3].Value.ToString());
                    li.Cells[2].Value = NumberUtils.computePrice(decimal.Parse(list.Cells[2].Value.ToString()), newQty);
                    li.Cells[3].Value = newQty.ToString();
                    isThereItemAlready = true;

                }
            }

            if (result && !isThereItemAlready) //Add item to the cart
            {
                decimal newPrice = NumberUtils.computePrice(decimal.Parse(list.Cells[2].Value.ToString()), int.Parse(list.Cells[3].Value.ToString()));
                string[] row = new string[] {
                    list.Cells[0].Value.ToString(),
                    list.Cells[1].Value.ToString(),
                    newPrice.ToString(),
                    list.Cells[3].Value.ToString()
                };

                mVIew.cashierCart.Rows.Add(row);

            }
            showTotal();
            getAllItems();

        }

        /// <summary>
        /// To clear the cart and updating the item database for the qty
        /// </summary>
        /// <param name="cartList"></param>
        public void clearCart(bool isTransact)
        {
            bool result = true;
            if (!isTransact)
            {
                var cartList = mVIew.cashierCart.Rows;
                foreach (DataGridViewRow li in cartList)
                {
                    if (!mMOdel.addItemQty(int.Parse(li.Cells[0].Value.ToString()), int.Parse(li.Cells[3].Value.ToString())))
                    {
                        result = false;
                    }
                }
            }

            if (result)
            {
                mVIew.cashierTotalPrice = "0";
                mVIew.cashierSubtotalPrice = "0";
                mVIew.cashierVatPrice = "0";
                mVIew.cashierCart.Rows.Clear();
            }
            getAllItems();

        }

        /// <summary>
        /// To show the total price of the transaction
        /// </summary>
        /// <param name="cartList"></param>
        public void showTotal()
        {
            var cartList = mVIew.cashierCart.Rows;
            decimal total = 0;
            decimal vat = 0;
            decimal subtotal = 0;
            foreach (DataGridViewRow li in cartList)
            {
                total += decimal.Parse(li.Cells[2].Value.ToString());
            }
            vat = (total * 0.12m);
            subtotal = total - vat;

            mVIew.cashierTotalPrice = total.ToString();
            mVIew.cashierSubtotalPrice = StringUtils.decimalToCurrency(subtotal);
            mVIew.cashierVatPrice = StringUtils.decimalToCurrency(vat);
        }

        public void doTransact()
        {
            Sales sales = new Sales()
            {
                dateOfTransaction = double.Parse(DateUtils.getStringDateNow("yyyyMMdd")),
                subtotalAmount = StringUtils.currencyToDecimal(mVIew.cashierSubtotalPrice),
                taxAmount = decimal.Parse(mVIew.cashierVatPrice),
                totalPriceAmount = StringUtils.currencyToDecimal(mVIew.cashierTotalPrice),
                totalDiscountAmount = 0,
                moneyPaid = decimal.Parse(mVIew.cashierAmountPaid),
                SalesItem = new List<SalesItem>()
            };

            foreach (DataGridViewRow row in mVIew.cashierCart.Rows)
            {

                sales.SalesItem.Add(new SalesItem()
                {
                    quantitySold = int.Parse(row.Cells[3].Value.ToString()),
                    pricePerUnit = decimal.Parse(row.Cells[2].Value.ToString()) / decimal.Parse(row.Cells[3].Value.ToString()),
                    itemsID = int .Parse(row.Cells[0].Value.ToString())
                });
            }
            decimal change = decimal.Parse(mVIew.cashierAmountPaid) - decimal.Parse(mVIew.cashierTotalPrice);
            mMOdel.addSales(sales);
            clearCart(true);
            mVIew.cashierAmountPaid = "0";
            mVIew.cashierAmountChange = StringUtils.decimalToCurrency(change);
            mVIew.onTransactDone();
        }

    }
}
