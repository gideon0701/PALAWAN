using POS1.Main.Model.Dashboard;
using POS1.Main.View.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS1.Main.Presenter.Dashboard
{
    class DashboardPresenter
    {
        private IDashboardView mView;
        private DashboardModel mModel;
        private string[] months = new string[] {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec",};

        public DashboardPresenter(IDashboardView view)
        {
            //mMOdel = new CashierInventoryModel();
            this.mView = view;
            mModel = new DashboardModel();
        }

        public void initDashboard()
        {
            setCombobox();
            fillYearlyChart();
        }

        private void setCombobox()
        {
            mView.dashboardDropdownYearly.Items.Clear();

            var years = mModel.getAllYear();
            
            foreach (string s in years)
            {
                mView.dashboardDropdownYearly.Items.Add(new ComboboxItem() { Text = s, Value = s });
            }
            if (years.Count <= 0)
            {
                mView.dashboardDropdownYearly.Items.Add(new ComboboxItem() { Text = "", Value = "" });
            }

            mView.dashboardDropdownYearly.SelectedIndex = 0;
        }

        public void fillYearlyChart()
        {
            Chart yearlyChart = mView.dashboardChartYearly;
            ComboBox yearlyDropdown = mView.dashboardDropdownYearly;
            yearlyChart.Series["Sales"].Points.Clear();
            int count = 0;
            string year =  (yearlyDropdown.SelectedItem as ComboboxItem).Value.ToString();
            var monthlySales = mModel.getMonthlySales(year);
            foreach (var month in months)
            {
                if (year != "")
                {
                    mView.dashboardChartYearly.Series["Sales"].Points.AddXY(month, monthlySales[count]);
                }
                else
                {
                    mView.dashboardChartYearly.Series["Sales"].Points.AddXY(month, "0");
                }
                count++;
            }

        }

    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
