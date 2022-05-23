using System;
using System.Data.SqlClient;
namespace Console_review
{
    public class DBConnection
    {

        public static void Connect()
        {
            string connectionString = "Server=94.73.145.4;Database=u9751868_db9EC;User Id=u9751868_user9EC;Password=PWtw68S5BRcg01S;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            var command = new SqlCommand("select * from Products", connection);
            var result = command.ExecuteReader();
            connection.Close();
        }
    }
}