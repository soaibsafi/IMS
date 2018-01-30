using InventoryManagementSystem.Entity;
using System.Collections.Generic;


namespace InventoryManagementSystem.Core
{
    public interface IMembershipService
    {
        int Add(Membership membership);
        int Remove(string id);
        int Edit(Membership membership);
        List<Membership> GetAll();
        bool checkValidMember(string memberId);
        int addShoppingToMemberId(string membershipId, double amountPayable);

        List<string> GetMemBerNames();
    }
}
