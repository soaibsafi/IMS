using System;

namespace InventoryManagementSystem.Entity
{
    public class Log
    {
        readonly string logId;
        DateTime loginTime;
        DateTime logoutTime;
        string action;
        string accountId;
        string itemCode;

        public Log()
        {
            
        }
        public Log(string logId)
        {
            this.logId = logId;
        }
        public Log(string logId, DateTime loginTime, DateTime logoutTime, string accountId)
        {
            this.logId = logId;
            this.loginTime = loginTime;
            this.logoutTime = logoutTime;
            this.accountId = accountId;
        }
        public Log(string logId, DateTime loginTime, DateTime logoutTime, string action, string accountId,string itemCode)
        {
            this.logId = logId;
            this.loginTime = loginTime;
            this.logoutTime = logoutTime;
            this.action = action;
            this.accountId = accountId;
            this.itemCode = itemCode;
        }

        public string LogId { get { return this.logId; } }
        public DateTime LoginTime { set { this.loginTime = value; } get { return this.loginTime; } }
        public DateTime LogoutTime { set { this.logoutTime = value; } get { return this.logoutTime; } }
        public string Action { set { this.action = value; } get { return this.action; } }
        public string AccountId { set { this.accountId = value; } get { return this.accountId; } }
        public string ItemCode { set { this.itemCode = value; } get { return this.itemCode; } }

    }
}
