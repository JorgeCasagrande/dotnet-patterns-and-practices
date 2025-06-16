// CQRS Example: Simple Order System
// Example in English with clear comments

using System;
using System.Collections.Generic;

// Command: Represents an action that changes state
public interface ICommand { }

// Query: Represents a request for data (no side effects)
public interface IQuery<TResult> { }

// Order entity
public class Order
{
    public Guid Id { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
}

// In-memory order store
public class OrderStore
{
    private readonly List<Order> _orders = new();
    public void Add(Order order) => _orders.Add(order);
    public IEnumerable<Order> GetAll() => _orders;
}

// Command: CreateOrder
public class CreateOrderCommand : ICommand
{
    public string Product { get; set; }
    public int Quantity { get; set; }
}

// Query: GetOrders
public class GetOrdersQuery : IQuery<IEnumerable<Order>> { }

// Command Handler
public class CreateOrderHandler
{
    private readonly OrderStore _store;
    public CreateOrderHandler(OrderStore store) => _store = store;
    public void Handle(CreateOrderCommand command)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),
            Product = command.Product,
            Quantity = command.Quantity
        };
        _store.Add(order);
        Console.WriteLine($"Order created: {order.Product} x{order.Quantity}");
    }
}

// Query Handler
public class GetOrdersHandler
{
    private readonly OrderStore _store;
    public GetOrdersHandler(OrderStore store) => _store = store;
    public IEnumerable<Order> Handle(GetOrdersQuery query) => _store.GetAll();
}

// Main program
class Program
{
    static void Main()
    {
        // Initialize store and handlers
        var store = new OrderStore();
        var commandHandler = new CreateOrderHandler(store);
        var queryHandler = new GetOrdersHandler(store);

        // Create some orders (commands)
        commandHandler.Handle(new CreateOrderCommand { Product = "Laptop", Quantity = 2 });
        commandHandler.Handle(new CreateOrderCommand { Product = "Mouse", Quantity = 5 });

        // Query all orders
        var orders = queryHandler.Handle(new GetOrdersQuery());
        Console.WriteLine("\nAll Orders:");
        foreach (var order in orders)
        {
            Console.WriteLine($"- {order.Product} x{order.Quantity} (Id: {order.Id})");
        }
    }
}