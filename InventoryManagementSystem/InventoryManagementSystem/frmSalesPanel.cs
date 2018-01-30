using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using DGVPrinterHelper;
using System.Drawing;

namespace InventoryManagementSystem
{
    public partial class frmSalesPanel : Form
    {
        private double amountDue;
        private double discount;
        readonly double vat = 1.5;
        private double amountPayable;
        private double amountChange;
        private double amountPaid;
        private string itemCode;
        private double totalVat;

        #region Decleration
        public static int cartCounter;
        public static int rowIndex;
        private static bool membershipChecker;
        public static DataTable dt;
        RefreshDelegate refreshDelegate;
        ServiceFactory factory;
        IItemService itemService;
        IAccountService accountService;
        ITransactionService transactionService;
        IMembershipService  membershipService;
        IMemberTypeService memberTypeService;
        IOfferService offerService;
        Membership member;
        DataTable invoice; 
        #endregion

        #region Initial Load
        public frmSalesPanel()
        {
            InitializeComponent();
            this.initialMethod();
        }
        private void initialMethod()
        {
            factory = new ServiceFactory();
            itemService = factory.GetItemServiceInstance();
            accountService = factory.GetAccountServiceInstance();
            transactionService = factory.GetTransactionServiceInstance();
            membershipService = factory.GetMembershipServiceInstance();
            memberTypeService = factory.GetMemberTypeServiceInstance();
            offerService = factory.GetOfferServiceInstance();

            AutoCompleteMethod(txtItemOrCode);
            AutoCompleteMethod(txtSearchItem);
            AutoCompleteMethodForOffer(txtSearchOffer);
            AutoCompleteMethodForMemBer(textBoxMemberSearch);
            invoice = new DataTable();
           


            refreshDelegate = this.RefreshDataGridView;
        }
        private void frmSalesPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsDBDataSet.MemberType' table. You can move, or remove it, as needed.
            this.memberTypeTableAdapter.Fill(this.imsDBDataSet.MemberType);
            // TODO: This line of code loads data into the 'imsDBDataSet.Membership' table. You can move, or remove it, as needed.
            this.membershipTableAdapter.Fill(this.imsDBDataSet.Membership);
            // TODO: This line of code loads data into the 'imsDBDataSet.Offer' table. You can move, or remove it, as needed.
            this.offerTableAdapter.Fill(this.imsDBDataSet.Offer);
            this.WindowState = FormWindowState.Maximized;
            this.dataGridViewItemAvailable.DataSource = null;
            this.PopulateDataGridViewItemAvailable();
        }
        #endregion

