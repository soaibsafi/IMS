using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class JoinTableDataAccess
    {
        
        public DataTable GetReportData()
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT SaleTransaction.TransactionID, SaleTransaction.TransactionDateTime, Account.UserName, Item.ItemCode, Item.ItemName, Item.Description, Item.CategoryID, Item.Price, Item.Stock FROM SaleTransaction INNER JOIN Account on SaleTransaction.AccountId = Account.AccountId INNER JOIN Item on SaleTransaction.ItemCode = Item.ItemCode",DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
    }
}
