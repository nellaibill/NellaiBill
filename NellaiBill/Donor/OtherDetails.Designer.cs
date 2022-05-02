
namespace NellaiBill.Donor
{
    partial class OtherDetails
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
            this.rchRemarks = new System.Windows.Forms.RichTextBox();
            this.lblOtherDetailsTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.Green;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveUpdate.Location = new System.Drawing.Point(997, 73);
            this.btnSaveUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(129, 71);
            this.btnSaveUpdate.TabIndex = 102;
            this.btnSaveUpdate.Text = "SAVE";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // rchRemarks
            // 
            this.rchRemarks.Location = new System.Drawing.Point(22, 73);
            this.rchRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.rchRemarks.Name = "rchRemarks";
            this.rchRemarks.Size = new System.Drawing.Size(967, 260);
            this.rchRemarks.TabIndex = 5;
            this.rchRemarks.Text = "";
            // 
            // lblOtherDetailsTitle
            // 
            this.lblOtherDetailsTitle.AutoSize = true;
            this.lblOtherDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOtherDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherDetailsTitle.ForeColor = System.Drawing.Color.White;
            this.lblOtherDetailsTitle.Location = new System.Drawing.Point(34, 11);
            this.lblOtherDetailsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtherDetailsTitle.Name = "lblOtherDetailsTitle";
            this.lblOtherDetailsTitle.Size = new System.Drawing.Size(173, 29);
            this.lblOtherDetailsTitle.TabIndex = 0;
            this.lblOtherDetailsTitle.Text = "Other  Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblOtherDetailsTitle);
            this.panel3.Location = new System.Drawing.Point(22, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 52);
            this.panel3.TabIndex = 105;
            // 
            // OtherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 554);
            this.Controls.Add(this.rchRemarks);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.panel3);
            this.Name = "OtherDetails";
            this.Text = "OtherDetails";
            this.Load += new System.EventHandler(this.OtherDetails_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.RichTextBox rchRemarks;
        internal System.Windows.Forms.Label lblOtherDetailsTitle;
        internal System.Windows.Forms.Panel panel3;
    }
}