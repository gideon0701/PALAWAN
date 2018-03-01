using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1.Main.View.Sales
{
    class gridViewCustomListviewColumn : DataGridViewColumn
    {
        public gridViewCustomListviewColumn() : base(new gridViewCustomListviewCell())
        {

        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }

            set
            {
                if (value != null &&
                 !value.GetType().IsAssignableFrom(typeof(gridViewCustomListviewCell)))
                {
                    throw new InvalidCastException("Must be a listview cell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
