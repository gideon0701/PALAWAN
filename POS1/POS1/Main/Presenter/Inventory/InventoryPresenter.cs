using POS1.Main.Model.Inventory;
using POS1.Main.View.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mVIew.inventoryWholesalePrice = item.WHOLESALEPRICE.ToString();
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
                item.ID = mVIew.inventoryID;
                mMOdel.doEdit(item);
                mVIew.onDbActionResult("edit", true);
            }
            clearFormInput();
            getAllInventory();

        }

        public void generateBarcode()
        {
            var selectedItem = (InventoryModel)mVIew.inventoryDataGrid.CurrentRow.DataBoundItem;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var image = barcode.Draw(selectedItem.ID, 50);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PNG|*.png|JPEG|*.jpg";
            saveFile.Title = "Save barcode";
            saveFile.FileName = selectedItem.NAME + " (Barcode)";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFile.OpenFile();
                switch (saveFile.FilterIndex)
                {
                    case 1:

                        image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:

                        image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
                fs.Close();
            }

        }

        private Items inputToItemModel()
        {
            Items item = new Items
            {
                NAME = mVIew.inventoryName,
                PRICE = decimal.Parse(mVIew.inventoryPrice),
                QTY = mVIew.inventoryQty,
                WHOLESALEPRICE = decimal.Parse(mVIew.inventoryWholesalePrice)

            };

            return item;
        }

        private void clearFormInput()
        {
            mVIew.inventoryID = "";
            mVIew.inventoryName = "";
            mVIew.inventoryPrice = "";
            mVIew.inventoryWholesalePrice = "";
            mVIew.inventoryQty = 0;
        }

    }
}
