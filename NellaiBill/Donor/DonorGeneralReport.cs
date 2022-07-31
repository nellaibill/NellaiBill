using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using NellaiBill.Models.Donor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            GridValidationControls();
           // xDb.LoadComboBoxForReport("select category_id,category_name from m_category", cmbCategory, "category_id", "category_name");
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
            //int xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            string xCountryName = cmbCountry.SelectedItem.ToString();
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
            lblTotalCount.Text = GetDataGridCount().ToString();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DonorFilter donorFilter = new DonorFilter();
            donorFilter.ShowDialog();
            this.LoadGrid();
        }

        private void btnDataGridPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnLoadGrid_Click(object sender, EventArgs e)
        {
            GridValidationControls();
            LoadGrid();
        }
        private void GridValidationControls()
        {
            dataGridView1.Visible = true;
            txtSearch.Visible = true;
            lblSearch.Visible = true;
            crystalReportViewer1.Visible = false;
        }
        private void CrystalReportValidationControls()
        {
            dataGridView1.Visible = false;
            crystalReportViewer1.Visible = true;
            txtSearch.Visible = false;
            lblSearch.Visible = false;
        }
        private int  GetDataGridCount()
        {
            int xCount = 1;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                xCount += 1;
            }
            return xCount;
        }

        private void btnAddressPrint_Click(object sender, EventArgs e)
        {
            CrystalReportValidationControls();
          
            string xCountryName = cmbCountry.SelectedItem.ToString();
            string xFilterPrintViewQry = "";
         
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
        }
    }
 
}
