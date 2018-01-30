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
    public partial class frmAddNewUserType : Form
    {
        RefreshDelegate refreshDelegate;
        public frmAddNewUserType(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
        }

        private void AddNewUserType()
        {
            UserType userType = new UserType(txtUserTypeId.Text);
            userType.UserTypeName = txtUserTypeName.Text;

            ServiceFactory factory = new ServiceFactory();
            IUserTypeService userTypeService = factory.GetUserTypeServiceInstance();

            if (userTypeService.Add(userType) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
        }

        private void buttonAddUserType_Click(object sender, EventArgs e)
        {
            this.AddNewUserType();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
