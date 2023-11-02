# Serilog.Subloggers

This library provides Serilog filters for separate logs in diferent purposes. 

# Install

> Install-Package Serilog.Subloggers

or

> dotnet add package Serilog.Subloggers

> [!NOTE]
> You need different Serilog packages in order to write information in diferent providers, like files, databases, etc.
> The example as follows uses the following packages:
    > dotnet add package Serilog.Sinks.Console
    > dotnet add package Serilog.Sinks.File
    > dotnet add package Serilog.Sinks.RollingFile

# Package
Latest versión: 1.2.0
Framework: netstandard2.1

Dependencies:
    - Microsoft.Extensions.Logging.Abstractions
    - Serilog

# Versions 
    
## Version 1.2.0
- New Error Sublogger
- Create your Subloggers

## Version 1.1.0

- Tests coverage
- LogClassificationExtensions Write methods
- TimeMetrics Log use now \t separators for easy use in a table to check time metrics

**New Time Extensions:**
Allow register time from external time measure:

- log.Time(ILogger Log, string name).Info(TimeSpan.FromSeconds(1));
- log.Time<T>(ILogger Log).Info(TimeSpan.FromSeconds(2));
- log.Time<T>(ILogger Log, string name).Info(TimeSpan.FromSeconds(3));

- log.Time(ILogger Log, string name).Info(TimeSpan.FromSeconds(1));
- log.Time<T>(ILogger Log).Info(TimeSpan.FromSeconds(2));
- log.Time<T>(ILogger Log, string name).Info(TimeSpan.FromSeconds(3));

## Version 1.0.0

EventTypeEnricher for Serilog

LoggerExtensions for **Microsoft.Extensions.Logging.ILogger**:

- Info
- Information
- Warning
- Error
- Fatal
- Write(LogLevel)
- Debug
- Verbose

**LogClassificationExtensions**:

- Info
- Information
- Warning
- Error
- Fatal
- Write(LogLevel)
- Debug
- Verbose

**LoggerClassificationExtensions**: 
- System
- Security
- Analytics
- Business

# Serilog Subloggers

Serilog allow you to send the log information to diferent places using filter techniques. 
This library provides components to perform this more oriented to separate log responsabilities.

The following Log purposes are defined:
- **System**: For log internal and system components
- **Security**: For security purposes logs.
- **Business**: for business information logs.
- **Analytics**: for log analytics information. 
- **Errors**: for log Errors. 
- **TimeMetrics**: for measure time inside a component alnd log elapsed execution time.

For use this feature you need configure 2 thinks: an event enricher to capture eventids in logs and 
a collection of different filters for filter by functionality or business domain

- EventId Enrichment:

This line capture eventId from log in order to configure a filter

```cs
    .Enrich.With<SubloggerEnricher>()
```

- Configure subloggers:

```cs
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

// Log errors in a separate file:
    .WriteTo.Logger(
    lc => lc.Filter.With<ErrorsEventFilter>()
    .WriteTo.File(@"log\Errors.txt", rollingInterval: RollingInterval.Day)
) 

// Time metrics log to trace Elapsed time inside the software components
.WriteTo.Logger(
    lc => lc.Filter.With<TimeMetricsEventFilter>()
    .WriteTo.File(@"log\TimeMetrics.txt", rollingInterval: RollingInterval.Day)
) 

// Use your own Sublogger.
// - Create SubloggerExtensions method and key
// - Create your EventFilter 
// Configure in Serilog:
    .WriteTo.Logger(
    lc => lc.Filter.With<MyCustomEventFilter>()
    .WriteTo.File(@"log\custom.txt", rollingInterval: RollingInterval.Day)
) // Time metrics log to trace Elapsed time inside the software components
;
```

# Usage

After configure Serilog, you can use the Serilog.Subloggers extensions in order to create diferent log events:
Use this line to trace security events: 

```cs
    msLogger.Security().Info("Security message");
```

or you can use to fluent API syntax:

```cs
 msLogger
    .Security()
        .Information("Logon access granted")
    .System()
        .Debug("User login OK")
    .Analytics()
        .Information("Logon");
```

This snippet send an information event to the security log file, another one to System log and, finally te 'logon' event to analytics log.
Notice that each log can be trace with the same log levels that any ILogger log. 

## Security
Use this line to trace security events: 

```cs
    msLogger.Security().Info("Security message");
```
 
## System
Use this line to trace System events: 

```cs
    msLogger.System().Information("System message");
```

## Analytics
Use this line to trace analytics events: 

```cs
    msLogger.Analytics().Information("Analytics message");
```

## Business
Use this line to trace business events: 

```cs
    msLogger.Business().Info("Business message");
```

## Errors
Use this line to trace Errors: 

```cs
    msLogger.Errors().Error("Error message");
```

## TimeMetrics
TimeMetrics is different to other log context. 
Wraps the code in a using statement to measure the execution time of your code.

The usage is:

