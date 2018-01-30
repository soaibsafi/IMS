using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    class MembershipService:IMembershipService
    {
        private static MembershipDataAccess membershipDataAccess = null;

        public MembershipService()
        {
            if (MembershipService.membershipDataAccess == null)
            {
                MembershipService.membershipDataAccess = new MembershipDataAccess();
            }
        }

        public int Add(Entity.Membership membership)
        {
            return MembershipService.membershipDataAccess.Add(membership);
        }

        public int Edit(Entity.Membership membership)
        {
            return MembershipService.membershipDataAccess.Edit(membership);
        }

        public List<Entity.Membership> GetAll()
        {
            return MembershipService.membershipDataAccess.GetAll();
        }

        public int Remove(string id)
        {
            return MembershipService.membershipDataAccess.Remove(id);
        }
        public bool checkValidMember(string memberId)                           //added
        {
            return MembershipService.membershipDataAccess.checkValidMember(memberId);
        }
        public int addShoppingToMemberId(string membershipId, double amountPayable) //added
        {
            return MembershipService.membershipDataAccess.addShoppingToMemberId(membershipId, amountPayable);
        }

        public List<string> GetMemBerNames()
        {
            return MembershipService.membershipDataAccess.GetMemBerNames();
        }
    }
}
