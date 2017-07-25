namespace InventoryManagementSystem
{
    partial class frmAccountLog
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
            this.listViewAccountLog = new System.Windows.Forms.ListView();
            this.colAccountLogUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccountLogDateAndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccountLogAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAccountLog
            // 
            this.listViewAccountLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccountLogUsername,
            this.colAccountLogDateAndTime,
            this.colAccountLogAction});
            this.listViewAccountLog.Location = new System.Drawing.Point(29, 47);
            this.listViewAccountLog.Name = "listViewAccountLog";
            this.listViewAccountLog.Size = new System.Drawing.Size(790, 301);
            this.listViewAccountLog.TabIndex = 38;
            this.listViewAccountLog.UseCompatibleStateImageBehavior = false;
            this.listViewAccountLog.View = System.Windows.Forms.View.Details;
            // 
            // colAccountLogUsername
            // 
            this.colAccountLogUsername.Text = "Username";
            this.colAccountLogUsername.Width = 249;
            // 
            // colAccountLogDateAndTime
            // 
            this.colAccountLogDateAndTime.Text = "Date & Time";
            this.colAccountLogDateAndTime.Width = 353;
            // 
            // colAccountLogAction
            // 
            this.colAccountLogAction.Text = "Action";
            this.colAccountLogAction.Width = 133;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 40;
            this.button1.Text = "Clear Log";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(176, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 39);
            this.button2.TabIndex = 39;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.listViewAccountLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccountLog;
        private System.Windows.Forms.ColumnHeader colAccountLogUsername;
        private System.Windows.Forms.ColumnHeader colAccountLogDateAndTime;
        private System.Windows.Forms.ColumnHeader colAccountLogAction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}