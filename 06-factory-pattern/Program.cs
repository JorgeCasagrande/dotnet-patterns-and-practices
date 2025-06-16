using System;

// Example of Factory and Factory Method patterns in .NET
// Shows both a simple factory and a factory method with polymorphism

namespace FactoryPatternExample
{
    // Product interface
    public interface IProduct
    {
        string GetName();
    }

    // Concrete products
    public class Book : IProduct
    {
        public string GetName() => "Book";
    }

    public class Laptop : IProduct
    {
        public string GetName() => "Laptop";
    }

    // Simple Factory
    public static class SimpleProductFactory
    {
        public static IProduct CreateProduct(string type)
        {
            return type switch
            {
                "book" => new Book(),
                "laptop" => new Laptop(),
                _ => throw new ArgumentException("Unknown product type")
            };
        }
    }

    // Factory Method pattern
    public abstract class ProductFactory
    {
        public abstract IProduct CreateProduct();
    }

    public class BookFactory : ProductFactory
    {
        public override IProduct CreateProduct() => new Book();
    }

    public class LaptopFactory : ProductFactory
    {
        public override IProduct CreateProduct() => new Laptop();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Simple Factory usage
            IProduct product1 = SimpleProductFactory.CreateProduct("book");
            IProduct product2 = SimpleProductFactory.CreateProduct("laptop");
            Console.WriteLine($"Simple Factory: {product1.GetName()} | {product2.GetName()}");

            // Factory Method usage
            ProductFactory bookFactory = new BookFactory();
            ProductFactory laptopFactory = new LaptopFactory();
            IProduct product3 = bookFactory.CreateProduct();
            IProduct product4 = laptopFactory.CreateProduct();
            Console.WriteLine($"Factory Method: {product3.GetName()} | {product4.GetName()}");
        }
    }
}
