
namespace NellaiBill.Donor
{
    partial class DonorImportantDates
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
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.cmbOccasion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblImportantDatesTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchRemarks = new System.Windows.Forms.RichTextBox();
            this.dtImp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.Green;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveUpdate.Location = new System.Drawing.Point(1233, 18);
            this.btnSaveUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(123, 45);
            this.btnSaveUpdate.TabIndex = 6;
            this.btnSaveUpdate.Text = "SAVE";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // cmbOccasion
            // 
            this.cmbOccasion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccasion.FormattingEnabled = true;
            this.cmbOccasion.Items.AddRange(new object[] {
            "DOB",
            "DOW",
            "DOD",
            "Others"});
            this.cmbOccasion.Location = new System.Drawing.Point(809, 47);
            this.cmbOccasion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOccasion.Name = "cmbOccasion";
            this.cmbOccasion.Size = new System.Drawing.Size(212, 24);
            this.cmbOccasion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Occasion";
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(314, 51);
            this.txtRelation.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelation.MaxLength = 10;
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(271, 22);
            this.txtRelation.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Relation";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 51);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 22);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1479, 332);
            this.dataGridView1.TabIndex = 97;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.lblImportantDatesTitle.Size = new System.Drawing.Size(196, 29);
            this.lblImportantDatesTitle.TabIndex = 0;
            this.lblImportantDatesTitle.Text = "Important Dates";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchRemarks);
            this.groupBox1.Controls.Add(this.dtImp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbOccasion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRelation);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1479, 156);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            // 
            // rchRemarks
            // 
            this.rchRemarks.Location = new System.Drawing.Point(1045, 47);
            this.rchRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.rchRemarks.Name = "rchRemarks";
            this.rchRemarks.Size = new System.Drawing.Size(337, 94);
            this.rchRemarks.TabIndex = 5;
            this.rchRemarks.Text = "";
            // 
            // dtImp
            // 
            this.dtImp.Location = new System.Drawing.Point(592, 49);
            this.dtImp.Name = "dtImp";
            this.dtImp.Size = new System.Drawing.Size(200, 22);
            this.dtImp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1042, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Remarks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 138;
            this.label2.Text = "Date";
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
            this.panel3.TabIndex = 95;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(1364, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 45);
            this.btnCancel.TabIndex = 98;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // DonorImportantDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 599);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSaveUpdate);
            this.Name = "DonorImportantDates";
            this.Text = "ImportantDates";
            this.Load += new System.EventHandler(this.DonorImportantDates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.ComboBox cmbOccasion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label lblImportantDatesTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtImp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}