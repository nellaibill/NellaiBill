using NellaiBill.Master;
using NellaiBill.Models.Donor;
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
    public partial class DonorFilter : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xDonorId;
        GlobalClass globalClass = new GlobalClass();
        public DonorFilter()
        {
            InitializeComponent();
        }

        private void btnDonorFilterApply_Click(object sender, EventArgs e)
        {
            string xQry = "update lukes_donor_settings set " +
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
                    " sr_email = " + globalClass.getInteger(chkSREmail.Checked) + " " +
                    " where  p_donor_settings_id= 1";
            xDb.DataProcess(xQry);
            MessageBox.Show("Saved/Updated");
            //DonorRegistration donorRegistration = new DonorRegistration();
            //var frm = (DonorRegistration)this.Owner;
            //if (frm != null)
            //    frm.btnRefresh.PerformClick();
            //donorRegistration.btnRefresh.PerformClick();
            this.Close();
    }

        private void DonorFilter_Load(object sender, EventArgs e)
        {
            DataFetch();
        }
        private void DataFetch()
        {
            DonorSettingsModel donorSettingsModelResponse = new DonorSettingsModel();
            donorSettingsModelResponse = xDb.GetDonorSettingsBasedOnQry(1);
            chkDonorAnnual.Checked = globalClass.getBoolean(donorSettingsModelResponse.DonorAnnual);
            chkDonorEndowment.Checked = globalClass.getBoolean(donorSettingsModelResponse.DonorEndowment);
            chkDonorThings.Checked = globalClass.getBoolean(donorSettingsModelResponse.DonorThings);
            chkDonorWelfare.Checked = globalClass.getBoolean(donorSettingsModelResponse.DonorWelfare);
            chkSupportCS.Checked = globalClass.getBoolean(donorSettingsModelResponse.SupportCS);
            chkSupportFS.Checked = globalClass.getBoolean(donorSettingsModelResponse.SupportFS);
            chkSupportBS.Checked = globalClass.getBoolean(donorSettingsModelResponse.SupportBS);
            chkSupportCloth.Checked = globalClass.getBoolean(donorSettingsModelResponse.SupportCloth);
            chkSupportOthers.Checked = globalClass.getBoolean(donorSettingsModelResponse.SupportOther);
            chkSROOC.Checked = globalClass.getBoolean(donorSettingsModelResponse.SROOC);
            chkSRNTC.Checked = globalClass.getBoolean(donorSettingsModelResponse.SRNTC);
            chkSREmail.Checked = globalClass.getBoolean(donorSettingsModelResponse.SREmail);
            chkSRPost.Checked = globalClass.getBoolean(donorSettingsModelResponse.SRPost);
            chkSRVisitor.Checked = globalClass.getBoolean(donorSettingsModelResponse.SRVisitor);
        }

        private void btnSelectAllCheckBox_Click(object sender, EventArgs e)
        {
            chkDonorAnnual.Checked = true;
            chkDonorEndowment.Checked = true;
            chkDonorThings.Checked = true;
            chkDonorWelfare.Checked = true;
            chkSupportCS.Checked = true;
            chkSupportFS.Checked = true;
            chkSupportBS.Checked = true;
            chkSupportCloth.Checked = true;
            chkSupportOthers.Checked = true;
            chkSROOC.Checked = true;
            chkSRNTC.Checked = true;
            chkSREmail.Checked = true;
            chkSRPost.Checked = true;
            chkSRVisitor.Checked = true;
        }

        private void btnDeSelectAllCheckBox_Click(object sender, EventArgs e)
        {
            chkDonorAnnual.Checked = false;
            chkDonorEndowment.Checked = false;
            chkDonorThings.Checked = false;
            chkDonorWelfare.Checked = false;
            chkSupportCS.Checked = false;
            chkSupportFS.Checked = false;
            chkSupportBS.Checked = false;
            chkSupportCloth.Checked = false;
            chkSupportOthers.Checked = false;
            chkSROOC.Checked = false;
            chkSRNTC.Checked = false;
            chkSREmail.Checked = false;
            chkSRPost.Checked = false;
            chkSRVisitor.Checked = false;
        }

    }
}
