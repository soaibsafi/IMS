using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    public class Item
    {
        readonly string itemCode;
        string itemName;
        string description;
        string categoryId;
        double price;
        int stock;

        public Item()
        {
            
        }
        public Item(string itemCode)
        {
            this.itemCode = itemCode;
        }
        public Item(string itemCode, string itemName, string categoryId, float price, int stock)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.categoryId = categoryId;
            this.price = price;
            this.stock = stock;

        }
        public Item(string itemCode, string itemName, string description, string categoryId, float price, int stock)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.description = description;
            this.categoryId = categoryId;
            this.price = price;
            this.stock = stock;
        }

        public string ItemCode { get {return this.itemCode; } }
        public string ItemName { set { this.itemName = value; } get { return this.itemName; } }
        public string Description { set { this.description = value; } get { return this.description; } }
        public string CategoryID { set { this.categoryId = value; } get { return this.categoryId; } }
        public double Price { set { this.price = value; } get { return this.price; } }
        public int Stock { set { this.stock = value; } get { return this.stock; } }
    }
}
