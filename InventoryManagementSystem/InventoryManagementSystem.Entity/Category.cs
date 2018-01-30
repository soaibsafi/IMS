using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    public class Category
    {
        readonly string categoryId;
        string categoryName;

        public Category()
        {
            
        }
        public Category(string categoryId)
        {
            this.categoryId = categoryId;
        }
        public Category(string categoryId, string categoryName)
        {
            this.categoryId = categoryId;
            this.categoryId = categoryName;
        }

        public string CategoryID{ get { return this.categoryId; } }
        public string CategoryName { set { this.categoryName = value; } get { return this.categoryName; } }
    }
}
