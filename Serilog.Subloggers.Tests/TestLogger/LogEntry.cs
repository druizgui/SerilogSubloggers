using Microsoft.Extensions.Logging;

namespace Serilog.Subloggers.Tests
{
    internal class LogEntry
    {
        public LogLevel LogLevel { get; set;
}
        public EventId EventId { get; set;
}
        public Exception? Exception { get; set;
}
        public string? Message { get; internal set;
}
    }
}