using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            UnsafeQuery("test", "test", "test");
        }

        public static void UnsafeQuery(string connection, string name, string password)
        {
            var hashAlg = SHA1.Create();
        }
    }
}
