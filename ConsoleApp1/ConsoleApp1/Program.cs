namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        }

        internal class ExceptionExample
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
