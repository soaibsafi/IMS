namespace InventoryManagementSystem
{
    partial class frmSalesPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSystemUserName = new System.Windows.Forms.Label();
            this.lblSystemDateTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tabControlSales = new System.Windows.Forms.TabControl();
            this.tabPagePos = new System.Windows.Forms.TabPage();
            this.tabPageItemAvailable = new System.Windows.Forms.TabPage();
            this.imageListSales = new System.Windows.Forms.ImageList(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.listViewPos = new System.Windows.Forms.ListView();
            this.colPosTransId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtStocks = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemOrCode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lblItemOrCode = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountChange = new System.Windows.Forms.TextBox();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShapePayment = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.comSearchByCategory = new System.Windows.Forms.ComboBox();
            this.lblSearchByCategory = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.colItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStocks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.tabControlSales.SuspendLayout();
            this.tabPagePos.SuspendLayout();
            this.tabPageItemAvailable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnChangeUser);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblSystemUserName);
            this.panel1.Controls.Add(this.lblSystemDateTime);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblSubTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 74);
            this.panel1.TabIndex = 1;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.BackColor = System.Drawing.Color.YellowGreen;
            this.btnChangeUser.FlatAppearance.BorderSize = 0;
            this.btnChangeUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUser.ForeColor = System.Drawing.Color.White;
            this.btnChangeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeUser.Location = new System.Drawing.Point(698, 7);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(182, 29);
            this.btnChangeUser.TabIndex = 7;
            this.btnChangeUser.Text = "CHANGE USER";
            this.btnChangeUser.UseVisualStyleBackColor = false;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(792, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSystemUserName
            // 
            this.lblSystemUserName.AutoSize = true;
            this.lblSystemUserName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemUserName.Location = new System.Drawing.Point(8, 36);
            this.lblSystemUserName.Name = "lblSystemUserName";
            this.lblSystemUserName.Size = new System.Drawing.Size(67, 14);
            this.lblSystemUserName.TabIndex = 5;
            this.lblSystemUserName.Text = "User Name";
            // 
            // lblSystemDateTime
            // 
            this.lblSystemDateTime.AutoSize = true;
            this.lblSystemDateTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemDateTime.Location = new System.Drawing.Point(4, 53);
            this.lblSystemDateTime.Name = "lblSystemDateTime";
            this.lblSystemDateTime.Size = new System.Drawing.Size(184, 14);
            this.lblSystemDateTime.TabIndex = 4;
            this.lblSystemDateTime.Text = "12:04 AM, Wednesday, 5 April, 2017 ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(277, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "S H W A P N O   R E T A I L";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(323, 39);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(247, 22);
            this.lblSubTitle.TabIndex = 3;
            this.lblSubTitle.Text = "Sales And Inventory System";
            // 
            // tabControlSales
            // 
            this.tabControlSales.Controls.Add(this.tabPagePos);
            this.tabControlSales.Controls.Add(this.tabPageItemAvailable);
            this.tabControlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSales.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSales.ImageList = this.imageListSales;
            this.tabControlSales.Location = new System.Drawing.Point(0, 74);
            this.tabControlSales.Name = "tabControlSales";
            this.tabControlSales.SelectedIndex = 0;
            this.tabControlSales.Size = new System.Drawing.Size(892, 466);
            this.tabControlSales.TabIndex = 2;
            // 
            // tabPagePos
            // 
            this.tabPagePos.Controls.Add(this.txtAmountChange);
            this.tabPagePos.Controls.Add(this.lblChangeAmount);
            this.tabPagePos.Controls.Add(this.txtAmountPaid);
            this.tabPagePos.Controls.Add(this.lblAmountPaid);
            this.tabPagePos.Controls.Add(this.lblPayment);
            this.tabPagePos.Controls.Add(this.lblItemOrCode);
            this.tabPagePos.Controls.Add(this.btnRemoveFromCart);
            this.tabPagePos.Controls.Add(this.btnAddToCart);
            this.tabPagePos.Controls.Add(this.btnGenerateBill);
            this.tabPagePos.Controls.Add(this.txtAmountDue);
            this.tabPagePos.Controls.Add(this.lblTotal);
            this.tabPagePos.Controls.Add(this.txtTotal);
            this.tabPagePos.Controls.Add(this.txtQuantity);
            this.tabPagePos.Controls.Add(this.txtItemOrCode);
            this.tabPagePos.Controls.Add(this.txtItemName);
            this.tabPagePos.Controls.Add(this.txtPrice);
            this.tabPagePos.Controls.Add(this.txtStocks);
            this.tabPagePos.Controls.Add(this.txtItemCode);
            this.tabPagePos.Controls.Add(this.lblAmountDue);
            this.tabPagePos.Controls.Add(this.lblQuantity);
            this.tabPagePos.Controls.Add(this.lblStock);
            this.tabPagePos.Controls.Add(this.lblPrice);
            this.tabPagePos.Controls.Add(this.lblItemName);
            this.tabPagePos.Controls.Add(this.lblItemCode);
            this.tabPagePos.Controls.Add(this.listViewPos);
            this.tabPagePos.Controls.Add(this.shapeContainer1);
            this.tabPagePos.ImageIndex = 0;
            this.tabPagePos.Location = new System.Drawing.Point(4, 55);
            this.tabPagePos.Name = "tabPagePos";
            this.tabPagePos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePos.Size = new System.Drawing.Size(884, 407);
            this.tabPagePos.TabIndex = 0;
            this.tabPagePos.Text = "POS                                                     ";
            this.tabPagePos.UseVisualStyleBackColor = true;
            // 
            // tabPageItemAvailable
            // 
            this.tabPageItemAvailable.Controls.Add(this.comSearchByCategory);
            this.tabPageItemAvailable.Controls.Add(this.lblSearchByCategory);
            this.tabPageItemAvailable.Controls.Add(this.txtSearchItem);
            this.tabPageItemAvailable.Controls.Add(this.lblSearchItem);
            this.tabPageItemAvailable.Controls.Add(this.listViewItems);
            this.tabPageItemAvailable.ImageIndex = 1;
            this.tabPageItemAvailable.Location = new System.Drawing.Point(4, 55);
            this.tabPageItemAvailable.Name = "tabPageItemAvailable";
            this.tabPageItemAvailable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItemAvailable.Size = new System.Drawing.Size(884, 407);
            this.tabPageItemAvailable.TabIndex = 1;
            this.tabPageItemAvailable.Text = "Items Available                                       ";
            this.tabPageItemAvailable.UseVisualStyleBackColor = true;
            // 
            // imageListSales
            // 
            this.imageListSales.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSales.ImageStream")));
            this.imageListSales.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSales.Images.SetKeyName(0, "pos.png");
            this.imageListSales.Images.SetKeyName(1, "items.png");
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.Location = new System.Drawing.Point(698, 42);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 28);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // listViewPos
            // 
            this.listViewPos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPosTransId,
            this.colPosDate,
            this.colPosItemCode,
            this.colPosItemName,
            this.colPosQuantity,
            this.colPosPrice,
            this.colPosTotal});
            this.listViewPos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPos.Location = new System.Drawing.Point(6, 6);
            this.listViewPos.Name = "listViewPos";
            this.listViewPos.Size = new System.Drawing.Size(868, 97);
            this.listViewPos.TabIndex = 0;
            this.listViewPos.UseCompatibleStateImageBehavior = false;
            this.listViewPos.View = System.Windows.Forms.View.Details;
            // 
            // colPosTransId
            // 
            this.colPosTransId.Text = "Transaction ID";
            this.colPosTransId.Width = 127;
            // 
            // colPosDate
            // 
            this.colPosDate.Text = "Date";
            this.colPosDate.Width = 143;
            // 
            // colPosItemCode
            // 
            this.colPosItemCode.Text = "ItemCode";
            this.colPosItemCode.Width = 123;
            // 
            // colPosItemName
            // 
            this.colPosItemName.Text = "Item";
            this.colPosItemName.Width = 148;
            // 
            // colPosQuantity
            // 
            this.colPosQuantity.Text = "Quantity";
            this.colPosQuantity.Width = 109;
            // 
            // colPosPrice
            // 
            this.colPosPrice.Text = "Price";
            this.colPosPrice.Width = 98;
            // 
            // colPosTotal
            // 
            this.colPosTotal.Text = "Total";
            this.colPosTotal.Width = 102;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(4, 125);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(74, 20);
            this.lblItemCode.TabIndex = 1;
            this.lblItemCode.Text = "Item Code:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(39, 158);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(39, 20);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(34, 189);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(31, 220);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 20);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(428, 110);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 16);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(607, 163);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(131, 22);
            this.lblAmountDue.TabIndex = 7;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(79, 124);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(140, 25);
            this.txtItemCode.TabIndex = 8;
            // 
            // txtStocks
            // 
            this.txtStocks.Enabled = false;
            this.txtStocks.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStocks.Location = new System.Drawing.Point(79, 218);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(140, 25);
            this.txtStocks.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(79, 187);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 25);
            this.txtPrice.TabIndex = 10;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(79, 156);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(140, 25);
            this.txtItemName.TabIndex = 11;
            // 
            // txtItemOrCode
            // 
            this.txtItemOrCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemOrCode.Location = new System.Drawing.Point(236, 129);
            this.txtItemOrCode.Name = "txtItemOrCode";
            this.txtItemOrCode.Size = new System.Drawing.Size(174, 25);
            this.txtItemOrCode.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(416, 129);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(82, 25);
            this.txtQuantity.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(504, 129);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(82, 25);
            this.txtTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(530, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 16);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Enabled = false;
            this.txtAmountDue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.Location = new System.Drawing.Point(735, 157);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(131, 35);
            this.txtAmountDue.TabIndex = 16;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(627, 329);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(239, 49);
            this.btnGenerateBill.TabIndex = 17;
            this.btnGenerateBill.Text = "Geterate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(236, 160);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(165, 49);
            this.btnAddToCart.TabIndex = 18;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.Red;
            this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(431, 160);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(155, 49);
            this.btnRemoveFromCart.TabIndex = 19;
            this.btnRemoveFromCart.Text = "Remove From Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            // 
            // lblItemOrCode
            // 
            this.lblItemOrCode.AutoSize = true;
            this.lblItemOrCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemOrCode.Location = new System.Drawing.Point(296, 110);
            this.lblItemOrCode.Name = "lblItemOrCode";
            this.lblItemOrCode.Size = new System.Drawing.Size(67, 16);
            this.lblItemOrCode.TabIndex = 20;
            this.lblItemOrCode.Text = "Item/Code";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(691, 117);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(91, 22);
            this.lblPayment.TabIndex = 21;
            this.lblPayment.Text = "Payment";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(735, 212);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(131, 35);
            this.txtAmountPaid.TabIndex = 23;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(603, 218);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(135, 22);
            this.lblAmountPaid.TabIndex = 22;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // txtAmountChange
            // 
            this.txtAmountChange.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountChange.Location = new System.Drawing.Point(735, 267);
            this.txtAmountChange.Name = "txtAmountChange";
            this.txtAmountChange.Size = new System.Drawing.Size(131, 35);
            this.txtAmountChange.TabIndex = 25;
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeAmount.Location = new System.Drawing.Point(649, 273);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(89, 22);
            this.lblChangeAmount.TabIndex = 24;
            this.lblChangeAmount.Text = "Change:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1,
            this.ovalShapePayment});
            this.shapeContainer1.Size = new System.Drawing.Size(878, 401);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShapePayment
            // 
            this.ovalShapePayment.BackColor = System.Drawing.Color.White;
            this.ovalShapePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ovalShapePayment.FillGradientColor = System.Drawing.Color.Red;
            this.ovalShapePayment.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.ForwardDiagonal;
            this.ovalShapePayment.Location = new System.Drawing.Point(664, 108);
            this.ovalShapePayment.Name = "ovalShapePayment";
            this.ovalShapePayment.Size = new System.Drawing.Size(134, 34);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 225;
            this.lineShape1.X2 = 225;
            this.lineShape1.Y1 = 115;
            this.lineShape1.Y2 = 247;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 594;
            this.lineShape2.X2 = 594;
            this.lineShape2.Y1 = 106;
            this.lineShape2.Y2 = 393;
            // 
            // comSearchByCategory
            // 
            this.comSearchByCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comSearchByCategory.FormattingEnabled = true;
            this.comSearchByCategory.Location = new System.Drawing.Point(695, 14);
            this.comSearchByCategory.Name = "comSearchByCategory";
            this.comSearchByCategory.Size = new System.Drawing.Size(144, 24);
            this.comSearchByCategory.TabIndex = 18;
            // 
            // lblSearchByCategory
            // 
            this.lblSearchByCategory.AutoSize = true;
            this.lblSearchByCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByCategory.Location = new System.Drawing.Point(569, 18);
            this.lblSearchByCategory.Name = "lblSearchByCategory";
            this.lblSearchByCategory.Size = new System.Drawing.Size(129, 16);
            this.lblSearchByCategory.TabIndex = 17;
            this.lblSearchByCategory.Text = "Search By Category:";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(108, 16);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(182, 22);
            this.txtSearchItem.TabIndex = 16;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItem.Location = new System.Drawing.Point(28, 18);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(82, 16);
            this.lblSearchItem.TabIndex = 15;
            this.lblSearchItem.Text = "Search Item:";
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemCode,
            this.colItemName,
            this.colDescription,
            this.colCategory,
            this.colPrice,
            this.colStocks});
            this.listViewItems.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewItems.Location = new System.Drawing.Point(31, 48);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(808, 344);
            this.listViewItems.TabIndex = 14;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // colItemCode
            // 
            this.colItemCode.Text = "Item Code";
            this.colItemCode.Width = 109;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 172;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 164;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 128;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 123;
            // 
            // colStocks
            // 
            this.colStocks.Text = "Stocks";
            this.colStocks.Width = 90;
            // 
            // SalesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 540);
            this.Controls.Add(this.tabControlSales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlSales.ResumeLayout(false);
            this.tabPagePos.ResumeLayout(false);
            this.tabPagePos.PerformLayout();
            this.tabPageItemAvailable.ResumeLayout(false);
            this.tabPageItemAvailable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSystemUserName;
        private System.Windows.Forms.Label lblSystemDateTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.TabControl tabControlSales;
        private System.Windows.Forms.TabPage tabPagePos;
        private System.Windows.Forms.TabPage tabPageItemAvailable;
        private System.Windows.Forms.ImageList imageListSales;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtAmountChange;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblItemOrCode;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemOrCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStocks;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.ListView listViewPos;
        private System.Windows.Forms.ColumnHeader colPosTransId;
        private System.Windows.Forms.ColumnHeader colPosDate;
        private System.Windows.Forms.ColumnHeader colPosItemCode;
        private System.Windows.Forms.ColumnHeader colPosItemName;
        private System.Windows.Forms.ColumnHeader colPosQuantity;
        private System.Windows.Forms.ColumnHeader colPosPrice;
        private System.Windows.Forms.ColumnHeader colPosTotal;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapePayment;
        private System.Windows.Forms.ComboBox comSearchByCategory;
        private System.Windows.Forms.Label lblSearchByCategory;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader colItemCode;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colStocks;
    }
}