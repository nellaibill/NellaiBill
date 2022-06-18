using System;
using System.Windows.Forms;

namespace NellaiBill.Donor
{
    public partial class ImpDatesReport : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public ImpDatesReport()
        {
            InitializeComponent();
        }

        private void btnImpDateReportLoad_Click(object sender, EventArgs e)
        {
            string xFilterQry = " and occasion_date BETWEEN '" + dtpFromDate.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpToDate.Value.ToString("yyyy-MM-dd") + "'";
            LoadGrid(xFilterQry);
        }
        private void LoadGrid(string xFilterQry)
        {
            string xQry = "SELECT p_donor_imp_date_id,f_donor_id, f.donor_name as DonorName,relation as Relation,name as Name,occasion_date as Date,occasion as Occasion,remarks as Remarks " +
                " FROM lukes_donor_important_dates as p, lukes_donor_registration as f WHERE p.f_donor_id = f.p_donor_id" + xFilterQry;
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

        private void ImpDatesReport_Load(object sender, EventArgs e)
        {
            LoadGrid("");
        }

        private void btnSingleDateFinder_Click(object sender, EventArgs e)
        {
            LoadGrid(" and  MONTH(occasion_date) = MONTH('" + dtpFromDate.Value.ToString("yyyy-MM-dd") + "') AND DAY(occasion_date) = DAY('" + dtpFromDate.Value.ToString("yyyy-MM-dd") + "')");

           // LoadGrid(" and DATE_FORMAT(FROM_UNIXTIME(occasion_date),'%m-%d') = DATE_FORMAT( '" + dtpFromDate.Value.ToString("yyyy-MM-dd") + "' ,'%m-%d')");
        }
    }
}
