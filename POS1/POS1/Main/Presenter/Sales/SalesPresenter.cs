using POS1.Main.Model.Sales;
using POS1.Main.View.Sales;
using POS1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1.Main.Presenter.Sales
{
    class SalesPresenter
    {
        private ISalesView mView;
        private SalesModel mModel;

        public SalesPresenter(ISalesView view)
        {
            mView = view;
            mModel = new SalesModel();
        }

        public void initTable()
        {
            DataGridView salesGrid = mView.salesDataGrid;

            salesGrid.ColumnCount = 8;
            salesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            salesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            salesGrid.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            salesGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            salesGrid.Columns[0].Name = "SALES ID";
            salesGrid.Columns[1].Name = "DATE OF TRANSACTION";
            salesGrid.Columns[2].Name = "SUBTOTAL";
            salesGrid.Columns[3].Name = "VAT";
            salesGrid.Columns[4].Name = "TOTAL";
            salesGrid.Columns[5].Name = "DISCOUNT";
            salesGrid.Columns[6].Name = "ITEM(Price per Unit)";
            gridViewCustomListviewColumn customCol = new gridViewCustomListviewColumn();
            salesGrid.Columns.Insert(7, customCol);


        }

        public void getAllSales()
        {
            var salesList = mModel.getAllSales();
            DataGridView salesGrid = mView.salesDataGrid;
            salesGrid.Rows.Clear();

            foreach (var list in salesList)
            {
                //string[] rows = new string[] {
                //    list.Id.ToString(),
                //    DateUtils.changeDateStringFormat(list.dateOfTransaction.ToString(),"yyyyMMdd","yyyy/MM/dd"),
                //    StringUtils.decimalToCurrency(list.subtotalAmount),
                //    StringUtils.decimalToCurrency(list.taxAmount),
                //    StringUtils.decimalToCurrency(list.totalPriceAmount),
                //    StringUtils.decimalToCurrency(list.totalPriceAmount),
                //    "adadadasqe"
                //};
                ListView customList = new ListView();
               
                foreach (var i in mModel.getAllItems(list.Id))
                {
                    customList.Items.Add(i.NAME);
                }
              
                var test = salesGrid.Rows.Add();
                salesGrid.Rows[test].Cells[0].Value = "";
                salesGrid.Rows[test].Cells[1].Value = "";
                salesGrid.Rows[test].Cells[2].Value = "";
                salesGrid.Rows[test].Cells[3].Value = "";
                salesGrid.Rows[test].Cells[4].Value = "";
                salesGrid.Rows[test].Cells[5].Value = "";
                salesGrid.Rows[test].Cells[6].Value = "";
                salesGrid.Rows[test].Cells[7].Value = customList;

            }
        }
    }
}
