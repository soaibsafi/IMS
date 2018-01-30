using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class CategoryDataAccess
    {
        public int Add(Entity.Category category)
        {
            string query = string.Format("INSERT INTO Category(CategoryID, CategoryName) VALUES('{0}', '{1}')", category.CategoryID, category.CategoryName);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string id)
        {
            string query = string.Format("DELETE FROM Category WHERE CategoryID='{0}'", id);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Entity.Category category)
        {
            string query = "UPDATE Category SET CategoryName='" + category.CategoryName + "' WHERE CategoryID=" + category.CategoryID;
            return DataAccess.ExecuteQuery(query);
        }
        public List<Entity.Category> GetAll()
        {
            string query = "SELECT CategoryID, CategoryName FROM Category";
            SqlDataReader reader = DataAccess.GetData(query);

            Entity.Category category = null;
            List<Entity.Category> categoryList = new List<Entity.Category>();
            while (reader.Read())
            {
                category = new Entity.Category(reader["CategoryID"].ToString());
                category.CategoryName = reader["CategoryName"].ToString();

                categoryList.Add(category);
            }
            return categoryList;
        }
    }
}
