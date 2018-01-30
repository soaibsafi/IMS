using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    class MemberTypeService:IMemberTypeService
    {
        private static MemberTypeDataAccess memberTypeDataAccess = null;

        public MemberTypeService()
        {
            if (MemberTypeService.memberTypeDataAccess == null)
            {
                MemberTypeService.memberTypeDataAccess = new MemberTypeDataAccess();
            }
        }

        public int Add(Entity.MemberType memberType)
        { 
            return MemberTypeService.memberTypeDataAccess.Add(memberType);
        }

        public int Edit(Entity.MemberType memberType)
        {
            return MemberTypeService.memberTypeDataAccess.Edit(memberType);
        }

        public List<Entity.MemberType> GetAll()
        {
            return MemberTypeService.memberTypeDataAccess.GetAll();
        }

        public Entity.MemberType GetMemberTypeName(string id)
        {
            return MemberTypeService.memberTypeDataAccess.GetMemberTypeName(id);
        }

        public int Remove(int id)
        {
            return MemberTypeService.memberTypeDataAccess.Remove(id);
        }
    }
}
