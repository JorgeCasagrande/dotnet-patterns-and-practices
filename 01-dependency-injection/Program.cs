using System;
using Microsoft.Extensions.DependencyInjection;

// Example of Dependency Injection in .NET
// This program demonstrates two approaches:
// 1. Manual (constructor injection)
// 2. Using the .NET DI container

namespace DependencyInjectionExample
{
    // Service interface
    // Defines a contract for sending messages
    public interface IMessageService
    {
        void Send(string message);
    }

    // Concrete implementation of the service
    // This class simulates sending an email
    public class EmailMessageService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    // Class that depends on the service
    // Notifier uses IMessageService to send notifications
    public class Notifier
    {
        private readonly IMessageService _messageService;
        // Dependency is injected via the constructor
        public Notifier(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void Notify(string message)
        {
            _messageService.Send(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- Example 1: Manual injection ---
            // We create the dependency and pass it to Notifier
            var emailService = new EmailMessageService();
            var notifierManual = new Notifier(emailService);
            notifierManual.Notify("Hello from manual injection!");

            // --- Example 2: Using the .NET DI container ---
            // We register the services in the DI container
            var services = new ServiceCollection();
            services.AddTransient<IMessageService, EmailMessageService>();
            services.AddTransient<Notifier>();

            // The container resolves and injects dependencies automatically
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var notifierDI = serviceProvider.GetRequiredService<Notifier>();
                notifierDI.Notify("Hello from the .NET DI container!");
            }
        }
    }
}
