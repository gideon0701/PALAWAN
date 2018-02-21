using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS1.Main.View.Dashboard
{
    interface IDashboardView
    {
        Chart dashboardChartYearly { get; set; }
        Chart dashboardChartMonthly { get; set; }
        Chart dashboardChartProductYearly { get; set; }
        ComboBox dashboardDropdownYearly { get; set; }
        ComboBox dashboardDropdownMonthly { get; set; }
    }
}
