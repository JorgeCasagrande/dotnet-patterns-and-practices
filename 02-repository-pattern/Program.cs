using System;
using System.Collections.Generic;
using System.Linq;

// Example of the Repository Pattern in .NET
// This example uses an in-memory list to simulate a database.

namespace RepositoryPatternExample
{
    // Entity: Product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    // Repository interface for Product
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetById(int id);
        IEnumerable<Product> GetAll();
        void Update(Product product);
        void Delete(int id);
    }

    // In-memory implementation of the repository
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            var existing = GetById(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create repository
            IProductRepository repository = new InMemoryProductRepository();

            // Add products
            repository.Add(new Product { Name = "Laptop", Price = 1200 });
            repository.Add(new Product { Name = "Mouse", Price = 25 });

            // List all products
            Console.WriteLine("All products:");
            foreach (var product in repository.GetAll())
            {
                Console.WriteLine($"{product.Id}: {product.Name} - ${product.Price}");
            }

            // Update a product
            var productToUpdate = repository.GetById(1);
            if (productToUpdate != null)
            {
                productToUpdate.Price = 1100;
                repository.Update(productToUpdate);
            }

            // Delete a product
            repository.Delete(2);

            // List all products after update and delete
            Console.WriteLine("\nProducts after update and delete:");
            foreach (var product in repository.GetAll())
            {
                Console.WriteLine($"{product.Id}: {product.Name} - ${product.Price}");
            }
        }
    }
}
