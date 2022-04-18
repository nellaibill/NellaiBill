using NellaiBill.Donor;
using NellaiBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Master
{
    public partial class DonorRegistration : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xDonorId;
        GlobalClass globalClass = new GlobalClass();
        public DonorRegistration()
        {
            InitializeComponent();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string xQry = "";
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Choose Name");
                txtName.Focus();
                return;
            }
            if (btnSaveUpdate.Text == "SAVE")
            {

                xQry = "insert into lukes_donor_registration (`donor_name`, `address_line1`, `address_line2`) " +
                    " values ( '" + txtName.Text + "','" + txtAddressLine1.Text + "','" + txtAddressLine2.Text + "')";
            }
            else
            {
                xQry = "update lukes_donor_registration set " +
                    " donor_name = '" + txtName.Text + "', " +
                    " address_line1 = '" + txtAddressLine1.Text + "', " +
                    " address_line2 = '" + txtAddressLine2.Text + "' " +
                    " where  p_donor_id= " + xDonorId + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Saved/Updated");
            LoadGrid();
            DataClear();
        }

      
        private void LoadGrid()
        {
            string xQry = "select p_donor_id as Id,donor_name as Name," +
                "address_line1 as Address1," +
                "address_line2 as Address2, " +
                "phone_no1, " +
                "phone_no2, " +
                "landline_no1, " +
                "landline_no2, " +
                "email_id1, " +
                "email_id2 " +
                "donor_file_name, " +
                "reference, " +
                "related_files " +
                //"donor_annual as Annual, " +
                //"donor_fd as FD, " +
                //"donor_things as Things, " +
                //"donor_welfare as Welfare, " +
                //"support_cs as CS, " +
                //"support_fs as FS, " +
                //"support_bs as BS" +
                " from lukes_donor_registration";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["Name"].Frozen = true;
            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[10].Width = 100;
        }
        private void DataClear()
        {
            txtName.Text = "";
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtMobileNo.Text = "";
            txtWhatsAppNo.Text = "";
            txtLandlineNo1.Text = "";
            txtLandlineNo2.Text = "";
            txtEmailId1.Text = "";
            txtEmailId2.Text = "";
            btnSaveUpdate.Text = "SAVE";
            ptxtPanCard.PlaceholderText = "Enter PanCard No";
            ptxtPanCard.Enabled = false;
            mBtnNew.Enabled = false;
            mbtnImportantDates.Enabled = false;
            mbtnDonationDetails.Enabled = false;
            mbtnFDDetails.Enabled = false;
            mbtnOtherDetails.Enabled = false;
        }

        private void DonorRegistration_Load(object sender, EventArgs e)
        {
            DataClear();
            LoadGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xDonorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            mBtnNew.Enabled = true;
            mbtnImportantDates.Enabled = true;
            mbtnDonationDetails.Enabled = true;
            mbtnFDDetails.Enabled = true;
            mbtnOtherDetails.Enabled = true;
            DataFetch(xDonorId);
            btnSaveUpdate.Text = "UPDATE";
        }
        private void DataFetch(int xDonorId)
        {
            string xQry = "select p_donor_id as Id,donor_name as Name," +
               "address_line1 as Address1," +
               "address_line2 as Address2, " +
               "phone_no1, " +
               "phone_no2, " +
               "landline_no1, " +
               "landline_no2, " +
               "email_id1, " +
               "email_id2, " +
               "donor_file_name, " +
               "reference, " +
               "related_files, " +
               "donor_annual as Annual, " +
               "donor_endowment as FD, " +
               "donor_things as Things, " +
               "donor_welfare as Welfare, " +
               "support_cs as CS, " +
               "support_fs as FS, " +
               "support_bs as BS" +
               " from lukes_donor_registration" +
               " where  p_donor_id= " + xDonorId + "";
            DonorRegistrationResponseModel donorRegistrationResponse = new DonorRegistrationResponseModel();
            donorRegistrationResponse = xDb.GetDonorRegistrationBasedOnQry(xQry);
            txtName.Text =donorRegistrationResponse.Name;
            txtAddressLine1.Text = donorRegistrationResponse.AddressLine1;
            txtAddressLine2.Text = donorRegistrationResponse.AddressLine2;
            txtMobileNo.Text = donorRegistrationResponse.PhoneNo1;
            txtWhatsAppNo.Text = donorRegistrationResponse.PhoneNo2;
            txtLandlineNo1.Text = donorRegistrationResponse.LandlineNo1;
            txtLandlineNo2.Text = donorRegistrationResponse.LandlineNo2;
            txtEmailId1.Text = donorRegistrationResponse.EmailId1;
            txtEmailId2.Text = donorRegistrationResponse.EmailId2;
        }

        private void mBtnNew_Click(object sender, EventArgs e)
        {
            DataClear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "NAME Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void chkDonorEndowment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDonorEndowment.Checked)
            {
                ptxtPanCard.Enabled = true;
            }
            else
            {
                ptxtPanCard.Enabled = false;
                ptxtPanCard.Text = "";
            }
        }

        private void mbtnImportantDates_Click(object sender, EventArgs e)
        {
            DonorImportantDates donorImportantDates = new DonorImportantDates(xDonorId);
            donorImportantDates.ShowDialog();
        }
    }
}
