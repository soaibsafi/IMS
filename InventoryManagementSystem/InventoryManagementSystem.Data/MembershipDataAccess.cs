using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class MembershipDataAccess
    {
        public int Add(Entity.Membership membership)
        {
            string query = string.Format("INSERT INTO Membership(MembershipID, MemberTypeID, MemberName, MemberAddress, PhoneNumber, Email, MemberFrom, TotalShopping) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})", membership.MemberID, membership.MemberTypeID, membership.MemberName, membership.MemberAddress, membership.PhoneNumber, membership.Email, membership.MemberFrom, membership.TotalShopping);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string id)
        {
            string query = string.Format("DELETE FROM Membership WHERE MembershipID='{0}'", id);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Entity.Membership membership)
        {
            string query = string.Format("UPDATE Membership SET MemberTypeID='" + membership.MemberTypeID + "', MemberName='" + membership.MemberName + "', MemberAddress='" + membership.MemberAddress + "', PhoneNumber='" + membership.PhoneNumber + "', Email='" + membership.Email + "', MemberFrom='" + membership.MemberFrom + "', TotalShopping='" + membership.TotalShopping + "' WHERE MembershipID='{0}'", membership.MemberID);
            return DataAccess.ExecuteQuery(query);
        }
        public List<Entity.Membership> GetAll()
        {
            string query = "SELECT MembershipID, MemberTypeID, MemberName, MemberAddress, PhoneNumber, Email, MemberFrom, TotalShopping FROM Membership";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Membership membership = null;
            List<Entity.Membership> membershipList = new List<Entity.Membership>();
            while (reader.Read())
            {
                membership = new Entity.Membership(reader["MembershipID"].ToString());
                membership.MemberTypeID = reader["MemberTypeID"].ToString();
                membership.MemberName = reader["MemberName"].ToString();
                membership.MemberAddress = reader["MemberAddress"].ToString();
                membership.PhoneNumber = reader["PhoneNumber"].ToString(); ;
                membership.Email = reader["Email"].ToString();
                membership.MemberFrom = Convert.ToDateTime(reader["MemberFrom"]);
                membership.TotalShopping = Convert.ToDouble(reader["TotalShopping"]);

                membershipList.Add(membership);
            }
            return membershipList;
        }
        public bool checkValidMember(string memberId)
        {
            string query = "SELECT MembershipID FROM Membership";
            SqlDataReader reader = DataAccess.GetData(query);

            string membership;

            while (reader.Read())
            {
                membership = reader["MembershipID"].ToString();
                if (membership == memberId)
                {
                    return true;
                }

            }
            return false;
        }
        public int addShoppingToMemberId(string membershipId, double amountPayable)
        {
            string query = string.Format("UPDATE Membership SET TotalShopping = (SELECT TotalShopping from Membership where MembershipID = '" + membershipId + "')+ '" + amountPayable + "' where MembershipID = '"+membershipId+"'");
            return DataAccess.ExecuteQuery(query);
        }



        public List<string> GetMemBerNames()
        {
            string query = "SELECT MemberName FROM Membership";
            SqlDataReader reader = DataAccess.GetData(query);

            List<string> memberNameList = new List<string>();

            while (reader.Read())
            {
                memberNameList.Add(reader["MemberName"].ToString());
            }
            return memberNameList;
        }
    }
}
