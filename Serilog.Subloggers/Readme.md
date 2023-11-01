# Serilog.Subloggers
 
## Description
This library provides Serilog filters for separate logs in diferent purposes. 

## Release notes

### version 
    Latest versión: 1.0.0

### Install

> Install-Package Serilog.Subloggers

or

> dotnet add package Serilog.Subloggers

> [!NOTE]
> You need different Serilog packages in order to write information in diferent providers, like files, databases, etc.
> The example as follows uses the following packages:
    > dotnet add package Serilog.Sinks.Console
    > dotnet add package Serilog.Sinks.File
    > dotnet add package Serilog.Sinks.RollingFile


## Serilog Subloggers

Serilog allow you to send the log information to diferent places using filter techniques. 
This library provides components to perform this more oriented to separate log responsabilities.

The following Log purposes are defined:
- **System**: For log internal and system components
- **Security**: For security purposes logs.
- **Business**: for business information logs.
- **Analytics**: for log analytics information. 
- **TimeMetrics**: for measure time inside a component alnd log elapsed execution time.

For use this feature you need configure 2 thinks: an event enricher to capture eventids in logs and 
a collection of different filters for filter by functionality or business domain

- EventId Enrichment:

This line capture eventId from log in order to configure a filter

```cs
    .Enrich.With<EventTypeEnricher>()
```

- Configure sub-loggers:

```cs
  .WriteTo.Logger(
        lc => lc.Filter.With<TimeMetricsEventFilter>()
        .WriteTo.File(@"log\TimeMetrics.txt", rollingInterval: RollingInterval.Day)
        ) //Time metrics log to trace Elapsed time inside the software components
                
    .WriteTo.Logger(
        lc => lc.Filter.With<AnalyticsEventFilter>()
        .WriteTo.File(@"log\Analytics.txt", rollingInterval: RollingInterval.Day)
        ) //

    .WriteTo.Logger(
        lc => lc.Filter.With<BusinessEventFilter>()
        .WriteTo.File(@"log\Business.txt", rollingInterval: RollingInterval.Day)
    ) // Log dedicated to business information (a sucessful sell, an offer received, ...

    .WriteTo.Logger(
        lc => lc.Filter.With<SystemEventFilter>()
        .WriteTo.File(@"log\System.txt", rollingInterval: RollingInterval.Day))
        // Log dedicated to business information (a sucessful sell, an offer received, ...)

    .WriteTo.Logger(
        lc => lc.Filter.With<SecurityEventFilter>()
        .WriteTo.File(@"log\Security.txt", rollingInterval: RollingInterval.Day))
    // Log dedicated to security matters (user login successful, failed, ...)
```

## Usage

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

### Security
Use this line to trace security events: 

```cs
    msLogger.Security().Info("Security message");
```
 
### System
Use this line to trace System events: 

```cs
    msLogger.System().Information("System message");
```

### Analytics
Use this line to trace analytics events: 

```cs
    msLogger.Analytics().Information("Analytics message");
```

### Business
Use this line to trace business events: 

```cs
    msLogger.Business().Info("Business message");
```

### TimeMetrics
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

    Microsoft.Extensions.Logging.ILogger msLogger = new SerilogLoggerFactory(Serilog.Log.Logger).CreateLogger("global");
            
    using (msLogger.TimeMetrics<Program>("Method"))  // Trace elapsed time in a timemetric log event
    {
        msLogger.LogInformation("Hello world!"); // Normal log with default extensions
        msLogger.Info("Normal log");  // Info log using Extensions ('Info' instead of 'LogInformation')

        msLogger.Security().Info("Security message");    // Trace security log event
        msLogger.Business().Info("Business message");    // Trace business log event
        msLogger.Analytics().Info("Analytics message");  // Trace analytics log event
        msLogger.System().Info("System message");        // Trace system log event

        msLogger.Info("Wait 1 second");
        Thread.Sleep(1000);

        msLogger.Security().Verbose("Verbose");
        msLogger.Security().Error(new Exception("security exception"), "Error");
        msLogger.Security().Warning("Warning");

        msLogger
            .Security()
                .Information("Logon access granted")
            .System()
                .Debug("User login OK")
            .Analytics()
                .Information("Logon");

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

**Log\TimeMetrics.txt**
```
2023-09-04 20:12:25.291 +02:00 [INF] Serilog.Subloggers.Sample.Program.Main. Elapsed: 00:00:01.175
```

You can see the full example in **Serilog.Subloggers.Sample** project.


## Framework
- netstandard2.1

## Net Core Dependencies
- Microsoft.Extensions.Logging.Abstractions


# Versions 

## 1.0.0

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

## 1.1.0

- Tests coverage
- LogClassificationExtensions Write methods
- TimeMetrics Log use now \t separators for easy use in a table to check time metrics
        
