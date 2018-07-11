using POS1.Main.View.Sales;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1.Main.Presenter.Sales
{
    class CustomColumn : DataGridViewColumn
    {
        public CustomColumn() : base(new CustomCell())
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
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(CustomCell)))
                {
                    throw new InvalidCastException("Must be a CustomCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class CustomCell : DataGridViewTextBoxCell
    {

        public CustomCell() : base()
        {
          
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            ListEditingControl ctl = DataGridView.EditingControl as ListEditingControl;

            ctl.View = System.Windows.Forms.View.List;
            ctl.Bounds = new Rectangle(new Point(0, 0), new Size(100, 100));
            //ctl.Columns.Add("product");
            InitializeListView(ctl, (ICollection)this.FormattedValue);
           
        }

        private void InitializeListView(ListView ctrl, ICollection value)
        {
            ctrl.Items.Clear();
            foreach (object obj in value)
            {

                ListViewItem items = new ListViewItem(obj.ToString());
                ctrl.Items.Add(items);
            }
            ctrl.Tag = this.Value;
        }

        public override Type EditType
        {
            get
            {
                // Return the type of the editing control that CalendarCell uses.
                return typeof(ListEditingControl);
            }
        }

        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, System.ComponentModel.TypeConverter valueTypeConverter, System.ComponentModel.TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            if (value == null)
            {
                return new List<object>();
            }
            return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
        }

        public override Type FormattedValueType
        {
            get
            {
                return typeof(ICollection);
            }
        }

        public override Type ValueType
        {
            get
            {
                return typeof(ICollection);
            }
        }
        private ListView internalControl;

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            graphics.FillRectangle(new SolidBrush(cellStyle.BackColor), cellBounds);
            if (internalControl == null)
            {
                internalControl = new ListView();
                internalControl.View = System.Windows.Forms.View.List;
                //internalControl.Bounds = new Rectangle(new Point(0, 0), new Size(200, 200));
            }
            internalControl.Items.Clear();
            ICollection collection = value as ICollection;
            if (collection != null)
            {
               
                foreach (object obj in collection)
                {
                    ListViewItem items = new ListViewItem(obj.ToString());
                    internalControl.Items.Add(items);
                }

                Bitmap bmp = new Bitmap(cellBounds.Width, cellBounds.Height);
                internalControl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                graphics.DrawImage(bmp, cellBounds, new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
            }
        }

        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            this.DataGridView.BeginEdit(false);
            base.OnClick(e);
        }
    }
}
