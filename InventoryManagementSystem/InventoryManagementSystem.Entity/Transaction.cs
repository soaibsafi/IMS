using System;

namespace InventoryManagementSystem.Entity
{
    public class Transaction
    {
        readonly string transactionId;
        readonly DateTime transactionDateTime;
        string itemCode;
        string accountId;
        string membershipId;
        string offerId;
        int quantity;

        public Transaction()
        {
            
        }
        public Transaction(string transactionId, DateTime transactionDateTime)
        {
            this.transactionId = transactionId;
            this.transactionDateTime = transactionDateTime;
        }
        public Transaction(string transactionId, DateTime transactionDateTime, string itemCode, string accountId)
        {
            this.transactionId = transactionId;
            this.transactionDateTime = transactionDateTime;
            this.itemCode = itemCode;
            this.accountId = accountId;
        }
        public Transaction(string transactionId, DateTime transactionDateTime, string itemCode, string accountId, string membershipId, string offerId, int quantity)
        {
            this.transactionId = transactionId;
            this.transactionDateTime = transactionDateTime;
            this.itemCode = itemCode;
            this.accountId = accountId;
            this.membershipId = membershipId;
            this.offerId = offerId;
            this.quantity = quantity;
        }

        public string TransactionID { get { return this.transactionId; } }
        public DateTime TransactionDateTime {  get { return this.transactionDateTime; } }
        public string ItemCode { set { this.itemCode = value; } get { return this.itemCode; } }
        public string AccountId { set { this.accountId = value; } get { return this.accountId; } }
        public string MembershipID { set { this.membershipId = value; } get { return this.membershipId; } }
        public string OfferID { set { this.offerId = value; } get { return this.offerId; } }
        public int Quantity { set { this.quantity = value; } get { return this.quantity; } }

    }
}
