using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmAddAccount : Form
    {
        RefreshDelegate refreshDelegate;
        public frmAddAccount(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
        }

        private void AddNewAccount()
        {
            Account account = new Account(txtAccountId.Text.ToString());
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.FirstName = txtFirstName.Text.ToString();
            account.LastName = txtLastName.Text.ToString(); ;
            account.UserTypeID = textBoxUserTypeID.Text;
            account.Salary = Convert.ToDouble(txtSalary.Text);
            account.JoinDate = Convert.ToDateTime(monthCalendarJoinDate.SelectionRange.Start.ToShortDateString());


            ServiceFactory factory = new ServiceFactory();
            IAccountService accountService = factory.GetAccountServiceInstance();

            if (accountService.Add(account) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            this.AddNewAccount();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
