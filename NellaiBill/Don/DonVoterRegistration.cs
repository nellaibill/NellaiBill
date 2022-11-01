using NellaiBill.Common;
using NellaiBill.Models.Don;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Don
{
    public partial class DonVoterRegistration : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xCandidateId;
        GlobalClass globalClass = new GlobalClass();
        public DonVoterRegistration()
        {
            InitializeComponent();
        }

        private void DonVoterRegistration_Load(object sender, EventArgs e)
        {
            LoadGrid();
            xDb.LoadComboBoxV2("city", cmbCity);
            xDb.LoadComboBoxV2("district", cmbDistrict);
            xDb.LoadComboBoxV2("pincode", cmbPincode);
            xDb.LoadComboBoxV2("assembly", cmbAssembly);
            xDb.LoadComboBoxV2("ward", cmbWard);
            xDb.LoadComboBoxV2("subward", cmbSubWard);

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
        private void DataFetch(int xCandidateId)
        {
            DonRegistrationResponseModal donRegistrationResponseModal = new DonRegistrationResponseModal();
            donRegistrationResponseModal = xDb.GetDonRegistrationBasedOnQry(xCandidateId);
            txtFamilyHeadName.Text = donRegistrationResponseModal.Name;
            cmbGender.SelectedItem = donRegistrationResponseModal.Gender;
            txtAge.Text = donRegistrationResponseModal.Age;
            txtDoorNo.Text = donRegistrationResponseModal.DoorNo;
            txtAddressLine1.Text = donRegistrationResponseModal.AddressLine1;
            txtAddressLine2.Text = donRegistrationResponseModal.AddressLine2;
            cmbCity.SelectedValue = donRegistrationResponseModal.City;
            cmbDistrict.SelectedValue = donRegistrationResponseModal.District;
            cmbPincode.SelectedValue = donRegistrationResponseModal.PinCode;
            cmbAssembly.SelectedValue = donRegistrationResponseModal.Assembly;
            cmbWard.SelectedValue = donRegistrationResponseModal.Ward;
            cmbSubWard.SelectedValue = donRegistrationResponseModal.Subward;
            txtEpic.Text = donRegistrationResponseModal.EpicNumber;
        }
        public void LoadGrid()
        {
            string xQry = "select id,candidate_name,epic_number,mobile_number,gender,age,city_name,district_name,pincode_number as pincode,ward_name,subward_name" +
                " from candidates ca, city c, district d, pincode p, assembly a, ward w, subward sw where ca.city_id = c.city_id " +
                " and ca.district_id = d.district_id " +
                " and ca.pincode_id = p.pincode_id " +
                " and ca.assembly_id = a.assembly_id " +
                " and ca.ward_id = w.ward_id " +
                " and ca.subward_id = sw.subward_id " +
                " order by id desc ";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "candidate_name Like '%" + txtSearch.Text
                 + "%' OR epic_number LIKE '%" + txtSearch.Text
                 + "%' OR mobile_number LIKE '%" + txtSearch.Text
                 + "%' OR gender LIKE '%" + txtSearch.Text
                 + "%' OR city_name LIKE '%" + txtSearch.Text
                 + "%' OR district_name LIKE '%" + txtSearch.Text
                // + "%' OR pincode_number LIKE '%" + txtSearch.Text
                 + "%' OR ward_name LIKE '%" + txtSearch.Text
                 + "%' OR subward_name LIKE '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string xQry = "";
            if (txtFamilyHeadName.Text == "")
            {
                MessageBox.Show("Please Choose Name");
                txtFamilyHeadName.Focus();
                return;
            }
            if (cmbCity.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose City");
                cmbCity.Focus();
                return;
            }
            if (cmbDistrict.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose District");
                cmbDistrict.Focus();
                return;
            }
            if (cmbPincode.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose PinCode");
                cmbPincode.Focus();
                return;
            }
            if (cmbAssembly.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Assembly");
                cmbAssembly.Focus();
                return;
            }
            if (cmbWard.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Ward");
                cmbWard.Focus();
                return;
            }
            if (cmbSubWard.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose SubWard");
                cmbSubWard.Focus();
                return;
            }
            if (btnSaveUpdate.Text == "Save")
            {
                xQry = "insert into candidates (`candidate_name`, `gender`, `age`,mobile_number," +
                  "addr_door_no,addr_line1,addr_line2," +
                  "city_id,district_id,pincode_id,assembly_id,ward_id,subward_id," +
                  "epic_number) " +
                  " values ( '" + txtFamilyHeadName.Text.Replace("'", "''") + "'," +
                  "'" + cmbGender.Text.Replace("'", "''") + "'," +
                  "'" + txtAge.Text.Replace("'", "''") + "'," +
                  "'" + txtMobileNo.Text + "'," +
                  "'" + txtDoorNo.Text + "'," +
                  "'" + txtAddressLine1.Text + "'," +
                  "'" + txtAddressLine2.Text + "'," +
                  "" + cmbCity.SelectedValue + "," +
                  "" + cmbDistrict.SelectedValue + "," +
                  "" + cmbPincode.SelectedValue + "," +
                  "" + cmbAssembly.SelectedValue + "," +
                  "" + cmbWard.SelectedValue + "," +
                  "" + cmbSubWard.SelectedValue + "," +
                  "'" + txtEpic.Text + "')";

                xDb.DataProcess(xQry);
                MessageBox.Show("Saved");
            }
            else
            {
                xQry = "update candidates set " +
                    " candidate_name = '" + txtFamilyHeadName.Text.Replace("'", "''") + "', " +
                    " gender = '" + cmbGender.SelectedItem + "', " +
                    " age = '" + txtAge.Text + "', " +
                    " mobile_number = '" + txtMobileNo.Text + "', " +
                    " addr_door_no = '" + txtDoorNo.Text + "', " +
                    " addr_line1 = '" + txtAddressLine1.Text + "', " +
                    " addr_line2 = '" + txtAddressLine2.Text + "', " +
                    " city_id = " + cmbCity.SelectedValue + ", " +
                    " district_id = " + cmbDistrict.SelectedValue + ", " +
                    " pincode_id = " + cmbPincode.SelectedValue + ", " +
                    " assembly_id = " + cmbAssembly.SelectedValue + ", " +
                    " ward_id = " + cmbWard.SelectedValue + ", " +
                    " subward_id = " + cmbSubWard.SelectedValue + ", " +
                    " epic_number = '" + txtEpic.Text + "' " +
                    " where  id= " + xCandidateId + "";
                xDb.DataProcess(xQry);
                MessageBox.Show("Updated");
            }
            LoadGrid();
            DataClear();
        }
        private void DataClear()
        {
            globalClass.ClearFormControls(this.groupBox1);
            LoadGrid();
            cmbCity.SelectedIndex = 0;
            cmbDistrict.SelectedIndex = 0;
            cmbPincode.SelectedIndex = 0;
            cmbAssembly.SelectedIndex = 0;
            cmbWard.SelectedIndex = 0;
            cmbSubWard.SelectedIndex = 0;
            btnSaveUpdate.Text = "SAVE";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xCandidateId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataFetch(xCandidateId);
            btnSaveUpdate.Text = "Update";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataClear();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            GlobalMasterForm globalMasterForm = new GlobalMasterForm("city", "city_id", "city_name");
            globalMasterForm.ShowDialog();
        }

        private void btnWard_Click(object sender, EventArgs e)
        {
            GlobalMasterForm globalMasterForm = new GlobalMasterForm("ward", "ward_id", "ward_name", "ward_no");
            globalMasterForm.ShowDialog();
        }

        private void btnSubWard_Click(object sender, EventArgs e)
        {
            GlobalMasterForm globalMasterForm = new GlobalMasterForm("subward", "subward_id", "subward_name", "ward_id", "ward");
            globalMasterForm.ShowDialog();
        }
    }
}
