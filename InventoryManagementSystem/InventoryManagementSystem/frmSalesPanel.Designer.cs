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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesPanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlSalesPanel = new System.Windows.Forms.TabControl();
            this.tabPagePos = new System.Windows.Forms.TabPage();
            this.printGridView = new System.Windows.Forms.DataGridView();
            this.txtTotalPayable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSetMemberID = new System.Windows.Forms.TextBox();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStocks = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemOrCode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemOrCode = new System.Windows.Forms.TextBox();
            this.txtAmountChange = new System.Windows.Forms.TextBox();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataGridViewPos = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageItemAvailable = new System.Windows.Forms.TabPage();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.dataGridViewItemAvailable = new System.Windows.Forms.DataGridView();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imsDBDataSet = new InventoryManagementSystem.imsDBDataSet();
            this.pictureBoxSearchItem = new System.Windows.Forms.PictureBox();
            this.tabPageOffers = new System.Windows.Forms.TabPage();
            this.pictureBoxSearchOffer = new System.Windows.Forms.PictureBox();
            this.txtSearchOffer = new System.Windows.Forms.TextBox();
            this.dataGridViewOfferDetails = new System.Windows.Forms.DataGridView();
            this.offerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerGivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerValidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageMembership = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendarMemberFrom = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxDeleteAccount = new System.Windows.Forms.PictureBox();
            this.pictureBoxEditMember = new System.Windows.Forms.PictureBox();
            this.picAddMember = new System.Windows.Forms.PictureBox();
            this.comMemberTypeId = new System.Windows.Forms.ComboBox();
            this.memberTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.pictureBoxMemberSearch = new System.Windows.Forms.PictureBox();
            this.textBoxMemberSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.membershipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalShoppingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageListSales = new System.Windows.Forms.ImageList(this.components);
            this.itemTableAdapter = new InventoryManagementSystem.imsDBDataSetTableAdapters.ItemTableAdapter();
            this.offerTableAdapter = new InventoryManagementSystem.imsDBDataSetTableAdapters.OfferTableAdapter();
            this.membershipTableAdapter = new InventoryManagementSystem.imsDBDataSetTableAdapters.MembershipTableAdapter();
            this.memberTypeTableAdapter = new InventoryManagementSystem.imsDBDataSetTableAdapters.MemberTypeTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControlSalesPanel.SuspendLayout();
            this.tabPagePos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPos)).BeginInit();
            this.tabPageItemAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchItem)).BeginInit();
            this.tabPageOffers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchOffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfferDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerBindingSource)).BeginInit();
            this.tabPageMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.53135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.46865F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(465, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "S H W A P N O   R E T A I L";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnChangeUser);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1199, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(151, 63);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.BackColor = System.Drawing.Color.YellowGreen;
            this.btnChangeUser.FlatAppearance.BorderSize = 0;
            this.btnChangeUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUser.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUser.ForeColor = System.Drawing.Color.White;
            this.btnChangeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeUser.Location = new System.Drawing.Point(62, 1);
            this.btnChangeUser.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(86, 29);
            this.btnChangeUser.TabIndex = 9;
            this.btnChangeUser.Text = "CHANGE USER";
            this.btnChangeUser.UseVisualStyleBackColor = false;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.homeMenu;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.change_user;
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changeUserToolStripMenuItem.Text = "Change User";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.exitMenu;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem,
            this.itemAvailableToolStripMenuItem,
            this.offersToolStripMenuItem,
            this.membershipToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.viewMenu;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.pos;
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pOSToolStripMenuItem.Text = "POS";
            this.pOSToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // itemAvailableToolStripMenuItem
            // 
            this.itemAvailableToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.items;
            this.itemAvailableToolStripMenuItem.Name = "itemAvailableToolStripMenuItem";
            this.itemAvailableToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.itemAvailableToolStripMenuItem.Text = "Item Available";
            this.itemAvailableToolStripMenuItem.Click += new System.EventHandler(this.itemAvailableToolStripMenuItem_Click);
            // 
            // offersToolStripMenuItem
            // 
            this.offersToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.offers;
            this.offersToolStripMenuItem.Name = "offersToolStripMenuItem";
            this.offersToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.offersToolStripMenuItem.Text = "Offers";
            this.offersToolStripMenuItem.Click += new System.EventHandler(this.offersToolStripMenuItem_Click);
            // 
            // membershipToolStripMenuItem
            // 
            this.membershipToolStripMenuItem.Image = global::InventoryManagementSystem.Properties.Resources.Membership;
            this.membershipToolStripMenuItem.Name = "membershipToolStripMenuItem";
            this.membershipToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.membershipToolStripMenuItem.Text = "Membership";
            this.membershipToolStripMenuItem.Click += new System.EventHandler(this.membershipToolStripMenuItem_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabControlSalesPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1350, 666);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tabControlSalesPanel
            // 
            this.tabControlSalesPanel.Controls.Add(this.tabPagePos);
            this.tabControlSalesPanel.Controls.Add(this.tabPageItemAvailable);
            this.tabControlSalesPanel.Controls.Add(this.tabPageOffers);
            this.tabControlSalesPanel.Controls.Add(this.tabPageMembership);
            this.tabControlSalesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSalesPanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSalesPanel.ImageList = this.imageListSales;
            this.tabControlSalesPanel.Location = new System.Drawing.Point(3, 3);
            this.tabControlSalesPanel.Name = "tabControlSalesPanel";
            this.tabControlSalesPanel.SelectedIndex = 0;
            this.tabControlSalesPanel.Size = new System.Drawing.Size(1344, 660);
            this.tabControlSalesPanel.TabIndex = 0;
            // 
            // tabPagePos
            // 
            this.tabPagePos.Controls.Add(this.printGridView);
            this.tabPagePos.Controls.Add(this.txtTotalPayable);
            this.tabPagePos.Controls.Add(this.label7);
            this.tabPagePos.Controls.Add(this.label6);
            this.tabPagePos.Controls.Add(this.txtSetMemberID);
            this.tabPagePos.Controls.Add(this.btnGenerateBill);
            this.tabPagePos.Controls.Add(this.txtVat);
            this.tabPagePos.Controls.Add(this.label5);
            this.tabPagePos.Controls.Add(this.txtDiscount);
            this.tabPagePos.Controls.Add(this.label4);
            this.tabPagePos.Controls.Add(this.txtItemName);
            this.tabPagePos.Controls.Add(this.txtPrice);
            this.tabPagePos.Controls.Add(this.txtStocks);
            this.tabPagePos.Controls.Add(this.txtItemCode);
            this.tabPagePos.Controls.Add(this.lblStock);
            this.tabPagePos.Controls.Add(this.lblPrice);
            this.tabPagePos.Controls.Add(this.lblItemName);
            this.tabPagePos.Controls.Add(this.lblItemCode);
            this.tabPagePos.Controls.Add(this.lblItemOrCode);
            this.tabPagePos.Controls.Add(this.lblQuantity);
            this.tabPagePos.Controls.Add(this.btnAddToCart);
            this.tabPagePos.Controls.Add(this.txtQuantity);
            this.tabPagePos.Controls.Add(this.txtItemOrCode);
            this.tabPagePos.Controls.Add(this.txtAmountChange);
            this.tabPagePos.Controls.Add(this.lblChangeAmount);
            this.tabPagePos.Controls.Add(this.txtAmountPaid);
            this.tabPagePos.Controls.Add(this.lblAmountPaid);
            this.tabPagePos.Controls.Add(this.lblPayment);
            this.tabPagePos.Controls.Add(this.btnPrintBill);
            this.tabPagePos.Controls.Add(this.txtAmountDue);
            this.tabPagePos.Controls.Add(this.lblAmountDue);
            this.tabPagePos.Controls.Add(this.shapeContainer1);
            this.tabPagePos.Controls.Add(this.dataGridViewPos);
            this.tabPagePos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePos.ImageIndex = 2;
            this.tabPagePos.Location = new System.Drawing.Point(4, 55);
            this.tabPagePos.Name = "tabPagePos";
            this.tabPagePos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePos.Size = new System.Drawing.Size(1336, 601);
            this.tabPagePos.TabIndex = 0;
            this.tabPagePos.Text = "POS";
            this.tabPagePos.UseVisualStyleBackColor = true;
            // 
            // printGridView
            // 
            this.printGridView.AllowUserToAddRows = false;
            this.printGridView.AllowUserToDeleteRows = false;
            this.printGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.printGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.printGridView.Location = new System.Drawing.Point(1017, 392);
            this.printGridView.Name = "printGridView";
            this.printGridView.ReadOnly = true;
            this.printGridView.Size = new System.Drawing.Size(10, 10);
            this.printGridView.TabIndex = 65;
            this.printGridView.Visible = false;
            // 
            // txtTotalPayable
            // 
            this.txtTotalPayable.Enabled = false;
            this.txtTotalPayable.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayable.Location = new System.Drawing.Point(1195, 234);
            this.txtTotalPayable.Name = "txtTotalPayable";
            this.txtTotalPayable.Size = new System.Drawing.Size(131, 35);
            this.txtTotalPayable.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1052, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 63;
            this.label7.Text = "Total Payable:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1077, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 62;
            this.label6.Text = "Member ID:";
            // 
            // txtSetMemberID
            // 
            this.txtSetMemberID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetMemberID.Location = new System.Drawing.Point(1195, 69);
            this.txtSetMemberID.Name = "txtSetMemberID";
            this.txtSetMemberID.Size = new System.Drawing.Size(131, 35);
            this.txtSetMemberID.TabIndex = 61;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(1074, 375);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(97, 49);
            this.btnGenerateBill.TabIndex = 56;
            this.btnGenerateBill.Text = "Geterate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // txtVat
            // 
            this.txtVat.Enabled = false;
            this.txtVat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(1195, 193);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(131, 35);
            this.txtVat.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1148, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "Vat:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(1195, 151);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(131, 35);
            this.txtDiscount.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1094, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 52;
            this.label4.Text = "Discount:";
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(903, 42);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(140, 25);
            this.txtItemName.TabIndex = 49;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(903, 73);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 25);
            this.txtPrice.TabIndex = 48;
            // 
            // txtStocks
            // 
            this.txtStocks.Enabled = false;
            this.txtStocks.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStocks.Location = new System.Drawing.Point(903, 104);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(140, 25);
            this.txtStocks.TabIndex = 47;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(903, 11);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(140, 25);
            this.txtItemCode.TabIndex = 46;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(850, 109);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 20);
            this.lblStock.TabIndex = 45;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(853, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 44;
            this.lblPrice.Text = "Price:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(858, 42);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(39, 20);
            this.lblItemName.TabIndex = 43;
            this.lblItemName.Text = "Item:";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(823, 13);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(74, 20);
            this.lblItemCode.TabIndex = 42;
            this.lblItemCode.Text = "Item Code:";
            // 
            // lblItemOrCode
            // 
            this.lblItemOrCode.AutoSize = true;
            this.lblItemOrCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemOrCode.Location = new System.Drawing.Point(167, 7);
            this.lblItemOrCode.Name = "lblItemOrCode";
            this.lblItemOrCode.Size = new System.Drawing.Size(71, 16);
            this.lblItemOrCode.TabIndex = 41;
            this.lblItemOrCode.Text = "Item Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(432, 7);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 16);
            this.lblQuantity.TabIndex = 40;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(558, 21);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(165, 34);
            this.btnAddToCart.TabIndex = 38;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click_1);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(407, 26);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(105, 29);
            this.txtQuantity.TabIndex = 36;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // txtItemOrCode
            // 
            this.txtItemOrCode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemOrCode.Location = new System.Drawing.Point(16, 26);
            this.txtItemOrCode.Name = "txtItemOrCode";
            this.txtItemOrCode.Size = new System.Drawing.Size(357, 29);
            this.txtItemOrCode.TabIndex = 35;
            this.txtItemOrCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemOrCode_KeyDown);
            // 
            // txtAmountChange
            // 
            this.txtAmountChange.Enabled = false;
            this.txtAmountChange.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountChange.Location = new System.Drawing.Point(1195, 318);
            this.txtAmountChange.Name = "txtAmountChange";
            this.txtAmountChange.Size = new System.Drawing.Size(131, 35);
            this.txtAmountChange.TabIndex = 33;
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeAmount.Location = new System.Drawing.Point(1105, 323);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(89, 22);
            this.lblChangeAmount.TabIndex = 32;
            this.lblChangeAmount.Text = "Change:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(1195, 275);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(131, 35);
            this.txtAmountPaid.TabIndex = 31;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(1059, 281);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(135, 22);
            this.lblAmountPaid.TabIndex = 30;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(1142, 15);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(143, 32);
            this.lblPayment.TabIndex = 29;
            this.lblPayment.Text = "PAYMENT";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.Red;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Location = new System.Drawing.Point(1213, 375);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(97, 49);
            this.btnPrintBill.TabIndex = 28;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Enabled = false;
            this.txtAmountDue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.Location = new System.Drawing.Point(1195, 110);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(131, 35);
            this.txtAmountDue.TabIndex = 27;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(1063, 116);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(131, 22);
            this.lblAmountDue.TabIndex = 26;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1330, 595);
            this.shapeContainer1.TabIndex = 34;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Gray;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gray;
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Percent10;
            this.rectangleShape1.Location = new System.Drawing.Point(1128, 6);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(159, 45);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1043;
            this.lineShape1.X2 = 1045;
            this.lineShape1.Y1 = -2;
            this.lineShape1.Y2 = 600;
            // 
            // dataGridViewPos
            // 
            this.dataGridViewPos.AllowUserToAddRows = false;
            this.dataGridViewPos.AllowUserToDeleteRows = false;
            this.dataGridViewPos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.dataGridViewPos.Location = new System.Drawing.Point(3, 159);
            this.dataGridViewPos.Name = "dataGridViewPos";
            this.dataGridViewPos.ReadOnly = true;
            this.dataGridViewPos.Size = new System.Drawing.Size(1040, 442);
            this.dataGridViewPos.TabIndex = 50;
            this.dataGridViewPos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPos_CellContentClick);
            // 
            // Remove
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.Remove.DefaultCellStyle = dataGridViewCellStyle2;
            this.Remove.FillWeight = 10F;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.HeaderText = "X";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Remove.Text = "✓";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 15;
            // 
            // tabPageItemAvailable
            // 
            this.tabPageItemAvailable.Controls.Add(this.txtSearchItem);
            this.tabPageItemAvailable.Controls.Add(this.dataGridViewItemAvailable);
            this.tabPageItemAvailable.Controls.Add(this.pictureBoxSearchItem);
            this.tabPageItemAvailable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageItemAvailable.ImageIndex = 1;
            this.tabPageItemAvailable.Location = new System.Drawing.Point(4, 55);
            this.tabPageItemAvailable.Name = "tabPageItemAvailable";
            this.tabPageItemAvailable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItemAvailable.Size = new System.Drawing.Size(1336, 601);
            this.tabPageItemAvailable.TabIndex = 1;
            this.tabPageItemAvailable.Text = "Item Available";
            this.tabPageItemAvailable.UseVisualStyleBackColor = true;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(6, 25);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(223, 22);
            this.txtSearchItem.TabIndex = 54;
            this.txtSearchItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchItem_KeyDown_1);
            // 
            // dataGridViewItemAvailable
            // 
            this.dataGridViewItemAvailable.AllowUserToAddRows = false;
            this.dataGridViewItemAvailable.AllowUserToDeleteRows = false;
            this.dataGridViewItemAvailable.AutoGenerateColumns = false;
            this.dataGridViewItemAvailable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItemAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItemAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridViewItemAvailable.DataSource = this.itemBindingSource;
            this.dataGridViewItemAvailable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewItemAvailable.Location = new System.Drawing.Point(3, 65);
            this.dataGridViewItemAvailable.Name = "dataGridViewItemAvailable";
            this.dataGridViewItemAvailable.ReadOnly = true;
            this.dataGridViewItemAvailable.Size = new System.Drawing.Size(1330, 533);
            this.dataGridViewItemAvailable.TabIndex = 23;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.imsDBDataSet;
            // 
            // imsDBDataSet
            // 
            this.imsDBDataSet.DataSetName = "imsDBDataSet";
            this.imsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBoxSearchItem
            // 
            this.pictureBoxSearchItem.Image = global::InventoryManagementSystem.Properties.Resources.search;
            this.pictureBoxSearchItem.Location = new System.Drawing.Point(235, 25);
            this.pictureBoxSearchItem.Name = "pictureBoxSearchItem";
            this.pictureBoxSearchItem.Size = new System.Drawing.Size(26, 22);
            this.pictureBoxSearchItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchItem.TabIndex = 55;
            this.pictureBoxSearchItem.TabStop = false;
            // 
            // tabPageOffers
            // 
            this.tabPageOffers.Controls.Add(this.pictureBoxSearchOffer);
            this.tabPageOffers.Controls.Add(this.txtSearchOffer);
            this.tabPageOffers.Controls.Add(this.dataGridViewOfferDetails);
            this.tabPageOffers.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageOffers.ImageIndex = 3;
            this.tabPageOffers.Location = new System.Drawing.Point(4, 55);
            this.tabPageOffers.Name = "tabPageOffers";
            this.tabPageOffers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffers.Size = new System.Drawing.Size(1336, 601);
            this.tabPageOffers.TabIndex = 2;
            this.tabPageOffers.Text = "Offers";
            this.tabPageOffers.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSearchOffer
            // 
            this.pictureBoxSearchOffer.Image = global::InventoryManagementSystem.Properties.Resources.search;
            this.pictureBoxSearchOffer.Location = new System.Drawing.Point(1304, 17);
            this.pictureBoxSearchOffer.Name = "pictureBoxSearchOffer";
            this.pictureBoxSearchOffer.Size = new System.Drawing.Size(26, 22);
            this.pictureBoxSearchOffer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchOffer.TabIndex = 79;
            this.pictureBoxSearchOffer.TabStop = false;
            // 
            // txtSearchOffer
            // 
            this.txtSearchOffer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOffer.Location = new System.Drawing.Point(1075, 17);
            this.txtSearchOffer.Name = "txtSearchOffer";
            this.txtSearchOffer.Size = new System.Drawing.Size(223, 22);
            this.txtSearchOffer.TabIndex = 78;
            this.txtSearchOffer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchOffer_KeyDown);
            // 
            // dataGridViewOfferDetails
            // 
            this.dataGridViewOfferDetails.AllowUserToAddRows = false;
            this.dataGridViewOfferDetails.AllowUserToDeleteRows = false;
            this.dataGridViewOfferDetails.AutoGenerateColumns = false;
            this.dataGridViewOfferDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewOfferDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOfferDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfferDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.offerIDDataGridViewTextBoxColumn,
            this.offerNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.discountPercentageDataGridViewTextBoxColumn,
            this.offerGivenDataGridViewTextBoxColumn,
            this.offerValidDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn1,
            this.categoryIDDataGridViewTextBoxColumn1,
            this.memberTypeIDDataGridViewTextBoxColumn});
            this.dataGridViewOfferDetails.DataSource = this.offerBindingSource;
            this.dataGridViewOfferDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewOfferDetails.Location = new System.Drawing.Point(3, 54);
            this.dataGridViewOfferDetails.Name = "dataGridViewOfferDetails";
            this.dataGridViewOfferDetails.ReadOnly = true;
            this.dataGridViewOfferDetails.Size = new System.Drawing.Size(1330, 544);
            this.dataGridViewOfferDetails.TabIndex = 77;
            // 
            // offerIDDataGridViewTextBoxColumn
            // 
            this.offerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offerIDDataGridViewTextBoxColumn.DataPropertyName = "OfferID";
            this.offerIDDataGridViewTextBoxColumn.HeaderText = "OfferID";
            this.offerIDDataGridViewTextBoxColumn.Name = "offerIDDataGridViewTextBoxColumn";
            this.offerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerNameDataGridViewTextBoxColumn
            // 
            this.offerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offerNameDataGridViewTextBoxColumn.DataPropertyName = "OfferName";
            this.offerNameDataGridViewTextBoxColumn.HeaderText = "OfferName";
            this.offerNameDataGridViewTextBoxColumn.Name = "offerNameDataGridViewTextBoxColumn";
            this.offerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // discountPercentageDataGridViewTextBoxColumn
            // 
            this.discountPercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discountPercentageDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.HeaderText = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.Name = "discountPercentageDataGridViewTextBoxColumn";
            this.discountPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerGivenDataGridViewTextBoxColumn
            // 
            this.offerGivenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offerGivenDataGridViewTextBoxColumn.DataPropertyName = "OfferGiven";
            this.offerGivenDataGridViewTextBoxColumn.HeaderText = "OfferGiven";
            this.offerGivenDataGridViewTextBoxColumn.Name = "offerGivenDataGridViewTextBoxColumn";
            this.offerGivenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerValidDataGridViewTextBoxColumn
            // 
            this.offerValidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offerValidDataGridViewTextBoxColumn.DataPropertyName = "OfferValid";
            this.offerValidDataGridViewTextBoxColumn.HeaderText = "OfferValid";
            this.offerValidDataGridViewTextBoxColumn.Name = "offerValidDataGridViewTextBoxColumn";
            this.offerValidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCodeDataGridViewTextBoxColumn1
            // 
            this.itemCodeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemCodeDataGridViewTextBoxColumn1.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn1.HeaderText = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn1.Name = "itemCodeDataGridViewTextBoxColumn1";
            this.itemCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryIDDataGridViewTextBoxColumn1
            // 
            this.categoryIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryIDDataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn1.Name = "categoryIDDataGridViewTextBoxColumn1";
            this.categoryIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberTypeIDDataGridViewTextBoxColumn
            // 
            this.memberTypeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memberTypeIDDataGridViewTextBoxColumn.DataPropertyName = "MemberTypeID";
            this.memberTypeIDDataGridViewTextBoxColumn.HeaderText = "MemberTypeID";
            this.memberTypeIDDataGridViewTextBoxColumn.Name = "memberTypeIDDataGridViewTextBoxColumn";
            this.memberTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // offerBindingSource
            // 
            this.offerBindingSource.DataMember = "Offer";
            this.offerBindingSource.DataSource = this.imsDBDataSet;
            // 
            // tabPageMembership
            // 
            this.tabPageMembership.Controls.Add(this.label3);
            this.tabPageMembership.Controls.Add(this.monthCalendarMemberFrom);
            this.tabPageMembership.Controls.Add(this.label2);
            this.tabPageMembership.Controls.Add(this.label1);
            this.tabPageMembership.Controls.Add(this.pictureBoxDeleteAccount);
            this.tabPageMembership.Controls.Add(this.pictureBoxEditMember);
            this.tabPageMembership.Controls.Add(this.picAddMember);
            this.tabPageMembership.Controls.Add(this.comMemberTypeId);
            this.tabPageMembership.Controls.Add(this.txtAddress);
            this.tabPageMembership.Controls.Add(this.txtPhoneNumber);
            this.tabPageMembership.Controls.Add(this.txtName);
            this.tabPageMembership.Controls.Add(this.lblLastName);
            this.tabPageMembership.Controls.Add(this.lblUserType);
            this.tabPageMembership.Controls.Add(this.lblPassword);
            this.tabPageMembership.Controls.Add(this.lblFirstName);
            this.tabPageMembership.Controls.Add(this.lblMemberName);
            this.tabPageMembership.Controls.Add(this.txtEmail);
            this.tabPageMembership.Controls.Add(this.label15);
            this.tabPageMembership.Controls.Add(this.txtMemberId);
            this.tabPageMembership.Controls.Add(this.lblMemberId);
            this.tabPageMembership.Controls.Add(this.pictureBoxMemberSearch);
            this.tabPageMembership.Controls.Add(this.textBoxMemberSearch);
            this.tabPageMembership.Controls.Add(this.dataGridViewMember);
            this.tabPageMembership.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMembership.ImageIndex = 4;
            this.tabPageMembership.Location = new System.Drawing.Point(4, 55);
            this.tabPageMembership.Name = "tabPageMembership";
            this.tabPageMembership.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembership.Size = new System.Drawing.Size(1336, 601);
            this.tabPageMembership.TabIndex = 3;
            this.tabPageMembership.Text = "Membership";
            this.tabPageMembership.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "Member From:";
            // 
            // monthCalendarMemberFrom
            // 
            this.monthCalendarMemberFrom.Location = new System.Drawing.Point(141, 321);
            this.monthCalendarMemberFrom.Name = "monthCalendarMemberFrom";
            this.monthCalendarMemberFrom.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Delete Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Edit Member";
            // 
            // pictureBoxDeleteAccount
            // 
            this.pictureBoxDeleteAccount.BackColor = System.Drawing.Color.Red;
            this.pictureBoxDeleteAccount.Image = global::InventoryManagementSystem.Properties.Resources.deleteAccount;
            this.pictureBoxDeleteAccount.Location = new System.Drawing.Point(217, 498);
            this.pictureBoxDeleteAccount.Name = "pictureBoxDeleteAccount";
            this.pictureBoxDeleteAccount.Size = new System.Drawing.Size(87, 76);
            this.pictureBoxDeleteAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeleteAccount.TabIndex = 99;
            this.pictureBoxDeleteAccount.TabStop = false;
            this.pictureBoxDeleteAccount.Click += new System.EventHandler(this.pictureBoxDeleteAccount_Click);
            // 
            // pictureBoxEditMember
            // 
            this.pictureBoxEditMember.Image = global::InventoryManagementSystem.Properties.Resources.editAccount;
            this.pictureBoxEditMember.Location = new System.Drawing.Point(66, 498);
            this.pictureBoxEditMember.Name = "pictureBoxEditMember";
            this.pictureBoxEditMember.Size = new System.Drawing.Size(87, 76);
            this.pictureBoxEditMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditMember.TabIndex = 98;
            this.pictureBoxEditMember.TabStop = false;
            this.pictureBoxEditMember.Click += new System.EventHandler(this.pictureBoxEditMember_Click);
            // 
            // picAddMember
            // 
            this.picAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picAddMember.Image = global::InventoryManagementSystem.Properties.Resources.addAccount;
            this.picAddMember.Location = new System.Drawing.Point(20, 6);
            this.picAddMember.Name = "picAddMember";
            this.picAddMember.Size = new System.Drawing.Size(57, 50);
            this.picAddMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddMember.TabIndex = 87;
            this.picAddMember.TabStop = false;
            this.picAddMember.Click += new System.EventHandler(this.picAddMember_Click);
            // 
            // comMemberTypeId
            // 
            this.comMemberTypeId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.memberTypeBindingSource, "MemberTypeID", true));
            this.comMemberTypeId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comMemberTypeId.FormattingEnabled = true;
            this.comMemberTypeId.Location = new System.Drawing.Point(141, 111);
            this.comMemberTypeId.Name = "comMemberTypeId";
            this.comMemberTypeId.Size = new System.Drawing.Size(227, 27);
            this.comMemberTypeId.TabIndex = 86;
            // 
            // memberTypeBindingSource
            // 
            this.memberTypeBindingSource.DataMember = "MemberType";
            this.memberTypeBindingSource.DataSource = this.imsDBDataSet;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(141, 179);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 68);
            this.txtAddress.TabIndex = 85;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(141, 253);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(227, 26);
            this.txtPhoneNumber.TabIndex = 96;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(141, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 26);
            this.txtName.TabIndex = 84;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(19, 257);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(118, 18);
            this.lblLastName.TabIndex = 90;
            this.lblLastName.Text = "Phone Number:";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(87, 291);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(50, 18);
            this.lblUserType.TabIndex = 83;
            this.lblUserType.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 18);
            this.lblPassword.TabIndex = 82;
            this.lblPassword.Text = "Member Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(67, 183);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 18);
            this.lblFirstName.TabIndex = 91;
            this.lblFirstName.Text = "Address:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(12, 113);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(125, 18);
            this.lblMemberName.TabIndex = 92;
            this.lblMemberName.Text = "Member Type Id:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(141, 287);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 26);
            this.txtEmail.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(7, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 88;
            this.label15.Text = "Add Member";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Enabled = false;
            this.txtMemberId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(141, 78);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(227, 26);
            this.txtMemberId.TabIndex = 94;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(50, 80);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(87, 18);
            this.lblMemberId.TabIndex = 93;
            this.lblMemberId.Text = "Member Id:";
            // 
            // pictureBoxMemberSearch
            // 
            this.pictureBoxMemberSearch.Image = global::InventoryManagementSystem.Properties.Resources.search;
            this.pictureBoxMemberSearch.Location = new System.Drawing.Point(1304, 19);
            this.pictureBoxMemberSearch.Name = "pictureBoxMemberSearch";
            this.pictureBoxMemberSearch.Size = new System.Drawing.Size(26, 22);
            this.pictureBoxMemberSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMemberSearch.TabIndex = 81;
            this.pictureBoxMemberSearch.TabStop = false;
            // 
            // textBoxMemberSearch
            // 
            this.textBoxMemberSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemberSearch.Location = new System.Drawing.Point(1075, 19);
            this.textBoxMemberSearch.Name = "textBoxMemberSearch";
            this.textBoxMemberSearch.Size = new System.Drawing.Size(223, 22);
            this.textBoxMemberSearch.TabIndex = 80;
            this.textBoxMemberSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMemberSearch_KeyDown);
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.AllowUserToAddRows = false;
            this.dataGridViewMember.AllowUserToDeleteRows = false;
            this.dataGridViewMember.AutoGenerateColumns = false;
            this.dataGridViewMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.membershipIDDataGridViewTextBoxColumn,
            this.memberTypeIDDataGridViewTextBoxColumn1,
            this.memberNameDataGridViewTextBoxColumn,
            this.memberAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.memberFromDataGridViewTextBoxColumn,
            this.totalShoppingDataGridViewTextBoxColumn});
            this.dataGridViewMember.DataSource = this.membershipBindingSource;
            this.dataGridViewMember.Location = new System.Drawing.Point(380, 58);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.ReadOnly = true;
            this.dataGridViewMember.Size = new System.Drawing.Size(956, 543);
            this.dataGridViewMember.TabIndex = 78;
            this.dataGridViewMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMember_CellContentClick);
            // 
            // membershipIDDataGridViewTextBoxColumn
            // 
            this.membershipIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.membershipIDDataGridViewTextBoxColumn.DataPropertyName = "MembershipID";
            this.membershipIDDataGridViewTextBoxColumn.FillWeight = 56.27267F;
            this.membershipIDDataGridViewTextBoxColumn.HeaderText = "Member ID";
            this.membershipIDDataGridViewTextBoxColumn.Name = "membershipIDDataGridViewTextBoxColumn";
            this.membershipIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberTypeIDDataGridViewTextBoxColumn1
            // 
            this.memberTypeIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memberTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "MemberTypeID";
            this.memberTypeIDDataGridViewTextBoxColumn1.FillWeight = 56.27267F;
            this.memberTypeIDDataGridViewTextBoxColumn1.HeaderText = "Member Type ID";
            this.memberTypeIDDataGridViewTextBoxColumn1.Name = "memberTypeIDDataGridViewTextBoxColumn1";
            this.memberTypeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.FillWeight = 56.27267F;
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberAddressDataGridViewTextBoxColumn
            // 
            this.memberAddressDataGridViewTextBoxColumn.DataPropertyName = "MemberAddress";
            this.memberAddressDataGridViewTextBoxColumn.FillWeight = 406.0913F;
            this.memberAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.memberAddressDataGridViewTextBoxColumn.Name = "memberAddressDataGridViewTextBoxColumn";
            this.memberAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.FillWeight = 56.27267F;
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 56.27267F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberFromDataGridViewTextBoxColumn
            // 
            this.memberFromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memberFromDataGridViewTextBoxColumn.DataPropertyName = "MemberFrom";
            this.memberFromDataGridViewTextBoxColumn.FillWeight = 56.27267F;
            this.memberFromDataGridViewTextBoxColumn.HeaderText = "Member From";
            this.memberFromDataGridViewTextBoxColumn.Name = "memberFromDataGridViewTextBoxColumn";
            this.memberFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalShoppingDataGridViewTextBoxColumn
            // 
            this.totalShoppingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalShoppingDataGridViewTextBoxColumn.DataPropertyName = "TotalShopping";
            this.totalShoppingDataGridViewTextBoxColumn.FillWeight = 56.27267F;
            this.totalShoppingDataGridViewTextBoxColumn.HeaderText = "Total Shopping";
            this.totalShoppingDataGridViewTextBoxColumn.Name = "totalShoppingDataGridViewTextBoxColumn";
            this.totalShoppingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "Membership";
            this.membershipBindingSource.DataSource = this.imsDBDataSet;
            // 
            // imageListSales
            // 
            this.imageListSales.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSales.ImageStream")));
            this.imageListSales.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSales.Images.SetKeyName(0, "help.png");
            this.imageListSales.Images.SetKeyName(1, "items.png");
            this.imageListSales.Images.SetKeyName(2, "pos.png");
            this.imageListSales.Images.SetKeyName(3, "offers.png");
            this.imageListSales.Images.SetKeyName(4, "Membership.png");
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // offerTableAdapter
            // 
            this.offerTableAdapter.ClearBeforeFill = true;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // memberTypeTableAdapter
            // 
            this.memberTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmSalesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSalesPanel";
            this.Text = "SHWAPNO RETAIL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalesPanel_FormClosed);
            this.Load += new System.EventHandler(this.frmSalesPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControlSalesPanel.ResumeLayout(false);
            this.tabPagePos.ResumeLayout(false);
            this.tabPagePos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPos)).EndInit();
            this.tabPageItemAvailable.ResumeLayout(false);
            this.tabPageItemAvailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchItem)).EndInit();
            this.tabPageOffers.ResumeLayout(false);
            this.tabPageOffers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchOffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfferDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offerBindingSource)).EndInit();
            this.tabPageMembership.ResumeLayout(false);
            this.tabPageMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControlSalesPanel;
        private System.Windows.Forms.TabPage tabPagePos;
        private System.Windows.Forms.TabPage tabPageItemAvailable;
        private System.Windows.Forms.TabPage tabPageOffers;
        private System.Windows.Forms.TabPage tabPageMembership;
        private System.Windows.Forms.ImageList imageListSales;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStocks;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemOrCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemOrCode;
        private System.Windows.Forms.TextBox txtAmountChange;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblAmountDue;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView dataGridViewPos;
        private System.Windows.Forms.DataGridView dataGridViewItemAvailable;
        private System.Windows.Forms.PictureBox pictureBoxSearchItem;
        private System.Windows.Forms.TextBox txtSearchItem;
        private imsDBDataSet imsDBDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private imsDBDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewOfferDetails;
        private System.Windows.Forms.BindingSource offerBindingSource;
        private imsDBDataSetTableAdapters.OfferTableAdapter offerTableAdapter;
        private System.Windows.Forms.PictureBox pictureBoxSearchOffer;
        private System.Windows.Forms.TextBox txtSearchOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerGivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerValidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private imsDBDataSetTableAdapters.MembershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.PictureBox pictureBoxMemberSearch;
        private System.Windows.Forms.TextBox textBoxMemberSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalShoppingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendarMemberFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxDeleteAccount;
        private System.Windows.Forms.PictureBox pictureBoxEditMember;
        private System.Windows.Forms.PictureBox picAddMember;
        private System.Windows.Forms.ComboBox comMemberTypeId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.BindingSource memberTypeBindingSource;
        private imsDBDataSetTableAdapters.MemberTypeTableAdapter memberTypeTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipToolStripMenuItem;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSetMemberID;
        private System.Windows.Forms.TextBox txtTotalPayable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridView printGridView;
    }
}