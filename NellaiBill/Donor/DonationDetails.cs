using NellaiBill.Models;
using System;
using System.Windows.Forms;

namespace NellaiBill.Donor
{
    public partial class DonationDetails : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xFDonorId;
        int xPDonorDonationDetailsId;
        public DonationDetails(int xDonorId)
        {
            InitializeComponent();
            xFDonorId = xDonorId;
            DataFetch(xDonorId);
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string xQry = "";
            int xAmount = Convert.ToInt32(txtAmount.Text);
            if (xAmount == 0)
            {
                MessageBox.Show("Please Choose Amount");
                txtAmount.Focus();
                return;
            }
            if (btnSaveUpdate.Text == "SAVE")
            {

                xQry = "insert into lukes_donor_donation_details (`f_donor_id`, `date`, `amount`,`channel`, `purpose`, `remarks`,`createdason`) " +
                    " values ( " + xFDonorId + ",'" +
                   dtpFDDate.Value.ToString("yyyy-MM-dd") + "','" +
                    txtAmount.Text + "','" +
                   txtChannel.Text + "','" +
                    txtPurpose.Text + "','" +
                    rchRemarks.Text + "','" +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            }
            else
            {
                xQry = "update lukes_donor_donation_details set " +
                    " amount = '" + txtAmount.Text + "', " +
                    " channel = '" + txtChannel.Text + "', " +
                    " date = '" + dtpFDDate.Value.ToString("yyyy-MM-dd") + "', " +
                    " purpose = '" + txtPurpose.Text + "', " +
                    " remarks = '" + rchRemarks.Text + "', " +
                    " updatedason = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                    " where  p_donor_donation_details_id= " + xPDonorDonationDetailsId + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Saved/Updated");
            LoadGrid();
            DataClear();
        }
        private void DataFetch(int xDonorId)
        {
            DonorRegistrationResponseModel donorRegistrationResponse = new DonorRegistrationResponseModel();
            donorRegistrationResponse = xDb.GetDonorRegistrationBasedOnQry(xDonorId);
            lblDonationDetailsTitle.Text = "Donation Details for " + donorRegistrationResponse.Name;
        }
        private void LoadGrid()
        {
            string xQry = "select p_donor_donation_details_id,f_donor_id,date as Date,amount as Amount,channel as Channel,purpose as Purpose,remarks as Remarks" +
                " from lukes_donor_donation_details where f_donor_id = " + xFDonorId + "";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns["Name"].Frozen = true;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
        }
        private void DataClear()
        {
            //dtpFDDate.Text = "";
            txtAmount.Text = "";
            txtChannel.Text = "";
            txtPurpose.Text = "";
            rchRemarks.Text = "";
            btnSaveUpdate.Text = "SAVE";
        }

        private void DonationDetails_Load(object sender, EventArgs e)
        {
            LoadGrid();
            DataClear();
            txtAmount.Controls[0].Visible = false;
            ((TextBox)txtAmount.Controls[1]).MaxLength = 10;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xPDonorDonationDetailsId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtpFDDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtChannel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPurpose.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            rchRemarks.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
        }
    }
}
