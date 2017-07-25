using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmAddItems: Form
    {
        public Form RefToAdminPanel { get; set; }
        public frmAddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, System.EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
