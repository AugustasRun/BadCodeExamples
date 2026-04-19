using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        }

        public static byte[] Hash(string input)
        {
            return MD5.HashData(Encoding.UTF8.GetBytes(input));
        }
    }
}
