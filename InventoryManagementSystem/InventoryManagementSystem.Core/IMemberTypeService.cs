using InventoryManagementSystem.Entity;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    public interface IMemberTypeService
    {
        int Add(MemberType memberType);
        int Remove(int id);
        int Edit(MemberType memberType);
        List<MemberType> GetAll();
        Entity.MemberType GetMemberTypeName(string id);
    }
}
