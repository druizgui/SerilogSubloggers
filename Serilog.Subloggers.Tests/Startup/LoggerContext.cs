using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using Serilog.Debugging;
using Serilog.Extensions.Logging;

namespace Serilog.Subloggers.Tests
{
    internal static class LoggerContext
    {
        internal static Microsoft.Extensions.Logging.ILogger Factory()
        {
            var loggeBuilder = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()

                .Enrich.With<EventTypeEnricher>() // used for read eventId log properties
                .WriteTo.Logger(
                    lc => lc.Filter.With<SecurityEventFilter>()
                    .WriteTo.Console()
                )
                .WriteTo.Logger(
                    lc => lc.Filter.With<SystemEventFilter>()
                    .WriteTo.Console()
                )
                .WriteTo.Logger(
                    lc => lc.Filter.With<AnalyticsEventFilter>()
                    .WriteTo.Console()
                )
                .WriteTo.Logger(
                    lc => lc.Filter.With<BusinessEventFilter>()
                    .WriteTo.Console()
                )
                .WriteTo.Logger(
                    lc => lc.Filter.With<TimeMetricsEventFilter>()
                    .WriteTo.Console()
                )
            ;

            return new SerilogLoggerFactory(loggeBuilder.CreateLogger()).CreateLogger("test");
        }

        internal static TestLogger TestFactory()
        {
            return new TestLogger();
        }
    }
}