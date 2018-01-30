using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmDeleteCategory : Form
    {
        RefreshDelegate refreshDelegate;

        ServiceFactory factory;
        ICategoryService categoryService;
        Category category;
        public frmDeleteCategory(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
            factory = new ServiceFactory();
            categoryService = factory.GetCategoryServiceInstance();
        }

        private void PopulateCategoryID(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewDeleteCategory.Rows[index];
            txtCatID.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void DeleteSelectedCategory()
        {
            category = new Category(txtCatID.Text.ToString());
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (categoryService.Remove(this.category.CategoryID) == 1)
                {
                    this.refreshDelegate.Invoke();
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
        }

        private void frmDeleteCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsDBDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.imsDBDataSet.Category);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            this.DeleteSelectedCategory();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PopulateCategoryID(e);
        }
    }
}
