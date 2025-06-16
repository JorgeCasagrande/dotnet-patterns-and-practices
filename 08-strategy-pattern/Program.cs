using System;

// Example of Strategy pattern in .NET with a domain scenario: payment processing

namespace StrategyPatternExample
{
    // Strategy interface
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    // Concrete strategies
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} with Credit Card.");
        }
    }

    public class PaypalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} with PayPal.");
        }
    }

    public class BankTransferPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} with Bank Transfer.");
        }
    }

    // Context class
    public class PaymentContext
    {
        private IPaymentStrategy _strategy;
        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ProcessPayment(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Use Credit Card payment
            var context = new PaymentContext(new CreditCardPayment());
            context.ProcessPayment(100);

            // Switch to PayPal payment
            context.SetStrategy(new PaypalPayment());
            context.ProcessPayment(200);

            // Switch to Bank Transfer payment
            context.SetStrategy(new BankTransferPayment());
            context.ProcessPayment(300);
        }
    }
}
