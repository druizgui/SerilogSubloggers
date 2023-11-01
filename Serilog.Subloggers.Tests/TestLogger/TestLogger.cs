using Microsoft.Extensions.Logging;

namespace Serilog.Subloggers.Tests
{
    internal class TestLogger : Microsoft.Extensions.Logging.ILogger, IDisposable
    {
        internal List<LogEntry> logEntries = new List<LogEntry>();

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            logEntries.Add(new LogEntry
            {
                LogLevel = logLevel,
                EventId = eventId,
                Exception = exception,
                Message = formatter.Invoke(state, exception)
            });
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return this;
        }

        public void Dispose()
        {
            logEntries.Clear();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }
    }
}