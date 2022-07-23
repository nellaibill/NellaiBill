using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using NellaiBill.Models.Donor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NellaiBill.Donor
{
    public partial class DonorGeneralReport : Form
    {
        ReportDocument cryRpt = new ReportDocument();
        DatabaseConnection xDb = new DatabaseConnection();
        GlobalClass xGlobalClass = new GlobalClass();
        int xDonorId;
        string xFilterQry = "";
        GlobalClass globalClass = new GlobalClass();
        Donor_Helper donor_Helper = new Donor_Helper();
        string xFormName = "";
        public DonorGeneralReport(string formName)
        {
            InitializeComponent();
            xFormName = formName;
            lblGeneralReportTitle.Text = xFormName;
        }

        private void DonorGeneralReport_Load(object sender, EventArgs e)
        {
            cmbCountry.Text = "All";
            dataGridView1.Visible = false;
            xDb.LoadComboBoxForReport("select category_id,category_name from m_category", cmbCategory, "category_id", "category_name");
            LoadGrid();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "Name Like '%" + txtSearch.Text
            + "%' OR Address LIKE '%" + txtSearch.Text
            + "%' OR State LIKE '%" + txtSearch.Text
            + "%' OR Country LIKE '%" + txtSearch.Text
            + "%' OR PhoneNo LIKE '%" + txtSearch.Text
            + "%' OR LandLineNo LIKE '%" + txtSearch.Text
            + "%' OR EmailId LIKE '%" + txtSearch.Text
            + "%' OR DonorFileName LIKE '%" + txtSearch.Text
            + "%' OR Reference LIKE '%" + txtSearch.Text
            + "%' OR RelatedFiles LIKE '%" + txtSearch.Text + "%'";
            //string xFilterSearch = "NAME Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void LoadGrid()
        {
            string xQry;
            int xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            string xCountryName = cmbCountry.SelectedItem.ToString();
            if (xCategoryId == 0)
            {
                xFilterQry = " and c.category_id>=0";
            }
            else
            {
                xFilterQry = " and c.category_id = " + xCategoryId;
            }
            if (xCountryName == "All")
            {

            }
            else
            {
                xFilterQry = " and d.country = '" + xCountryName + "'";
            }

            DonorSettingsModel donorSettingsModelResponse = new DonorSettingsModel();
            donorSettingsModelResponse = xDb.GetDonorSettingsBasedOnQry(1);

            Donor_Helper donor_Helper = new Donor_Helper();
            xFilterQry += donor_Helper.GetDonorFilterQry();

            if (xFormName == "CategoryReport")
            {
                xQry = "select p_donor_id as Id," +
                            "c.category_name as CategoryName," +
                            "donor_name as Name," +
                            "CONCAT(address_line1, '-', address_line2) as Address," +
                            "state as State," +
                            "country as Country," +
                            "CONCAT(phone_no1, '-', phone_no2) as PhoneNo," +
                            "CONCAT(landline_no1, '-', landline_no2) as LandLineNo," +
                            "CONCAT(email_id1, '-', email_id2) as EmailId," +
                            "donor_file_name as DonorFileName, " +
                            "reference as Reference, " +
                            "related_files as RelatedFiles " +
                            "from lukes_donor_registration as d,m_category c where c.category_id = d.category_id" + xFilterQry + " order by p_donor_id desc";
                xDb.LoadGrid(xQry, dataGridView1);
                xDb.LoadGridToWord(xQry, "Name", "Address", donor_Helper.donorNames, donor_Helper.donorAddress);
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AutoSize = false;
                dataGridView1.ScrollBars = ScrollBars.Both;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["Name"].Frozen = true;
                dataGridView1.Columns["Name"].Width = 150;
                dataGridView1.Columns[1].Width = 300;
                dataGridView1.Columns[2].Width = 300;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 250;
                dataGridView1.Columns[6].Width = 250;
                dataGridView1.Columns[7].Width = 250;
                dataGridView1.Columns[8].Width = 250;
                dataGridView1.Columns[9].Width = 250;
                dataGridView1.Columns[10].Width = 250;
            }
            else if (xFormName == "PanCardReport")
            {
                xQry = "select p_donor_id as Id," +
                                      "c.category_name as CategoryName," +
                                      "donor_name as Name," +
                                      "pancard as PanCard," +
                                      "CONCAT(address_line1, '-', address_line2) as Address," +
                                      "state as State," +
                                      "country as Country," +
                                      "CONCAT(phone_no1, '-', phone_no2) as PhoneNo," +
                                      "CONCAT(landline_no1, '-', landline_no2) as LandLineNo," +
                                      "CONCAT(email_id1, '-', email_id2) as EmailId," +
                                      "donor_file_name as DonorFileName, " +
                                      "reference as Reference, " +
                                      "related_files as RelatedFiles " +
                                      "from lukes_donor_registration as d,m_category c where c.category_id = d.category_id and pancard!='' " + xFilterQry + " order by p_donor_id desc";
                xDb.LoadGrid(xQry, dataGridView1);
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AutoSize = false;
                dataGridView1.ScrollBars = ScrollBars.Both;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["Name"].Frozen = true;
                dataGridView1.Columns["Name"].Width = 150;
                dataGridView1.Columns[1].Width = 300;
                dataGridView1.Columns[2].Width = 300;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 250;
                dataGridView1.Columns[6].Width = 250;
                dataGridView1.Columns[7].Width = 250;
                dataGridView1.Columns[8].Width = 250;
                dataGridView1.Columns[9].Width = 250;
                dataGridView1.Columns[10].Width = 250;
            }
            else if (xFormName == "FDReport")
            {
                xQry = "select f.f_donor_id as Id,p.donor_name,f.date as Date,f.amount as Amount,f.bank as Bank, f.purpose as Purpose,f.remarks as Remarks  " +
                    " from lukes_donor_registration p," +
                    " lukes_donor_fd_details f " +
                    "where p.p_donor_id = f.f_donor_id";

                xDb.LoadGrid(xQry, dataGridView1);
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AutoSize = false;
                dataGridView1.ScrollBars = ScrollBars.Both;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 300;
                dataGridView1.Columns[5].Width = 300;
            }
            else if (xFormName == "DonationDetailsReport")
            {
                xQry = "select f_donor_id as Id,date as Date,amount as Amount,channel as Channel, purpose as Purpose,remarks as Remarks from lukes_donor_donation_details";
                xDb.LoadGrid(xQry, dataGridView1);
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AutoSize = false;
                dataGridView1.ScrollBars = ScrollBars.Both;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 300;
                dataGridView1.Columns[5].Width = 300;
            }

        }
        private void btnImpDateReportLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            txtSearch.Visible = true;
            lblSearch.Visible = true;
            crystalReportViewer1.Visible = false;
            /*  reportViewer1.Visible = false;
              int xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
              if (xCategoryId != 0)
              {
                  xFilterQry = "and d.category_id=" + xCategoryId;
              }
              else
              {
                  xFilterQry = "";
              }*/

            LoadGrid();
            int xCount = 1;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                xCount += 1;
            }
            lblTotalCount.Text = xCount.ToString();
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            crystalReportViewer1.Visible = true;
            txtSearch.Visible = false;
            lblSearch.Visible = false;
            int xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            string xCountryName = cmbCountry.SelectedItem.ToString();
            string xFilterPrintViewQry = "";
            if (xCategoryId == 0)
            {
                xFilterPrintViewQry = " and c.category_id>=0";
            }
            else
            {
                xFilterPrintViewQry = " and c.category_id = " + xCategoryId;
            }
            if (xCountryName == "All")
            {

            }
            else
            {
                xFilterPrintViewQry = " and d.country = '" + xCountryName + "'";
            }


            DonorSettingsModel donorSettingsModelResponse = new DonorSettingsModel();
            donorSettingsModelResponse = xDb.GetDonorSettingsBasedOnQry(1);

            Donor_Helper donor_Helper = new Donor_Helper();
            xFilterPrintViewQry += donor_Helper.GetDonorFilterQry();

            string path = globalClass.GetReportPath() + "rptDonorAddress.rpt";
            cryRpt.Load(path);
            cryRpt.SetParameterValue("xFilterQry", xFilterPrintViewQry);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            /* //TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            //TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            //ConnectionInfo crConnectionInfo = new ConnectionInfo();
            //CrystalDecisions.CrystalReports.Engine.Tables CrTables;
            cryRpt.Load(path);

            foreach (CrystalDecisions.Shared.IConnectionInfo connection in cryRpt.DataSourceConnections)
            {
                connection.IntegratedSecurity = true;
                for (int i = 0; i < cryRpt.DataSourceConnections.Count; i++)
                {
                    cryRpt.DataSourceConnections[i].SetConnection("localhost", "nellaibill", "root", "");

                }
            }
            //crConnectionInfo.ServerName = "dsn_32_ansi_nellaibill";
            //crConnectionInfo.DatabaseName = "nellaibill";
            //crConnectionInfo.UserID = "root";
            //crConnectionInfo.Password = "nellaibill";
            //CrTables = cryRpt.Database.Tables;
            //foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            //{
            //    crtableLogoninfo = CrTable.LogOnInfo;
            //    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            //    CrTable.ApplyLogOnInfo(crtableLogoninfo);
            //}
           */

            //crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
            //xGlobalClass.CreateDocument(donor_Helper.donorNames, donor_Helper.donorAddress);
        }
        private List<DataSet1> getData()
        {
            List<DataSet1> datas = new List<DataSet1>();

            DataSet Dataset1 = new DataSet();
            string xQry = "select " +
                            "CONCAT(donor_name, '- ' ,address_line1, '-', address_line2) as Address " +
                            "from lukes_donor_registration as d,m_category c where c.category_id = d.category_id" + xFilterQry + " order by p_donor_id desc";
            using (MySqlConnection conn = new MySqlConnection(xDb.GetConnectionString()))
            {
                using MySqlDataAdapter adapter = new MySqlDataAdapter(xQry, conn);
                adapter.Fill(Dataset1);
            }

            int xRowCount = 0;
            System.Data.DataTable dt = Dataset1.Tables[0];
            // return dt;
            foreach (DataRow row in dt.Rows)
            {
                DataSet1 data = new DataSet1();
                data.x = row["Address"].ToString();
                //xRowCount += 1;
                //if (xRowCount % 2 == 0)
                //{
                //    data.x = row["Address"].ToString();
                //}
                //else
                //{
                //    data.y = row["Address"].ToString();
                //}
                datas.Add(data);
            }
            return datas;
        }

        private void runRptViewer()
        {
            /*
            this.reportViewer1.Reset();
            string appPath = System.Windows.Forms.Application.StartupPath;
            this.reportViewer1.LocalReport.ReportPath = appPath + @"/donor_report1.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", getData());
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.DataBind();
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();*/
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DonorFilter donorFilter = new DonorFilter();
            donorFilter.ShowDialog();
            this.LoadGrid();
        }
    }
    public class DataSet1
    {
        public string x
        {
            get; set;
        }

    }
}
