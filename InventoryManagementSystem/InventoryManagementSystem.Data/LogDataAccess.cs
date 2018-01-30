using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class LogDataAccess
    {
        public int Add(Entity.Log log)
        {
            string query = string.Format("INSERT INTO Account(LogId, Login, Logout, Action, AccountId, ItemCode) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", log.LogId, log.LoginTime, log.LogoutTime, log.AccountId, log.ItemCode);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(int id)
        {
            string query = "DELETE FROM Log WHERE LogId=" + id;
            return DataAccess.ExecuteQuery(query);
        }
        public int Edit(Entity.Log log)
        {
            string query = "UPDATE Account SET Login='" + log.LoginTime + "', Logout='" + log.LogoutTime + "', Action='" + log.Action + "', AccountId='" + log.AccountId + "', ItemCode='" + log.ItemCode + "' WHERE LogId=" + log.LogId;
            return DataAccess.ExecuteQuery(query);
        }
        public List<Entity.Log> GetAll()
        {
            string query = "SELECT LogId, Login, Logout, Action, AccountId, ItemCode FROM Log";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Log log = null;
            List<Entity.Log> logList = new List<Entity.Log>();
            while (reader.Read())
            {
                log = new Entity.Log(reader["LogId"].ToString());
                log.LoginTime = Convert.ToDateTime(reader["Login"]);
                log.LogoutTime = Convert.ToDateTime(reader["Logout"]);
                log.Action = reader["Action"].ToString();
                log.AccountId = reader["AccountId"].ToString();
                log.ItemCode = reader["ItemCode"].ToString();

                logList.Add(log);
            }
            return logList;
        }
        public DataTable GetItemLogData()
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT SaleTransaction.TransactionDateTime as 'Date & Time', Log.Action, Account.UserName as 'Updated By', Item.ItemCode as 'Item Code', Item.ItemName as 'Item Name', Item.CategoryID, Item.Price, Item.Stock as 'Current Stock', (Item.Price* Item.Stock) as 'Total Price' FROM SaleTransaction INNER JOIN Account on SaleTransaction.AccountId = Account.AccountId INNER JOIN Item on SaleTransaction.ItemCode = Item.ItemCode JOIN Log on Account.AccountId = Log.AccountId", DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public DataTable GetStockLogData()
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT SaleTransaction.TransactionDateTime as 'Date & Time',SaleTransaction.Quantity as 'Stock Added', Log.Action, Account.UserName as 'Updated By', Item.ItemCode as 'Item Code', Item.ItemName as 'Item Name', Item.CategoryID, Item.Price, Item.Stock as 'Current Stock', (Item.Price* Item.Stock) as 'Total Price' FROM SaleTransaction INNER JOIN Account on SaleTransaction.AccountId = Account.AccountId INNER JOIN Item on SaleTransaction.ItemCode = Item.ItemCode JOIN Log on Account.AccountId = Log.AccountId", DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public DataTable GetAccountLogData()
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT SaleTransaction.TransactionDateTime as 'Date & Time', Account.UserName as 'User Name', Log.Action, Log.AccountId as 'Updated By' FROM SaleTransaction INNER JOIN Account on SaleTransaction.AccountId = Account.AccountId INNER JOIN Log on Account.AccountId = Log.AccountId", DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public DataTable GetLoginHistoryData()
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT Account.UserName as 'User Name', UserType.UserTypeName as 'User Type', Log.Login as 'Login Time', Log.Logout as 'Logout Time' FROM Log INNER JOIN Account on Log.AccountId = Account.AccountId INNER JOIN UserType on Account.UserTypeID = UserType.UserTypeId", DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
    }
}
