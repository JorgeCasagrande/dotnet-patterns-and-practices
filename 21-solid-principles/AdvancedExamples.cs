// Advanced SOLID Principles Examples
// Each principle is demonstrated with a more realistic, advanced scenario and detailed comments

using System;
using System.Collections.Generic;

public static class SolidAdvancedExamples
{
    public static void RunAll()
    {
        Console.WriteLine("\n--- ADVANCED SOLID EXAMPLES ---");
        RunSRP();
        RunOCP();
        RunLSP();
        RunISP();
        RunDIP();
    }

    // SRP: Single Responsibility Principle
    // This example separates the responsibilities of data persistence (OrderRepository)
    // and business logic (OrderService). Each class has a single, well-defined responsibility.
    private static void RunSRP()
    {
        Console.WriteLine("\n[SRP] Domain Service and Repository Example:");
        var repo = new OrderRepository();
        var service = new OrderService(repo);
        service.PlaceOrder("Product A", 2);
    }

    // OCP: Open/Closed Principle
    // The payment processor uses the strategy pattern to allow new payment methods
    // to be added without modifying existing code. Each payment method implements IPaymentStrategy.
    private static void RunOCP()
    {
        Console.WriteLine("\n[OCP] Strategy Pattern for Payments:");
        IPaymentStrategy credit = new CreditCardPayment();
        IPaymentStrategy paypal = new PaypalPayment();
        var processor = new PaymentProcessor(credit);
        processor.Pay(100); // Uses credit card
        processor.Strategy = paypal;
        processor.Pay(50);  // Uses PayPal
    }

    // LSP: Liskov Substitution Principle
    // Both Car and Truck are subclasses of Vehicle and can be used interchangeably
    // wherever a Vehicle is expected, without breaking the program's correctness.
    private static void RunLSP()
    {
        Console.WriteLine("\n[LSP] Proper Inheritance Example:");
        List<Vehicle> vehicles = new() { new Car(), new Truck() };
        foreach (var v in vehicles)
            v.Drive();
    }

    // ISP: Interface Segregation Principle
    // The API client implements two small interfaces (IReadable, IWritable),
    // so consumers only depend on the operations they actually use.
    private static void RunISP()
    {
        Console.WriteLine("\n[ISP] Segregated API Client:");
        IReadable reader = new ApiClient();
        IWritable writer = new ApiClient();
        reader.Read();
        writer.Write();
    }

    // DIP: Dependency Inversion Principle
    // The notification service depends on the abstraction IMessageSender, not a concrete implementation.
    // This allows for easy substitution (e.g., using SmsSender for testing or production).
    private static void RunDIP()
    {
        Console.WriteLine("\n[DIP] Service with Dependency Injection:");
        IMessageSender sender = new SmsSender();
        var service = new NotificationServiceAdvanced(sender);
        service.Notify("Advanced DIP in action!");
    }

    // --- Advanced SRP ---
    // Handles data persistence for orders
    public class OrderRepository
    {
        public void Save(string product, int qty)
        {
            Console.WriteLine($"Order saved: {product} x{qty}");
        }
    }
    // Handles business logic for placing orders
    public class OrderService
    {
        private readonly OrderRepository _repo;
        public OrderService(OrderRepository repo) => _repo = repo;
        public void PlaceOrder(string product, int qty)
        {
            _repo.Save(product, qty);
            Console.WriteLine("Order placed!");
        }
    }

    // --- Advanced OCP ---
    // Payment strategy abstraction
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
    // Concrete payment by credit card
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} with credit card");
    }
    // Concrete payment by PayPal
    public class PaypalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} with PayPal");
    }
    // Payment processor uses a strategy
    public class PaymentProcessor
    {
        public IPaymentStrategy Strategy { get; set; }
        public PaymentProcessor(IPaymentStrategy strategy) => Strategy = strategy;
        public void Pay(decimal amount) => Strategy.Pay(amount);
    }

    // --- Advanced LSP ---
    // Abstract vehicle
    public abstract class Vehicle
    {
        public abstract void Drive();
    }
    // Car implements Drive
    public class Car : Vehicle
    {
        public override void Drive() => Console.WriteLine("Car is driving");
    }
    // Truck implements Drive
    public class Truck : Vehicle
    {
        public override void Drive() => Console.WriteLine("Truck is driving");
    }

    // --- Advanced ISP ---
    // Interface for reading
    public interface IReadable { void Read(); }
    // Interface for writing
    public interface IWritable { void Write(); }
    // API client implements both
    public class ApiClient : IReadable, IWritable
    {
        public void Read() => Console.WriteLine("Reading from API");
        public void Write() => Console.WriteLine("Writing to API");
    }

    // --- Advanced DIP ---
    // Notification service depends on abstraction
    public class NotificationServiceAdvanced
    {
        private readonly IMessageSender _sender;
        public NotificationServiceAdvanced(IMessageSender sender) => _sender = sender;
        public void Notify(string message) => _sender.Send(message);
    }
    // SMS sender implementation
    public class SmsSender : IMessageSender
    {
        public void Send(string message) => Console.WriteLine($"SMS sent: {message}");
    }
}
