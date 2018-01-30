using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    public class UserType
    {
        readonly string userTypeId;
        string userTypeName;

        public UserType()
        {
            
        }
        public UserType(string userTypeId)
        {
            this.userTypeId = userTypeId;
        }
        //Constructor with all attribute
        public UserType(string userTypeId, string userTypeName)
        {
            this.userTypeId = userTypeId;
            this.userTypeName = userTypeName;
        }

        //Public Properties
        public string UserTypeId { get { return this.userTypeId; } }
        public string UserTypeName { set { this.userTypeName = value; } get { return this.userTypeName; } }
    }
}
