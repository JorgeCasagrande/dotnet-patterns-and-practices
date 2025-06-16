// Service Locator Example: Registering and Resolving Services
// Example in English with clear comments and explanations

using System;
using System.Collections.Generic;

// Service locator implementation
public class ServiceLocator
{
    private readonly Dictionary<Type, object> _services = new();

    // Register a service instance by type
    public void Register<TService>(TService instance)
    {
        _services[typeof(TService)] = instance;
    }

    // Resolve a service by type
    public TService Resolve<TService>()
    {
        if (_services.TryGetValue(typeof(TService), out var service))
            return (TService)service;
        throw new InvalidOperationException($"Service of type {typeof(TService)} not registered.");
    }
}

// Example service interface and implementation
public interface IMessageSender
{
    void Send(string message);
}

public class EmailSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"[EmailSender] Sending email: {message}");
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Create the service locator
        var locator = new ServiceLocator();

        // Register an EmailSender as IMessageSender
        locator.Register<IMessageSender>(new EmailSender());

        // Resolve and use the service
        var sender = locator.Resolve<IMessageSender>();
        sender.Send("Hello from Service Locator!");

        // Try to resolve a service that is not registered
        try
        {
            var notRegistered = locator.Resolve<Program>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] {ex.Message}");
        }
    }
}
