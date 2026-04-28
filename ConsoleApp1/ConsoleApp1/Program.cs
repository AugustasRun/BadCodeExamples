using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
            UnsafeQuery("test", "test", "test");
        }

        public static object UnsafeQuery(string connection, string name, string password)
        {
            using SqlConnection someConnection = new SqlConnection(connection);
            using SqlCommand someCommand = someConnection.CreateCommand();

            someCommand.CommandText = "SELECT AccountNumber FROM Users WHERE Username = @username AND Password = @password";
            someCommand.Parameters.AddWithValue("@username", name);
            someCommand.Parameters.AddWithValue("@password", password);

            someConnection.Open();
            object accountNumber = someCommand.ExecuteScalar();
            return accountNumber;
        }
    }
}