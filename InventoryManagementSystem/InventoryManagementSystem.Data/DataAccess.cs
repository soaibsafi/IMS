using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem.Data
{
    public static class DataAccess
    {
        static SqlConnection conn;

        static public SqlConnection Connection
        {
            get
            {
                conn = new SqlConnection(InventoryManagementSystem.Data.Properties.Settings.Default.imsDBConnectionString);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }
        
    }
}
