namespace InventoryManagementSystem
{
    partial class frmAddNewUserType
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddUserType = new System.Windows.Forms.Button();
            this.lblAddUserType = new System.Windows.Forms.Label();
            this.txtUserTypeName = new System.Windows.Forms.TextBox();
            this.txtUserTypeId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(147, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 33);
            this.buttonCancel.TabIndex = 74;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddUserType
            // 
            this.buttonAddUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddUserType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUserType.Location = new System.Drawing.Point(33, 136);
            this.buttonAddUserType.Name = "buttonAddUserType";
            this.buttonAddUserType.Size = new System.Drawing.Size(83, 33);
            this.buttonAddUserType.TabIndex = 73;
            this.buttonAddUserType.Text = "Add";
            this.buttonAddUserType.UseVisualStyleBackColor = false;
            this.buttonAddUserType.Click += new System.EventHandler(this.buttonAddUserType_Click);
            // 
            // lblAddUserType
            // 
            this.lblAddUserType.AutoSize = true;
            this.lblAddUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserType.Location = new System.Drawing.Point(58, 9);
            this.lblAddUserType.Name = "lblAddUserType";
            this.lblAddUserType.Size = new System.Drawing.Size(172, 25);
            this.lblAddUserType.TabIndex = 72;
            this.lblAddUserType.Text = "New User Type";
            // 
            // txtUserTypeName
            // 
            this.txtUserTypeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserTypeName.Location = new System.Drawing.Point(65, 88);
            this.txtUserTypeName.Name = "txtUserTypeName";
            this.txtUserTypeName.Size = new System.Drawing.Size(193, 26);
            this.txtUserTypeName.TabIndex = 71;
            // 
            // txtUserTypeId
            // 
            this.txtUserTypeId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserTypeId.Location = new System.Drawing.Point(65, 53);
            this.txtUserTypeId.Name = "txtUserTypeId";
            this.txtUserTypeId.Size = new System.Drawing.Size(193, 26);
            this.txtUserTypeId.TabIndex = 70;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(35, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 18);
            this.lblId.TabIndex = 69;
            this.lblId.Text = "ID:";
            // 
            // lblIName
            // 
            this.lblIName.AutoSize = true;
            this.lblIName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIName.Location = new System.Drawing.Point(10, 91);
            this.lblIName.Name = "lblIName";
            this.lblIName.Size = new System.Drawing.Size(52, 18);
            this.lblIName.TabIndex = 68;
            this.lblIName.Text = "Name:";
            // 
            // frmAddNewUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddUserType);
            this.Controls.Add(this.lblAddUserType);
            this.Controls.Add(this.txtUserTypeName);
            this.Controls.Add(this.txtUserTypeId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewUserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewUserType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddUserType;
        private System.Windows.Forms.Label lblAddUserType;
        private System.Windows.Forms.TextBox txtUserTypeName;
        private System.Windows.Forms.TextBox txtUserTypeId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIName;
    }
}