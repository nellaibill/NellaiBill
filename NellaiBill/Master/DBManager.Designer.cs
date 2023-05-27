
namespace NellaiBill.Master
{
    partial class DBManager
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtImportPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(267, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "DATABASE MANAGEMENT";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(58, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 33);
            this.panel3.TabIndex = 40;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(108, 73);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(527, 20);
            this.txtFilePath.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "PATH";
            // 
            // btnBrowseExport
            // 
            this.btnBrowseExport.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnBrowseExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseExport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBrowseExport.Location = new System.Drawing.Point(651, 68);
            this.btnBrowseExport.Name = "btnBrowseExport";
            this.btnBrowseExport.Size = new System.Drawing.Size(99, 31);
            this.btnBrowseExport.TabIndex = 50;
            this.btnBrowseExport.Text = "Browse";
            this.btnBrowseExport.UseVisualStyleBackColor = false;
            this.btnBrowseExport.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Red;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImport.Location = new System.Drawing.Point(763, 302);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(99, 31);
            this.btnImport.TabIndex = 51;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Visible = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExport.Location = new System.Drawing.Point(763, 68);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(99, 31);
            this.btnExport.TabIndex = 52;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtImportPath
            // 
            this.txtImportPath.Location = new System.Drawing.Point(108, 309);
            this.txtImportPath.Name = "txtImportPath";
            this.txtImportPath.Size = new System.Drawing.Size(527, 20);
            this.txtImportPath.TabIndex = 54;
            this.txtImportPath.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "PATH";
            this.label1.Visible = false;
            // 
            // btnBrowseImport
            // 
            this.btnBrowseImport.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnBrowseImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBrowseImport.Location = new System.Drawing.Point(651, 302);
            this.btnBrowseImport.Name = "btnBrowseImport";
            this.btnBrowseImport.Size = new System.Drawing.Size(99, 31);
            this.btnBrowseImport.TabIndex = 55;
            this.btnBrowseImport.Text = "Browse";
            this.btnBrowseImport.UseVisualStyleBackColor = false;
            this.btnBrowseImport.Visible = false;
            this.btnBrowseImport.Click += new System.EventHandler(this.btnBrowseImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(65, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Please be careful before you click on  Import button it will change the database " +
    "records";
            this.label2.Visible = false;
            // 
            // DBManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseImport);
            this.Controls.Add(this.txtImportPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowseExport);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Name = "DBManager";
            this.Text = "DBManager";
            this.Load += new System.EventHandler(this.DBManager_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtImportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseImport;
        private System.Windows.Forms.Label label2;
    }
}