// Adapter Pattern Example: Adapting a Legacy Logger to a New Interface
// Example in English with clear comments and explanations

using System;

// New logging interface expected by the application
public interface ILogger
{
    void Log(string message);
}

// Legacy logger with a different interface
public class LegacyLogger
{
    public void WriteLog(string msg)
    {
        Console.WriteLine($"[LegacyLogger] {msg}");
    }
}

// Adapter: makes LegacyLogger compatible with ILogger
public class LoggerAdapter : ILogger
{
    private readonly LegacyLogger _legacyLogger;
    public LoggerAdapter(LegacyLogger legacyLogger)
    {
        _legacyLogger = legacyLogger;
    }
    public void Log(string message)
    {
        // Translate the call to the legacy method
        _legacyLogger.WriteLog(message);
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Application expects ILogger
        ILogger logger = new LoggerAdapter(new LegacyLogger());
        logger.Log("This is a log message using the Adapter Pattern.");
    }
}
