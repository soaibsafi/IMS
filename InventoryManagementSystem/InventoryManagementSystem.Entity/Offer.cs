using System;

namespace InventoryManagementSystem.Entity
{
    public class Offer
    {
        readonly string offerId;
        string offerName;
        string description;
        double discountPercentage;
        DateTime offerGiven;
        DateTime offerValid;
        string itemCode;
        string categoryId;
        string memberTypeId;

        public Offer()
        {
            
        }
        public Offer(string offerId)
        {
            this.offerId = offerId;
        }
        public Offer(string offerId, string offerName, float discountPercentage, DateTime offerGiven, DateTime offerValid)
        {
            this.offerId = offerId;
            this.offerName = offerName;
            this.discountPercentage = discountPercentage;
            this.offerGiven = offerGiven;
            this.offerValid = offerValid;
        }
        public Offer(string offerId, string offerName, string description, float discountPercentage, DateTime offerGiven, DateTime offerValid, string itemCode, string categoryId, string memberTypeId)
        {
            this.offerId = offerId;
            this.offerName = offerName;
            this.description = description;
            this.discountPercentage = discountPercentage;
            this.offerGiven = offerGiven;
            this.offerValid = offerValid;
            this.itemCode = itemCode;
            this.categoryId = categoryId;
            this.memberTypeId = memberTypeId;
        }

        public string OfferID { get { return this.offerId; } }
        public string OfferName { set { this.offerName = value; } get { return this.offerName; } }
        public string Description { set { this.description = value; } get { return this.description; } }
        public double DiscountPercentage { set { this.discountPercentage = value; } get { return this.discountPercentage; } }
        public DateTime OfferGiven { set { this.offerGiven = value; } get { return this.offerGiven; } }
        public DateTime OfferValid { set { this.offerValid = value; } get { return this.offerValid; } }
        public string ItemCode { set { this.itemCode = value; } get { return this.itemCode; } }
        public string CategoryID { set { this.categoryId = value; } get { return this.categoryId; } }
        public string MemberTypeID { set { this.memberTypeId = value; } get { return this.memberTypeId; } }

    }
}
