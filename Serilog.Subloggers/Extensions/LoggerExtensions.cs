using System;

namespace Microsoft.Extensions.Logging
{
    public static class LoggerExtensions
    {
        /// <summary>Writes the specified level.</summary>
        /// <param name="log">The log.</param>
        /// <param name="level">The level.</param>
        /// <param name="message">The message.</param>
        public static void Write(this ILogger log, LogLevel level, string message)
        {
            log.Log(level, message);
        }

        /// <summary>Writes the specified level.</summary>
        /// <param name="log">The log.</param>
        /// <param name="level">The level.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Write(this ILogger log, LogLevel level, string message, params object[] parameters)
        {
            log.Log(level, message, parameters);
        }

        /// <summary>Writes the specified level.</summary>
        /// <param name="log">The log.</param>
        /// <param name="level">The level.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Write(this ILogger log, LogLevel level, Exception exception, string message)
        {
            log.Log(level, exception, message);
        }

        /// <summary>Writes the specified level.</summary>
        /// <param name="log">The log.</param>
        /// <param name="level">The level.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Write(this ILogger log, LogLevel level, Exception exception, string message, params object[] parameters)
        {
            log.Log(level, exception, message, parameters);
        }

        /// <summary>Verboses the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        public static void Verbose(this ILogger log, string message)
        {
            log.LogDebug(message);
        }

        /// <summary>Verboses the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Verbose(this ILogger log, string message, params object[] parameters)
        {
            log.LogDebug(message, parameters);
        }

        /// <summary>Verboses the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Verbose(this ILogger log, Exception exception, string message)
        {
            log.LogDebug(exception, message);
        }

        /// <summary>Verboses the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Verbose(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogDebug(exception, message, parameters);
        }

        /// <summary>Debugs the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        public static void Debug(this ILogger log, string message)
        {
            log.LogDebug(message);
        }

        /// <summary>Debugs the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Debug(this ILogger log, string message, params object[] parameters)
        {
            log.LogDebug(message, parameters);
        }

        /// <summary>Debugs the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Debug(this ILogger log, Exception exception, string message)
        {
            log.LogDebug(exception, message);
        }

        /// <summary>Debugs the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Debug(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogDebug(exception, message, parameters);
        }

        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        public static void Information(this ILogger log, string message)
        {
            log.LogInformation(message);
        }

        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Information(this ILogger log, string message, params object[] parameters)
        {
            log.LogInformation(message, parameters);
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Information(this ILogger log, Exception exception, string message)
        {
            log.LogInformation(exception, message);
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Information(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogInformation(exception, message, parameters);
        }

        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        public static void Info(this ILogger log, string message)
        {
            log.LogInformation(message);
        }

        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Info(this ILogger log, string message, params object[] parameters)
        {
            log.LogInformation(message, parameters);
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Info(this ILogger log, Exception exception, string message)
        {
            log.LogInformation(exception, message);
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Info(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogInformation(exception, message, parameters);
        }

        /// <summary>Warnings the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        public static void Warning(this ILogger log, string message)
        {
            log.LogWarning(message);
        }

        /// <summary>Warnings the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Warning(this ILogger log, string message, params object[] parameters)
        {
            log.LogWarning(message, parameters);
        }

        /// <summary>Warnings the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Warning(this ILogger log, Exception exception, string message)
        {
            log.LogWarning(exception, message);
        }

        /// <summary>Warnings the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Warning(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogWarning(exception, message, parameters);
        }

        /// <summary>Errors the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        public static void Error(this ILogger log, string message)
        {
            log.LogError(message);
        }

        /// <summary>Errors the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Error(this ILogger log, string message, params object[] parameters)
        {
            log.LogError(message, parameters);
        }

        /// <summary>Errors the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Error(this ILogger log, Exception exception, string message)
        {
            log.LogError(exception, message);
        }

        /// <summary>Errors the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Error(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogError(exception, message, parameters);
        }

        /// <summary>Fatals the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        public static void Fatal(this ILogger log, string message)
        {
            log.LogCritical(message);
        }

        /// <summary>Fatals the specified message.</summary>
        /// <param name="log">The log.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Fatal(this ILogger log, string message, params object[] parameters)
        {
            log.LogCritical(message, parameters);
        }

        /// <summary>Fatals the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static void Fatal(this ILogger log, Exception exception, string message)
        {
            log.LogCritical(exception, message);
        }

        /// <summary>Fatals the specified exception.</summary>
        /// <param name="log">The log.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static void Fatal(this ILogger log, Exception exception, string message, params object[] parameters)
        {
            log.LogCritical(exception, message, parameters);
        }
    }
}
