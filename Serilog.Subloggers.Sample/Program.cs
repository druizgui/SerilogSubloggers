using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

namespace Serilog.Subloggers.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console() // default log in console for general purposes. All 
                .Enrich.With<EventTypeEnricher>() // used for read eventId log properties

                .WriteTo.Logger(
                    lc => lc.Filter.With<SecurityEventFilter>()
                    .WriteTo.File(@"log\Security.txt", rollingInterval: RollingInterval.Day)
                ) // Log dedicated to security matters (user login successful, failed, ...)

                .WriteTo.Logger(
                    lc => lc.Filter.With<SystemEventFilter>()
                    .WriteTo.File(@"log\System.txt", rollingInterval: RollingInterval.Day)
                )  // Log dedicated to business information (a sucessful sell, an offer received, ...)

                .WriteTo.Logger(
                    lc => lc.Filter.With<AnalyticsEventFilter>()
                    .WriteTo.File(@"log\Analytics.txt", rollingInterval: RollingInterval.Day)
                ) // Log for analytics information


                .WriteTo.Logger(
                    lc => lc.Filter.With<BusinessEventFilter>()
                    .WriteTo.File(@"log\Business.txt", rollingInterval: RollingInterval.Day)
                ) // Log dedicated to business information (a sucessful sell, an offer received, ...

                .WriteTo.Logger(
                    lc => lc.Filter.With<TimeMetricsEventFilter>()
                    .WriteTo.File(@"log\TimeMetrics.txt", rollingInterval: RollingInterval.Day)
                ) // Time metrics log to trace Elapsed time inside the software components

                .CreateLogger();

            using (var serilog = new SerilogLoggerFactory(Serilog.Log.Logger))
            {
                Microsoft.Extensions.Logging.ILogger msLogger = serilog.CreateLogger("global");

                using (msLogger.TimeMetrics<Program>(nameof(Main))) // Trace elapsed time in a time metric log event
                {
                    msLogger.LogInformation("Hello world!"); // Normal log with default extensions
                    msLogger.Info("Normal log");  // Information log using Extensions ('Info' instead of 'LogInformation')

                    msLogger.Security().Info("Security message");    // Trace security log event
                    msLogger.Business().Info("Business message");    // Trace business log event
                    msLogger.Analytics().Info("Analytics message");  // Trace analytics log event
                    msLogger.System().Info("System message");        // Trace system log event

                    msLogger.LogInformation("Wait 1 second");
                    Thread.Sleep(1000);

                    msLogger.Security().Verbose("Verbose");
                    msLogger.Security().Error(new Exception("security exception"), "Error");
                    msLogger.Security().Warning("Warning");

                    msLogger
                        .Security()
                            .Info("Logon access granted")
                        .System()
                            .Debug("User login OK")
                        .Analytics()
                            .Information("Logon");

                }
            }
        }
    }
}