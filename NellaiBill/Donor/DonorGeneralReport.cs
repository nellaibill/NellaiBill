using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Donor
{
    public partial class DonorGeneralReport : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xDonorId;
        string xFilterQry = "";
        GlobalClass globalClass = new GlobalClass();
        string xFormName = "";
        public DonorGeneralReport(string formName)
        {
            InitializeComponent();
            xFormName = formName;
            lblGeneralReportTitle.Text = xFormName;
        }

        private void DonorGeneralReport_Load(object sender, EventArgs e)
        {
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
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void LoadGrid()
        {
            string xQry;
            int xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            if (xCategoryId == 0)
            {
                xFilterQry = " and c.category_id>=0";
            }
            else
            {
                xFilterQry = " and c.category_id = " + xCategoryId;
            }
            if (xFormName == "CategoryReport")
            {
                xQry = "select p_donor_id as Id," +
                            "c.category_name as CategoryName," +
                            "donor_name as Name," +
                            "CONCAT(address_line1, '-', address_line2, '-', state, '-', country) as Address," +
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
                                      "CONCAT(address_line1, '-', address_line2, '-', state, '-', country) as Address," +
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
            int xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            if (xCategoryId != 0)
            {
                xFilterQry = "and d.category_id=" + xCategoryId;
            }
            else
            {
                xFilterQry = "";
            }
            LoadGrid();
        }
    }
}
