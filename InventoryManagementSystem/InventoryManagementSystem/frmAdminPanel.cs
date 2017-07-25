using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void tabPageItems_Click(object sender, EventArgs e)
        {

        }

        private void tabPageStocks_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAccount_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSales_Click(object sender, EventArgs e)
        {

        }

        private void tabPageLogManager_Click(object sender, EventArgs e)
        {

        }

        private void tabPageHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            new frmLogin(true).Show();
            this.Close();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picAddItem_Click(object sender, EventArgs e)
        {
            frmAddItems addItems = new frmAddItems();
            addItems.RefToAdminPanel = this;
            //this.Visible = false;
            addItems.Show();
        }

        private void picDailySales_Click(object sender, EventArgs e)
        {
            frmDailySales ds = new frmDailySales();
            ds.RefToAdminPanel = this;
            //this.Visible = false;
            ds.Show();
        }

        private void picMonthlySales_Click(object sender, EventArgs e)
        {
            frmMonthlySales ms = new frmMonthlySales();
            ms.RefToAdminPanel = this;
            //this.Visible = false;
            ms.Show();
        }

        private void picYearlySales_Click(object sender, EventArgs e)
        {
            frmYearlySales ys = new frmYearlySales();
            ys.RefToAdminPanel = this;
            //this.Visible = false;
            ys.Show();
        }
        
        private void picAddAccount_Click(object sender, EventArgs e)
        {
            frmAddAccount addAccount = new frmAddAccount();
            addAccount.RefToAdminPanel = this;
            //this.Visible = false;
            addAccount.Show();
        }

        private void btnItemLog_Click(object sender, EventArgs e)
        {
            frmItemLog il = new frmItemLog();
            il.RefToAdminPanel = this;
            //this.Visible = false;
            il.Show();
        }

        private void btnStockLog_Click(object sender, EventArgs e)
        {
            frmStockLog sl = new frmStockLog();
            sl.RefToAdminPanel = this;
            //this.Visible = false;
            sl.Show();
        }

        private void btnAccountLog_Click(object sender, EventArgs e)
        {
            frmAccountLog al = new frmAccountLog();
            al.RefToAdminPanel = this;
            //this.Visible = false;
            al.Show();
        }

        private void btnLogInHistory_Click(object sender, EventArgs e)
        {
            frmLogInHistory lih = new frmLogInHistory();
            lih.RefToAdminPanel = this;
            //this.Visible = false;
            lih.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
