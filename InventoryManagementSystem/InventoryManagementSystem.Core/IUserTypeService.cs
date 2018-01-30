
using InventoryManagementSystem.Entity;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    public interface IUserTypeService
    {
        int Add(UserType userType);
        int Remove(string id);
        int Edit(UserType userType);
        List<UserType> GetAll();
    }
}
