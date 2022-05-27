using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging;
using System;
namespace SqlWithEFCore
{
    public class ConsoleLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new ConsoleLogger();
        }

        public void Dispose() { }
    }
    public class ConsoleLogger : ILogger
    {
        // if your logger uses unmanaged resources, you can
        // return the class that implements IDisposable here 
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Trace:
                case LogLevel.Information:
                case LogLevel.None:
                    return false;
                case LogLevel.Debug:
                case LogLevel.Warning:
                case LogLevel.Error:
                case LogLevel.Critical:
                default:
                    return true;
            };
        }
        public void Log<TState>(LogLevel logLevel,
  EventId eventId, TState state, Exception exception,
  Func<TState, Exception, string> formatter)
        {
            // log the level and event identifier
            Console.Write($"Level: {logLevel}, Event ID: {eventId.Id}");
            // only output the state or exception if it exists
            if (state != null)
            {
                Console.Write($", State: {state}");
            }
            if (exception != null)
            {
                Console.Write($", Exception: {exception.Message}");
            }
            Console.WriteLine();
        }
    }
}