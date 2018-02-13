using ScannerSampleLab1.Main.Model.Inventory;
using ScannerSampleLab1.Main.View.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerSampleLab1.Main.Presenter.Inventory
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
            
            mVIew.inventoryDataGrid.DataSource = mMOdel.getAllInventory();
        }

        public void deleteItem()
        {
            var item = (Items) mVIew.inventoryDataGrid.CurrentRow.DataBoundItem;
            mMOdel.deleteItem(item);

            getAllInventory();
        }

        public void doAddUpdate()
        {

            if (mVIew.inventoryID == "")
            {
                mMOdel.doAdd(inputToModel());
            }
           
            getAllInventory();

        }

        private Items inputToModel()
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
