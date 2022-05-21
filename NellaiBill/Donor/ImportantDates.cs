using NellaiBill.Models;
using System;
using System.Windows.Forms;

namespace NellaiBill.Donor
{
    public partial class DonorImportantDates : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xFDonorId;
        int xPDonorImpDateId;
        GlobalClass globalClass = new GlobalClass();
        public DonorImportantDates(int xDonorId)
        {
            InitializeComponent();
            xFDonorId = xDonorId;
            DataFetch(xDonorId);
        }

        private void DonorImportantDates_Load(object sender, EventArgs e)
        {
            LoadGrid();
            DataClear();
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

                xQry = "insert into lukes_donor_important_dates (`f_donor_id`, `name`, `relation`,`occasion_date`, `occasion`, `remarks`,`createdason`) " +
                    " values ( " + xFDonorId + ",'" +
                    txtName.Text + "','" +
                    txtRelation.Text + "','" +
                   dtImp.Value.ToString("yyyy-MM-dd") + "','" +
                    cmbOccasion.Text + "','" +
                    rchRemarks.Text + "','" +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            }
            else
            {
                xQry = "update lukes_donor_important_dates set " +
                    " name = '" + txtName.Text + "', " +
                    " relation = '" + txtRelation.Text + "', " +
                    " occasion_date = '" + dtImp.Value.ToString("yyyy-MM-dd") + "', " +

                    " occasion = '" + cmbOccasion.SelectedValue + "', " +
                    " remarks = '" + rchRemarks.Text + "', " +
                    " updatedason = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                    " where  p_donor_imp_date_id= " + xPDonorImpDateId + "";
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
            lblImportantDatesTitle.Text = "Important Dates for " + donorRegistrationResponse.Name; 
        }

        private void LoadGrid()
        {
            string xQry = "select p_donor_imp_date_id,f_donor_id,name as Name,relation as Relation,occasion_date as Date,occasion as Occasion,remarks as Remarks" +
                " from lukes_donor_important_dates where f_donor_id = " + xFDonorId + "";
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
            txtName.Text = "";
            txtRelation.Text = "";
            dtImp.Text = "";
            rchRemarks.Text = "";
            btnSaveUpdate.Text = "SAVE";
            cmbOccasion.SelectedIndex = 1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xPDonorImpDateId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRelation.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtImp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbOccasion.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            rchRemarks.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
        }
    }
}
