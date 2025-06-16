using System;
using System.Collections.Generic;

// Example of the Observer pattern in .NET
// Includes both a classic implementation and the use of IObservable<T>/IObserver<T>

namespace ObserverPatternExample
{
    // --- Classic Observer Pattern ---

    // Observer interface: defines the contract for receiving updates
    public interface IObserver
    {
        void Update(string message);
    }

    // Subject interface: defines methods for attaching, detaching, and notifying observers
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }

    // Concrete subject: NewsAgency manages a list of observers (subscribers)
    public class NewsAgency : ISubject
    {
        private readonly List<IObserver> _observers = new();
        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);
        public void Notify(string message)
        {
            foreach (var observer in _observers)
                observer.Update(message);
        }
        // Publishes news and notifies all subscribers
        public void PublishNews(string news)
        {
            Console.WriteLine($"NewsAgency publishes: {news}");
            Notify(news);
        }
    }

    // Concrete observer: Subscriber receives updates from the subject
    public class Subscriber : IObserver
    {
        public string Name { get; }
        public Subscriber(string name) => Name = name;
        public void Update(string message)
        {
            Console.WriteLine($"{Name} received news: {message}");
        }
    }

    // --- .NET IObservable<T> / IObserver<T> Example ---

    // WeatherStation implements IObservable<int> to notify observers of temperature changes
    public class WeatherStation : IObservable<int>
    {
        private readonly List<IObserver<int>> _observers = new();
        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }
        // Notifies all observers of the new temperature
        public void SetTemperature(int temp)
        {
            Console.WriteLine($"WeatherStation: Temperature is {temp}°C");
            foreach (var observer in _observers)
                observer.OnNext(temp);
        }
        // Helper class to allow observers to unsubscribe
        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<int>> _observers;
            private readonly IObserver<int> _observer;
            public Unsubscriber(List<IObserver<int>> observers, IObserver<int> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }

    // TemperatureDisplay implements IObserver<int> to receive temperature updates
    public class TemperatureDisplay : IObserver<int>
    {
        public string Name { get; }
        public TemperatureDisplay(string name) => Name = name;
        public void OnCompleted() { }
        public void OnError(Exception error) { }
        public void OnNext(int value)
        {
            Console.WriteLine($"{Name} displays temperature: {value}°C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // --- Classic Observer ---
            // NewsAgency is the subject, Subscriber are observers
            var agency = new NewsAgency();
            var sub1 = new Subscriber("Alice");
            var sub2 = new Subscriber("Bob");
            agency.Attach(sub1);
            agency.Attach(sub2);
            agency.PublishNews("Observer pattern in .NET!"); // Both receive the news
            agency.Detach(sub1);
            agency.PublishNews("Second news update."); // Only Bob receives the news

            Console.WriteLine("\n--- .NET IObservable/IObserver Example ---");

            // --- .NET IObservable/IObserver ---
            // WeatherStation is the observable, TemperatureDisplay are observers
            var station = new WeatherStation();
            var display1 = new TemperatureDisplay("Display1");
            var display2 = new TemperatureDisplay("Display2");
            var subDisp1 = station.Subscribe(display1); // Subscribe display1
            var subDisp2 = station.Subscribe(display2); // Subscribe display2
            station.SetTemperature(25); // Both displays receive the update
            subDisp1.Dispose(); // Unsubscribe display1
            station.SetTemperature(30); // Only display2 receives the update
        }
    }
}
