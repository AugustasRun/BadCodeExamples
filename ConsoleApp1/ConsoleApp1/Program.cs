using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var temp = new ExampleClass();
        }
    }

    internal class ExampleClass
    {
        public JsonSerializerSettings Settings { get; }

        public ExampleClass()
        {
            Settings = new JsonSerializerSettings();
            Settings.TypeNameHandling = TypeNameHandling.All;
        }
    }
}
