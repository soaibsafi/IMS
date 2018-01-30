using System;

namespace InventoryManagementSystem.Entity
{
    public class Membership
    {
        readonly string membershipId;
        string memberTypeId;
        string memberName;
        string memberAddress;
        string phoneNumber;
        string email;
        DateTime memberFrom;
        double totalShopping;

        public Membership()
        {
            
        }
        public Membership(string membershipId)
        {
            this.membershipId = membershipId;
        }
        public Membership(string membershipId, string memberTypeId, string memberName, string phoneNumber, DateTime memberFrom, float totalShopping)
        {
            this.membershipId = membershipId;
            this.memberTypeId = memberTypeId;
            this.memberName = memberName;
            this.phoneNumber = phoneNumber;
            this.memberFrom = memberFrom;
            this.totalShopping = totalShopping;
        }
        public Membership(string membershipId, string memberTypeId, string memberName, string memberAddress, string phoneNumber, string email, DateTime memberFrom, float totalShopping)
        {
            this.membershipId = membershipId;
            this.memberTypeId = memberTypeId;
            this.memberName = memberName;
            this.memberAddress = memberAddress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.memberFrom = memberFrom;
            this.totalShopping = totalShopping;
        }

        public string MemberID { get { return this.membershipId; } }
        public string MemberTypeID { set { this.memberTypeId = value; } get { return this.memberTypeId; } }
        public string MemberName { set { this.memberName = value; } get { return this.memberName; } }
        public string MemberAddress { set { this.memberAddress = value; } get { return this.memberAddress; } }
        public string PhoneNumber { set { this.phoneNumber = value; } get { return this.phoneNumber; } }
        public string Email { set { this.email = value; } get { return this.email; } }
        public DateTime MemberFrom { set { this.memberFrom = value; } get { return this.memberFrom; } }
        public double TotalShopping { set { this.totalShopping = value; } get { return this.totalShopping; } }
    }
}
