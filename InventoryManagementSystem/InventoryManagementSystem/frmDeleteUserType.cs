using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmDeleteUserType : Form
    {
        RefreshDelegate refreshDelegate;

        ServiceFactory factory;
        IUserTypeService userTypeService;
        UserType userType;
        public frmDeleteUserType(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
            factory = new ServiceFactory();
            userTypeService = factory.GetUserTypeServiceInstance();
        }
        private void PopulateUserTypeID(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewDeleteUserType.Rows[index];
            txtUserTypeID.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void DeleteSelectedUserType()
        {
            userType = new UserType(txtUserTypeID.Text.ToString());
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (userTypeService.Remove(this.userType.UserTypeId) == 1)
                {
                    this.refreshDelegate.Invoke();
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
        }

        private void frmDeleteUserType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsDBDataSet.UserType' table. You can move, or remove it, as needed.
            this.userTypeTableAdapter.Fill(this.imsDBDataSet.UserType);

        }

        private void dataGridViewDeleteUserType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PopulateUserTypeID(e);
        }

        private void btnRemoveUserType_Click(object sender, EventArgs e)
        {
            this.DeleteSelectedUserType();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
