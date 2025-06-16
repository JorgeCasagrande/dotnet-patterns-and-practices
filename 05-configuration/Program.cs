using System;
using Microsoft.Extensions.Configuration;

// Example of configuration management in .NET
// Reads settings from appsettings.json and environment variables

namespace ConfigurationExample
{
    // Strongly-typed settings class
    public class AppSettings
    {
        public string? ApplicationName { get; set; }
        public int MaxItems { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Build configuration from appsettings.json and environment variables
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            // Bind configuration to AppSettings object
            var appSettings = config.GetSection("AppSettings").Get<AppSettings>();

            // Read a value from environment variable (if set)
            string? envValue = config["MY_ENV_VAR"];

            Console.WriteLine($"ApplicationName: {appSettings?.ApplicationName}");
            Console.WriteLine($"MaxItems: {appSettings?.MaxItems}");
            Console.WriteLine($"MY_ENV_VAR: {envValue}");

            Console.WriteLine("Try setting MY_ENV_VAR in your environment and re-run the app.");
        }
    }
}
