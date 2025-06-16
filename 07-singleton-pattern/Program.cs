using System;
using System.Threading;

// Example of Singleton pattern in .NET
// Includes both classic and thread-safe implementations

namespace SingletonPatternExample
{
    // Classic Singleton (not thread-safe)
    public class ClassicSingleton
    {
        private static ClassicSingleton _instance;
        public string Value { get; private set; }
        private ClassicSingleton() { Value = "Classic Singleton"; }
        public static ClassicSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClassicSingleton();
                return _instance;
            }
        }
    }

    // Thread-safe Singleton (using double-check locking)
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object _lock = new object();
        public string Value { get; private set; }
        private ThreadSafeSingleton() { Value = "Thread-Safe Singleton"; }
        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new ThreadSafeSingleton();
                    }
                }
                return _instance;
            }
        }
    }

    // Thread-safe Singleton (using static initialization)
    public class StaticSingleton
    {
        public string Value { get; private set; }
        private StaticSingleton() { Value = "Static Thread-Safe Singleton"; }
        public static StaticSingleton Instance { get; } = new StaticSingleton();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Classic Singleton
            var classic1 = ClassicSingleton.Instance;
            var classic2 = ClassicSingleton.Instance;
            Console.WriteLine($"Classic: {classic1.Value} | Same instance: {ReferenceEquals(classic1, classic2)}");

            // Thread-safe Singleton (double-check locking)
            var safe1 = ThreadSafeSingleton.Instance;
            var safe2 = ThreadSafeSingleton.Instance;
            Console.WriteLine($"Thread-Safe: {safe1.Value} | Same instance: {ReferenceEquals(safe1, safe2)}");

            // Thread-safe Singleton (static initialization)
            var static1 = StaticSingleton.Instance;
            var static2 = StaticSingleton.Instance;
            Console.WriteLine($"Static: {static1.Value} | Same instance: {ReferenceEquals(static1, static2)}");
        }
    }
}