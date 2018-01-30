using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class UserTypeDataAccess
    {
        public int Add(Entity.UserType userType)
        {
            string query = string.Format("INSERT INTO UserType(UserTypeId, UserTypeName) VALUES('{0}', '{1}')", userType.UserTypeId, userType.UserTypeName);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string id)
        {
            string query = string.Format("DELETE FROM UserType WHERE UserTypeId='{0}'", id);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Entity.UserType userType)
        {
            string query = "UPDATE Account SET UserTypeName='" + userType.UserTypeName + "' WHERE UserTypeId=" + userType.UserTypeId;
            return DataAccess.ExecuteQuery(query);
        }
        public List<Entity.UserType> GetAll()
        {
            string query = "SELECT UserTypeId, UserTypeName FROM UserType";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.UserType userType = null;
            List<Entity.UserType> userTypeList = new List<Entity.UserType>();
            while (reader.Read())
            {
                userType = new Entity.UserType(reader["UserTypeId"].ToString());
                userType.UserTypeName = reader["UserTypeName"].ToString();

                userTypeList.Add(userType);
            }
            return userTypeList;
        }
    }
}
