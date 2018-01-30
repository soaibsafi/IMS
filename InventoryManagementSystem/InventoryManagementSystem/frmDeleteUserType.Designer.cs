namespace InventoryManagementSystem
{
    partial class frmDeleteUserType
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewDeleteUserType = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imsDBDataSet = new InventoryManagementSystem.imsDBDataSet();
            this.lblRemoveUserType = new System.Windows.Forms.Label();
            this.btnRemoveUserType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserTypeId = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new InventoryManagementSystem.imsDBDataSetTableAdapters.CategoryTableAdapter();
            this.txtUserTypeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTypeTableAdapter = new InventoryManagementSystem.imsDBDataSetTableAdapters.UserTypeTableAdapter();
            this.userTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteUserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeleteUserType
            // 
            this.dataGridViewDeleteUserType.AllowUserToAddRows = false;
            this.dataGridViewDeleteUserType.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteUserType.AutoGenerateColumns = false;
            this.dataGridViewDeleteUserType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteUserType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userTypeIdDataGridViewTextBoxColumn});
            this.dataGridViewDeleteUserType.DataSource = this.userTypeBindingSource;
            this.dataGridViewDeleteUserType.Location = new System.Drawing.Point(165, 54);
            this.dataGridViewDeleteUserType.Name = "dataGridViewDeleteUserType";
            this.dataGridViewDeleteUserType.ReadOnly = true;
            this.dataGridViewDeleteUserType.Size = new System.Drawing.Size(148, 150);
            this.dataGridViewDeleteUserType.TabIndex = 91;
            this.dataGridViewDeleteUserType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeleteUserType_CellContentClick);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.imsDBDataSet;
            // 
            // imsDBDataSet
            // 
            this.imsDBDataSet.DataSetName = "imsDBDataSet";
            this.imsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRemoveUserType
            // 
            this.lblRemoveUserType.AutoSize = true;
            this.lblRemoveUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveUserType.Location = new System.Drawing.Point(59, 5);
            this.lblRemoveUserType.Name = "lblRemoveUserType";
            this.lblRemoveUserType.Size = new System.Drawing.Size(212, 25);
            this.lblRemoveUserType.TabIndex = 90;
            this.lblRemoveUserType.Text = "Remove User Type";
            // 
            // btnRemoveUserType
            // 
            this.btnRemoveUserType.BackColor = System.Drawing.Color.Red;
            this.btnRemoveUserType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUserType.Location = new System.Drawing.Point(69, 260);
            this.btnRemoveUserType.Name = "btnRemoveUserType";
            this.btnRemoveUserType.Size = new System.Drawing.Size(83, 33);
            this.btnRemoveUserType.TabIndex = 94;
            this.btnRemoveUserType.Text = "Delete";
            this.btnRemoveUserType.UseVisualStyleBackColor = false;
            this.btnRemoveUserType.Click += new System.EventHandler(this.btnRemoveUserType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(171, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 33);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserTypeId
            // 
            this.lblUserTypeId.AutoSize = true;
            this.lblUserTypeId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTypeId.Location = new System.Drawing.Point(7, 57);
            this.lblUserTypeId.Name = "lblUserTypeId";
            this.lblUserTypeId.Size = new System.Drawing.Size(152, 18);
            this.lblUserTypeId.TabIndex = 92;
            this.lblUserTypeId.Text = "Select User Type ID:";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // txtUserTypeID
            // 
            this.txtUserTypeID.Enabled = false;
            this.txtUserTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserTypeID.Location = new System.Drawing.Point(107, 218);
            this.txtUserTypeID.Name = "txtUserTypeID";
            this.txtUserTypeID.Size = new System.Drawing.Size(206, 29);
            this.txtUserTypeID.TabIndex = 96;
            this.txtUserTypeID.Text = "Select a ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "Selected ID:";
            // 
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "UserType";
            this.userTypeBindingSource.DataSource = this.imsDBDataSet;
            // 
            // userTypeTableAdapter
            // 
            this.userTypeTableAdapter.ClearBeforeFill = true;
            // 
            // userTypeIdDataGridViewTextBoxColumn
            // 
            this.userTypeIdDataGridViewTextBoxColumn.DataPropertyName = "UserTypeId";
            this.userTypeIdDataGridViewTextBoxColumn.HeaderText = "UserTypeId";
            this.userTypeIdDataGridViewTextBoxColumn.Name = "userTypeIdDataGridViewTextBoxColumn";
            this.userTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmDeleteUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(328, 308);
            this.Controls.Add(this.dataGridViewDeleteUserType);
            this.Controls.Add(this.lblRemoveUserType);
            this.Controls.Add(this.btnRemoveUserType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblUserTypeId);
            this.Controls.Add(this.txtUserTypeID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteUserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteUserType";
            this.Load += new System.EventHandler(this.frmDeleteUserType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteUserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeleteUserType;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private imsDBDataSet imsDBDataSet;
        private System.Windows.Forms.Label lblRemoveUserType;
        private System.Windows.Forms.Button btnRemoveUserType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserTypeId;
        private imsDBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TextBox txtUserTypeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private imsDBDataSetTableAdapters.UserTypeTableAdapter userTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeIdDataGridViewTextBoxColumn;
    }
}