namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
            var temp = new C();
        }
    }

    internal sealed class C
    {
        public static void M(IReadOnlyList<string> list)
        {
            Console.Write(list.First());
            Console.Write(list.Last());
            Console.Write(list.Count());
        }
    }
}
