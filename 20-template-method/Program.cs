// Template Method Pattern Example: Data Processing Workflow
// Example in English with clear comments and explanations

using System;

// Abstract base class defines the template method
public abstract class DataProcessor
{
    // Template method: defines the skeleton of the algorithm
    public void Process()
    {
        ReadData();
        TransformData();
        SaveData();
    }

    // Steps to be implemented or overridden by subclasses
    protected abstract void ReadData();
    protected abstract void TransformData();
    protected virtual void SaveData()
    {
        Console.WriteLine("Saving data (default implementation)");
    }
}

// Concrete class: reads and processes CSV data
public class CsvDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading data from CSV file");
    }
    protected override void TransformData()
    {
        Console.WriteLine("Transforming CSV data");
    }
    protected override void SaveData()
    {
        Console.WriteLine("Saving CSV data to database");
    }
}

// Concrete class: reads and processes JSON data
public class JsonDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading data from JSON file");
    }
    protected override void TransformData()
    {
        Console.WriteLine("Transforming JSON data");
    }
    // Uses default SaveData implementation
}

// Main program
class Program
{
    static void Main()
    {
        DataProcessor csvProcessor = new CsvDataProcessor();
        csvProcessor.Process();
        Console.WriteLine();
        DataProcessor jsonProcessor = new JsonDataProcessor();
        jsonProcessor.Process();
    }
}
