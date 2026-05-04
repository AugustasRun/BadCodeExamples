using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
            UnsafeQuery("test", "test", "test");
        }

        public static void UnsafeQuery(string connection, string name, string password)
        {
            using var hashAlg = SHA1.Create();
        }
    }
}
