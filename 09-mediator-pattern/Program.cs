using System;
using System.Collections.Generic;

// Example of the classic Mediator pattern in .NET
// Centralizes communication between components (users in a chat)

namespace MediatorPatternExample
{
    // Mediator interface defines the contract for communication
    public interface IMediator
    {
        void Send(string message, Colleague sender);
    }

    // Colleague base class represents a participant in the system
    public abstract class Colleague
    {
        protected IMediator _mediator;
        public string Name { get; }
        public Colleague(IMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }
    }

    // Concrete colleague: User
    // Each user can send and receive messages via the mediator
    public class User : Colleague
    {
        public User(IMediator mediator, string name) : base(mediator, name) { }
        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _mediator.Send(message, this);
        }
        public void Receive(string message, string from)
        {
            Console.WriteLine($"{Name} receives from {from}: {message}");
        }
    }

    // Concrete mediator: ChatMediator
    // Manages communication between users
    public class ChatMediator : IMediator
    {
        private readonly List<User> _users = new();
        // Register a user to the chat
        public void Register(User user)
        {
            _users.Add(user);
        }
        // Send a message from one user to all others
        public void Send(string message, Colleague sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.Receive(message, sender.Name);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the mediator (chat room)
            var chat = new ChatMediator();

            // Create users and register them with the mediator
            var alice = new User(chat, "Alice");
            var bob = new User(chat, "Bob");
            var carol = new User(chat, "Carol");
            chat.Register(alice);
            chat.Register(bob);
            chat.Register(carol);

            // Users send messages via the mediator
            // The mediator delivers the message to all other users
            alice.Send("Hello everyone!");
            bob.Send("Hi Alice!");
            carol.Send("Good morning!");
        }
    }
}
