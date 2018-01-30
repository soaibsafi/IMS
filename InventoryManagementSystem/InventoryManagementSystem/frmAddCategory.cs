using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmAddCategory : Form
    {
        RefreshDelegate refreshDelegate;
        public frmAddCategory(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
        }
        private void AddNewCategory()
        {
            Category category = new Category(txtCategoryId.Text);
            category.CategoryName = txtCategoryName.Text;

            ServiceFactory factory = new ServiceFactory();
            ICategoryService categoryService = factory.GetCategoryServiceInstance();

            if (categoryService.Add(category) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            this.AddNewCategory();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
