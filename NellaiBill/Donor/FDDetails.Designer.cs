
namespace NellaiBill.Donor
{
    partial class FDDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFDDetailsTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rchRemarks = new System.Windows.Forms.RichTextBox();
            this.dtpFDDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBtnFDDetailsPrint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBtnFDDetailsPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.Green;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveUpdate.Location = new System.Drawing.Point(343, 102);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(92, 37);
            this.btnSaveUpdate.TabIndex = 6;
            this.btnSaveUpdate.Text = "SAVE";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Purpose";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(315, 41);
            this.txtBank.MaxLength = 100;
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(204, 20);
            this.txtBank.TabIndex = 3;
            this.txtBank.TextChanged += new System.EventHandler(this.txtBank_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Bank";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(843, 270);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblFDDetailsTitle
            // 
            this.lblFDDetailsTitle.AutoSize = true;
            this.lblFDDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFDDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDDetailsTitle.ForeColor = System.Drawing.Color.White;
            this.lblFDDetailsTitle.Location = new System.Drawing.Point(70, 0);
            this.lblFDDetailsTitle.Name = "lblFDDetailsTitle";
            this.lblFDDetailsTitle.Size = new System.Drawing.Size(105, 24);
            this.lblFDDetailsTitle.TabIndex = 0;
            this.lblFDDetailsTitle.Text = "FD Details";
            this.lblFDDetailsTitle.Click += new System.EventHandler(this.lblFDDetailsTitle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBtnFDDetailsPrint);
            this.groupBox1.Controls.Add(this.btnSaveUpdate);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtPurpose);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.rchRemarks);
            this.groupBox1.Controls.Add(this.dtpFDDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(30, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 201);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(180, 41);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(114, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.ValueChanged += new System.EventHandler(this.txtAmount_ValueChanged);
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(531, 41);
            this.txtPurpose.MaxLength = 100;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(204, 20);
            this.txtPurpose.TabIndex = 4;
            this.txtPurpose.TextChanged += new System.EventHandler(this.txtPurpose_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(343, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rchRemarks
            // 
            this.rchRemarks.Location = new System.Drawing.Point(17, 102);
            this.rchRemarks.Name = "rchRemarks";
            this.rchRemarks.Size = new System.Drawing.Size(320, 77);
            this.rchRemarks.TabIndex = 5;
            this.rchRemarks.Text = "";
            this.rchRemarks.TextChanged += new System.EventHandler(this.rchRemarks_TextChanged);
            // 
            // dtpFDDate
            // 
            this.dtpFDDate.Location = new System.Drawing.Point(16, 40);
            this.dtpFDDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFDDate.Name = "dtpFDDate";
            this.dtpFDDate.Size = new System.Drawing.Size(151, 20);
            this.dtpFDDate.TabIndex = 1;
            this.dtpFDDate.ValueChanged += new System.EventHandler(this.dtpFDDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Remarks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblFDDetailsTitle);
            this.panel3.Location = new System.Drawing.Point(26, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 33);
            this.panel3.TabIndex = 100;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pBtnFDDetailsPrint
            // 
            this.pBtnFDDetailsPrint.Image = global::NellaiBill.Properties.Resources.symbol_print;
            this.pBtnFDDetailsPrint.Location = new System.Drawing.Point(472, 139);
            this.pBtnFDDetailsPrint.Name = "pBtnFDDetailsPrint";
            this.pBtnFDDetailsPrint.Size = new System.Drawing.Size(47, 40);
            this.pBtnFDDetailsPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBtnFDDetailsPrint.TabIndex = 192;
            this.pBtnFDDetailsPrint.TabStop = false;
            this.pBtnFDDetailsPrint.Click += new System.EventHandler(this.pBtnFDDetailsPrint_Click);
            // 
            // FDDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FDDetails";
            this.Text = "FDDetails";
            this.Load += new System.EventHandler(this.FDDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBtnFDDetailsPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label lblFDDetailsTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchRemarks;
        private System.Windows.Forms.DateTimePicker dtpFDDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.PictureBox pBtnFDDetailsPrint;
    }
}