using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Reports
{
    public partial class SalesReturnReport : Form
    {
        ReportDocument cryRpt = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public SalesReturnReport()
        {
            InitializeComponent();
        }

        private void CR_SalesReturn_Load(object sender, EventArgs e)
        {
            string path = globalClass.GetReportPath() + "rptSalesReturn.rpt";
            cryRpt.Load(path);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }
    }
}
