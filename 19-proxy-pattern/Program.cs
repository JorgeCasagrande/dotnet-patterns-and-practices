// Proxy Pattern Example: Adding Logging to a Real Service
// Example in English with clear comments and explanations

using System;

// Service interface
public interface IService
{
    void Execute(string command);
}

// Real service implementation
public class RealService : IService
{
    public void Execute(string command)
    {
        Console.WriteLine($"[RealService] Executing: {command}");
    }
}

// Proxy: adds logging before and after calling the real service
public class LoggingProxy : IService
{
    private readonly IService _realService;
    public LoggingProxy(IService realService)
    {
        _realService = realService;
    }
    public void Execute(string command)
    {
        Console.WriteLine($"[Proxy] Logging before execution: {command}");
        _realService.Execute(command);
        Console.WriteLine("[Proxy] Logging after execution");
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Use the proxy instead of the real service directly
        IService service = new LoggingProxy(new RealService());
        service.Execute("Run report");
    }
}
