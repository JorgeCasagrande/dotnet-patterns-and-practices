// Basic SOLID Principles Examples
// Each principle is demonstrated with a simple, clear scenario and detailed comments

using System;
using System.Collections.Generic;

public static class SolidBasicExamples
{
    public static void RunAll()
    {
        Console.WriteLine("--- BASIC SOLID EXAMPLES ---");
        RunSRP();
        RunOCP();
        RunLSP();
        RunISP();
        RunDIP();
    }

    // SRP: Single Responsibility Principle
    // This example shows a class (Invoice) that only holds data, and another class (InvoicePrinter) that only prints invoices.
    // Each class has a single responsibility, making the code easier to maintain and extend.
    public static void RunSRP()
    {
        Console.WriteLine("\n[SRP] Single Responsibility Principle:");
        var invoice = new Invoice { Amount = 100 };
        var printer = new InvoicePrinter();
        printer.Print(invoice); // Only prints, does not handle invoice data logic
    }

    // OCP: Open/Closed Principle
    // The Shape base class is open for extension (new shapes can be added), but closed for modification (existing code is not changed).
    // Adding a new shape only requires creating a new subclass.
    public static void RunOCP()
    {
        Console.WriteLine("\n[OCP] Open/Closed Principle:");
        var shapes = new List<Shape>
        {
            new Rectangle { Width = 2, Height = 3 },
            new Circle { Radius = 1 }
        };
        foreach (var shape in shapes)
            Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}"); // Shows the class name and area
    }

    // LSP: Liskov Substitution Principle
    // Any subclass of Bird (e.g., Sparrow) can be used wherever a Bird is expected, and will behave correctly.
    // This ensures that derived classes do not break the behavior expected from the base class.
    public static void RunLSP()
    {
        Console.WriteLine("\n[LSP] Liskov Substitution Principle:");
        Bird bird = new Sparrow(); // Substitution: Sparrow is a Bird
        bird.Fly(); // Works as expected
    }

    // ISP: Interface Segregation Principle
    // Interfaces are split so that classes only implement what they actually need.
    // Human implements both IWorker and IEater, but could implement only one if needed.
    public static void RunISP()
    {
        Console.WriteLine("\n[ISP] Interface Segregation Principle:");
        IWorker worker = new Human();
        worker.Work(); // Only work-related methods are exposed
        IEater eater = new Human();
        eater.Eat(); // Only eat-related methods are exposed
    }

    // DIP: Dependency Inversion Principle
    // High-level module (NotificationService) depends on an abstraction (IMessageSender), not a concrete implementation.
    // This allows for easy substitution of different message senders (e.g., EmailSender, SmsSender) and makes testing easier.
    public static void RunDIP()
    {
        Console.WriteLine("\n[DIP] Dependency Inversion Principle:");
        var notification = new NotificationService(new EmailSender()); // Injects dependency via constructor
        notification.Notify("SOLID principles in action!");
    }
}

// --- Basic SRP ---
// Holds invoice data only
public class Invoice
{
    public decimal Amount { get; set; }
}

// Only responsible for printing invoices
public class InvoicePrinter
{
    public void Print(Invoice invoice)
    {
        Console.WriteLine($"Invoice amount: {invoice.Amount}");
    }
}

// --- Basic OCP ---
// Abstract base class for shapes
public abstract class Shape
{
    public abstract decimal Area();
}

// Rectangle shape implementation
public class Rectangle : Shape
{
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public override decimal Area() => Width * Height;
}

// Circle shape implementation
public class Circle : Shape
{
    public decimal Radius { get; set; }
    public override decimal Area() => (decimal)Math.PI * Radius * Radius;
}

// --- Basic LSP ---
// Base class for birds
public class Bird
{
    public virtual void Fly() => Console.WriteLine("Bird is flying");
}

// Sparrow is a type of Bird
public class Sparrow : Bird { }

// --- Basic ISP ---
// Interface for working
public interface IWorker
{
    void Work();
}

// Interface for eating
public interface IEater
{
    void Eat();
}

// Human implements both interfaces
public class Human : IWorker, IEater
{
    public void Work() => Console.WriteLine("Human is working");
    public void Eat() => Console.WriteLine("Human is eating");
}

// --- Basic DIP ---
// Abstraction for sending messages
public interface IMessageSender
{
    void Send(string message);
}

// Concrete implementation for email
public class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"Email sent: {message}");
}

// Service depends on abstraction, not concrete sender
public class NotificationService
{
    private readonly IMessageSender _sender;
    public NotificationService(IMessageSender sender) => _sender = sender;
    public void Notify(string message) => _sender.Send(message);
}
