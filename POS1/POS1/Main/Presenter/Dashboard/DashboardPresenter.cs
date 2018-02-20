using POS1.Main.Model.Dashboard;
using POS1.Main.View.Dashboard;
using POS1.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            fillMonthlyChart();

        }

        private void setCombobox()
        {
            //FOR DROPDOWN YEAR
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

            //FOR DROPDOWN MONTH
            mView.dashboardDropdownMonthly.Items.Clear();
            var months = mModel.getAllMonths();
            foreach (string s in months)
            {
                mView.dashboardDropdownMonthly.Items.Add(new ComboboxItem() { Text = DateUtils.getMonthName(s), Value = DateUtils.getMonthName(s)});
            }
            if (months.Count <= 0)
            {
                mView.dashboardDropdownMonthly.Items.Add(new ComboboxItem() { Text = "", Value = "" });
            }
            mView.dashboardDropdownMonthly.SelectedIndex = 0;
            
        }

        public void fillMonthlyChart()
        {
            string[] weeks = new string[] { "1st Week", "2nd Week", "3rd Week", "4th Week" };
            Chart monthlyChart = mView.dashboardChartMonthly;
            ComboBox monthlyDropdown = mView.dashboardDropdownMonthly;
            ComboBox yearlyDropdown = mView.dashboardDropdownYearly;
            monthlyChart.Series["Sales"].Points.Clear();
            monthlyChart.Series["Sales"].ToolTip = "#VAL";
            monthlyChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            int count = 0;
            string month = DateUtils.getMonthNumber((monthlyDropdown.SelectedItem as ComboboxItem).Value.ToString());
            string year = (yearlyDropdown.SelectedItem as ComboboxItem).Value.ToString();
            var weeklaySales = mModel.getWeeklySales(month, year);
            foreach (var week in weeks)
            {
                if (month != "")
                {
                    monthlyChart.Series["Sales"].Points.AddXY(week, weeklaySales[count]);
                }

                count++;
            }

        }

        public void fillYearlyChart()
        {
            string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", };
            Chart yearlyChart = mView.dashboardChartYearly;
            ComboBox yearlyDropdown = mView.dashboardDropdownYearly;
            yearlyChart.Series["Sales"].Points.Clear();
            yearlyChart.Series["Sales"].ToolTip = "#VAL";
            yearlyChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            int count = 0;
            string year =  (yearlyDropdown.SelectedItem as ComboboxItem).Value.ToString();
            var monthlySales = mModel.getMonthlySales(year);
            foreach (var month in months)
            {
                if (year != "")
                {
                    yearlyChart.Series["Sales"].Points.AddXY(month, monthlySales[count]);
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
