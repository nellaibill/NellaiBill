using MySql.Data.MySqlClient;
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

namespace NellaiBill.Master
{
    public partial class DBManager : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public DBManager()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            txtFilePath.Text = folderPath;
        }

        private  void btnImport_Click(object sender, EventArgs e)
        {
            string xRestoreFilePath = txtImportPath.Text;
            xDb.DataProcess("SET GLOBAL max_allowed_packet = 16777216"); //16 MB https://stackoverflow.com/questions/6973939/mysql-database-error-packets-larger-than-max-allowed-packet-are-not-allowed-d
            WaitSomeTime();
            using (MySqlConnection conn = new MySqlConnection(xDb.conString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(xRestoreFilePath);
                        conn.Close();
                    }
                }
            }
            MessageBox.Show(" Restore completed");
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text == "")
                {
                    MessageBox.Show("Please Choose Folder");
                    return;
                }


                BackUpDatabase(txtFilePath.Text);
                MessageBox.Show("Back up completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error - Back up not completed" + ex);
            }
        }
        public void BackUpDatabase(string file)
        {
            CompanyInfoResponseModel response = xDb.GetCompanyDetails();
            string xCompanyName = response.CompanyTitle;
            string xCurrentDateTime = DateTime.Now.ToString("ddMMMMyyyy_h_mm_tt");
            string xFileName = file + "\\" + xCompanyName + "_" + xCurrentDateTime + ".sql";
            using (xDb.connection = new MySqlConnection(xDb.conString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = xDb.connection;
                        xDb.connection.Open();
                        mb.ExportInfo.AddCreateDatabase = true;
                        mb.ExportInfo.ExportTableStructure = true;
                        mb.ExportInfo.ExportRows = true;
                        mb.ExportToFile(xFileName);
                        xDb.connection.Close();
                    }
                }
            }
        }

        private void btnBrowseImport_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = openFileDialog.FileName;
            }
            txtImportPath.Text = folderPath; ;
        }
    }
}
