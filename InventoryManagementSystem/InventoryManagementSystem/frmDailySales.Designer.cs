namespace InventoryManagementSystem
{
    partial class frmDailySales
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTransCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemCodeSales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemNameSales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPriceSales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDailySalesPop = new System.Windows.Forms.Label();
            this.lblMaylySalesDate = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblTotalDailyTrans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalTrans = new System.Windows.Forms.TextBox();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTransCode,
            this.colDate,
            this.colItemCodeSales,
            this.colItemNameSales,
            this.colPriceSales,
            this.colQuantity,
            this.colTotal});
            this.listView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(18, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(846, 278);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colTransCode
            // 
            this.colTransCode.Text = "Transaction code";
            this.colTransCode.Width = 114;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 147;
            // 
            // colItemCodeSales
            // 
            this.colItemCodeSales.Text = "Item Code";
            this.colItemCodeSales.Width = 82;
            // 
            // colItemNameSales
            // 
            this.colItemNameSales.Text = "Item";
            this.colItemNameSales.Width = 170;
            // 
            // colPriceSales
            // 
            this.colPriceSales.Text = "Price";
            this.colPriceSales.Width = 110;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 113;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.Width = 85;
            // 
            // lblDailySalesPop
            // 
            this.lblDailySalesPop.AutoSize = true;
            this.lblDailySalesPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailySalesPop.Location = new System.Drawing.Point(342, 19);
            this.lblDailySalesPop.Name = "lblDailySalesPop";
            this.lblDailySalesPop.Size = new System.Drawing.Size(109, 16);
            this.lblDailySalesPop.TabIndex = 11;
            this.lblDailySalesPop.Text = "List of Sales For: ";
            // 
            // lblMaylySalesDate
            // 
            this.lblMaylySalesDate.AutoSize = true;
            this.lblMaylySalesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaylySalesDate.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblMaylySalesDate.Location = new System.Drawing.Point(447, 15);
            this.lblMaylySalesDate.Name = "lblMaylySalesDate";
            this.lblMaylySalesDate.Size = new System.Drawing.Size(115, 20);
            this.lblMaylySalesDate.TabIndex = 12;
            this.lblMaylySalesDate.Text = "5 April, 2017 ";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(18, 343);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(94, 39);
            this.btnDeleteItem.TabIndex = 18;
            this.btnDeleteItem.Text = "Back";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblTotalDailyTrans
            // 
            this.lblTotalDailyTrans.AutoSize = true;
            this.lblTotalDailyTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDailyTrans.Location = new System.Drawing.Point(307, 352);
            this.lblTotalDailyTrans.Name = "lblTotalDailyTrans";
            this.lblTotalDailyTrans.Size = new System.Drawing.Size(116, 16);
            this.lblTotalDailyTrans.TabIndex = 19;
            this.lblTotalDailyTrans.Text = "Total Transaction:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Sales:";
            // 
            // txtTotalTrans
            // 
            this.txtTotalTrans.Enabled = false;
            this.txtTotalTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTrans.Location = new System.Drawing.Point(429, 346);
            this.txtTotalTrans.Name = "txtTotalTrans";
            this.txtTotalTrans.Size = new System.Drawing.Size(114, 31);
            this.txtTotalTrans.TabIndex = 21;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Enabled = false;
            this.txtTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSales.Location = new System.Drawing.Point(750, 343);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(114, 31);
            this.txtTotalSales.TabIndex = 22;
            // 
            // DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(884, 407);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.txtTotalTrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalDailyTrans);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lblMaylySalesDate);
            this.Controls.Add(this.lblDailySalesPop);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailySales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTransCode;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colItemCodeSales;
        private System.Windows.Forms.ColumnHeader colItemNameSales;
        private System.Windows.Forms.ColumnHeader colPriceSales;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.Label lblDailySalesPop;
        private System.Windows.Forms.Label lblMaylySalesDate;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblTotalDailyTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalTrans;
        private System.Windows.Forms.TextBox txtTotalSales;
    }
}