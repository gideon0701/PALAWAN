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

            salesGrid.ColumnCount = 7;
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
            CustomColumn listCol = new CustomColumn();
            listCol.HeaderText = "Sales Item";
            salesGrid.Columns.Insert(6, listCol);
           
        }

        public void getAllSales()
        {
            var salesList = mModel.getAllSales();
            DataGridView salesGrid = mView.salesDataGrid;
            salesGrid.Rows.Clear();

            foreach (var list in salesList)
            {
                var row = salesGrid.Rows.Add();
                salesGrid.Rows[row].Cells[0].Value = list.Id.ToString();
                salesGrid.Rows[row].Cells[1].Value = DateUtils.changeDateStringFormat(list.dateOfTransaction.ToString(), "yyyyMMdd", "yyyy/MM/dd");
                salesGrid.Rows[row].Cells[2].Value = StringUtils.decimalToCurrency(list.subtotalAmount);
                salesGrid.Rows[row].Cells[3].Value = StringUtils.decimalToCurrency(list.taxAmount);
                salesGrid.Rows[row].Cells[4].Value = StringUtils.decimalToCurrency(list.totalPriceAmount);
                salesGrid.Rows[row].Cells[5].Value = StringUtils.decimalToCurrency(list.totalDiscountAmount);

                //ListViewItem itemList = new ListViewItem();
                //foreach (var l in mModel.getAllItems(list.Id))
                //{
                //    itemList.SubItems.Add(l.Item1);
                //}
                salesGrid.Rows[row].Cells[6].Value = mModel.getAllItems(list.Id);

            }
            
        }
    }
}
