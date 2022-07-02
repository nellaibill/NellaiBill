
namespace NellaiBill.Donor
{
    partial class DonorGeneralReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGeneralReportTitle = new System.Windows.Forms.Label();
            this.btnImpDateReportLoad = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnPrintView = new System.Windows.Forms.Button();
            this.cachedrptIpAdmissionReport1 = new NellaiBill.CrystalReports.CachedrptIpAdmissionReport();
            this.cachedrptIpAdmissionReport2 = new NellaiBill.CrystalReports.CachedrptIpAdmissionReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblGeneralReportTitle);
            this.panel3.Location = new System.Drawing.Point(24, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 33);
            this.panel3.TabIndex = 105;
            // 
            // lblGeneralReportTitle
            // 
            this.lblGeneralReportTitle.AutoSize = true;
            this.lblGeneralReportTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneralReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralReportTitle.ForeColor = System.Drawing.Color.White;
            this.lblGeneralReportTitle.Location = new System.Drawing.Point(359, 0);
            this.lblGeneralReportTitle.Name = "lblGeneralReportTitle";
            this.lblGeneralReportTitle.Size = new System.Drawing.Size(72, 24);
            this.lblGeneralReportTitle.TabIndex = 0;
            this.lblGeneralReportTitle.Text = "Report";
            // 
            // btnImpDateReportLoad
            // 
            this.btnImpDateReportLoad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImpDateReportLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpDateReportLoad.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImpDateReportLoad.Location = new System.Drawing.Point(440, 61);
            this.btnImpDateReportLoad.Name = "btnImpDateReportLoad";
            this.btnImpDateReportLoad.Size = new System.Drawing.Size(136, 58);
            this.btnImpDateReportLoad.TabIndex = 111;
            this.btnImpDateReportLoad.Text = "LOAD";
            this.btnImpDateReportLoad.UseVisualStyleBackColor = false;
            this.btnImpDateReportLoad.Click += new System.EventHandler(this.btnImpDateReportLoad_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(96, 62);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(189, 21);
            this.cmbCategory.TabIndex = 179;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 178;
            this.label17.Text = "Category";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 20);
            this.txtSearch.TabIndex = 182;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(925, 541);
            this.dataGridView1.TabIndex = 180;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(25, 99);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 181;
            this.lblSearch.Text = "Search";
            // 
            // btnPrintView
            // 
            this.btnPrintView.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrintView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintView.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrintView.Location = new System.Drawing.Point(582, 61);
            this.btnPrintView.Name = "btnPrintView";
            this.btnPrintView.Size = new System.Drawing.Size(206, 58);
            this.btnPrintView.TabIndex = 183;
            this.btnPrintView.Text = "PRINT VIEW";
            this.btnPrintView.UseVisualStyleBackColor = false;
            this.btnPrintView.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NellaiBill.Donor.donor_report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 149);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(922, 555);
            this.reportViewer1.TabIndex = 184;
            // 
            // DonorGeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 752);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPrintView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnImpDateReportLoad);
            this.Name = "DonorGeneralReport";
            this.Text = "DonorGeneralReport";
            this.Load += new System.EventHandler(this.DonorGeneralReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblGeneralReportTitle;
        private System.Windows.Forms.Button btnImpDateReportLoad;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnPrintView;
        private CrystalReports.CachedrptIpAdmissionReport cachedrptIpAdmissionReport1;
        private CrystalReports.CachedrptIpAdmissionReport cachedrptIpAdmissionReport2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}