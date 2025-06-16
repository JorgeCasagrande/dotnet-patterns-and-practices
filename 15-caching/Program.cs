// Caching Example: In-Memory Cache for Simulated Data Access
// Example in English with clear comments and explanations

using System;
using System.Collections.Generic;
using System.Threading;

// Simple in-memory cache
// Stores key-value pairs in memory for fast retrieval
public class SimpleCache<TKey, TValue>
{
    private readonly Dictionary<TKey, TValue> _cache = new();
    // Tries to get a value from the cache
    public bool TryGetValue(TKey key, out TValue value) => _cache.TryGetValue(key, out value);
    // Adds or updates a value in the cache
    public void Set(TKey key, TValue value) => _cache[key] = value;
}

// Simulated slow data source
// Represents a data source that takes time to return data (e.g., database, API)
public class SlowDataSource
{
    public string GetData(string key)
    {
        // Simulate slow access (e.g., network/database delay)
        Thread.Sleep(1000);
        return $"Data for {key} at {DateTime.Now:HH:mm:ss}";
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Create cache and data source instances
        var cache = new SimpleCache<string, string>();
        var dataSource = new SlowDataSource();

        // Loop to fetch data by key
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter a key to fetch data (or 'exit' to quit):");
            var key = Console.ReadLine();
            if (key == "exit") break;

            // Try to get data from cache first
            if (cache.TryGetValue(key, out var cachedValue))
            {
                // Data found in cache: fast access
                Console.WriteLine($"[CACHE] {cachedValue}");
            }
            else
            {
                // Data not in cache: fetch from slow source and cache it
                var data = dataSource.GetData(key);
                cache.Set(key, data);
                Console.WriteLine($"[SOURCE] {data}");
            }
        }
    }
}