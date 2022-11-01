using System;
using System.Windows.Forms;

namespace NellaiBill.Common
{
    public partial class GlobalMasterForm : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xTableName = "";
        string xPrimaryColumn = "";
        string xFirstColumn = "";
        string xSecondColumn = "";
        string xSecondColumnDropDownTable = "";
        int xPrimaryId;
        public GlobalMasterForm(string table, string primarycolumn, string firstcolumn, string secondcolumn = "", string secondcolumn_dropdown_table = "")
        {
            InitializeComponent();
            xTableName = table;
            xPrimaryColumn = primarycolumn;
            xFirstColumn = firstcolumn;
            xSecondColumn = secondcolumn;
            xSecondColumnDropDownTable = secondcolumn_dropdown_table;
            lblHeading.Text = table.ToUpper();
        }

        private void GlobalMasterForm_Load(object sender, EventArgs e)
        {

            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            LoadGrid();
            lblFirstField.Text = xFirstColumn;
            if (xSecondColumn == "")
            {
                lblSecondField.Visible = false;
                cmbSecondField.Visible = false;
            }
            else
            {
                lblSecondField.Text = xSecondColumn;
            }
            if (xSecondColumnDropDownTable != "")
            {
                cmbSecondField.DropDownStyle = ComboBoxStyle.DropDownList;
                //xDb.LoadComboBox("select * from "+ xSecondColumnDropDownTable+" order by " + xSecondColumnDropDownTable + ", " + cmbSecondField + ", "city_id", "city_name");
                xDb.LoadComboBox("select ward_id,ward_name from ward order by ward_name ", cmbSecondField, "ward_id", "ward_name");
            }


        }
        private void LoadGrid()
        {
            string xSecondColumnQry = "";
            if (xSecondColumn != "")
            {
                xSecondColumnQry = " , " + xSecondColumn;
            }
            string xQuery = "select " + xPrimaryColumn + " as Id," + xFirstColumn + " as Name " + xSecondColumnQry +
                " from " + xTableName + " order by " + xPrimaryColumn;
            xDb.LoadGrid(xQuery, dataGridView1);
            dataGridView1.Columns[1].Width = 200;
            btnSaveUpdate.Text = "SAVE";
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
        public void DataProcess()
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (txtFirstField.Text == "")
            {
                MessageBox.Show("Please Enter " + xTableName + " Name");
                txtFirstField.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                if (xSecondColumn != "")
                {
                    xQry = "insert into    " + xTableName + "(" + xFirstColumn + ", " + xSecondColumn + ") values( '" + txtFirstField.Text + "','" + cmbSecondField.Text + "')";
                }
                else
                {
                    xQry = "insert into    " + xTableName + "(" + xFirstColumn + ") values( '" + txtFirstField.Text + "')";
                }

            }
            else
            {
                string xSecondColumnQry = "";
                if (xSecondColumn != "")
                {
                    xSecondColumnQry = ", " + xSecondColumn + " = " + cmbSecondField.Text + "";
                }
                xQry = "update " + xTableName + " set " + xFirstColumn + " = '" + txtFirstField.Text + "' " + xSecondColumnQry +
                    " where " + xPrimaryColumn + " = " + xPrimaryId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (xDb.CountRecord("select * from m_group where category_id  = " + xCategoryId + " ") >= 1)
            //{
            //    MessageBox.Show("Selected Category mapped with other Group[Please delete group first]");
            //    return;
            //}
            //else
            //{
            //    string xQry = "delete from " + xTableName + " where  category_id= " + xCategoryId + "";
            //    xDb.DataProcess(xQry);
            //}

            //LoadGrid();
            //DataClear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataClear();
            LoadGrid();
        }
        private void DataClear()
        {
            txtFirstField.Text = "";
            cmbSecondField.Text = "";
            btnSaveUpdate.Text = "SAVE";
            btnDelete.Enabled = false;
            txtFirstField.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xPrimaryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFirstField.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (xSecondColumn != "")
            {
                cmbSecondField.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            btnSaveUpdate.Text = "UPDATE";
        }
    }
}
