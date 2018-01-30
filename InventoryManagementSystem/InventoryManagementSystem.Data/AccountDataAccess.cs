using System.Data.SqlClient;
using InventoryManagementSystem.Entity;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace InventoryManagementSystem.Data
{
    public class AccountDataAccess
    {
        public int Add(Entity.Account account)
        {
            string query = string.Format("INSERT INTO Account(AccountId, UserName, Password, FirstName, LastName, UserTypeID, Salary, JoinDate) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}')", account.AccountID, account.Username, account.Password, account.FirstName, account.LastName, account.UserTypeID, account.Salary, account.JoinDate);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string id)
        {
            string query = string.Format("DELETE FROM Account WHERE AccountId='{0}'",id);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Entity.Account account)
        {
            string query = string.Format("UPDATE Account SET UserName='" + account.Username + "', Password='" + account.Password + "', FirstName='" + account.FirstName + "', LastName='" + account.LastName + "', UserTypeID='" + account.UserTypeID + "', Salary='" + account.Salary + "', JoinDate='" + account.JoinDate + "' WHERE AccountId='{0}'", account.AccountID);
            return DataAccess.ExecuteQuery(query);
        }
        public List<Entity.Account> GetAll()
        {
            string query = "SELECT AccountId, UserName, Password, FirstName, LastName, UserTypeID, Salary, JoinDate FROM Account";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Account account = null;
            List<Entity.Account> accountList = new List<Entity.Account>();
            while (reader.Read())
            {
                account = new Entity.Account(reader["AccountId"].ToString());
                account.Username = reader["UserName"].ToString();
                account.Password = reader["Password"].ToString();
                account.FirstName = reader["FirstName"].ToString();
                account.LastName = reader["LastName"].ToString(); ;
                account.UserTypeID = reader["UserTypeID"].ToString();
                account.Salary =Convert.ToDouble(reader["UserTypeID"]);
                account.JoinDate = Convert.ToDateTime(reader["UserTypeID"]);

                accountList.Add(account);
            }
            return accountList;
        }
        public Entity.Account GetByUsernamePassword(string username, string password)
        {
            string query = string.Format("SELECT UserTypeID FROM Account WHERE UserName='{0}' AND Password='{1}'", username, password);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Entity.Account account = null;
            if (reader.HasRows)
            {
                account = new Entity.Account();
                account.UserTypeID = reader["UserTypeID"].ToString();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
                Application.Exit();
            }
            return account;
        }

        public List<string> GetUserNameList()
        {
            string query = "SELECT * FROM Account";
            SqlDataReader reader = DataAccess.GetData(query);
            List<string> userName = new List<string>();
            while (reader.Read())
            {
                userName.Add(reader["UserName"].ToString());
            }
            return userName;
        }

        public int  checkValidUser(string dept, string email)
        {
            MessageBox.Show(email+" "+dept);
            string query = "SELECT UserName,Email FROM Account";
            SqlDataReader reader = DataAccess.GetData(query);
            string e = "";
            string d = "";
            while (reader.Read())
            {
                e= reader["Email"].ToString();
                d= reader["UserName"].ToString();
                if (e.Equals(email) && dept.Equals(d))
                {
                    return 1;
                }

            }
            return 0;
        }
        public string ValidUserPass(string userName)
        {
            string query = "SELECT UserName,Password FROM Account where UserName = '"+userName+"'";
            SqlDataReader reader = DataAccess.GetData(query);
            string p="";
            while (reader.Read())
            {
               p =  reader["Password"].ToString();
            }
            return p;
        }
    }
}
