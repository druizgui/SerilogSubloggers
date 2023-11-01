using System;

namespace Microsoft.Extensions.Logging
{
    public static class LoggerExtensions
    {
        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="message">The the message.</param>
        public static void Write(this ILogger log, LogLevel level, string message)
        {
            log.Log(level, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Write(this ILogger log, LogLevel level, string message, params object[] parameters)
        {
            log.Log(level, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static void Write(this ILogger log, LogLevel level, Exception exception, string message)
        {
            log.Log(level, exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="level">The <see cref="LogLevel"/> level.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Write(this ILogger log, LogLevel level, Exception exception, string message, params object[] parameters)
        {
            log.Log(level, exception, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Verbose(this ILogger log, string message)
        {
            log.LogDebug(message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Verbose(this ILogger log, string message, params object[] parameters)
        {
            log.LogDebug(message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static void Verbose(this ILogger log, Exception exception, string message)
        {
            log.LogDebug(exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Verbose(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogDebug(exception, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Debug(this ILogger log, string message)
        {
            log.LogDebug(message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Debug(this ILogger log, string message, params object[] parameters)
        {
            log.LogDebug(message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static void Debug(this ILogger log, Exception exception, string message)
        {
            log.LogDebug(exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Debug"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Debug(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogDebug(exception, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Information(this ILogger log, string message)
        {
            log.LogInformation(message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Information(this ILogger log, string message, params object[] parameters)
        {
            log.LogInformation(message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static void Information(this ILogger log, Exception exception, string message)
        {
            log.LogInformation(exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Information(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogInformation(exception, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Info(this ILogger log, string message)
        {
            log.LogInformation(message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Info(this ILogger log, string message, params object[] parameters)
        {
            log.LogInformation(message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Info(this ILogger log, Exception exception, string message)
        {
            log.LogInformation(exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Information"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Info(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogInformation(exception, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Warning"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Warning(this ILogger log, string message)
        {
            log.LogWarning(message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Warning"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Warning(this ILogger log, string message, params object[] parameters)
        {
            log.LogWarning(message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Warning"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static void Warning(this ILogger log, Exception exception, string message)
        {
            log.LogWarning(exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Warning"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Warning(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogWarning(exception, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Error"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Error(this ILogger log, string message)
        {
            log.LogError(message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Error"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Error(this ILogger log, string message, params object[] parameters)
        {
            log.LogError(message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Error"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static void Error(this ILogger log, Exception exception, string message)
        {
            log.LogError(exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Error"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Error(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogError(exception, message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Critical"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        public static void Fatal(this ILogger log, string message)
        {
            log.LogCritical(message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Critical"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Fatal(this ILogger log, string message, params object[] parameters)
        {
            log.LogCritical(message, parameters);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Critical"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        public static void Fatal(this ILogger log, Exception exception, string message)
        {
            log.LogCritical(exception, message);
        }

        /// <summary>Writes a log message in the <see cref="ILogger"/> instance with the specified level <see cref="LogLevel.Critical"/>.</summary>
        /// <param name="log">A <see cref="ILogger"/> instance.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The the message.</param>
        /// <param name="parameters">The parameters of the message.</param>
        public static void Fatal(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogCritical(exception, message, parameters);
        }
    }
}
