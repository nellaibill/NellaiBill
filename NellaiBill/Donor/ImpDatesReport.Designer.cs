
namespace NellaiBill.Donor
{
    partial class ImpDatesReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblImportantDatesTitle = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImpDateReportLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 322);
            this.dataGridView1.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblImportantDatesTitle);
            this.panel3.Location = new System.Drawing.Point(8, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 41);
            this.panel3.TabIndex = 98;
            // 
            // lblImportantDatesTitle
            // 
            this.lblImportantDatesTitle.AutoSize = true;
            this.lblImportantDatesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblImportantDatesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportantDatesTitle.ForeColor = System.Drawing.Color.White;
            this.lblImportantDatesTitle.Location = new System.Drawing.Point(93, 0);
            this.lblImportantDatesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImportantDatesTitle.Name = "lblImportantDatesTitle";
            this.lblImportantDatesTitle.Size = new System.Drawing.Size(282, 29);
            this.lblImportantDatesTitle.TabIndex = 0;
            this.lblImportantDatesTitle.Text = "Important Dates Report";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(36, 110);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFromDate.TabIndex = 100;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(292, 110);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 22);
            this.dtpToDate.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "FromDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 103;
            this.label2.Text = "ToDate";
            // 
            // btnImpDateReportLoad
            // 
            this.btnImpDateReportLoad.BackColor = System.Drawing.Color.Green;
            this.btnImpDateReportLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpDateReportLoad.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImpDateReportLoad.Location = new System.Drawing.Point(517, 87);
            this.btnImpDateReportLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnImpDateReportLoad.Name = "btnImpDateReportLoad";
            this.btnImpDateReportLoad.Size = new System.Drawing.Size(123, 45);
            this.btnImpDateReportLoad.TabIndex = 104;
            this.btnImpDateReportLoad.Text = "LOAD";
            this.btnImpDateReportLoad.UseVisualStyleBackColor = false;
            this.btnImpDateReportLoad.Click += new System.EventHandler(this.btnImpDateReportLoad_Click);
            // 
            // ImpDatesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 542);
            this.Controls.Add(this.btnImpDateReportLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Name = "ImpDatesReport";
            this.Text = "ImpDatesReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblImportantDatesTitle;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImpDateReportLoad;
    }
}