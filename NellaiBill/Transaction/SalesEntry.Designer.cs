namespace NellaiBill.Master
{
    partial class SalesEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_total_amount_value = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMrp = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rchCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.txtCustomerMobileNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtStockId = new System.Windows.Forms.TextBox();
            this.product_id = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtDiscPercentage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNoDg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAfterDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GstPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GstValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnLedgerSearch = new System.Windows.Forms.Button();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1015, 47);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(97, 26);
            this.txtQty.TabIndex = 13;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1024, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 684);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 46);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Amount";
            // 
            // lbl_total_amount_value
            // 
            this.lbl_total_amount_value.AutoSize = true;
            this.lbl_total_amount_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_amount_value.ForeColor = System.Drawing.Color.Red;
            this.lbl_total_amount_value.Location = new System.Drawing.Point(47, 734);
            this.lbl_total_amount_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_amount_value.Name = "lbl_total_amount_value";
            this.lbl_total_amount_value.Size = new System.Drawing.Size(43, 46);
            this.lbl_total_amount_value.TabIndex = 74;
            this.lbl_total_amount_value.Text = "0";
            // 
            // lblBatch
            // 
            this.lblBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(385, 91);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(58, 20);
            this.lblBatch.TabIndex = 17;
            this.lblBatch.Text = "Batch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(636, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mrp";
            // 
            // txtMrp
            // 
            this.txtMrp.Enabled = false;
            this.txtMrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrp.Location = new System.Drawing.Point(633, 47);
            this.txtMrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMrp.Name = "txtMrp";
            this.txtMrp.Size = new System.Drawing.Size(103, 26);
            this.txtMrp.TabIndex = 23;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(248, 92);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(56, 20);
            this.lblStock.TabIndex = 21;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(252, 114);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 26);
            this.txtStock.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(513, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Gst";
            // 
            // rchCustomerAddress
            // 
            this.rchCustomerAddress.Enabled = false;
            this.rchCustomerAddress.Location = new System.Drawing.Point(653, 55);
            this.rchCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchCustomerAddress.Name = "rchCustomerAddress";
            this.rchCustomerAddress.Size = new System.Drawing.Size(353, 56);
            this.rchCustomerAddress.TabIndex = 200;
            this.rchCustomerAddress.Text = "";
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.Enabled = false;
            this.txtCustomerMobileNo.Location = new System.Drawing.Point(653, 20);
            this.txtCustomerMobileNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.Size = new System.Drawing.Size(353, 24);
            this.txtCustomerMobileNo.TabIndex = 201;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(521, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 25);
            this.label19.TabIndex = 38;
            this.label19.Text = "Mobile No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(521, 55);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 25);
            this.label18.TabIndex = 35;
            this.label18.Text = "Address";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.txtSellingPrice);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtProductCode);
            this.panel4.Controls.Add(this.btnItemSearch);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtUnitPrice);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.txtStockId);
            this.panel4.Controls.Add(this.product_id);
            this.panel4.Controls.Add(this.txtItemNo);
            this.panel4.Controls.Add(this.txtItem);
            this.panel4.Controls.Add(this.txtBatch);
            this.panel4.Controls.Add(this.txtTax);
            this.panel4.Controls.Add(this.txtDiscPercentage);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.txtDiscountValue);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.txtExpDate);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtStock);
            this.panel4.Controls.Add(this.lblStock);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblBatch);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtQty);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtMrp);
            this.panel4.Location = new System.Drawing.Point(16, 188);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1643, 178);
            this.panel4.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(875, 15);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 20);
            this.label23.TabIndex = 64;
            this.label23.Text = "Selling Price";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(879, 47);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(93, 26);
            this.txtSellingPrice.TabIndex = 63;
            this.txtSellingPrice.TextChanged += new System.EventHandler(this.txtSellingPrice_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 62;
            this.label13.Text = "Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Enabled = false;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(4, 47);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(107, 26);
            this.txtProductCode.TabIndex = 11;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.BackColor = System.Drawing.Color.Lime;
            this.btnItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSearch.Location = new System.Drawing.Point(195, 4);
            this.btnItemSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(220, 36);
            this.btnItemSearch.TabIndex = 61;
            this.btnItemSearch.Text = "SEARCH (CTRL+I)";
            this.btnItemSearch.UseVisualStyleBackColor = false;
            this.btnItemSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(759, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 59;
            this.label14.Text = "Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(763, 47);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(93, 26);
            this.txtUnitPrice.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(124, 91);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 20);
            this.label22.TabIndex = 57;
            this.label22.Text = "StockId";
            // 
            // txtStockId
            // 
            this.txtStockId.Enabled = false;
            this.txtStockId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockId.Location = new System.Drawing.Point(128, 116);
            this.txtStockId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockId.Name = "txtStockId";
            this.txtStockId.Size = new System.Drawing.Size(103, 26);
            this.txtStockId.TabIndex = 19;
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id.Location = new System.Drawing.Point(4, 92);
            this.product_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(24, 20);
            this.product_id.TabIndex = 55;
            this.product_id.Text = "Id";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Enabled = false;
            this.txtItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(4, 117);
            this.txtItemNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(103, 26);
            this.txtItemNo.TabIndex = 18;
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(120, 47);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(377, 26);
            this.txtItem.TabIndex = 12;
            // 
            // txtBatch
            // 
            this.txtBatch.Enabled = false;
            this.txtBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.Location = new System.Drawing.Point(385, 116);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(389, 26);
            this.txtBatch.TabIndex = 21;
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(517, 47);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 26);
            this.txtTax.TabIndex = 17;
            // 
            // txtDiscPercentage
            // 
            this.txtDiscPercentage.Enabled = false;
            this.txtDiscPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscPercentage.Location = new System.Drawing.Point(908, 121);
            this.txtDiscPercentage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiscPercentage.Name = "txtDiscPercentage";
            this.txtDiscPercentage.Size = new System.Drawing.Size(100, 26);
            this.txtDiscPercentage.TabIndex = 14;
            this.txtDiscPercentage.Visible = false;
            this.txtDiscPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscPercentage_KeyPress);
            this.txtDiscPercentage.Leave += new System.EventHandler(this.txtDiscPercentage_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(904, 92);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.TabIndex = 51;
            this.label20.Text = "Discount%";
            this.label20.Visible = false;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Enabled = false;
            this.txtDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountValue.Location = new System.Drawing.Point(1039, 121);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(100, 26);
            this.txtDiscountValue.TabIndex = 15;
            this.txtDiscountValue.Visible = false;
            this.txtDiscountValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountValue_KeyPress);
            this.txtDiscountValue.Leave += new System.EventHandler(this.txtDiscountValue_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1035, 92);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 20);
            this.label21.TabIndex = 48;
            this.label21.Text = "Dis Val";
            this.label21.Visible = false;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Enabled = false;
            this.txtExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Location = new System.Drawing.Point(799, 116);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(85, 26);
            this.txtExpDate.TabIndex = 22;
            this.txtExpDate.Visible = false;
            // 
            // label15
            // 
            this.label15.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(795, 91);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "ExpDate";
            this.label15.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1183, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 96);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "ADD (CTRL+A)";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemNoDg1,
            this.product_name,
            this.Batch,
            this.ExpDate,
            this.Stock,
            this.UnitPrice,
            this.UnitSP,
            this.Mrp,
            this.Qty,
            this.Amount,
            this.DiscPercentage,
            this.DiscValue,
            this.AmountAfterDiscount,
            this.GstPercentage,
            this.GstValue,
            this.TotalAmount,
            this.DGDelete});
            this.dataGridView1.Location = new System.Drawing.Point(16, 374);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.Size = new System.Drawing.Size(1643, 299);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Id
            // 
            this.Id.FillWeight = 46.63264F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ItemNoDg1
            // 
            this.ItemNoDg1.HeaderText = "ItemNoDg1";
            this.ItemNoDg1.MinimumWidth = 6;
            this.ItemNoDg1.Name = "ItemNoDg1";
            this.ItemNoDg1.Visible = false;
            // 
            // product_name
            // 
            this.product_name.FillWeight = 253.8071F;
            this.product_name.HeaderText = "Item Name";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // Batch
            // 
            this.Batch.FillWeight = 129.7703F;
            this.Batch.HeaderText = "Batch";
            this.Batch.MinimumWidth = 6;
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.FillWeight = 75.35877F;
            this.ExpDate.HeaderText = "Exp Date";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            this.ExpDate.Visible = false;
            // 
            // Stock
            // 
            this.Stock.FillWeight = 76.29374F;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 74.59606F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // UnitSP
            // 
            this.UnitSP.HeaderText = "UnitSP";
            this.UnitSP.MinimumWidth = 6;
            this.UnitSP.Name = "UnitSP";
            // 
            // Mrp
            // 
            this.Mrp.HeaderText = "Mrp";
            this.Mrp.MinimumWidth = 6;
            this.Mrp.Name = "Mrp";
            this.Mrp.Visible = false;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 72.75848F;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 96.89227F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DiscPercentage
            // 
            this.DiscPercentage.HeaderText = "D-%";
            this.DiscPercentage.MinimumWidth = 6;
            this.DiscPercentage.Name = "DiscPercentage";
            this.DiscPercentage.ReadOnly = true;
            this.DiscPercentage.Visible = false;
            // 
            // DiscValue
            // 
            this.DiscValue.HeaderText = "D-Value";
            this.DiscValue.MinimumWidth = 6;
            this.DiscValue.Name = "DiscValue";
            this.DiscValue.ReadOnly = true;
            this.DiscValue.Visible = false;
            // 
            // AmountAfterDiscount
            // 
            this.AmountAfterDiscount.HeaderText = "AAD";
            this.AmountAfterDiscount.MinimumWidth = 6;
            this.AmountAfterDiscount.Name = "AmountAfterDiscount";
            this.AmountAfterDiscount.ReadOnly = true;
            this.AmountAfterDiscount.Visible = false;
            // 
            // GstPercentage
            // 
            this.GstPercentage.HeaderText = "Gst %";
            this.GstPercentage.MinimumWidth = 6;
            this.GstPercentage.Name = "GstPercentage";
            this.GstPercentage.ReadOnly = true;
            this.GstPercentage.Visible = false;
            // 
            // GstValue
            // 
            this.GstValue.FillWeight = 76.99837F;
            this.GstValue.HeaderText = "Gst Value";
            this.GstValue.MinimumWidth = 6;
            this.GstValue.Name = "GstValue";
            this.GstValue.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // DGDelete
            // 
            this.DGDelete.HeaderText = "";
            this.DGDelete.MinimumWidth = 6;
            this.DGDelete.Name = "DGDelete";
            this.DGDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(16, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1643, 37);
            this.panel3.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(724, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sales  Entry";
            // 
            // cmbBillType
            // 
            this.cmbBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillType.Enabled = false;
            this.cmbBillType.FormattingEnabled = true;
            this.cmbBillType.Items.AddRange(new object[] {
            "Please Select",
            "IP",
            "OP",
            "NON-OP",
            "COURIER"});
            this.cmbBillType.Location = new System.Drawing.Point(193, 89);
            this.cmbBillType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(83, 24);
            this.cmbBillType.TabIndex = 2;
            this.cmbBillType.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(189, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bill Type";
            this.label6.Visible = false;
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.Enabled = false;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Please Select",
            "Cash",
            "Credit",
            "Online",
            "Cheque"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(889, 695);
            this.cmbPaymentMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(132, 24);
            this.cmbPaymentMode.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 695);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mode of Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(21, 86);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 31);
            this.label17.TabIndex = 34;
            this.label17.Text = "InvNo";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.Red;
            this.lblInvoiceNo.Location = new System.Drawing.Point(111, 9);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(33, 36);
            this.lblInvoiceNo.TabIndex = 35;
            this.lblInvoiceNo.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbBillType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(16, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 128);
            this.panel1.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 736);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(549, 736);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(144, 26);
            this.txtBalance.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(447, 695);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Paid";
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(549, 695);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(144, 26);
            this.txtPaid.TabIndex = 51;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.Color.Lime;
            this.btnSaveBill.Enabled = false;
            this.btnSaveBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.Location = new System.Drawing.Point(1044, 684);
            this.btnSaveBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(125, 80);
            this.btnSaveBill.TabIndex = 59;
            this.btnSaveBill.Text = "SAVE (CTRL+S)";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.btnLedgerSearch);
            this.groupBox1.Controls.Add(this.txtCustomerNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCustomerMobileNo);
            this.groupBox1.Controls.Add(this.rchCustomerAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(303, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1212, 128);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details(Add Customer  - Ctrl+F2)";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(105, 59);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(383, 24);
            this.txtCustomerName.TabIndex = 204;
            // 
            // btnLedgerSearch
            // 
            this.btnLedgerSearch.BackColor = System.Drawing.Color.Lime;
            this.btnLedgerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedgerSearch.Location = new System.Drawing.Point(1016, 15);
            this.btnLedgerSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLedgerSearch.Name = "btnLedgerSearch";
            this.btnLedgerSearch.Size = new System.Drawing.Size(136, 58);
            this.btnLedgerSearch.TabIndex = 62;
            this.btnLedgerSearch.Text = "SEARCH (CTRL+L)";
            this.btnLedgerSearch.UseVisualStyleBackColor = false;
            this.btnLedgerSearch.Click += new System.EventHandler(this.txtLedgerSearch_Click);
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Enabled = false;
            this.txtCustomerNo.Location = new System.Drawing.Point(105, 23);
            this.txtCustomerNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(147, 24);
            this.txtCustomerNo.TabIndex = 203;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 202;
            this.label8.Text = "Id";
            // 
            // SalesEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1714, 789);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPaymentMode);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_total_amount_value);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalesEntry";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesEntry_KeyDown);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_total_amount_value;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMrp;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCustomerMobileNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rchCustomerAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbBillType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiscPercentage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtStockId;
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLedgerSearch;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNoDg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountAfterDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GstPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn GstValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn DGDelete;
    }
}