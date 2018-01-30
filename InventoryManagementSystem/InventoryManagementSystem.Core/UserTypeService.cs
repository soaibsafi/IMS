using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    class UserTypeService:IUserTypeService
    {
        private static UserTypeDataAccess userTypeDataAccess = null;

        public UserTypeService()
        {
            if (UserTypeService.userTypeDataAccess == null)
            {
                UserTypeService.userTypeDataAccess = new UserTypeDataAccess();
            }
        }

        public int Add(Entity.UserType userType)
        {
            return UserTypeService.userTypeDataAccess.Add(userType);
        }

        public int Edit(Entity.UserType userType)
        {
            return UserTypeService.userTypeDataAccess.Edit(userType);
        }

        public List<Entity.UserType> GetAll()
        {
            return UserTypeService.userTypeDataAccess.GetAll();
        }

        public int Remove(string id)
        {
            return UserTypeService.userTypeDataAccess.Remove(id);
        }
    }
}
