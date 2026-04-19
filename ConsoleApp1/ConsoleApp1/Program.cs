namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        }

        public static int GenerateCode()
        {
            var random = new Random();
            return random.Next(100000, 999999);
        }
    }
}
