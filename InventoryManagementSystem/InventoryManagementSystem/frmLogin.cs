using System.Threading;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread thread = new Thread(new ThreadStart(StartStartUpForm));
            thread.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            thread.Abort();       
        }
         public frmLogin(bool show)
        {
            if (show)
            {
                InitializeComponent();
            }
        }
        public void StartStartUpForm()
        {
            Application.Run(new frmStartUpScreen());
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (txtUserName.Text.Equals("1"))
            {
                new frmAdminPanel().Show();
                this.Hide();
            }
            else if (txtUserName.Text.Equals("2"))
            {
                new frmSalesPanel().Show();
                this.Hide();
            }
            
        }
    }
}