        #region Sales Panel Method
        private void ChangeUser()
        {
            new frmLogin().Show();
            //this.Hide();
            this.Dispose();
        }
        private void CalculateAmountDue()
        {
            amountDue = 0.0;
            foreach (DataGridViewRow row in dataGridViewPos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 5) 
                    {
                        amountDue += Convert.ToDouble(cell.Value);
                    }
                }
            }
        }
        private void CalculateDiscount()
        {
            string id = txtSetMemberID.Text.ToString();
            MemberType memberType = memberTypeService.GetMemberTypeName(id);
            Offer offer = offerService.GetDiscount(memberType.MemberTypeID.ToString());
            discount = Convert.ToDouble(offer.DiscountPercentage);
        }
        private void TotalPayable()
        {
            double totalDue = 0;
            try
            {
                totalDue = Double.Parse(txtAmountDue.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a valid amount.");
            }

            double totalDiscount = (discount / 100) * totalDue;
            totalVat = (amountDue / 100) * vat;
            amountPayable = (totalDue + totalVat) - totalDiscount;
            if (membershipChecker)                                               //ADDED
            {
                //MessageBox.Show("Adding total shopping");
                membershipService.addShoppingToMemberId(txtSetMemberID.Text, amountPayable);
                membershipChecker = false;
            }
        }
        private double  CalculateChange()
        {
            try
            {
                amountPaid = Convert.ToDouble(txtAmountPaid.Text);
                amountChange = amountPaid - amountPayable;
                return amountChange;
            }catch
            {
                MessageBox.Show("Insert Amount Paid");
                return -1D;
            }
            
        }
        private void GenerateBill()
        {
            txtAmountDue.Text = "0.0";
            txtDiscount.Text = "0.0";
            txtVat.Text = "0.0";
            txtTotalPayable.Text = "0.0";
            this.CalculateAmountDue();
            txtAmountDue.Text = amountDue.ToString();
            if (!txtSetMemberID.Text.Equals(""))
            {
                membershipChecker = membershipService.checkValidMember(txtSetMemberID.Text);       //added 
                if (membershipChecker)
                {
                    this.CalculateDiscount();
                    txtDiscount.Text = discount.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Member id");
                }

            }
            txtVat.Text = vat.ToString();
            this.TotalPayable();
            txtTotalPayable.Text = amountPayable.ToString();
        }
        private void UpdateDatabaseForSell()
        {
            foreach (DataGridViewRow row in dataGridViewPos.Rows)
            {
                double itemPrice = 0;
                double totalPrice = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int itemQuantity = 0;
                    if (cell.ColumnIndex == 5)
                    {
                        totalPrice = Convert.ToDouble(cell.Value);
                        int tp = (int)totalPrice;

                        itemPrice = itemService.GetPrice(itemCode);
                        int ip = (int)itemPrice;
                        itemQuantity = (tp / ip);
                        itemService.UpdateStock(itemCode, itemQuantity);
                    }
                    if (cell.ColumnIndex == 1)
                    {
                        itemCode = cell.Value.ToString();

                        /*int tid = 11;
                        Transaction transaction = new Transaction(tid.ToString(), DateTime.Now);
                        transaction.ItemCode = itemCode;
                        transaction.AccountId = frmLogin.accountName;
                        transaction.MembershipID = txtSetMemberID.Text.ToString();
                        transaction.Quantity = itemQuantity;

                        if (transactionService.AddWithoutOfferID(transaction) == 1)
                        {
                            this.refreshDelegate.Invoke();
                            MessageBox.Show("Record Added Successfully!");
                            this.Close();
                        }*/
                    }
                }

            }
        }
        private void BillCreate()
        {
            //ref PrintBill();
        }

        private bool PrintBill()
        {
            
          
            double  chnge = this.CalculateChange();
            if (chnge >= 0)
            {

                txtAmountChange.Text = amountChange.ToString();

                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (amountChange < 0)
                    {
                        MessageBox.Show("Amount paid is less than Total Payable!");
                        amountPaid = 0;
                        txtAmountPaid.Text = "";
                        return false;
                    }
                    else
                    {
                        this.UpdateDatabaseForSell();
                        this.BillCreate();
                    }

                    this.dataGridViewItemAvailable.DataSource = itemService.GetAllSortedItem();
                    return true;

                }
                else if (result == DialogResult.No)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("More Money Required");
                return false;
            }

        }
        #endregion

        #region POS Method
        private void tableClear(DataTable dt)
        {
            try
            {
                dt.Clear();
            }
            catch (DataException e)
            {
                Console.WriteLine("Exception of type {0} occurred.", e.GetType());
            }
        }
        private void RefreshDataGridView()
        {

            this.PopulateDataGridViewItemAvailable();
        }
        private void PopulateDataGridViewItemAvailable()
        {
            this.dataGridViewItemAvailable.AutoGenerateColumns = false;
            this.dataGridViewItemAvailable.DataSource = itemService.GetAllSortedItem();
        }
        private void AutoCompleteMethod(TextBox txtBox)
        {

            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            List<string> itemNameList = new List<string>();
            itemNameList = itemService.GetName();
            foreach (string it in itemNameList)
            {
                col.Add(it);
            }
            txtBox.AutoCompleteCustomSource = col;
        }
        private void ClearPosButton()
        {
            txtItemOrCode.Text = "";
            txtQuantity.Text = "";
        }
        private void PosGridViewContentClick(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                if (cartCounter == 1)
                {
                    this.tableClear(dt);
                    cartCounter = 0;
                }
                else
                {
                    int rin = e.RowIndex;
                    String stock = dt.Rows[rin].ItemArray[5].ToString();
                    dt.Rows[rin].Delete();
                    rowIndex--;
                    cartCounter--;
                }
                dt.AcceptChanges();

            }
            dataGridViewPos.DataSource = dt;
        }
        private void PosQuantityEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string itemName = txtItemOrCode.Text;
                int quantity = Convert.ToInt32(txtQuantity.Text);
                if (quantity > 0)
                {
                    bool available = itemService.checkStockQuantity(itemName, quantity);
                    if (available)
                    {

                        if (cartCounter == 0)
                        {
                            dt = itemService.GetByName(itemName, quantity);
                            cartCounter++;
                            string price = dt.Rows[rowIndex].ItemArray[4].ToString();
                            double totalPrice = quantity * Convert.ToDouble(price);
                            dt.Rows[rowIndex].SetField(4, totalPrice);
                        }
                        else
                        {
                            rowIndex++;
                            cartCounter++;
                            DataTable Odt = new DataTable();
                            Odt = dt.Clone();
                            Odt = itemService.GetByName(itemName, quantity);
                            dt.Merge(Odt);
                            string price = dt.Rows[rowIndex].ItemArray[4].ToString();
                            double totalPrice = quantity * Convert.ToDouble(price);
                            dt.Rows[rowIndex].SetField(4, totalPrice);
                        }
                        dataGridViewPos.DataSource = dt;
                        txtItemOrCode.Text = "";
                        txtQuantity.Text = "";
                        txtItemOrCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Stock is Limited");
                        txtItemOrCode.Text = "";
                        txtQuantity.Text = "";
                        txtItemOrCode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Quantity Can't be zero or negative.");
                }
            }
            


        }
        private void Print()
        {
            //INVOICE
            DataTable invoice = new DataTable();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "SHWAPNO RETAIL\nINVOICE";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now);
            printer.SubTitleAlignment = StringAlignment.Near;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            //printer.Footer = string.Format("Total: {0} BDT", txtTotalPayable);
            printer.FooterAlignment = StringAlignment.Near;
            printer.PrintDataGridView(printGridView);
            printGridView = null;

        }
        private DataTable makeInvoice(DataTable dt)
        {
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Cost(TK)", typeof(string));
            for (int j = 0; j < dataGridViewPos.Rows.Count; j++)
            {
                DataRow dr;
                DataGridViewRow row = dataGridViewPos.Rows[j];
                dr = dt.NewRow();
                int k = 0;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == 2 || i == 5)
                    {
                        dr[k] = row.Cells[i].Value.ToString();
                        k++;
                    }
                }
                dt.Rows.Add(dr);
            }
            DataRow r = dt.NewRow();
            r = dt.NewRow();
            r[0] = "Discount : ";
            r[1] = txtDiscount.Text;
            dt.Rows.Add(r);
            DataRow r1 = dt.NewRow();
            r1[0] = "VAT(1.5%): ";
            r1[1] = totalVat.ToString();
            dt.Rows.Add(r1);

            DataRow r3 = dt.NewRow();
            r3[0] = "---------------------------------------------------------";
            r3[1] = "-------";
            dt.Rows.Add(r3);
            DataRow r2 = dt.NewRow();
            r2[0] = "Total Cost: ";
            r2[1] = txtTotalPayable.Text;
            dt.Rows.Add(r2);
            printGridView.DataSource = dt;
            return dt;
        }
        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            string itemName = txtItemOrCode.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            bool available = itemService.checkStockQuantity(itemName, quantity);
            if (available)
            {

                if (cartCounter == 0)
                {
                    dt = itemService.GetByName(itemName, quantity);
                    cartCounter++;
                    string price = dt.Rows[rowIndex].ItemArray[4].ToString();
                    double totalPrice = quantity * Convert.ToDouble(price);
                    dt.Rows[rowIndex].SetField(4, totalPrice);
                }
                else
                {
                    rowIndex++;
                    cartCounter++;
                    DataTable Odt = new DataTable();
                    Odt = dt.Clone();
                    Odt = itemService.GetByName(itemName, quantity);
                    dt.Merge(Odt);
                    string price = dt.Rows[rowIndex].ItemArray[4].ToString();
                    double totalPrice = quantity * Convert.ToDouble(price);
                    dt.Rows[rowIndex].SetField(4, totalPrice);
                }
                dataGridViewPos.DataSource = dt;
                txtItemOrCode.Text = null;
                txtQuantity.Text = null;
                txtItemOrCode.Focus();
            }
            else
            {
                MessageBox.Show("Stock is Limited");
            }
        }
        #endregion

        #region Item Available Method
        private void ItemAvailableSearchItem(KeyEventArgs e)
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = txtSearchItem.Text;

                bool found = false;
                foreach (DataGridViewRow row in dataGridViewItemAvailable.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        rowIn = row.Index;
                        dataGridViewItemAvailable.Rows[rowIn].Selected = true;
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Item Unavailable");
                }
            }
        }
        #endregion

        #region Offers Method
        private void AutoCompleteMethodForOffer(TextBox txtBox)
        {

            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            List<string> offerNameList = new List<string>();
            offerNameList = offerService.GetOfferNames();
            foreach (string it in offerNameList)
            {
                col.Add(it);
            }
            txtBox.AutoCompleteCustomSource = col;
        }
        private void txtSearchOffer_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = txtSearchOffer.Text;

                bool found = false;
                foreach (DataGridViewRow row in dataGridViewOfferDetails.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        rowIn = row.Index;
                        dataGridViewOfferDetails.Rows[rowIn].Selected = true;
                        found = true;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Offer Unavailable");
                }
            }
        }


        #endregion

        #region Membership Method
        private void EditMember()
        {
            member = new Membership(txtMemberId.Text.ToString());
            this.member.MemberTypeID = comMemberTypeId.Text;
            this.member.MemberName = txtName.Text;
            this.member.MemberAddress = txtAddress.Text;
            this.member.PhoneNumber = txtPhoneNumber.Text;
            this.member.Email = txtEmail.Text;

            if (membershipService.Edit(this.member) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Updated Successfully!");
            }
        }
        private void RemoveMember()
        {
            this.member = new Membership(txtMemberId.Text.ToString());
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (membershipService.Remove(this.member.MemberID) == 1)
                {
                    this.refreshDelegate.Invoke();
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
        }
        private void PopulateMemberGridView(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewMember.Rows[index];
            txtMemberId.Text = selectedRow.Cells[0].Value.ToString();
            comMemberTypeId.Text = selectedRow.Cells[1].Value.ToString();
            txtName.Text = selectedRow.Cells[2].Value.ToString();
            txtAddress.Text = selectedRow.Cells[3].Value.ToString();
            txtPhoneNumber.Text = selectedRow.Cells[4].Value.ToString();
            txtEmail.Text = selectedRow.Cells[5].Value.ToString();
        }
        private void AutoCompleteMethodForMemBer(TextBox txtBox)
        {

            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            List<string> memberNameList = new List<string>();
            memberNameList = membershipService.GetMemBerNames();
            foreach (string it in memberNameList)
            {
                col.Add(it);
            }
            txtBox.AutoCompleteCustomSource = col;
        }
        private void textBoxMemberSearch_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = textBoxMemberSearch.Text;

                bool found = false;
                foreach (DataGridViewRow row in dataGridViewMember.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        rowIn = row.Index;
                        dataGridViewMember.Rows[rowIn].Selected = true;
                        found = true;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("No Member Found");
                }
            }
        }
        #endregion

        #region Sales Panel Event
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.ChangeUser();
        }
        private void frmSalesPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void tabControlSales_Click(object sender, EventArgs e)
        {
            refreshDelegate.Invoke();
        }
        //Menu Strip
        private void changeUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.ChangeUser();
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlSalesPanel.SelectedTab = tabPagePos;
        }
        private void itemAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlSalesPanel.SelectedTab = tabPageItemAvailable;
        }
        private void offersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlSalesPanel.SelectedTab = tabPageOffers;
        }
        private void membershipToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.tabControlSalesPanel.SelectedTab = tabPageMembership;
        }
        #endregion

        #region POS Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearPosButton();
        } 
        private void dataGridViewPos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PosGridViewContentClick(e);
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewPos.Rows[index];
            txtItemCode.Text = selectedRow.Cells[1].Value.ToString();
            txtItemName.Text = selectedRow.Cells[2].Value.ToString();
            txtPrice.Text = selectedRow.Cells[5].Value.ToString();
            txtStocks.Text = selectedRow.Cells[6].Value.ToString();
        }
        private void txtItemOrCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtQuantity.Focus();
            }
        }
        public void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            this.PosQuantityEnter(e);
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //this.txtQuantity_KeyDown(this.e);
        }
        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            this.GenerateBill();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (this.PrintBill())
            {
                invoice = new DataTable();
                this.makeInvoice(invoice);
                this.Print();
            }
            
            
        }
        #endregion

        #region Item Available Event
        private void txtSearchItem_KeyDown_1(object sender, KeyEventArgs e)
        {
            this.ItemAvailableSearchItem(e);
        }
        #endregion

        #region Offers Event

        #endregion

        #region Membership Event
        private void picAddMember_Click(object sender, EventArgs e)
        {
            new frmAddMember(refreshDelegate).ShowDialog();
        }
        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PopulateMemberGridView(e);
        }
        private void pictureBoxEditMember_Click(object sender, EventArgs e)
        {
            this.EditMember();
        }
        private void pictureBoxDeleteAccount_Click(object sender, EventArgs e)
        {
            this.RemoveMember();
        }

        #endregion

    }
}
