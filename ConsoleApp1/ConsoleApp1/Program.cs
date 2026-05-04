using Microsoft.Win32;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        }

        public static string? ReadRegistry()
        {
            return Registry.GetValue(
                @"HKEY_LOCAL_MACHINE\Software\MyApp",
                "InstallPath",
                null)?.ToString();
        }
    }
}
