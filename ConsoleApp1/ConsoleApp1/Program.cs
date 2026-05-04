using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
        }

        public static Aes Create()
        {
            var aes = Aes.Create();
            aes.Mode = CipherMode.ECB;
            return aes;
        }
    }
}
