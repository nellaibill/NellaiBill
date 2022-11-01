
namespace NellaiBill.Common
{
    partial class GlobalMasterForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.txtFirstField = new System.Windows.Forms.TextBox();
            this.lblFirstField = new System.Windows.Forms.Label();
            this.lblSecondField = new System.Windows.Forms.Label();
            this.cmbSecondField = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblHeading);
            this.panel3.Location = new System.Drawing.Point(27, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 33);
            this.panel3.TabIndex = 39;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(294, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(66, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "TITLE";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(510, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(429, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(436, 365);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(348, 60);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUpdate.TabIndex = 35;
            this.btnSaveUpdate.Text = "SAVE";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // txtFirstField
            // 
            this.txtFirstField.Location = new System.Drawing.Point(115, 62);
            this.txtFirstField.Name = "txtFirstField";
            this.txtFirstField.Size = new System.Drawing.Size(227, 20);
            this.txtFirstField.TabIndex = 34;
            // 
            // lblFirstField
            // 
            this.lblFirstField.AutoSize = true;
            this.lblFirstField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstField.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFirstField.Location = new System.Drawing.Point(24, 64);
            this.lblFirstField.Name = "lblFirstField";
            this.lblFirstField.Size = new System.Drawing.Size(51, 13);
            this.lblFirstField.TabIndex = 33;
            this.lblFirstField.Text = "First Field";
            // 
            // lblSecondField
            // 
            this.lblSecondField.AutoSize = true;
            this.lblSecondField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondField.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSecondField.Location = new System.Drawing.Point(24, 91);
            this.lblSecondField.Name = "lblSecondField";
            this.lblSecondField.Size = new System.Drawing.Size(69, 13);
            this.lblSecondField.TabIndex = 40;
            this.lblSecondField.Text = "Second Field";
            // 
            // cmbSecondField
            // 
            this.cmbSecondField.FormattingEnabled = true;
            this.cmbSecondField.Location = new System.Drawing.Point(115, 91);
            this.cmbSecondField.Name = "cmbSecondField";
            this.cmbSecondField.Size = new System.Drawing.Size(227, 21);
            this.cmbSecondField.TabIndex = 42;
            // 
            // GlobalMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 491);
            this.Controls.Add(this.cmbSecondField);
            this.Controls.Add(this.lblSecondField);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.txtFirstField);
            this.Controls.Add(this.lblFirstField);
            this.Name = "GlobalMasterForm";
            this.Text = "GlobalMasterForm";
            this.Load += new System.EventHandler(this.GlobalMasterForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.TextBox txtFirstField;
        private System.Windows.Forms.Label lblFirstField;
        private System.Windows.Forms.Label lblSecondField;
        private System.Windows.Forms.ComboBox cmbSecondField;
    }
}