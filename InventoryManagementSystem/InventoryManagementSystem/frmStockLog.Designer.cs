namespace InventoryManagementSystem
{
    partial class frmStockLog
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
            this.listViewStockLog = new System.Windows.Forms.ListView();
            this.colItemLogItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockLogStockAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockLogDateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewStockLog
            // 
            this.listViewStockLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemLogItem,
            this.colStockLogStockAdded,
            this.colStockLogDateAdded});
            this.listViewStockLog.Location = new System.Drawing.Point(29, 40);
            this.listViewStockLog.Name = "listViewStockLog";
            this.listViewStockLog.Size = new System.Drawing.Size(790, 316);
            this.listViewStockLog.TabIndex = 41;
            this.listViewStockLog.UseCompatibleStateImageBehavior = false;
            this.listViewStockLog.View = System.Windows.Forms.View.Details;
            // 
            // colItemLogItem
            // 
            this.colItemLogItem.Text = "Item Name";
            this.colItemLogItem.Width = 305;
            // 
            // colStockLogStockAdded
            // 
            this.colStockLogStockAdded.Text = "Stock Added";
            this.colStockLogStockAdded.Width = 213;
            // 
            // colStockLogDateAdded
            // 
            this.colStockLogDateAdded.Text = "Date & Time";
            this.colStockLogDateAdded.Width = 254;
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.Red;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.Location = new System.Drawing.Point(29, 362);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(141, 39);
            this.btnClearLog.TabIndex = 43;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(176, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 39);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StockLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.listViewStockLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewStockLog;
        private System.Windows.Forms.ColumnHeader colItemLogItem;
        private System.Windows.Forms.ColumnHeader colStockLogStockAdded;
        private System.Windows.Forms.ColumnHeader colStockLogDateAdded;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnBack;
    }
}