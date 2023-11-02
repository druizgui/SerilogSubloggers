using Microsoft.Extensions.Logging;

using Serilog;
using System.Diagnostics;

namespace Serilog.Subloggers.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loggerBuilder = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console() // default log in console for general purposes. All 
                .Enrich.With<SubloggerEnricher>() // used for read eventId log properties

                // Log dedicated to security matters (user login successful, failed, ...)
                .WriteTo.Logger(
                    lc => lc.Filter.With<SecurityEventFilter>()
                    .WriteTo.File(@"log\Security.txt", rollingInterval: RollingInterval.Day)
                ) 

                // Log dedicated to system information (a sucessful sell, an offer received, ...)
                .WriteTo.Logger(
                    lc => lc.Filter.With<SystemEventFilter>()
                    .WriteTo.File(@"log\System.txt", rollingInterval: RollingInterval.Day)
                )  

                // Log for analytics information
                .WriteTo.Logger(
                    lc => lc.Filter.With<AnalyticsEventFilter>()
                    .WriteTo.File(@"log\Analytics.txt", rollingInterval: RollingInterval.Day)
                ) 

                // Log dedicated to business information (a sucessful sell, an offer received, ...
                .WriteTo.Logger(
                    lc => lc.Filter.With<BusinessEventFilter>()
                    .WriteTo.File(@"log\Business.txt", rollingInterval: RollingInterval.Day)
                ) 

                // Time metrics log to trace Elapsed time inside the software components
                .WriteTo.Logger(
                    lc => lc.Filter.With<TimeMetricsEventFilter>()
                    .WriteTo.File(@"log\TimeMetrics.txt", rollingInterval: RollingInterval.Day)
                ) 

                // Log errors in a separate file:
                .WriteTo.Logger(
                    lc => lc.Filter.With<ErrorsEventFilter>()
                    .WriteTo.File(@"log\Errors.txt", rollingInterval: RollingInterval.Day)
                ) 

                // Use your own Sublogger.
                // - Create SubloggerExtensions method and key
                // - Create your EventFilter 
                // Configure in Serilog:
                .WriteTo.Logger(
                    lc => lc.Filter.With<MyCustomEventFilter>()
                    .WriteTo.File(@"log\custom.txt", rollingInterval: RollingInterval.Day)
                )
                ;

            Serilog.Log.Logger = loggerBuilder.CreateLogger();

            var totalTime_watch = new Stopwatch();
            totalTime_watch.Start();

            using (var serilog = new Serilog.Extensions.Logging.SerilogLoggerFactory(Serilog.Log.Logger))
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

                    msLogger
                        .Errors()
                            .Error("This is an error");

                    // Use your custom Sublogger:
                    msLogger
                        .MyCustom()
                            .Info("This is my custom log info");
                }

                //Version 1.1.0
                //Other usage for time metrics:

                totalTime_watch.Stop();
                msLogger.Time("TimeMetric-1").Information(totalTime_watch.Elapsed);
                msLogger.Time<Program>().Information(totalTime_watch.Elapsed);
                msLogger.Time<Program>("Version-1.1.0").Information(totalTime_watch.Elapsed);
            }
        }
    }
}