using System.Configuration;
using System.Data.SqlClient;

namespace StajEmployeeManProje
{
    public static class DatabaseHelper
    {
        private static string _connectionString;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["EmployeeDB"]?.ConnectionString
                        ?? @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bahab\OneDrive\Belgeler\employee.mdf;Integrated Security=True;Connect Timeout=30";
                }
                return _connectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
