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
        int xDonorId;
        GlobalClass globalClass = new GlobalClass();
        public DonVoterRegistration()
        {
            InitializeComponent();
        }

        private void DonVoterRegistration_Load(object sender, EventArgs e)
        {
            LoadGrid("");
            xDb.LoadComboBox("select city_id,city_name from city order by city_name ", cmbCity, "city_id", "city_name");
            xDb.LoadComboBox("select district_id,district_name from district order by district_name ", cmbDistrict, "district_id", "district_name");
            xDb.LoadComboBox("select pincode_id,pincode_number from pincode order by pincode_number ", cmbPincode, "pincode_id", "pincode_number");
            xDb.LoadComboBox("select assembly_id,assembly_name from assembly order by assembly_name ", cmbAssembly, "assembly_id", "assembly_name");
            xDb.LoadComboBox("select ward_id,ward_name from ward order by ward_name ", cmbWard, "ward_id", "ward_name");
            xDb.LoadComboBox("select subward_id,subward_name from subward order by subward_name ", cmbSubWard, "subward_id", "subward_name");

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
        public void LoadGrid(string xFilter)
        {
            string xQry = "select candidate_name,epic_number,mobile_number,gender,age,city_name,district_name,pincode_number,ward_name,subward_name" +
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
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 150;
        }
    }
}
