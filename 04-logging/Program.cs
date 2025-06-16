using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

// Example of logging in .NET using both console and file providers.
// This example uses Serilog for file and console logging.

namespace LoggingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Serilog for file and console logging
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("app.log", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Set up dependency injection and logging
            var services = new ServiceCollection();
            services.AddLogging(builder =>
            {
                builder.ClearProviders();
                builder.AddSerilog(); // Use Serilog for logging
            });

            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

            // Log messages of different levels
            logger.LogInformation("This is an information message.");
            logger.LogWarning("This is a warning message.");
            logger.LogError("This is an error message.");

            Console.WriteLine("Check the console and 'app.log' file for log output.");
        }
    }
}
