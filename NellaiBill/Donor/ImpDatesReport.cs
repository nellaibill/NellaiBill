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
            LoadGrid();
        }
        private void LoadGrid()
        {
            string xQry = "SELECT p_donor_imp_date_id,f_donor_id,name as Name,relation as Relation,occasion_date as Date,occasion as Occasion,remarks as Remarks FROM lukes_donor_important_dates WHERE occasion_date BETWEEN '" + dtpFromDate.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpToDate.Value.ToString("yyyy-MM-dd") + "'";
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
            //dataGridView1.Columns[5].Width = 150;
        }
    }
}
