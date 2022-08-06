﻿
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
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddressPrint = new System.Windows.Forms.Button();
            this.cachedrptIpAdmissionReport1 = new NellaiBill.CrystalReports.CachedrptIpAdmissionReport();
            this.cachedrptIpAdmissionReport2 = new NellaiBill.CrystalReports.CachedrptIpAdmissionReport();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnDataGridPrint = new System.Windows.Forms.Button();
            this.radHomeAddress = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOfficeAddress = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // btnLoadGrid
            // 
            this.btnLoadGrid.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoadGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGrid.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLoadGrid.Location = new System.Drawing.Point(731, 43);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(94, 42);
            this.btnLoadGrid.TabIndex = 111;
            this.btnLoadGrid.Text = "LOAD";
            this.btnLoadGrid.UseVisualStyleBackColor = false;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 20);
            this.txtSearch.TabIndex = 182;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddressPrint
            // 
            this.btnAddressPrint.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddressPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddressPrint.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddressPrint.Location = new System.Drawing.Point(122, 21);
            this.btnAddressPrint.Name = "btnAddressPrint";
            this.btnAddressPrint.Size = new System.Drawing.Size(78, 34);
            this.btnAddressPrint.TabIndex = 183;
            this.btnAddressPrint.Text = "Print";
            this.btnAddressPrint.UseVisualStyleBackColor = false;
            this.btnAddressPrint.Click += new System.EventHandler(this.btnAddressPrint_Click);
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
            this.label13.Location = new System.Drawing.Point(470, 33);
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
            this.cmbCountry.Location = new System.Drawing.Point(473, 58);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(159, 25);
            this.cmbCountry.TabIndex = 188;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(30, 40);
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
            this.btnFilter.Location = new System.Drawing.Point(639, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 42);
            this.btnFilter.TabIndex = 190;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(353, 48);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(29, 31);
            this.lblTotalCount.TabIndex = 191;
            this.lblTotalCount.Text = "0";
            // 
            // btnDataGridPrint
            // 
            this.btnDataGridPrint.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDataGridPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataGridPrint.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDataGridPrint.Location = new System.Drawing.Point(831, 43);
            this.btnDataGridPrint.Name = "btnDataGridPrint";
            this.btnDataGridPrint.Size = new System.Drawing.Size(68, 42);
            this.btnDataGridPrint.TabIndex = 192;
            this.btnDataGridPrint.Text = "Print";
            this.btnDataGridPrint.UseVisualStyleBackColor = false;
            this.btnDataGridPrint.Click += new System.EventHandler(this.btnDataGridPrint_Click);
            // 
            // radHomeAddress
            // 
            this.radHomeAddress.AutoSize = true;
            this.radHomeAddress.Checked = true;
            this.radHomeAddress.Location = new System.Drawing.Point(6, 15);
            this.radHomeAddress.Name = "radHomeAddress";
            this.radHomeAddress.Size = new System.Drawing.Size(94, 17);
            this.radHomeAddress.TabIndex = 193;
            this.radHomeAddress.TabStop = true;
            this.radHomeAddress.Text = "Home Address";
            this.radHomeAddress.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOfficeAddress);
            this.groupBox1.Controls.Add(this.radHomeAddress);
            this.groupBox1.Controls.Add(this.btnAddressPrint);
            this.groupBox1.Location = new System.Drawing.Point(926, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 60);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Print";
            // 
            // radOfficeAddress
            // 
            this.radOfficeAddress.AutoSize = true;
            this.radOfficeAddress.Location = new System.Drawing.Point(6, 38);
            this.radOfficeAddress.Name = "radOfficeAddress";
            this.radOfficeAddress.Size = new System.Drawing.Size(94, 17);
            this.radOfficeAddress.TabIndex = 194;
            this.radOfficeAddress.TabStop = true;
            this.radOfficeAddress.Text = "Office Address";
            this.radOfficeAddress.UseVisualStyleBackColor = true;
            // 
            // DonorGeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 752);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDataGridPrint);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLoadGrid);
            this.Name = "DonorGeneralReport";
            this.Text = "DonorGeneralReport";
            this.Load += new System.EventHandler(this.DonorGeneralReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblGeneralReportTitle;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddressPrint;
        private CrystalReports.CachedrptIpAdmissionReport cachedrptIpAdmissionReport1;
        private CrystalReports.CachedrptIpAdmissionReport cachedrptIpAdmissionReport2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnDataGridPrint;
        private System.Windows.Forms.RadioButton radHomeAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOfficeAddress;
    }
}