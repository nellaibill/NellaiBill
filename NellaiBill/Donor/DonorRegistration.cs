using CrystalDecisions.CrystalReports.Engine;
using NellaiBill.Donor;
using NellaiBill.Models;
using NellaiBill.Models.Donor;
using System;
using System.Data;
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
            string xDeleteString = "";
            int xCategoryId = 1;// Int32.Parse(cmbCategory.SelectedValue.ToString());
            if (btnSaveUpdate.Text == "SAVE")
            {
                if (xDb.CheckDonorMobileNoExists(txtMobileNo.Text))
                {
                    MessageBox.Show("Mobile Number Already Exists");
                    txtMobileNo.Focus();
                    return;
                }
                xQry = "insert into lukes_donor_registration (`donor_name`, `address_line1`, `address_line2`," +
                    "state,country,phone_no1,phone_no2,landline_no1,landline_no2," +
                    "donor_file_name,email_id1,email_id2," +
                    "reference,related_files,pancard,category_id,notes,special_details," +
                    "donor_annual,donor_endowment,donor_things,donor_welfare," +
                    "support_cs,support_fs,support_bs,support_cloth,support_other," +
                    "sr_ooc,sr_ntc,sr_post,sr_visitor,sr_email,greetings_pongal,greetings_easter,greetings_christmas,greetings_others) " +
                    " values ( '" + txtName.Text.Replace("'", "''") + "'," +
                    "'" + rchHomeAddress.Text.Replace("'", "''") + "'," +
                    "'" + rchOfficeAddress.Text.Replace("'", "''") + "'," +
                    "''," +
                    "'" + cmbCountry.SelectedItem + "'," +
                    "'" + txtMobileNo.Text + "'," +
                    "'" + txtWhatsAppNo.Text + "'," +
                    "'" + txtLandLineNo1.Text + "'," +
                    "'" + txtLandLineNo2.Text + "'," +
                    "'" + txtFileName.Text.Replace("'", "''") + "'," +
                    "'" + txtEmailId1.Text.Replace("'", "''") + "'," +
                    "'" + txtEmailId2.Text.Replace("'", "''") + "'," +
                    "'" + txtReference.Text.Replace("'", "''") + "'," +
                    "'" + txtRelatedFiles.Text.Replace("'", "''") + "'," +
                    "'" + txtPanCard.Text.Replace("'", "''") + "'," +
                    "" + xCategoryId + "," +
                    "'" + rchRemarks.Text.Replace("'", "''") + "'," +
                    "'" + txtSpecialDetails.Text.Replace("'", "''") + "'," +
                    "'" + globalClass.getInteger(chkDonorAnnual.Checked) + "'," +
                    "'" + globalClass.getInteger(chkDonorEndowment.Checked) + "'," +
                    "'" + globalClass.getInteger(chkDonorThings.Checked) + "'," +
                    "'" + globalClass.getInteger(chkDonorWelfare.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSupportCS.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSupportFS.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSupportBS.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSupportCloth.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSupportOthers.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSROOC.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSRNTC.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSRPost.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSRVisitor.Checked) + "'," +
                    "'" + globalClass.getInteger(chkSREmail.Checked) + "'," +
                    "'" + globalClass.getInteger(chkPongal.Checked) + "'," +
                    "'" + globalClass.getInteger(chkEaster.Checked) + "'," +
                    "'" + globalClass.getInteger(chkChristmas.Checked) + "'," +
                    "'" + globalClass.getInteger(chkOthers.Checked) + "')";

                xDb.DataProcess(xQry);
                MessageBox.Show("Saved");
                LoadGrid();
                DataClear();
            }
            else
            {
                xQry = "update lukes_donor_registration set " +
                    " donor_name = '" + txtName.Text.Replace("'", "''") + "', " +
                    " address_line1 = '" + rchHomeAddress.Text.Replace("'", "''") + "', " +
                    " address_line2 = '" + rchOfficeAddress.Text.Replace("'", "''") + "', " +
                    " state = '', " +
                    " country = '" + cmbCountry.SelectedItem + "', " +
                    " phone_no1 = '" + txtMobileNo.Text + "', " +
                    " phone_no2 = '" + txtWhatsAppNo.Text + "', " +
                    " landline_no1 = '" + txtLandLineNo1.Text + "', " +
                    " landline_no2 = '" + txtLandLineNo2.Text + "', " +
                    " donor_file_name = '" + txtFileName.Text.Replace("'", "''") + "', " +
                    " email_id1 = '" + txtEmailId1.Text.Replace("'", "''") + "', " +
                    " email_id2 = '" + txtEmailId2.Text.Replace("'", "''") + "', " +
                    " reference = '" + txtReference.Text.Replace("'", "''") + "', " +
                    " related_files = '" + txtRelatedFiles.Text.Replace("'", "''") + "', " +
                    " pancard = '" + txtPanCard.Text.Replace("'", "''") + "', " +
                    " category_id = " + xCategoryId + ", " +
                    " notes = '" + rchRemarks.Text.Replace("'", "''") + "', " +
                    " special_details = '" + txtSpecialDetails.Text.Replace("'", "''") + "', " +
                    " donor_annual = " + globalClass.getInteger(chkDonorAnnual.Checked) + ", " +
                    " donor_endowment = " + globalClass.getInteger(chkDonorEndowment.Checked) + ", " +
                    " donor_things = " + globalClass.getInteger(chkDonorThings.Checked) + ", " +
                    " donor_welfare = " + globalClass.getInteger(chkDonorWelfare.Checked) + ", " +
                    " support_cs = " + globalClass.getInteger(chkSupportCS.Checked) + ", " +
                    " support_fs = " + globalClass.getInteger(chkSupportFS.Checked) + ", " +
                    " support_bs = " + globalClass.getInteger(chkSupportBS.Checked) + ", " +
                    " support_cloth = " + globalClass.getInteger(chkSupportCloth.Checked) + ", " +
                    " support_other = " + globalClass.getInteger(chkSupportOthers.Checked) + ", " +
                    " sr_ooc = " + globalClass.getInteger(chkSROOC.Checked) + ", " +
                    " sr_ntc = " + globalClass.getInteger(chkSRNTC.Checked) + ", " +
                    " sr_post = " + globalClass.getInteger(chkSRPost.Checked) + ", " +
                    " sr_visitor = " + globalClass.getInteger(chkSRVisitor.Checked) + ", " +
                    " sr_email = " + globalClass.getInteger(chkSREmail.Checked) + ", " +
                    " greetings_pongal = " + globalClass.getInteger(chkPongal.Checked) + ", " +
                    " greetings_easter = " + globalClass.getInteger(chkEaster.Checked) + ", " +
                    " greetings_christmas = " + globalClass.getInteger(chkChristmas.Checked) + ", " +
                    " greetings_others = " + globalClass.getInteger(chkOthers.Checked) + " " +
                    " where  p_donor_id= " + xDonorId + "";
                xDb.DataProcess(xQry);
                MessageBox.Show("Updated");
            }
        }
        public void RefreshGrid()
        {
            dataGridView1.DataSource = null;
        }
        public void LoadGrid()
        {
            DonorSettingsModel donorSettingsModelResponse = new DonorSettingsModel();
            donorSettingsModelResponse = xDb.GetDonorSettingsBasedOnQry(1);

            string xFilterQry = "where is_active=1";
            Donor_Helper donor_Helper = new Donor_Helper();
            xFilterQry += donor_Helper.GetDonorFilterQry();

            string xQry = "select p_donor_id as Id," +
                "donor_name as Name," +
                "CONCAT(address_line1) as HomeAddress," +
                "CONCAT(address_line2) as OfficeAddress," +
                "notes as  Notes," +
                "CONCAT(country) as Country," +
                "CONCAT(phone_no1, '-', phone_no2) as PhoneNo," +
                "CONCAT(landline_no1, '-', landline_no2) as LandlineNo," +
                "CONCAT(email_id1, '-', email_id2) as EmailId," +
                "donor_file_name as DonorFileName, " +
                "reference as Reference, " +
                "pancard as PanCard, " +
                "related_files as RelatedFiles " +
                "from lukes_donor_registration " + xFilterQry + " order by p_donor_id desc";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["Name"].Frozen = true;
            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Columns[5].Width = 250;
            dataGridView1.Columns[6].Width = 250;
            dataGridView1.Columns[7].Width = 250;
        }

        private void DataClear()
        {
            globalClass.ClearFormControls(this.groupBox1);
            globalClass.ClearFormControls(this.groupBox2);
            globalClass.ClearFormControls(this.groupBox3);
            globalClass.ClearFormControls(this.groupBox4);
            globalClass.ClearFormControls(this.groupBox6);
            rchRemarks.Clear();
            rchHomeAddress.Clear();
            rchOfficeAddress.Clear();
            LoadGrid();
            cmbCountry.SelectedIndex = 0;
            btnSaveUpdate.Text = "SAVE";
            mbtnImportantDates.Visible = false;
            mbtnDonationDetails.Visible = false;
            mbtnFDDetails.Visible = false;
        }

        private void DonorRegistration_Load(object sender, EventArgs e)
        {
            // xDb.LoadComboBox("select category_id,category_name from m_category", cmbCategory, "category_id", "category_name");
            DataClear();
            LoadGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xDonorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            mbtnImportantDates.Visible = true;
            mbtnDonationDetails.Visible = true;
            mbtnFDDetails.Visible = true;
            DataFetch(xDonorId);
            btnSaveUpdate.Text = "Update";
        }
        private void DataFetch(int xDonorId)
        {
            DonorRegistrationResponseModel donorRegistrationResponse = new DonorRegistrationResponseModel();
            donorRegistrationResponse = xDb.GetDonorRegistrationBasedOnQry(xDonorId);
            txtName.Text = donorRegistrationResponse.Name;
            rchHomeAddress.Text = donorRegistrationResponse.AddressLine1;
            rchOfficeAddress.Text = donorRegistrationResponse.AddressLine2;
            cmbCountry.Text = donorRegistrationResponse.Country;
            txtMobileNo.Text = donorRegistrationResponse.PhoneNo1;
            txtWhatsAppNo.Text = donorRegistrationResponse.PhoneNo2;
            txtLandLineNo1.Text = donorRegistrationResponse.LandlineNo1;
            txtLandLineNo2.Text = donorRegistrationResponse.LandlineNo2;
            txtEmailId1.Text = donorRegistrationResponse.EmailId1;
            txtEmailId2.Text = donorRegistrationResponse.EmailId2;
            txtReference.Text = donorRegistrationResponse.Reference;
            txtFileName.Text = donorRegistrationResponse.DonorFileName;
            txtRelatedFiles.Text = donorRegistrationResponse.RelatedFiles;
            rchRemarks.Text = donorRegistrationResponse.Notes;
            txtSpecialDetails.Text = donorRegistrationResponse.SpecialDetails;
            txtPanCard.Text = donorRegistrationResponse.PanCard;
            //cmbCategory.Text = donorRegistrationResponse.CategoryName;
            chkDonorAnnual.Checked = globalClass.getBoolean(donorRegistrationResponse.DonorAnnual);
            chkDonorEndowment.Checked = globalClass.getBoolean(donorRegistrationResponse.DonorEndowment);
            chkDonorThings.Checked = globalClass.getBoolean(donorRegistrationResponse.DonorThings);
            chkDonorWelfare.Checked = globalClass.getBoolean(donorRegistrationResponse.DonorWelfare);
            chkSupportCS.Checked = globalClass.getBoolean(donorRegistrationResponse.SupportCS);
            chkSupportFS.Checked = globalClass.getBoolean(donorRegistrationResponse.SupportFS);
            chkSupportBS.Checked = globalClass.getBoolean(donorRegistrationResponse.SupportBS);
            chkSupportCloth.Checked = globalClass.getBoolean(donorRegistrationResponse.SupportCloth);
            chkSupportOthers.Checked = globalClass.getBoolean(donorRegistrationResponse.SupportOther);
            chkSROOC.Checked = globalClass.getBoolean(donorRegistrationResponse.SROOC);
            chkSRNTC.Checked = globalClass.getBoolean(donorRegistrationResponse.SRNTC);
            chkSREmail.Checked = globalClass.getBoolean(donorRegistrationResponse.SREmail);
            chkSRPost.Checked = globalClass.getBoolean(donorRegistrationResponse.SRPost);
            chkSRVisitor.Checked = globalClass.getBoolean(donorRegistrationResponse.SRVisitor);
            chkPongal.Checked = globalClass.getBoolean(donorRegistrationResponse.GreetingsPongal);
            chkEaster.Checked = globalClass.getBoolean(donorRegistrationResponse.GreetingsEaster);
            chkChristmas.Checked = globalClass.getBoolean(donorRegistrationResponse.GreetingsChristmas);
            chkOthers.Checked = globalClass.getBoolean(donorRegistrationResponse.GreetingsOthers);
        }

        private void mBtnNew_Click(object sender, EventArgs e)
        {
            DataClear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "Name Like '%" + txtSearch.Text
                 + "%' OR HomeAddress LIKE '%" + txtSearch.Text
                 + "%' OR OfficeAddress LIKE '%" + txtSearch.Text
                 + "%' OR PhoneNo LIKE '%" + txtSearch.Text
                 + "%' OR EmailId LIKE '%" + txtSearch.Text
                 + "%' OR DonorFileName LIKE '%" + txtSearch.Text
                 + "%' OR Reference LIKE '%" + txtSearch.Text
                 + "%' OR PanCard LIKE '%" + txtSearch.Text
                 + "%' OR Notes LIKE '%" + txtSearch.Text
                 + "%' OR RelatedFiles LIKE '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void mbtnImportantDates_Click(object sender, EventArgs e)
        {
            DonorImportantDates donorImportantDates = new DonorImportantDates(xDonorId);
            donorImportantDates.ShowDialog();
        }

        private void mbtnFDDetails_Click(object sender, EventArgs e)
        {
            FDDetails fDDetails = new FDDetails(xDonorId);
            fDDetails.ShowDialog();
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            globalClass.AcceptOnlyNumeric(e);
        }

        private void txtWhatsAppNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            globalClass.AcceptOnlyNumeric(e);
        }

        private void txtLandlineNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            globalClass.AcceptOnlyNumeric(e);
        }

        private void txtLandlineNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            globalClass.AcceptOnlyNumeric(e);

        }

        private void DonorRegistration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                DataClear();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSaveUpdate.PerformClick();
            }
        }

        private void mbtnDonationDetails_Click(object sender, EventArgs e)
        {
            DonationDetails donationDetails = new DonationDetails(xDonorId);
            donationDetails.ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void mbtnOtherDetails_Click_1(object sender, EventArgs e)
        {
            OtherDetails otherDetails = new OtherDetails(xDonorId);
            otherDetails.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void DonorRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "Do you want to close", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }


        private void pBtnPrint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                ReportDocument reportDocument = new ReportDocument();
                GlobalClass globalClass = new GlobalClass();
                string path = globalClass.GetReportPath() + "rptDonorInfo.rpt";
                reportDocument.Load(path);
                reportDocument.SetParameterValue("DonorId", xDonorId);
                reportDocument.PrintToPrinter(1, true, 0, 0);
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }

        private void pBtnFilter_Click(object sender, EventArgs e)
        {
            DonorFilter donorFilter = new DonorFilter();
            donorFilter.ShowDialog();
            DataClear();
            this.LoadGrid();
        }

        private void pBtnNew_Click(object sender, EventArgs e)
        {
            DataClear();
        }

        private void pBtnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                string xQry = "delete from lukes_donor_registration where  p_donor_id= " + xDonorId + "";
                xDb.DataProcess(xQry);
                MessageBox.Show("Record Deleted");
                LoadGrid();
                DataClear();
            }

        }

        private void pBtnPrevious_Click(object sender, EventArgs e)
        {
            xDonorId = xDonorId - 1;
            if (xDonorId == 0)
            {
                MessageBox.Show("You have reached the first donor");
            }
            else
            {
                DataFetch(xDonorId);
            }
        }

        private void pBtnNext_Click(object sender, EventArgs e)
        {
            xDonorId = xDonorId + 1;
            int xMaxDonorId = Convert.ToInt32(xDb.GetMaxId("p_donor_id", "lukes_donor_registration").ToString());
            if (xDonorId == xMaxDonorId)
            {
                MessageBox.Show("You have reached the last donor");
            }
            else
            {
                DataFetch(xDonorId);
            }
        }

        private void DonorRegistration_Leave(object sender, EventArgs e)
        {
            // MessageBox.Show("Leaving");
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }
    }
}

