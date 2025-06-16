using System;
using System.Collections.Generic;
using System.Linq;

// Example of the Unit of Work Pattern in .NET
// This example coordinates multiple repositories and simulates a transaction in memory.

namespace UnitOfWorkPatternExample
{
    // Entity: Product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Entity: Customer
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Repository interface for Product
    public interface IProductRepository
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
    }

    // Repository interface for Customer
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        IEnumerable<Customer> GetAll();
    }

    // In-memory implementation of Product repository
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;
        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }
        public IEnumerable<Product> GetAll() => _products;
    }

    // In-memory implementation of Customer repository
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();
        private int _nextId = 1;
        public void Add(Customer customer)
        {
            customer.Id = _nextId++;
            _customers.Add(customer);
        }
        public IEnumerable<Customer> GetAll() => _customers;
    }

    // Unit of Work interface
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICustomerRepository Customers { get; }
        void Commit();
        void Rollback();
    }

    // In-memory implementation of Unit of Work
    public class InMemoryUnitOfWork : IUnitOfWork
    {
        public IProductRepository Products { get; }
        public ICustomerRepository Customers { get; }
        private bool _committed = false;

        public InMemoryUnitOfWork()
        {
            Products = new InMemoryProductRepository();
            Customers = new InMemoryCustomerRepository();
        }

        // Simulate commit (in a real scenario, this would persist changes)
        public void Commit()
        {
            _committed = true;
            Console.WriteLine("Transaction committed.");
        }

        // Simulate rollback (in a real scenario, this would discard changes)
        public void Rollback()
        {
            _committed = false;
            Console.WriteLine("Transaction rolled back.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Unit of Work
            IUnitOfWork unitOfWork = new InMemoryUnitOfWork();

            // Add entities
            unitOfWork.Products.Add(new Product { Name = "Keyboard" });
            unitOfWork.Customers.Add(new Customer { Name = "Alice" });

            // Commit transaction
            unitOfWork.Commit();

            // List all products and customers
            Console.WriteLine("\nProducts:");
            foreach (var product in unitOfWork.Products.GetAll())
            {
                Console.WriteLine($"{product.Id}: {product.Name}");
            }

            Console.WriteLine("\nCustomers:");
            foreach (var customer in unitOfWork.Customers.GetAll())
            {
                Console.WriteLine($"{customer.Id}: {customer.Name}");
            }
        }
    }
}
