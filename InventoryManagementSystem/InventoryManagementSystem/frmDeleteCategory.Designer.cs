namespace InventoryManagementSystem
{
    partial class frmDeleteCategory
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
            this.lblAddOffer = new System.Windows.Forms.Label();
            this.dataGridViewDeleteCategory = new System.Windows.Forms.DataGridView();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imsDBDataSet = new InventoryManagementSystem.imsDBDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new InventoryManagementSystem.imsDBDataSetTableAdapters.CategoryTableAdapter();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddOffer
            // 
            this.lblAddOffer.AutoSize = true;
            this.lblAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOffer.Location = new System.Drawing.Point(53, 4);
            this.lblAddOffer.Name = "lblAddOffer";
            this.lblAddOffer.Size = new System.Drawing.Size(199, 25);
            this.lblAddOffer.TabIndex = 83;
            this.lblAddOffer.Text = "Remove Category";
            // 
            // dataGridViewDeleteCategory
            // 
            this.dataGridViewDeleteCategory.AllowUserToAddRows = false;
            this.dataGridViewDeleteCategory.AllowUserToDeleteRows = false;
            this.dataGridViewDeleteCategory.AutoGenerateColumns = false;
            this.dataGridViewDeleteCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn});
            this.dataGridViewDeleteCategory.DataSource = this.categoryBindingSource;
            this.dataGridViewDeleteCategory.Location = new System.Drawing.Point(146, 53);
            this.dataGridViewDeleteCategory.Name = "dataGridViewDeleteCategory";
            this.dataGridViewDeleteCategory.ReadOnly = true;
            this.dataGridViewDeleteCategory.Size = new System.Drawing.Size(153, 150);
            this.dataGridViewDeleteCategory.TabIndex = 84;
            this.dataGridViewDeleteCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(6, 56);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(140, 18);
            this.lblCategoryId.TabIndex = 85;
            this.lblCategoryId.Text = "Select Category ID";
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Red;
            this.btnRemoveCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCategory.Location = new System.Drawing.Point(58, 259);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(83, 33);
            this.btnRemoveCategory.TabIndex = 87;
            this.btnRemoveCategory.Text = "Delete";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(160, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 33);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imsDBDataSet
            // 
            this.imsDBDataSet.DataSetName = "imsDBDataSet";
            this.imsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.imsDBDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "Selected ID:";
            // 
            // txtCatID
            // 
            this.txtCatID.Enabled = false;
            this.txtCatID.Location = new System.Drawing.Point(106, 222);
            this.txtCatID.Multiline = true;
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(193, 22);
            this.txtCatID.TabIndex = 89;
            this.txtCatID.Text = "Select a ID";
            // 
            // frmDeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(312, 304);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.dataGridViewDeleteCategory);
            this.Controls.Add(this.lblAddOffer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteCategory";
            this.Load += new System.EventHandler(this.frmDeleteCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddOffer;
        private System.Windows.Forms.DataGridView dataGridViewDeleteCategory;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnCancel;
        private imsDBDataSet imsDBDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private imsDBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatID;
    }
}