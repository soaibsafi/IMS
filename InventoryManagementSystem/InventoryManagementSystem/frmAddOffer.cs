using InventoryManagementSystem.Core;
using InventoryManagementSystem.Entity;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmAddOffer : Form
    {
        RefreshDelegate refreshDelegate;
        public frmAddOffer(RefreshDelegate refreshDelegate)
        {
            InitializeComponent();
            this.refreshDelegate = refreshDelegate;
        }
        private void AddNewOffer()
        {
            Offer offer = new Offer(txtOfferId.Text.ToString());
            offer.OfferName = txtOfferName.Text;
            offer.Description = txtOfferDescription.Text;
            offer.DiscountPercentage = Convert.ToDouble(txtDiscount.Text);
            offer.OfferGiven = Convert.ToDateTime(monthCalendarOfferGiven.SelectionRange.Start.ToShortDateString());
            offer.OfferValid = Convert.ToDateTime(monthCalendarOfferExpired.SelectionRange.Start.ToShortDateString());
            offer.ItemCode = txtItemCode.Text;
            offer.CategoryID = txtCategoryID.Text;
            offer.MemberTypeID = txtMemberTypeID.Text;

            ServiceFactory factory = new ServiceFactory();
            IOfferService offerService = factory.GetOfferServiceInstance();

            if (offerService.Add(offer) == 1)
            {
                this.refreshDelegate.Invoke();
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddOffer_Click(object sender, EventArgs e)
        {
            this.AddNewOffer();
        }
    }
}
