using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
        }
    }

    class C
    {
        public static void M(IReadOnlyList<string> list)
        {
            Console.Write(list.First());
            Console.Write(list.Last());
            Console.Write(list.Count());
        }
    }
}
