// Pipeline Behavior Example: Logging and Validation Behaviors
// Example in English with clear comments and explanations

using System;
using System.Collections.Generic;

// Request model
public class Request
{
    public string Data { get; set; }
}

// Handler interface
public interface IHandler<TRequest>
{
    void Handle(TRequest request);
}

// Pipeline behavior interface
public interface IPipelineBehavior<TRequest>
{
    void Handle(TRequest request, Action next);
}

// Logging behavior: logs before and after the next step
public class LoggingBehavior : IPipelineBehavior<Request>
{
    public void Handle(Request request, Action next)
    {
        Console.WriteLine($"[LOG] Handling request with data: {request.Data}");
        next();
        Console.WriteLine("[LOG] Finished handling request");
    }
}

// Validation behavior: checks if data is not empty
public class ValidationBehavior : IPipelineBehavior<Request>
{
    public void Handle(Request request, Action next)
    {
        if (string.IsNullOrWhiteSpace(request.Data))
        {
            Console.WriteLine("[VALIDATION] Request data is required.");
            return;
        }
        next();
    }
}

// Actual handler: processes the request
public class RequestHandler : IHandler<Request>
{
    public void Handle(Request request)
    {
        Console.WriteLine($"[HANDLER] Processing: {request.Data}");
    }
}

// Pipeline executor: chains behaviors and handler
public class Pipeline<TRequest>
{
    private readonly List<IPipelineBehavior<TRequest>> _behaviors;
    private readonly IHandler<TRequest> _handler;

    public Pipeline(List<IPipelineBehavior<TRequest>> behaviors, IHandler<TRequest> handler)
    {
        _behaviors = behaviors;
        _handler = handler;
    }

    public void Execute(TRequest request)
    {
        int index = -1;
        Action next = null;
        next = () =>
        {
            index++;
            if (index < _behaviors.Count)
                _behaviors[index].Handle(request, next);
            else
                _handler.Handle(request);
        };
        next();
    }
}

// Main program
class Program
{
    static void Main()
    {
        var behaviors = new List<IPipelineBehavior<Request>>
        {
            new LoggingBehavior(),
            new ValidationBehavior()
        };
        var handler = new RequestHandler();
        var pipeline = new Pipeline<Request>(behaviors, handler);

        // Example 1: Valid request
        pipeline.Execute(new Request { Data = "Hello pipeline!" });
        Console.WriteLine();
        // Example 2: Invalid request (empty data)
        pipeline.Execute(new Request { Data = "" });
    }
}
