using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1.Main.View.Sales
{
    class gridViewCustomListviewCell : DataGridViewTextBoxCell
    {
        public gridViewCustomListviewCell() : base()
        {

        }

        public override void InitializeEditingControl(int rowIndex, object
         initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            ListView ctl =
                DataGridView.EditingControl as ListView;
            // Use the default row value when Value property is null.
            if (this.Value == null)
            {
                ListViewItem list = new ListViewItem();
                list.SubItems.Add("");
                ListView listview = new ListView();
                listview.Items.Add(list);
                ctl = listview;
            }
            else
            {
                ctl = (ListView) Value;
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                // Use the current date and time as the default value.
                return null;
            }
        }

    }
}
