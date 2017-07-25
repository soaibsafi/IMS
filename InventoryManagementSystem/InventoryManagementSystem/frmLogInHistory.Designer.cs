namespace InventoryManagementSystem
{
    partial class frmLogInHistory
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
            this.listViewLogInHistory = new System.Windows.Forms.ListView();
            this.colLogInHistoryUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLogInHistoryUserType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLogInHistoryTimeIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLogInHistoryTimeOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLogInHistory
            // 
            this.listViewLogInHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLogInHistoryUsername,
            this.colLogInHistoryUserType,
            this.colLogInHistoryTimeIn,
            this.colLogInHistoryTimeOut});
            this.listViewLogInHistory.Location = new System.Drawing.Point(29, 40);
            this.listViewLogInHistory.Name = "listViewLogInHistory";
            this.listViewLogInHistory.Size = new System.Drawing.Size(790, 316);
            this.listViewLogInHistory.TabIndex = 41;
            this.listViewLogInHistory.UseCompatibleStateImageBehavior = false;
            this.listViewLogInHistory.View = System.Windows.Forms.View.Details;
            // 
            // colLogInHistoryUsername
            // 
            this.colLogInHistoryUsername.Text = "Username";
            this.colLogInHistoryUsername.Width = 170;
            // 
            // colLogInHistoryUserType
            // 
            this.colLogInHistoryUserType.Text = "User Type";
            this.colLogInHistoryUserType.Width = 159;
            // 
            // colLogInHistoryTimeIn
            // 
            this.colLogInHistoryTimeIn.Text = "Time In";
            this.colLogInHistoryTimeIn.Width = 226;
            // 
            // colLogInHistoryTimeOut
            // 
            this.colLogInHistoryTimeOut.Text = "Time Out";
            this.colLogInHistoryTimeOut.Width = 209;
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.Red;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.Location = new System.Drawing.Point(29, 366);
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
            this.btnBack.Location = new System.Drawing.Point(176, 366);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 39);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LogInHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.listViewLogInHistory);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLogInHistory;
        private System.Windows.Forms.ColumnHeader colLogInHistoryUsername;
        private System.Windows.Forms.ColumnHeader colLogInHistoryUserType;
        private System.Windows.Forms.ColumnHeader colLogInHistoryTimeIn;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader colLogInHistoryTimeOut;
    }
}