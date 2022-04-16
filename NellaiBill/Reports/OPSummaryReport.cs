﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class OPSummaryReport : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        ReportDocument cryRpt = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public OPSummaryReport()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            if (cmbCaseType.SelectedItem == "" || cmbCaseType.SelectedItem == null)
            {
                MessageBox.Show("Please Choose CaseType");
                cmbCaseType.Select();
                return;
            }
            if (cmbDoctorName.SelectedItem == "" || cmbDoctorName.SelectedItem == null)
            {
                MessageBox.Show("Please Choose DoctorName");
                cmbDoctorName.Select();
                return;
            }
            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            string path = globalClass.GetReportPath() + "rptOPConsolidated.rpt";
            cryRpt.Load(path);

            cryRpt.SetParameterValue("FromDate", DateTime.Parse(xFromDate));
            cryRpt.SetParameterValue("ToDate", DateTime.Parse(xToDate));
            cryRpt.SetParameterValue("CaseType", cmbCaseType.Text);
            cryRpt.SetParameterValue("CaseType1", cmbCaseType1.Text);
            cryRpt.SetParameterValue("DoctorName", cmbDoctorName.Text);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }

        private void OPSummaryReport_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBoxForReport("select doctor_id,doctor_name from m_doctor", cmbDoctorName, "doctor_id", "doctor_name");
            cmbCaseType.SelectedIndex = 0;
            cmbCaseType1.SelectedIndex = 0;
        }
    }
}