```cs
    using (msLogger.TimeMetrics<Program>("Method"))
    {
        // Your code here.
    }
```

You can use 3 types of time metrics functions:

- Use your specific namespace or literal to identify the time measure:
```cs
using (msLogger.TimeMetrics("Namespace")) 
{ 
}
```

The result is:
> 2023-09-04 20:12:25.291 +02:00 [INF] **Namespace**. Elapsed: 00:00:01.000

- Use a class as a generic parameter:
```cs
using (msLogger.TimeMetrics<Program>()) 
{ 
}
```

The result is:
> 2023-09-04 20:12:25.291 +02:00 [INF] **Serilog.Subloggers.Sample.Program.Main**. Elapsed: 00:00:01.000

- Use a class as a generic parameter and contact more information with the string parameter:
```cs
using (msLogger.TimeMetrics<Program>("Method"))  
{ 
}
```

The result is:

> 2023-09-04 20:12:25.291 +02:00 [INF] **Serilog.Subloggers.Sample.Program.Main**. Elapsed: 00:00:01.000


## Example

Full code example:

```cs
static void Main(string[] args)
{
    var loggerBuilder = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.Console() // default log in console for general purposes. All 
        .Enrich.With<EventTypeEnricher>() // used for read eventId log properties
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
        ) // Time metrics log to trace Elapsed time inside the software components
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

    Serilog.Log.CloseAndFlush();
}
```

The output results for this example is:

**Console:**
```
[20:12:24 INF] Hello world!
[20:12:24 INF] Normal log
[20:12:24 INF] Security message
[20:12:24 INF] Business message
[20:12:24 INF] Analytics message
[20:12:24 INF] System message
[20:12:24 INF] Wait 1 second
[20:12:25 DBG] Verbose
[20:12:25 ERR] Error
System.Exception: security exception
[20:12:25 WRN] Warning
[20:12:25 INF] Logon access granted
[20:12:25 DBG] User login OK
[20:12:25 INF] Logon
[20:12:25 INF] Serilog.Subloggers.Sample.Program.Main. Elapsed: 00:00:01.175
```

**Log\Security.txt**
```
2023-09-04 20:12:24.184 +02:00 [INF] Security message
2023-09-04 20:12:25.265 +02:00 [DBG] Verbose
2023-09-04 20:12:25.267 +02:00 [ERR] Error
System.Exception: security exception
2023-09-04 20:12:25.275 +02:00 [WRN] Warning
2023-09-04 20:12:25.278 +02:00 [INF] Logon access granted
```

**Log\System.txt**
```
2023-09-04 20:12:24.249 +02:00 [INF] System message
2023-09-04 20:12:25.280 +02:00 [DBG] User login OK
```

**Log\Analytics.txt**
```
2023-09-04 20:12:24.240 +02:00 [INF] Analytics message
2023-09-04 20:12:25.282 +02:00 [INF] Logon
```

**Log\Business.txt**
```
2023-09-04 20:12:24.230 +02:00 [INF] Business message
```

**Log\Errors.txt**
```
2023-09-04 20:12:24.230 +02:00 [ERR] This is an error
```

**Log\TimeMetrics.txt**
```
2023-09-04 20:12:25.291 +02:00 [INF] Serilog.Subloggers.Sample.Program.Main. Elapsed: 00:00:01.175
2023-11-01 20:02:56.643 +01:00 [INF] TimeMetric-1	Elapsed:	00:00:08.871
2023-11-01 20:02:56.646 +01:00 [INF] Serilog.Subloggers.Sample.Program	Elapsed:	00:00:08.871
2023-11-01 20:02:56.648 +01:00 [INF] Serilog.Subloggers.Sample.Program.Version-1.1.0	Elapsed:	00:00:08.871
```

You can see the full example in **Serilog.Subloggers.Sample** project.

# Create your custom Subloggers

Implement a Extension class with The Method to use as Sublogger. Use LogClassification.CustomSubloggerFactory to create sublogger log;

```cs
public static class SubloggerExtensions
{
    public const string MyCustomKey = "Custom";

    public static LogClassification MyCustom(this Microsoft.Extensions.Logging.ILogger log) => LogClassification.CustomSubloggerFactory(log, MyCustomKey);
}
```

Create a string Key property (MyCustomKey) or name that are used by the extension method and the custom event filter.

- Implement a Event filter class that inherits from **EventFilterBase**:
```cs
public class MyCustomEventFilter : EventFilterBase
{
    public override string FilterName => SubloggerExtensions.MyCustomKey;
}
```

Configure in Serilog:
```cs
.WriteTo.Logger(
    lc => lc.Filter.With<MyCustomEventFilter>()
    .WriteTo.File(@"log\custom.txt", rollingInterval: RollingInterval.Day)
)
```

Use it in your code:
```cs
msLogger
    .MyCustom()
        .Info("This is my custom log info");
```

You can see the example in **Serilog.Subloggers.Sample** project.