// Validation Example: Manual and Pattern-based Validation
// Example in English with clear comments

using System;
using System.Text.RegularExpressions;

// User data model
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}

// Validator interface
public interface IValidator<T>
{
    bool Validate(T obj, out string error);
}

// User validator implementing business rules
public class UserValidator : IValidator<User>
{
    public bool Validate(User user, out string error)
    {
        if (string.IsNullOrWhiteSpace(user.Name))
        {
            error = "Name is required.";
            return false;
        }
        if (!Regex.IsMatch(user.Email ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            error = "Email is invalid.";
            return false;
        }
        if (user.Age < 18 || user.Age > 120)
        {
            error = "Age must be between 18 and 120.";
            return false;
        }
        error = string.Empty;
        return true;
    }
}

// Main program
class Program
{
    static void Main()
    {
        var user = new User { Name = "", Email = "test@domain", Age = 15 };
        var validator = new UserValidator();

        if (validator.Validate(user, out var error))
        {
            Console.WriteLine("User is valid!");
        }
        else
        {
            Console.WriteLine($"Validation failed: {error}");
        }

        // Example with valid data
        var validUser = new User { Name = "Alice", Email = "alice@example.com", Age = 30 };
        if (validator.Validate(validUser, out error))
        {
            Console.WriteLine("Valid user: " + validUser.Name);
        }
        else
        {
            Console.WriteLine($"Validation failed: {error}");
        }
    }
}
