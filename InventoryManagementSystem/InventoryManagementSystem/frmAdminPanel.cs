using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public delegate void RefreshDelegate();
    public partial class frmAdminPanel : Form
    {
        RefreshDelegate refreshDelegate;

        ServiceFactory factory;
        IAccountService accountService;
        ICategoryService categoryService;
        IItemService itemService;
        ILogService logService;
        IMembershipService membershipServece;
        IMemberTypeService memberTypeService;
        IOfferService offerService;
        ITransactionService transactionService;
        IUserTypeService userTypeService;

        Account account;
        Item item;
        Offer offer;

        public frmAdminPanel()
        {
            InitializeComponent();
            this.InitialMethod();
        }
        private void InitialMethod()
        {
            factory = new ServiceFactory();
            accountService = factory.GetAccountServiceInstance();
            categoryService = factory.GetCategoryServiceInstance();
            itemService = factory.GetItemServiceInstance();
            logService = factory.GetLogServiceInstance();
            membershipServece = factory.GetMembershipServiceInstance();
            memberTypeService = factory.GetMemberTypeServiceInstance();
            offerService = factory.GetOfferServiceInstance();
            transactionService = factory.GetTransactionServiceInstance();
            userTypeService = factory.GetUserTypeServiceInstance();

            AutoCompleteMethodForAccountName(txtSearchUsername);
            AutoCompleteMethodForItemName(txtSearchItem);
            AutoCompleteMethodForMember(txtMemberSearch);
            AutoCompleteMethodForOffer(txtOfferSearch);
            refreshDelegate = this.RefreshDataGridViewStocks;
            refreshDelegate = this.RefreshDataGridViewAccount;
        }

        #region Admin Panel Method
        private void ChangeUser()
        {
            new frmLogin().Show();
            this.Hide();
        }
        #endregion

        #region Stock Method

        private void GetSelectedItem()
        {
            string itemId = dataGridViewStocks.SelectedRows[0].Cells["itemCodeDataGridViewTextBoxColumn"].Value.ToString();
            Item item = itemService.GetById(itemId);
            txtItemCode.Text = item.ItemCode;
            txtItemName.Text = item.ItemName;
        }

        private void PopulateDataGridViewStock()
        {
            dataGridViewStocks.AutoGenerateColumns = false;
            dataGridViewStocks.DataSource = itemService.GetAllSortedByItemName();
        }
        private void PopulateDataGridViewAccount()
        {
            dataGridViewAccount.AutoGenerateColumns = false;
            dataGridViewAccount.DataSource = accountService.GetAllSortedByAccountName();
        }

        private void RefreshDataGridViewStocks()
        {
            dataGridViewStocks.DataSource = null;
            this.PopulateDataGridViewStock();
        }
        private void RefreshDataGridViewAccount()
        {
            
        }
        private void EditItem()
        {
            item = new Item(txtItemCode.Text.ToString());
            this.item.ItemName = txtItemName.Text;
            this.item.Description = txtItemDescription.Text;
            this.item.CategoryID = comCategory.Text;
            this.item.Price = Convert.ToDouble(txtPrice.Text);
            this.item.Stock = Convert.ToInt32(txtStocks.Text);

            if (itemService.Edit(this.item) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Updated Successfully!");
            }
        }

        private void RemoveItem()
        {
            this.item = new Item(txtItemCode.Text.ToString());
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (itemService.Remove(this.item.ItemCode) == 1)
                {
                    this.refreshDelegate.Invoke();
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
        }

        private void TotalItemCount()
        {

        }
        private void AutoCompleteMethodForItemName(TextBox txtBox)                       //Method added
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
        private void txtSearchItem_KeyDown(object sender, KeyEventArgs e)             // method added
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = txtSearchItem.Text;

                bool found = false;
                foreach (DataGridViewRow row in dataGridViewStocks.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        rowIn = row.Index;
                        dataGridViewStocks.Rows[rowIn].Selected = true;
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

        #region Account Method
        private void EditAccount()
        {
            account = new Account(txtAccountId.Text);
            this.account.Username = txtUsername.Text;
            this.account.Password = txtPassword.Text;
            this.account.FirstName = txtFirstname.Text;
            this.account.LastName = txtLastName.Text;
            this.account.UserTypeID = comUserType.Text;
            this.account.Salary =Convert.ToDouble(txtSalary.Text);

            if (accountService.Edit(this.account) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Updated Successfully!");
            }
        }

        private void RemoveAccount()
        {
            this.account = new Account(txtAccountId.Text);
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (accountService.Remove(this.account.AccountID) == 1)
                {
                    this.refreshDelegate.Invoke();
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
        }

        private void GenerateAccountGridView(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAccount.Rows[index];
            txtAccountId.Text = selectedRow.Cells[0].Value.ToString();
            txtUsername.Text = selectedRow.Cells[1].Value.ToString();
            txtPassword.Text = selectedRow.Cells[2].Value.ToString();
            txtFirstname.Text = selectedRow.Cells[3].Value.ToString();
            txtLastName.Text = selectedRow.Cells[4].Value.ToString();
            comUserType.Text = selectedRow.Cells[5].Value.ToString();
            txtSalary.Text = selectedRow.Cells[6].Value.ToString();
        }
        private void AutoCompleteMethodForAccountName(TextBox txtBox)
        {

            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            List<string> userNameList = new List<string>();
            userNameList = accountService.GetUserNameList();
            foreach (string it in userNameList)
            {
                col.Add(it);
            }
            txtBox.AutoCompleteCustomSource = col;
        }
        private void txtSearchUsername_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = txtSearchUsername.Text;

                bool found = false;
                foreach (DataGridViewRow row in dataGridViewAccount.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        rowIn = row.Index;
                        dataGridViewAccount.Rows[rowIn].Selected = true;
                        found = true;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("user Unavailable");
                }
            }
        }

        #endregion

        #region Report Method
        private void GetAllSales()
        {
            DataTable dt = transactionService.GetReportData();
            this.refreshDelegate.Invoke();
            dataGridViewAllSales.DataSource = dt;
        }
        
        private void GetDailySales()
        {
            DataTable dt = transactionService.GetReportData();
            this.refreshDelegate.Invoke();
            dataGridViewDailySales.DataSource = dt;
        }
        private void GetMonthlySales()
        {
            DataTable dt = transactionService.GetReportData();
            this.refreshDelegate.Invoke();
            dataGridViewMonthlySales.DataSource = dt;
        }
        private void GetYearlySales()
        {
            DataTable dt = transactionService.GetReportData();
            this.refreshDelegate.Invoke();
            dataGridViewYearlySales.DataSource = dt;
        }
        #endregion

        #region Log Method
        private void GetItemLogData()
        {
            DataTable dt = logService.GetItemLogData(); ;
            this.refreshDelegate.Invoke();
            dataGridViewItemLog.DataSource = dt;
        }
        private void GetLoginHistoryData()
        {
            DataTable dt = logService.GetLoginHistoryData();
            this.refreshDelegate.Invoke();
            dataGridViewLoginHistory.DataSource = dt;
        }
        private void GetStockLogData()
        {
            DataTable dt = logService.GetStockLogData();
            this.refreshDelegate.Invoke();
            dataGridViewStockLog.DataSource = dt;
        }
        private void GetAccountLogData()
        {
            DataTable dt = logService.GetAccountLogData();
            this.refreshDelegate.Invoke();
            dataGridViewAccountLog.DataSource = dt;
        }
        #endregion

        #region Offer Method
        private void EditOffer()
        {
            offer = new Offer(txtOfferId.Text);
            this.offer.OfferName = txtOfferName.Text;
            this.offer.Description = txtOfferDescription.Text;
            this.offer.DiscountPercentage = Convert.ToDouble(txtDiscount.Text);
            this.offer.OfferGiven = Convert.ToDateTime(txtOfferGiven.Text);
            this.offer.OfferValid = Convert.ToDateTime(txtOfferValidity.Text);
            this.offer.ItemCode = comboBoxItemCode.Text;
            this.offer.CategoryID = comboBoxCategoryId.Text;
            this.offer.MemberTypeID = comboBoxMemberShipId.Text;

            if (offerService.Edit(this.offer) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Updated Successfully!");
            }
        }

        private void RemoveOffer()
        {
            this.offer = new Offer(txtOfferId.Text);
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (offerService.Remove(this.offer.OfferID) == 1)
                {
                    this.refreshDelegate.Invoke();
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
        }
        private void GenerateOfferGridView(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewOfferDetails.Rows[index];
            txtOfferId.Text = selectedRow.Cells[0].Value.ToString();
            txtOfferName.Text = selectedRow.Cells[1].Value.ToString();
            txtOfferDescription.Text = selectedRow.Cells[2].Value.ToString();
            txtDiscount.Text = selectedRow.Cells[3].Value.ToString();
            txtOfferGiven.Text = selectedRow.Cells[4].Value.ToString();
            txtOfferValidity.Text = selectedRow.Cells[5].Value.ToString();
            comboBoxCategoryId.Text = selectedRow.Cells[6].Value.ToString();
            comboBoxItemCode.Text = selectedRow.Cells[7].Value.ToString();
            comboBoxMemberShipId.Text = selectedRow.Cells[8].Value.ToString();
        }


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
        private void txtOfferSearch_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = txtOfferSearch.Text;

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
        private void AutoCompleteMethodForMember(TextBox txtBox)                       //Method added
        {

            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            List<string> memberNameList = new List<string>();
            memberNameList = membershipServece.GetMemBerNames();
            foreach (string it in memberNameList)
            {
                col.Add(it);
            }
            txtBox.AutoCompleteCustomSource = col;
        }
        private void txtMemberSearch_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = txtMemberSearch.Text;

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
                    MessageBox.Show("Member Not Found");
                }
            }

        }
        #endregion

        #region Admin Panel Event
        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsDBDataSet1.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter1.Fill(this.imsDBDataSet1.Account);
            // TODO: This line of code loads data into the 'imsDBDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.imsDBDataSet.Transaction);
            // TODO: This line of code loads data into the 'imsDBDataSet.UserType' table. You can move, or remove it, as needed.
            this.userTypeTableAdapter.Fill(this.imsDBDataSet.UserType);
            this.membershipTableAdapter.Fill(this.imsDBDataSet.Membership);
            this.offerTableAdapter.Fill(this.imsDBDataSet.Offer);
            this.accountTableAdapter.Fill(this.imsDBDataSet.Account);
            this.logTableAdapter.Fill(this.imsDBDataSet.Log);
            this.categoryTableAdapter.Fill(this.imsDBDataSet.Category);
            this.itemTableAdapter.Fill(this.imsDBDataSet.Item);
            this.WindowState = FormWindowState.Maximized;

            this.PopulateDataGridViewStock();
        }

        private void frmAdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.ChangeUser();
        }

        private void tabControlAdmin_Click(object sender, EventArgs e)
        {
            this.GetAllSales();
        }

        //Menu Strip Events
        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeUser();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlAdmin.SelectedTab = tabPageStocks;
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlAdmin.SelectedTab = tabPageUserAccount;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlAdmin.SelectedTab = tabPageReport;
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlAdmin.SelectedTab = tabPageLog;
        }

        private void offerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlAdmin.SelectedTab = tabPageOffers;
        }

        private void membershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControlAdmin.SelectedTab = tabPageMembership;
        }

        #endregion

        #region Stock Events
        private void picAddItem_Click(object sender, EventArgs e)
        {
            new frmAddItem(refreshDelegate).Show();
        }
        private void pictureBoxEditItem_Click(object sender, EventArgs e)
        {
            this.EditItem();
        }

        private void pictureBoxDeleteItem_Click(object sender, EventArgs e)
        {
            this.RemoveItem();
        }
        private void dataGridViewStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewStocks.Rows[index];
            txtItemCode.Text = selectedRow.Cells[0].Value.ToString();
            txtItemName.Text = selectedRow.Cells[1].Value.ToString();
            txtItemDescription.Text = selectedRow.Cells[2].Value.ToString();
            comCategory.Text = selectedRow.Cells[3].Value.ToString();
            txtPrice.Text = selectedRow.Cells[4].Value.ToString();
            txtStocks.Text = selectedRow.Cells[5].Value.ToString();
        }
        private void lblAddItem_Click(object sender, EventArgs e)
        {
            this.pictureBoxEditItem_Click(sender, e);
        }
        private void pictureBoxNewCategory_Click(object sender, EventArgs e)
        {
            new frmAddCategory(refreshDelegate).ShowDialog();
        }

        private void pictureBoxDeleteCategory_Click(object sender, EventArgs e)
        {
            new frmDeleteCategory(refreshDelegate).ShowDialog();
        }
        #endregion

        #region Account Events
        private void picAddAccount_Click(object sender, EventArgs e)
        {
            new frmAddAccount(refreshDelegate).Show();
        }
        private void pictureBoxEditUser_Click(object sender, EventArgs e)
        {
            this.EditAccount();
        }

        private void pictureBoxDeleteAccount_Click(object sender, EventArgs e)
        {
            this.RemoveAccount();
        }
        private void dataGridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            this.GenerateAccountGridView(e);
        }
        private void pictureBoxNewUserType_Click(object sender, EventArgs e)
        {
            new frmAddNewUserType(refreshDelegate).ShowDialog();
        }

        private void pictureBoxDeleteUserType_Click(object sender, EventArgs e)
        {
            new frmDeleteUserType(refreshDelegate).ShowDialog();
        }
        #endregion

        #region Report Events
        private void tabControlReport_Selected(object sender, TabControlEventArgs e)
        {
            this.GetAllSales();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.GetDailySales();
        }
        private void comboBoxSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetMonthlySales();
        }

        private void comboBoxSelectMonth_DisplayMemberChanged(object sender, EventArgs e)
        {
            this.GetYearlySales();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetYearlySales();
        }
        #endregion

        #region Log Events
        private void tabControlLog_Selected(object sender, TabControlEventArgs e)
        {
            this.GetItemLogData();
            this.GetStockLogData();
            this.GetAccountLogData();
            this.GetLoginHistoryData();
        }
        #endregion

        #region Offer Events
        private void dataGridViewOfferDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GenerateOfferGridView(e);
        }
        private void pictureBoxNewOffer_Click(object sender, EventArgs e)
        {
            new frmAddOffer(refreshDelegate).ShowDialog();
        }

        private void pictureBoxEditOffer_Click(object sender, EventArgs e)
        {
            this.EditOffer();
        }

        private void pictureBoxDeteleOffer_Click(object sender, EventArgs e)
        {
            this.RemoveOffer();
        }







        #endregion
        
    }
}
