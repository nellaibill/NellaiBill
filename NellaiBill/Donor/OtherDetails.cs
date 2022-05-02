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

namespace NellaiBill.Donor
{
    public partial class OtherDetails : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xFDonorId;
        public OtherDetails(int xDonorId)
        {
            InitializeComponent();
            xFDonorId = xDonorId;
            DataFetch(xDonorId);
        }
       
        private void OtherDetails_Load(object sender, EventArgs e)
        {

        }
        private void DataFetch(int xDonorId)
        {
            DonorRegistrationResponseModel donorRegistrationResponse = new DonorRegistrationResponseModel();
            donorRegistrationResponse = xDb.GetDonorRegistrationBasedOnQry(xDonorId);
            lblOtherDetailsTitle.Text = "Other Details for " + donorRegistrationResponse.Name;
            rchRemarks.Text = donorRegistrationResponse.OtherDetails;
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "update lukes_donor_registration set " +
                    " other_details = '" + rchRemarks.Text + "', " +
                    " updatedason = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                    " where  p_donor_id= " + xFDonorId + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Updated");
        }
    }
}
