namespace InventoryManagementSystem
{
    partial class frmItemLog
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
            this.listViewItemLog = new System.Windows.Forms.ListView();
            this.colItemLogItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemLogDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemLogAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewItemLog
            // 
            this.listViewItemLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemLogItem,
            this.colItemLogDate,
            this.colItemLogAction});
            this.listViewItemLog.Location = new System.Drawing.Point(47, 48);
            this.listViewItemLog.Name = "listViewItemLog";
            this.listViewItemLog.Size = new System.Drawing.Size(750, 308);
            this.listViewItemLog.TabIndex = 0;
            this.listViewItemLog.UseCompatibleStateImageBehavior = false;
            this.listViewItemLog.View = System.Windows.Forms.View.Details;
            // 
            // colItemLogItem
            // 
            this.colItemLogItem.Text = "Item Name";
            this.colItemLogItem.Width = 249;
            // 
            // colItemLogDate
            // 
            this.colItemLogDate.Text = "Date & Time";
            this.colItemLogDate.Width = 353;
            // 
            // colItemLogAction
            // 
            this.colItemLogAction.Text = "Action";
            this.colItemLogAction.Width = 133;
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.Red;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.Location = new System.Drawing.Point(47, 362);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(141, 39);
            this.btnClearLog.TabIndex = 37;
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
            this.btnBack.Location = new System.Drawing.Point(194, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 39);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ItemLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listViewItemLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewItemLog;
        private System.Windows.Forms.ColumnHeader colItemLogItem;
        private System.Windows.Forms.ColumnHeader colItemLogDate;
        private System.Windows.Forms.ColumnHeader colItemLogAction;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnBack;
    }
}