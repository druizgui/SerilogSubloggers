using System;
using System.Reflection.Emit;

namespace Microsoft.Extensions.Logging
{
    public static class LogClassificationTimeMetricsExtensions
    {
        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="message">The the message.</param>
        public static ILogger Write(this LogClassificationTimeMetrics log, LogLevel level, TimeSpan elapsed)
        {
            log.Logger.Log(level, log.Event, LogElapsedTimer.TimeMetricLogFormatter(log.Name, elapsed));
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Verbose(this LogClassificationTimeMetrics log, TimeSpan elapsed)
        {
            log.Logger.Log(LogLevel.Debug, log.Event, LogElapsedTimer.TimeMetricLogFormatter(log.Name, elapsed));
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Debug(this LogClassificationTimeMetrics log, TimeSpan elapsed)
        {
            log.Logger.Log(LogLevel.Debug, log.Event, LogElapsedTimer.TimeMetricLogFormatter(log.Name, elapsed));
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Information(this LogClassificationTimeMetrics log, TimeSpan elapsed)
        {
            log.Logger.Log(LogLevel.Information, log.Event, LogElapsedTimer.TimeMetricLogFormatter(log.Name, elapsed));
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Info(this LogClassificationTimeMetrics log, TimeSpan elapsed)
        {
            log.Logger.Log(LogLevel.Information, log.Event, LogElapsedTimer.TimeMetricLogFormatter(log.Name, elapsed));
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Warning(this LogClassificationTimeMetrics log, TimeSpan elapsed)
        {
            log.Logger.Log(LogLevel.Warning, log.Event, LogElapsedTimer.TimeMetricLogFormatter(log.Name, elapsed));
            return log.Logger;
        }
    }
}
