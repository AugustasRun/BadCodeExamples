namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
            var temp = new ExceptionExample();
        }

        internal sealed class ExceptionExample
        {
            public static void Run()
            {
                try
                {
                    DoWork();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private static void DoWork() => throw new InvalidOperationException();
        }
    }
}
