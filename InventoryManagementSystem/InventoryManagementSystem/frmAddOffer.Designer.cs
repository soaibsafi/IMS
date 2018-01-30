namespace InventoryManagementSystem
{
    partial class frmAddOffer
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
            this.monthCalendarOfferGiven = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddOffer = new System.Windows.Forms.Button();
            this.lblAddOffer = new System.Windows.Forms.Label();
            this.txtMemberTypeID = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtOfferDescription = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtOfferName = new System.Windows.Forms.TextBox();
            this.txtOfferId = new System.Windows.Forms.TextBox();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.monthCalendarOfferExpired = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.lineShapeAddItem = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // monthCalendarOfferGiven
            // 
            this.monthCalendarOfferGiven.Location = new System.Drawing.Point(444, 58);
            this.monthCalendarOfferGiven.Name = "monthCalendarOfferGiven";
            this.monthCalendarOfferGiven.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 86;
            this.label1.Text = "Start From:";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.Location = new System.Drawing.Point(136, 329);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(204, 26);
            this.txtCategoryID.TabIndex = 85;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(357, 400);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 33);
            this.buttonCancel.TabIndex = 84;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddOffer
            // 
            this.buttonAddOffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddOffer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOffer.Location = new System.Drawing.Point(257, 400);
            this.buttonAddOffer.Name = "buttonAddOffer";
            this.buttonAddOffer.Size = new System.Drawing.Size(83, 33);
            this.buttonAddOffer.TabIndex = 83;
            this.buttonAddOffer.Text = "Add";
            this.buttonAddOffer.UseVisualStyleBackColor = false;
            this.buttonAddOffer.Click += new System.EventHandler(this.buttonAddOffer_Click);
            // 
            // lblAddOffer
            // 
            this.lblAddOffer.AutoSize = true;
            this.lblAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOffer.Location = new System.Drawing.Point(291, 9);
            this.lblAddOffer.Name = "lblAddOffer";
            this.lblAddOffer.Size = new System.Drawing.Size(116, 25);
            this.lblAddOffer.TabIndex = 82;
            this.lblAddOffer.Text = "New Offer";
            // 
            // txtMemberTypeID
            // 
            this.txtMemberTypeID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberTypeID.Location = new System.Drawing.Point(136, 362);
            this.txtMemberTypeID.Name = "txtMemberTypeID";
            this.txtMemberTypeID.Size = new System.Drawing.Size(204, 26);
            this.txtMemberTypeID.TabIndex = 79;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(3, 364);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(127, 18);
            this.lblSalary.TabIndex = 73;
            this.lblSalary.Text = "Member Type ID:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(136, 258);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(204, 26);
            this.txtDiscount.TabIndex = 72;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(136, 294);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(204, 26);
            this.txtItemCode.TabIndex = 80;
            // 
            // txtOfferDescription
            // 
            this.txtOfferDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfferDescription.Location = new System.Drawing.Point(136, 126);
            this.txtOfferDescription.Multiline = true;
            this.txtOfferDescription.Name = "txtOfferDescription";
            this.txtOfferDescription.Size = new System.Drawing.Size(204, 122);
            this.txtOfferDescription.TabIndex = 71;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(46, 296);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 18);
            this.lblLastName.TabIndex = 74;
            this.lblLastName.Text = "Item Code:";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(35, 331);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(95, 18);
            this.lblUserType.TabIndex = 70;
            this.lblUserType.Text = "Category ID:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(36, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 18);
            this.lblPassword.TabIndex = 69;
            this.lblPassword.Text = "Description:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(55, 263);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 18);
            this.lblFirstName.TabIndex = 75;
            this.lblFirstName.Text = "Discount:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(37, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 18);
            this.lblUsername.TabIndex = 76;
            this.lblUsername.Text = "Offer Name:";
            // 
            // txtOfferName
            // 
            this.txtOfferName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfferName.Location = new System.Drawing.Point(136, 93);
            this.txtOfferName.Name = "txtOfferName";
            this.txtOfferName.Size = new System.Drawing.Size(204, 26);
            this.txtOfferName.TabIndex = 81;
            // 
            // txtOfferId
            // 
            this.txtOfferId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfferId.Location = new System.Drawing.Point(136, 58);
            this.txtOfferId.Name = "txtOfferId";
            this.txtOfferId.Size = new System.Drawing.Size(204, 26);
            this.txtOfferId.TabIndex = 78;
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountId.Location = new System.Drawing.Point(62, 62);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(68, 18);
            this.lblAccountId.TabIndex = 77;
            this.lblAccountId.Text = "Offer ID:";
            // 
            // monthCalendarOfferExpired
            // 
            this.monthCalendarOfferExpired.Location = new System.Drawing.Point(444, 226);
            this.monthCalendarOfferExpired.Name = "monthCalendarOfferExpired";
            this.monthCalendarOfferExpired.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Expired:";
            // 
            // lineShapeAddItem
            // 
            this.lineShapeAddItem.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShapeAddItem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShapeAddItem.BorderWidth = 2;
            this.lineShapeAddItem.Name = "lineShapeAddItem";
            this.lineShapeAddItem.X1 = 346;
            this.lineShapeAddItem.X2 = 347;
            this.lineShapeAddItem.Y1 = 40;
            this.lineShapeAddItem.Y2 = 457;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShapeAddItem});
            this.shapeContainer1.Size = new System.Drawing.Size(713, 458);
            this.shapeContainer1.TabIndex = 90;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 299;
            this.lineShape1.X2 = 396;
            this.lineShape1.Y1 = 35;
            this.lineShape1.Y2 = 35;
            // 
            // frmAddOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(713, 458);
            this.Controls.Add(this.monthCalendarOfferExpired);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendarOfferGiven);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOffer);
            this.Controls.Add(this.lblAddOffer);
            this.Controls.Add(this.txtMemberTypeID);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtOfferDescription);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtOfferName);
            this.Controls.Add(this.txtOfferId);
            this.Controls.Add(this.lblAccountId);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarOfferGiven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddOffer;
        private System.Windows.Forms.Label lblAddOffer;
        private System.Windows.Forms.TextBox txtMemberTypeID;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtOfferDescription;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtOfferName;
        private System.Windows.Forms.TextBox txtOfferId;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.MonthCalendar monthCalendarOfferExpired;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeAddItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}