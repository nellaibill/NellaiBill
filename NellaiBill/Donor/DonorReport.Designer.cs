
namespace NellaiBill.Donor
{
    partial class DonorReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblGeneralReportTitle);
            this.panel3.Location = new System.Drawing.Point(-57, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1293, 33);
            this.panel3.TabIndex = 184;
            // 
            // lblGeneralReportTitle
            // 
            this.lblGeneralReportTitle.AutoSize = true;
            this.lblGeneralReportTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneralReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralReportTitle.ForeColor = System.Drawing.Color.White;
            this.lblGeneralReportTitle.Location = new System.Drawing.Point(598, 0);
            this.lblGeneralReportTitle.Name = "lblGeneralReportTitle";
            this.lblGeneralReportTitle.Size = new System.Drawing.Size(72, 24);
            this.lblGeneralReportTitle.TabIndex = 0;
            this.lblGeneralReportTitle.Text = "Report";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(13, 61);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1223, 759);
            this.crystalReportViewer1.TabIndex = 185;
            // 
            // DonorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 874);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel3);
            this.Name = "DonorReport";
            this.Text = "DonorReport";
            this.Load += new System.EventHandler(this.DonorReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblGeneralReportTitle;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}