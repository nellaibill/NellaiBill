﻿namespace NellaiBill.Master
{
    partial class frmItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chboxNorcatic = new System.Windows.Forms.CheckBox();
            this.chboxScheduleHp = new System.Windows.Forms.CheckBox();
            this.chboxScheduleH = new System.Windows.Forms.CheckBox();
            this.lblMrp = new System.Windows.Forms.Label();
            this.txtMrp = new System.Windows.Forms.TextBox();
            this.lblProductNameInTamil = new System.Windows.Forms.Label();
            this.txtProductNameInTamil = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblNorcatic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSchHPlus = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.lbSchH = new System.Windows.Forms.Label();
            this.lbSalt = new System.Windows.Forms.Label();
            this.lblHsnCode = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.mBtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mBtnSaveUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(520, 104);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(78, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.Visible = false;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category";
            this.label2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 407);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(206, 39);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(283, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Name";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(19, 39);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(173, 21);
            this.cmbGroup.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Group";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chboxNorcatic);
            this.panel2.Controls.Add(this.chboxScheduleHp);
            this.panel2.Controls.Add(this.chboxScheduleH);
            this.panel2.Controls.Add(this.lblMrp);
            this.panel2.Controls.Add(this.txtMrp);
            this.panel2.Controls.Add(this.lblProductNameInTamil);
            this.panel2.Controls.Add(this.txtProductNameInTamil);
            this.panel2.Controls.Add(this.lblProductCode);
            this.panel2.Controls.Add(this.txtProductCode);
            this.panel2.Controls.Add(this.lblNorcatic);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSchHPlus);
            this.panel2.Controls.Add(this.cmbTax);
            this.panel2.Controls.Add(this.lbSchH);
            this.panel2.Controls.Add(this.lbSalt);
            this.panel2.Controls.Add(this.lblHsnCode);
            this.panel2.Controls.Add(this.txtSalt);
            this.panel2.Controls.Add(this.txtHsnCode);
            this.panel2.Controls.Add(this.mBtnCancel);
            this.panel2.Controls.Add(this.mBtnSaveUpdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbGroup);
            this.panel2.Location = new System.Drawing.Point(12, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 154);
            this.panel2.TabIndex = 29;
            // 
            // chboxNorcatic
            // 
            this.chboxNorcatic.AutoSize = true;
            this.chboxNorcatic.Location = new System.Drawing.Point(912, 130);
            this.chboxNorcatic.Name = "chboxNorcatic";
            this.chboxNorcatic.Size = new System.Drawing.Size(15, 14);
            this.chboxNorcatic.TabIndex = 56;
            this.chboxNorcatic.UseVisualStyleBackColor = true;
            this.chboxNorcatic.CheckedChanged += new System.EventHandler(this.chboxNorcatic_CheckedChanged);
            // 
            // chboxScheduleHp
            // 
            this.chboxScheduleHp.AutoSize = true;
            this.chboxScheduleHp.Location = new System.Drawing.Point(912, 104);
            this.chboxScheduleHp.Name = "chboxScheduleHp";
            this.chboxScheduleHp.Size = new System.Drawing.Size(15, 14);
            this.chboxScheduleHp.TabIndex = 56;
            this.chboxScheduleHp.UseVisualStyleBackColor = true;
            this.chboxScheduleHp.CheckedChanged += new System.EventHandler(this.chboxScheduleHp_CheckedChanged);
            // 
            // chboxScheduleH
            // 
            this.chboxScheduleH.AutoSize = true;
            this.chboxScheduleH.Location = new System.Drawing.Point(912, 75);
            this.chboxScheduleH.Name = "chboxScheduleH";
            this.chboxScheduleH.Size = new System.Drawing.Size(15, 14);
            this.chboxScheduleH.TabIndex = 56;
            this.chboxScheduleH.UseVisualStyleBackColor = true;
            this.chboxScheduleH.CheckedChanged += new System.EventHandler(this.chboxScheduleH_CheckedChanged);
            // 
            // lblMrp
            // 
            this.lblMrp.AutoSize = true;
            this.lblMrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMrp.Location = new System.Drawing.Point(15, 75);
            this.lblMrp.Name = "lblMrp";
            this.lblMrp.Size = new System.Drawing.Size(43, 24);
            this.lblMrp.TabIndex = 55;
            this.lblMrp.Text = "Mrp";
            // 
            // txtMrp
            // 
            this.txtMrp.Location = new System.Drawing.Point(19, 102);
            this.txtMrp.Name = "txtMrp";
            this.txtMrp.Size = new System.Drawing.Size(91, 20);
            this.txtMrp.TabIndex = 6;
            this.txtMrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMrp_KeyPress);
            // 
            // lblProductNameInTamil
            // 
            this.lblProductNameInTamil.AutoSize = true;
            this.lblProductNameInTamil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameInTamil.Location = new System.Drawing.Point(202, 75);
            this.lblProductNameInTamil.Name = "lblProductNameInTamil";
            this.lblProductNameInTamil.Size = new System.Drawing.Size(207, 24);
            this.lblProductNameInTamil.TabIndex = 53;
            this.lblProductNameInTamil.Text = "Product Name  In Tamil";
            // 
            // txtProductNameInTamil
            // 
            this.txtProductNameInTamil.Location = new System.Drawing.Point(206, 102);
            this.txtProductNameInTamil.Name = "txtProductNameInTamil";
            this.txtProductNameInTamil.Size = new System.Drawing.Size(283, 20);
            this.txtProductNameInTamil.TabIndex = 8;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(619, 12);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(126, 24);
            this.lblProductCode.TabIndex = 51;
            this.lblProductCode.Text = "Product Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(623, 40);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(142, 20);
            this.txtProductCode.TabIndex = 5;
            this.txtProductCode.Leave += new System.EventHandler(this.txtProductCode_Leave);
            // 
            // lblNorcatic
            // 
            this.lblNorcatic.AutoSize = true;
            this.lblNorcatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorcatic.Location = new System.Drawing.Point(827, 120);
            this.lblNorcatic.Name = "lblNorcatic";
            this.lblNorcatic.Size = new System.Drawing.Size(79, 24);
            this.lblNorcatic.TabIndex = 48;
            this.lblNorcatic.Text = "Norcatic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Gst";
            // 
            // lblSchHPlus
            // 
            this.lblSchHPlus.AutoSize = true;
            this.lblSchHPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchHPlus.Location = new System.Drawing.Point(780, 98);
            this.lblSchHPlus.Name = "lblSchHPlus";
            this.lblSchHPlus.Size = new System.Drawing.Size(126, 24);
            this.lblSchHPlus.TabIndex = 48;
            this.lblSchHPlus.Text = "Schedule H +";
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Items.AddRange(new object[] {
            "5",
            "12",
            "18",
            "28"});
            this.cmbTax.Location = new System.Drawing.Point(507, 39);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(105, 21);
            this.cmbTax.TabIndex = 4;
            // 
            // lbSchH
            // 
            this.lbSchH.AutoSize = true;
            this.lbSchH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSchH.Location = new System.Drawing.Point(796, 75);
            this.lbSchH.Name = "lbSchH";
            this.lbSchH.Size = new System.Drawing.Size(110, 24);
            this.lbSchH.TabIndex = 48;
            this.lbSchH.Text = "Schedule H";
            // 
            // lbSalt
            // 
            this.lbSalt.AutoSize = true;
            this.lbSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalt.Location = new System.Drawing.Point(629, 75);
            this.lbSalt.Name = "lbSalt";
            this.lbSalt.Size = new System.Drawing.Size(40, 24);
            this.lbSalt.TabIndex = 48;
            this.lbSalt.Text = "Salt";
            // 
            // lblHsnCode
            // 
            this.lblHsnCode.AutoSize = true;
            this.lblHsnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsnCode.Location = new System.Drawing.Point(766, 11);
            this.lblHsnCode.Name = "lblHsnCode";
            this.lblHsnCode.Size = new System.Drawing.Size(95, 24);
            this.lblHsnCode.TabIndex = 48;
            this.lblHsnCode.Text = "Hsn Code";
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(623, 104);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(91, 20);
            this.txtSalt.TabIndex = 7;
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.Location = new System.Drawing.Point(771, 40);
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(91, 20);
            this.txtHsnCode.TabIndex = 7;
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Depth = 0;
            this.mBtnCancel.Location = new System.Drawing.Point(932, 66);
            this.mBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Primary = true;
            this.mBtnCancel.Size = new System.Drawing.Size(136, 48);
            this.mBtnCancel.TabIndex = 45;
            this.mBtnCancel.Text = "CANCEL";
            this.mBtnCancel.UseVisualStyleBackColor = true;
            this.mBtnCancel.Click += new System.EventHandler(this.mBtnCancel_Click);
            // 
            // mBtnSaveUpdate
            // 
            this.mBtnSaveUpdate.Depth = 0;
            this.mBtnSaveUpdate.Location = new System.Drawing.Point(932, 12);
            this.mBtnSaveUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnSaveUpdate.Name = "mBtnSaveUpdate";
            this.mBtnSaveUpdate.Primary = true;
            this.mBtnSaveUpdate.Size = new System.Drawing.Size(136, 48);
            this.mBtnSaveUpdate.TabIndex = 43;
            this.mBtnSaveUpdate.Text = "SAVE";
            this.mBtnSaveUpdate.UseVisualStyleBackColor = true;
            this.mBtnSaveUpdate.Click += new System.EventHandler(this.mBtnSaveUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 33);
            this.panel3.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(404, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Entry";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(858, 211);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 20);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(779, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Search Here..";
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 623);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmItem";
            this.Text = "Item";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Item_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnSaveUpdate;
        private System.Windows.Forms.Label lblHsnCode;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTax;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnCancel;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductNameInTamil;
        private System.Windows.Forms.TextBox txtProductNameInTamil;
        private System.Windows.Forms.Label lblMrp;
        private System.Windows.Forms.TextBox txtMrp;
        private System.Windows.Forms.CheckBox chboxScheduleH;
        private System.Windows.Forms.Label lbSchH;
        private System.Windows.Forms.Label lbSalt;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.CheckBox chboxNorcatic;
        private System.Windows.Forms.CheckBox chboxScheduleHp;
        private System.Windows.Forms.Label lblNorcatic;
        private System.Windows.Forms.Label lblSchHPlus;
    }
}