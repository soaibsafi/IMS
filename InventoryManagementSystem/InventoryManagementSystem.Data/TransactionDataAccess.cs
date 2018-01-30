using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class TransactionDataAccess
    {
        public int Add(Entity.Transaction transaction)
        {
            string query = string.Format("INSERT INTO SaleTransaction(TransactionID, TransactionDateTime, ItemCode, AccountID, MembershipID, OfferID, Quantity) VALUES('{0}', '{1}', '{2}', '{3}', '{4}, '{5}', '{6}')", transaction.TransactionID, transaction.TransactionDateTime, transaction.ItemCode, transaction.AccountId, transaction.MembershipID, transaction.OfferID, transaction.Quantity);
            return DataAccess.ExecuteQuery(query);
        }
        public int AddWithoutOfferID(Entity.Transaction transaction)
        {
            string query = string.Format("INSERT INTO SaleTransaction(TransactionID, TransactionDateTime, ItemCode, AccountID, MembershipID, Quantity) VALUES('{0}', '{1}', '{2}', '{3}', '{4}, '{5}')", transaction.TransactionID, transaction.TransactionDateTime, transaction.ItemCode, transaction.AccountId, transaction.MembershipID, transaction.Quantity);
            return DataAccess.ExecuteQuery(query);
        }
        public int AddWithoutMemberID(Entity.Transaction transaction)
        {
            string query = string.Format("INSERT INTO SaleTransaction(TransactionID, TransactionDateTime, ItemCode, AccountID, Quantity) VALUES('{0}', '{1}', '{2}', '{3}', '{4})", transaction.TransactionID, transaction.TransactionDateTime, transaction.ItemCode, transaction.AccountId, transaction.Quantity);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int id)
        {
            string query = string.Format("DELETE FROM SaleTransaction WHERE TransactionID='{0}'", id);
            return DataAccess.ExecuteQuery(query);
        }

        //public int Edit(Entity.Offer offer)
        //{
        //    string query = "UPDATE Offer SET OfferName='" + offer.OfferName + "', Description='" + offer.Description + "', DiscountPercentage='" + offer.DiscountPercentage + "', OfferGiven='" + offer.OfferGiven + "', OfferValid='" + offer.OfferValid + "', ItemCode='" + offer.ItemCode + "', CategoryID='" + offer.CategoryID + "', MemberTypeID='" + offer.MemberTypeID + "' WHERE OfferID=" + offer.OfferID;
        //    return DataAccess.ExecuteQuery(query);
        //}
        public List<Entity.Transaction> GetAll()
        {
            string query = "SELECT SaleTransaction, TransactionDateTime, ItemCode, AccountID, MembershipID, OfferID FROM Transaction";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Transaction transaction = null;
            List<Entity.Transaction> transactionList = new List<Entity.Transaction>();
            while (reader.Read())
            {
                transaction = new Entity.Transaction(reader["TransactionID"].ToString(), Convert.ToDateTime(reader["TransactionDateTime"]));
                transaction.ItemCode = reader["ItemCode"].ToString();
                transaction.AccountId = reader["AccountID"].ToString();
                transaction.MembershipID = reader["MembershipID"].ToString();
                transaction.OfferID = reader["OfferID"].ToString();

                transactionList.Add(transaction);
            }
            return transactionList;
        }

        public DataTable GetReportData()
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT SaleTransaction.TransactionID, SaleTransaction.TransactionDateTime, Account.UserName, Item.ItemCode, Item.ItemName, Item.Description, Item.CategoryID, Item.Price, Item.Stock FROM SaleTransaction INNER JOIN Account on SaleTransaction.AccountId = Account.AccountId INNER JOIN Item on SaleTransaction.ItemCode = Item.ItemCode", DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public DataTable GetReportDataByDate()
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT SaleTransaction.TransactionID, SaleTransaction.TransactionDateTime, Account.UserName, Item.ItemCode, Item.ItemName, Item.Description, Item.CategoryID, Item.Price, Item.Stock FROM SaleTransaction INNER JOIN Account on SaleTransaction.AccountId = Account.AccountId INNER JOIN Item on SaleTransaction.ItemCode = Item.ItemCode", DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
    }
}
