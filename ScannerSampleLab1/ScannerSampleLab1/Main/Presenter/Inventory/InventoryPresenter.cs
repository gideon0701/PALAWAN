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

    }
}
