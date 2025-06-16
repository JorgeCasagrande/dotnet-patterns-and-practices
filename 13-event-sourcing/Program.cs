// Event Sourcing Example: Simple Bank Account
// Example in English with clear comments

using System;
using System.Collections.Generic;

// Event base type
public abstract class BankAccountEvent
{
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}

// Deposit event
public class Deposited : BankAccountEvent
{
    public decimal Amount { get; set; }
}

// Withdrawal event
public class Withdrawn : BankAccountEvent
{
    public decimal Amount { get; set; }
}

// Bank account aggregate
public class BankAccount
{
    private readonly List<BankAccountEvent> _events = new();
    public IEnumerable<BankAccountEvent> Events => _events;

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Amount must be positive.");
        _events.Add(new Deposited { Amount = amount });
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Amount must be positive.");
        if (GetBalance() < amount) throw new InvalidOperationException("Insufficient funds.");
        _events.Add(new Withdrawn { Amount = amount });
    }

    // Rebuilds the current balance by replaying all events
    public decimal GetBalance()
    {
        decimal balance = 0;
        foreach (var e in _events)
        {
            switch (e)
            {
                case Deposited d:
                    balance += d.Amount;
                    break;
                case Withdrawn w:
                    balance -= w.Amount;
                    break;
            }
        }
        return balance;
    }
}

// Main program
class Program
{
    static void Main()
    {
        var account = new BankAccount();
        account.Deposit(100);
        account.Deposit(50);
        account.Withdraw(30);

        Console.WriteLine($"Current balance: {account.GetBalance()}");
        Console.WriteLine("Event history:");
        foreach (var e in account.Events)
        {
            switch (e)
            {
                case Deposited d:
                    Console.WriteLine($"Deposited: {d.Amount} at {d.Timestamp}");
                    break;
                case Withdrawn w:
                    Console.WriteLine($"Withdrawn: {w.Amount} at {w.Timestamp}");
                    break;
            }
        }
    }
}