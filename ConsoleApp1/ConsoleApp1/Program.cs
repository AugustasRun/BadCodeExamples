using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal sealed class Program
    {
        static async Task Main(string[] args)
        {
            var temp = new ExampleClass();
        }
    }

    internal sealed class ExampleClass
    {
        public JsonSerializerSettings Settings { get; }

        public ExampleClass()
        {
            Settings = new JsonSerializerSettings();
            Settings.TypeNameHandling = TypeNameHandling.All;
        }
    }
}
