namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        }

        public static void Import(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new Exception("Path is required.");
            }
        }
    }
}
