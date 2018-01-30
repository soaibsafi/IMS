using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmAddItem : Form
    {
        private RefreshDelegate refreshDelegate;
        frmAdminPanel adminpanel = new frmAdminPanel();

        public frmAddItem(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
        }

        #region Methods
        private void AddNewItem()
        {
            Item item = new Item(txtItemCode.Text);
            item.ItemName = txtItemName.Text;
            item.Description = txtItemDescription.Text;
            item.Price = Convert.ToDouble(txtPrice.Text);
            item.Stock = Convert.ToInt32(txtStocks.Text);
            item.CategoryID = txtCategory.Text;


            ServiceFactory factory = new ServiceFactory();
            IItemService itemService = factory.GetItemServiceInstance();
            
            if (itemService.Add(item) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
        }
        #endregion

        #region Handle Event
        private void frmAddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsDBDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.imsDBDataSet.Item);
            // TODO: This line of code loads data into the 'imsDBDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.imsDBDataSet.Category);

        }
                
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            this.AddNewItem();
            adminpanel.Refresh();
        }
        #endregion

    }
}
