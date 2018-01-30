using System;
using System.Threading;
using System.Windows.Forms;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Core;

namespace InventoryManagementSystem
{
    public partial class frmLogin : Form
    {
        ServiceFactory factory;
        IAccountService accountService;
        public static string accountName;
        public frmLogin()
        {
            Thread thread = new Thread(new ThreadStart(StartStartUpForm));
            thread.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            factory = new ServiceFactory();
            accountService = factory.GetAccountServiceInstance();
            thread.Abort();
        }
        //Will be use for Change User
        public frmLogin(bool show)
        {
            if (show)
            {
                InitializeComponent();
            }
        }

        #region Methods
        private void StartStartUpForm()
        {
            Application.Run(new frmStartUpScreen());
        }

        private void Login()
        {
            string username = txtUserName.Text.ToString();
            string password = txtPassword.Text.ToString();
            Account account = accountService.GetByUsernamePassword(username, password);
            //return account;
            if (account.UserTypeID.Equals("UT1") || account.UserTypeID.Equals("UT2"))
            {
                new frmAdminPanel().Show();
                this.Hide();
            }
            else if (account.UserTypeID.Equals("UT3"))
            {
                new frmSalesPanel().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
            accountName = username;
        }
        #endregion

        #region Event Handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
            txtUserName.Focus();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter||e.KeyCode==Keys.Tab)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnLogin.Focus();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnExit.Focus();
            }
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnExit.PerformClick();
            }
        }
        #endregion

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            new ForgetPassword().ShowDialog();
        }
    }
}
