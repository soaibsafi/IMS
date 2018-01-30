using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Data
{
    public class OfferDataAccess
    {
        public int Add(Entity.Offer offer)
        {
            string query = string.Format("INSERT INTO Offer(OfferID, OfferName, Description, DiscountPercentage, OfferGiven, OfferValid, ItemCode, CategoryID, MemberTypeID) VALUES('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}')", offer.OfferID, offer.OfferName, offer.Description, offer.DiscountPercentage, offer.OfferGiven, offer.OfferValid, offer.ItemCode, offer.CategoryID, offer.MemberTypeID);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string id)
        {
            string query = string.Format("DELETE FROM Offer WHERE OfferID='{0}'", id);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Entity.Offer offer)
        {
            string query = string.Format("UPDATE Offer SET OfferName='" + offer.OfferName + "', Description='" + offer.Description + "', DiscountPercentage='" + offer.DiscountPercentage + "', OfferGiven='" + offer.OfferGiven + "', OfferValid='" + offer.OfferValid + "', ItemCode='" + offer.ItemCode + "', CategoryID='" + offer.CategoryID + "', MemberTypeID='" + offer.MemberTypeID + "' WHERE OfferID='{0}'", offer.OfferID);
            return DataAccess.ExecuteQuery(query);
        }
        public List<Entity.Offer> GetAll()
        {
            string query = "SELECT OfferID, OfferName, Description, DiscountPercentage, OfferGiven, OfferValid, ItemCode, CategoryID, MemberTypeID FROM Offer";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Offer offer = null;
            List<Entity.Offer> offerList = new List<Entity.Offer>();
            while (reader.Read())
            {
                offer = new Entity.Offer(reader["OfferID"].ToString());
                offer.OfferName = reader["OfferName"].ToString();
                offer.Description = reader["Description"].ToString();
                offer.DiscountPercentage = Convert.ToDouble(reader["DiscountPercentage"]);
                offer.OfferGiven = Convert.ToDateTime(reader["OfferGiven"]); ;
                offer.OfferValid = Convert.ToDateTime(reader["OfferValid"]);
                offer.ItemCode = reader["ItemCode"].ToString();
                offer.CategoryID = reader["CategoryID"].ToString();
                offer.MemberTypeID = reader["MemberTypeID"].ToString(); ;

                offerList.Add(offer);
            }
            return offerList;
        }
        public Entity.Offer GetDiscount(string id)
        {
            string query = string.Format("SELECT Offer.OfferID, Offer.DiscountPercentage FROM Offer WHERE Offer.MemberTypeID = '{0}'", id);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Entity.Offer offer = null;
            if (reader.HasRows)
            {
                offer = new Entity.Offer(reader["OfferID"].ToString());
                offer.DiscountPercentage = Convert.ToDouble(reader["DiscountPercentage"]);
            }
            else
            {
                MessageBox.Show("No Offer Found!");

            }

            return offer;
        }
        public List<string> GetOfferNames()                // added
        {
            string query = string.Format("SELECT  OfferName FROM Offer");
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();
            List<string> offerName= new List<string>();
            if (reader.Read())
            {
                offerName.Add(reader["OfferName"].ToString());
            }
            return offerName;
        }
    }
}
