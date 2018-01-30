using System;

namespace InventoryManagementSystem.Entity
{
    public class MemberType
    {
        readonly string memberTypeId;
        string memberTypeName;

        public MemberType()
        {
            
        }
        public MemberType(string memberTypeId)
        {
            this.memberTypeId = memberTypeId;
        }
        public MemberType(string memberTypeId, string memberTypeName)
        {
            this.memberTypeId = memberTypeId;
            this.memberTypeName = memberTypeName;
        }

        public string MemberTypeID { get { return this.memberTypeId; } }
        public string MemberTypeName { set { this.memberTypeName = value; } get { return this.memberTypeName; } }
    }
}
