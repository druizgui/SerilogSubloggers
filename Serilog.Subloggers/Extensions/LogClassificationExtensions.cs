using System;

namespace Microsoft.Extensions.Logging
{
    public static class LogClassificationExtensions
    { 
        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="message">The the message.</param>
        public static ILogger Write(this LogClassification log, LogLevel level, string message)
        {
            log.Logger.Log(level, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Write(this LogClassification log, LogLevel level, string message, params object[] parameters)
        {
            log.Logger.Log(level, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static ILogger Write(this LogClassification log, LogLevel level, Exception exception, string message)
        {
            log.Logger.Log(level, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Write(this LogClassification log, LogLevel level, Exception exception, string message, params object[] parameters)
        {
            log.Logger.Log(level, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Verbose(this LogClassification log, string message)
        {
            log.Logger.LogDebug(log.Event, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Verbose(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Verbose(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogDebug(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Verbose(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Debug(this LogClassification log, string message)
        {
            log.Logger.LogDebug(log.Event, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Debug(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Debug(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogDebug(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Debug(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Information(this LogClassification log, string message)
        {
             log.Logger.LogInformation(log.Event, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Information(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Information(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogInformation(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Information(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Info(this LogClassification log, string message)
        {
            log.Logger.LogInformation(log.Event, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Info(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Info(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogInformation(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Info(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Warning(this LogClassification log, string message)
        {
            log.Logger.LogWarning(log.Event, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Warning(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogWarning(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Warning(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogWarning(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Warning(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogWarning(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Error(this LogClassification log, string message)
        {
            log.Logger.LogError(log.Event, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Error(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogError(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Error(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogError(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Error(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogError(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        public static ILogger Fatal(this LogClassification log, string message)
        {
            log.Logger.LogCritical(log.Event, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Fatal(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogCritical(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Fatal(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogCritical(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static ILogger Fatal(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogCritical(log.Event, exception, message, parameters);
            return log.Logger;
        }
    }
}
