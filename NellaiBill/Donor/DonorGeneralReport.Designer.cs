
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
            this.btnPrintView = new System.Windows.Forms.Button();
            this.cachedrptIpAdmissionReport1 = new NellaiBill.CrystalReports.CachedrptIpAdmissionReport();
            this.cachedrptIpAdmissionReport2 = new NellaiBill.CrystalReports.CachedrptIpAdmissionReport();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblGeneralReportTitle);
            this.panel3.Location = new System.Drawing.Point(28, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1352, 26);
            this.panel3.TabIndex = 105;
            // 
            // lblGeneralReportTitle
            // 
            this.lblGeneralReportTitle.AutoSize = true;
            this.lblGeneralReportTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneralReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralReportTitle.ForeColor = System.Drawing.Color.White;
            this.lblGeneralReportTitle.Location = new System.Drawing.Point(554, 0);
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
            this.btnImpDateReportLoad.Location = new System.Drawing.Point(1045, 40);
            this.btnImpDateReportLoad.Name = "btnImpDateReportLoad";
            this.btnImpDateReportLoad.Size = new System.Drawing.Size(136, 42);
            this.btnImpDateReportLoad.TabIndex = 111;
            this.btnImpDateReportLoad.Text = "LOAD";
            this.btnImpDateReportLoad.UseVisualStyleBackColor = false;
            this.btnImpDateReportLoad.Click += new System.EventHandler(this.btnImpDateReportLoad_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(28, 61);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(133, 21);
            this.cmbCategory.TabIndex = 179;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 178;
            this.label17.Text = "Category";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(365, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(441, 20);
            this.txtSearch.TabIndex = 182;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPrintView
            // 
            this.btnPrintView.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrintView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintView.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrintView.Location = new System.Drawing.Point(1187, 40);
            this.btnPrintView.Name = "btnPrintView";
            this.btnPrintView.Size = new System.Drawing.Size(186, 42);
            this.btnPrintView.TabIndex = 183;
            this.btnPrintView.Text = "PRINT VIEW";
            this.btnPrintView.UseVisualStyleBackColor = false;
            this.btnPrintView.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 763);
            this.dataGridView1.TabIndex = 180;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(28, 97);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1352, 772);
            this.crystalReportViewer1.TabIndex = 184;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 189;
            this.label13.Text = "Country";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "All",
            "India",
            "OutsideIndia"});
            this.cmbCountry.Location = new System.Drawing.Point(184, 57);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(159, 25);
            this.cmbCountry.TabIndex = 188;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(362, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 181;
            this.lblSearch.Text = "Search";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFilter.Location = new System.Drawing.Point(894, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(136, 42);
            this.btnFilter.TabIndex = 190;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(825, 48);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(29, 31);
            this.lblTotalCount.TabIndex = 191;
            this.lblTotalCount.Text = "0";
            // 
            // DonorGeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 752);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.crystalReportViewer1);
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
        private System.Windows.Forms.Button btnPrintView;
        private CrystalReports.CachedrptIpAdmissionReport cachedrptIpAdmissionReport1;
        private CrystalReports.CachedrptIpAdmissionReport cachedrptIpAdmissionReport2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblTotalCount;
    }
}