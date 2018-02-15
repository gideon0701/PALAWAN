using POS1.Main.Model.Inventory;
using POS1.Main.View.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS1.Main.Presenter.Inventory
{
    class InventoryPresenter
    {
        private IInventoryView mVIew;
        private InventoryModel mMOdel;

        public InventoryPresenter(IInventoryView view)
        {
            mMOdel = new InventoryModel();
            mVIew = view;
        }

        public void getAllInventory()
        {
            string searchKeyword = mVIew.inventorySearch;

            if (searchKeyword == null)
            {
                mVIew.inventoryDataGrid.DataSource = mMOdel.getAllInventory();
            }
            else
            {
                mVIew.inventoryDataGrid.DataSource = mMOdel.searchInventory(searchKeyword);
            }
          
        }

        public void deleteItem()
        {
            try
            {
                var item = (InventoryModel)mVIew.inventoryDataGrid.CurrentRow.DataBoundItem;
                mMOdel.deleteItem(item);
                getAllInventory();
                mVIew.onDbActionResult("delete", true);
            }
            catch
            {
                mVIew.onDbActionResult("delete", false);
            }
            
        }

        public void doEdit()
        {
            var item = (InventoryModel)mVIew.inventoryDataGrid.CurrentRow.DataBoundItem;
            mVIew.inventoryID = item.ID.ToString();
            mVIew.inventoryName = item.NAME;
            mVIew.inventoryPrice = item.PRICE.ToString();
            mVIew.inventoryQty = (int) item.QTY;

        }

        public void doAddUpdate()
        {

            if (mVIew.inventoryID == "")
            {
                mMOdel.doAdd(inputToItemModel());
                mVIew.onDbActionResult("add", true);
            }
            else
            {
                Items item = inputToItemModel();
                item.ID = int.Parse(mVIew.inventoryID);
                mMOdel.doEdit(item);
                mVIew.onDbActionResult("edit", true);
            }
            clearFormInput();
            getAllInventory();

        }

        private Items inputToItemModel()
        {
            Items item = new Items
            {
                
                NAME = mVIew.inventoryName,
                PRICE = double.Parse(mVIew.inventoryPrice),
                QTY = mVIew.inventoryQty

            };

            return item;
        }

        private void clearFormInput()
        {
            mVIew.inventoryID = "";
            mVIew.inventoryName = "";
            mVIew.inventoryPrice = "";
            mVIew.inventoryQty = 0;
        }

    }
}
