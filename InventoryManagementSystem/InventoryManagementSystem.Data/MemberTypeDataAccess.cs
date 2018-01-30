using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Data
{
    public class MemberTypeDataAccess
    {
        public int Add(Entity.MemberType memberType)
        {
            string query = string.Format("INSERT INTO MemberType(MemberTypeID, MemberTypeName) VALUES('{0}', '{1}')", memberType.MemberTypeID, memberType.MemberTypeName);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int id)
        {
            string query = "DELETE FROM MemberType WHERE MemberTypeID=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Entity.MemberType memberType)
        {
            string query = "UPDATE Account SET MemberTypeName='" + memberType.MemberTypeName + "' WHERE MemberTypeID=" + memberType.MemberTypeID;
            return DataAccess.ExecuteQuery(query);
        }
        public List<Entity.MemberType> GetAll()
        {
            string query = "SELECT MemberTypeID, MemberTypeName FROM MemberType";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.MemberType memberType = null;
            List<Entity.MemberType> memberTypeList = new List<Entity.MemberType>();
            while (reader.Read())
            {
                memberType = new Entity.MemberType(reader["MemberTypeID"].ToString());
                memberType.MemberTypeName = reader["MemberTypeName"].ToString();

                memberTypeList.Add(memberType);
            }
            return memberTypeList;
        }

        public Entity.MemberType GetMemberTypeName(string id)
        {
            string query = string.Format("SELECT MemberType.MemberTypeID, MemberType.MemberTypeName FROM MemberType INNER JOIN Membership on MemberType.MemberTypeID = Membership.MemberTypeID AND Membership.MembershipID = '{0}'", id);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Entity.MemberType memberType = null;
            if (reader.HasRows)
            {
                memberType = new Entity.MemberType(reader["MemberTypeID"].ToString());
                memberType.MemberTypeName = reader["MemberTypeName"].ToString();
            }
            else
            {
                MessageBox.Show("Member Not Found!");
                
            }
            return memberType;
        }

    }
}
