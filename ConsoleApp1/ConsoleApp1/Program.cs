using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static Task Main(string[] args)
        {
            UnsafeQuery("test", "test", "test");
            return Task.CompletedTask;
        }

        public static object? UnsafeQuery(string connection, string name, string password)
        {
            using SqlConnection someConnection = new SqlConnection(connection);
            using SqlCommand someCommand = new SqlCommand(
                "SELECT AccountNumber FROM Users WHERE Username = @Username AND Password = @Password",
                someConnection);

            someCommand.Parameters.AddWithValue("@Username", name);
            someCommand.Parameters.AddWithValue("@Password", password);

            someConnection.Open();
            return someCommand.ExecuteScalar();
        }
    }
}