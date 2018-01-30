using System;

namespace InventoryManagementSystem.Entity
{
    public class Account
    {
        readonly string accountId;
        string username;
        string password;
        string firstName;
        string lastName;
        string userTypeId;
        double salary;
        DateTime joinDate;

        public Account()
        {
            
        }
        public Account(string accountId)
        {
            this.accountId = accountId;
        }

        //Constructor with all attribute
        public Account(string accountId, string username, string password, string firstName, string lastName, string userTypeId, float salary, DateTime joinDate)
        {
            this.accountId = accountId;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userTypeId = userTypeId;
            this.salary = salary;
            this.joinDate = joinDate;
        }
        //Constructor without nullable attribute
        public Account(string accountId, string username, string password, string firstName, string userTypeId, float salary, DateTime joinDate)
        {
            this.accountId = accountId;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.userTypeId = userTypeId;
            this.salary = salary;
            this.joinDate = joinDate;
        }

        //Properties
        public string AccountID { get { return this.accountId; } }
        public string Username { set { this.username = value; } get { return this.username; } }
        public string Password { set { this.password = value; } get { return this.password; } }
        public string FirstName { set { this.firstName = value; } get { return this.firstName; } }
        public string LastName { set { this.lastName = value; } get { return this.lastName; } }
        public string UserTypeID { set { this.userTypeId = value; } get { return this.userTypeId; } }
        public double Salary { set { this.salary = value; } get { return this.salary; } }
        public DateTime JoinDate { set { this.joinDate = value; } get { return this.joinDate; } }

    }
}
