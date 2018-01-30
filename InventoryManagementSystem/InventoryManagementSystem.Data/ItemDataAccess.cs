using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem.Data
{
    public class ItemDataAccess
    {
        public int Add(Entity.Item item)
        {
            try
            {
                string query = string.Format("INSERT INTO Item(ItemCode, ItemName, Description, CategoryID, Price, Stock) VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5})", item.ItemCode, item.ItemName, item.Description, item.CategoryID, item.Price, item.Stock);
                return DataAccess.ExecuteQuery(query);
            }catch
            {
                System.Windows.Forms.MessageBox.Show("This itemcode is already assigned!");
            }
            return 0;
        }

        public int Remove(string id)
        {
            string query = string.Format("DELETE FROM Item WHERE ItemCode='{0}'",id);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Entity.Item item)
        {
            try
            {
                string query = string.Format("UPDATE Item SET ItemName='" + item.ItemName + "', Description='" + item.Description + "', CategoryID='" + item.CategoryID + "', Price='" + item.Price + "', Stock='" + item.Stock + "' WHERE ItemCode='{0}'", item.ItemCode);
                return DataAccess.ExecuteQuery(query);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("This itemcode is already assigned!");
            }
            return 0;
        }
        public List<Entity.Item> GetAll()
        {
            string query = "SELECT ItemCode, ItemName, Description, CategoryID, Price, Stock FROM Item";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Item item = null;
            List<Entity.Item> itemList = new List<Entity.Item>();
            while (reader.Read())
            {
                item = new Entity.Item(reader["ItemCode"].ToString());
                item.ItemName = reader["ItemName"].ToString();
                item.Description = reader["Description"].ToString();
                item.CategoryID = reader["CategoryID"].ToString();
                item.Price = Convert.ToDouble(reader["Price"]);
                item.Stock = Convert.ToInt32(reader["Stock"]);

                itemList.Add(item);
            }
            return itemList;
        }
        public Entity.Item GetById(string id)
        {
            string query = "SELECT ItemCode, ItemName, Description, CategoryID, Price, Stock FROM Item";
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Entity.Item item = null;
            if (reader.HasRows)
            {
                item = new Entity.Item(reader["ItemCode"].ToString());
                item.ItemName = reader["ItemName"].ToString();
                item.Description = reader["Description"].ToString();
                item.CategoryID = reader["CategoryID"].ToString();
                item.Price = Convert.ToDouble(reader["Price"]);
                item.Stock = Convert.ToInt32(reader["Stock"]);
            }
            return item;
        }
        public DataTable GetAllSortedItem()
        {
            /*string query = "SELECT ItemCode, ItemName, Description, CategoryID, Price, Stock FROM Item";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Item item = null;
            List<Entity.Item> itemList = new List<Entity.Item>();
            while (reader.Read())
            {
                item = new Entity.Item(reader["ItemCode"].ToString());
                item.ItemName = reader["ItemName"].ToString();
                item.Description = reader["Description"].ToString();
                item.CategoryID = reader["CategoryID"].ToString();
                item.Price = Convert.ToDouble(reader["Price"]);
                item.Stock = Convert.ToInt32(reader["Stock"]);

                itemList.Add(item);
            }
            return itemList;*/


            SqlDataAdapter report = new SqlDataAdapter("SELECT ItemCode, ItemName, Description, CategoryID, Price, Stock FROM Item", DataAccess.Connection);

            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        
        public List<string> GetName()
        {
            string query = "SELECT * FROM Item";
            SqlDataReader reader = DataAccess.GetData(query);
            List<string> itemName = new List<string>();
            while (reader.Read())
            {
                itemName.Add(reader["ItemName"].ToString());
            }
            return itemName;
        }

        public DataTable GetByName(string name, double quantity)
        {
            SqlDataAdapter report = new SqlDataAdapter("SELECT ItemCode, ItemName, Description, CategoryID, Price, Stock FROM Item where ItemName = '" + name + "'", DataAccess.Connection);

            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }

        public double GetPrice(String itemcode)
        {
            double price = 0;
            string query = string.Format("SELECT Price FROM Item Where ItemCode='{0}'", itemcode);
            SqlDataReader reader = DataAccess.GetData(query);
            while (reader.Read())
            {
                price = Convert.ToDouble(reader["Price"]);
            }

            return price;
        }

        public int UpdateStock(string itemcode, int quantity)
        {
            string query = string.Format("update item set Stock=(select stock from item where ItemCode='{0}') - {1} where ItemCode = '{0}'", itemcode, quantity);
            return DataAccess.ExecuteQuery(query);
        }
        public bool checkStockQuantity(string itemName, int quantity)                          // method added
        {
            string query = "SELECT itemName,Stock FROM Item where ItemName='" + itemName + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            int stock = 0;
            while (reader.Read())
            {
                stock = Convert.ToInt32(reader["Stock"]);
            }
            if (stock < quantity)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
