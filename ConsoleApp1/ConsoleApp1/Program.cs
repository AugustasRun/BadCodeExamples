namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
        }

        public static string Read(string path)
        {
            var reader = new StreamReader(path);
            return reader.ReadToEnd();
        }
    }
}
