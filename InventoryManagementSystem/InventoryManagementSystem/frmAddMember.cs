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
    public partial class frmAddMember : Form
    {
        private RefreshDelegate refreshDelegate;
        public frmAddMember(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
            
        }

        private void AddNewMember()
        {
            Membership membership = new Membership(txtMemberId.Text);
            membership.MemberTypeID = comMemberTypeId.Text;
            membership.MemberName = txtName.Text;
            membership.MemberAddress = txtAddress.Text;
            membership.PhoneNumber = txtPhoneNumber.Text;
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please give a valid Email Address");
            }
            else if(txtEmail.Text.Equals(""))
            {
                membership.Email = "NULL";
            }
            else
            {
                membership.Email = txtEmail.Text;
            }
            membership.MemberFrom = DateTime.Now;
            membership.TotalShopping = 0.0;


            ServiceFactory factory = new ServiceFactory();
            IMembershipService membershipService = factory.GetMembershipServiceInstance();

            if (membershipService.Add(membership) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Member Added Successfully!");
                this.Close();
            }
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            this.AddNewMember();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsDBDataSet.MemberType' table. You can move, or remove it, as needed.
            this.memberTypeTableAdapter.Fill(this.imsDBDataSet.MemberType);

        }
    }
}
