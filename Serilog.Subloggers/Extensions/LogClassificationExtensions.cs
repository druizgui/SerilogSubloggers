using System;

namespace Microsoft.Extensions.Logging
{
    public static class LogClassificationExtensions
    {
        /// <summary>Verboses the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        public static ILogger Verbose(this LogClassification log, string message)
        {
            log.Logger.LogDebug(log.Event, message);
            return log.Logger;
        }

        /// <summary>Verboses the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Verbose(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Verboses the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Verbose(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogDebug(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Verboses the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Verbose(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Debugs the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        public static ILogger Debug(this LogClassification log, string message)
        {
            log.Logger.LogDebug(log.Event, message);
            return log.Logger;
        }

        /// <summary>Debugs the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Debug(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Debugs the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Debug(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogDebug(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Debugs the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Debug(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogDebug(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        public static ILogger Information(this LogClassification log, string message)
        {
             log.Logger.LogInformation(log.Event, message);
            return log.Logger;
        }


        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Information(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Information(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogInformation(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Information(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        public static ILogger Info(this LogClassification log, string message)
        {
            log.Logger.LogInformation(log.Event, message);
            return log.Logger;
        }

        /// <summary>Informations the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Info(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Info(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogInformation(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Informations the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Info(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogInformation(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Warnings the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        public static ILogger Warning(this LogClassification log, string message)
        {
            log.Logger.LogWarning(log.Event, message);
            return log.Logger;
        }

        /// <summary>Warnings the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Warning(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogWarning(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Warnings the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Warning(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogWarning(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Warnings the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Warning(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogWarning(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Errors the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        public static ILogger Error(this LogClassification log, string message)
        {
            log.Logger.LogError(log.Event, message);
            return log.Logger;
        }

        /// <summary>Errors the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Error(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogError(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Errors the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Error(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogError(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Errors the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Error(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogError(log.Event, exception, message, parameters);
            return log.Logger;
        }

        /// <summary>Fatals the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        public static ILogger Fatal(this LogClassification log, string message)
        {
            log.Logger.LogCritical(log.Event, message);
            return log.Logger;
        }

        /// <summary>Fatals the specified message.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Fatal(this LogClassification log, string message, params object[] parameters)
        {
            log.Logger.LogCritical(log.Event, message, parameters);
            return log.Logger;
        }

        /// <summary>Fatals the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public static ILogger Fatal(this LogClassification log, Exception exception, string message)
        {
            log.Logger.LogCritical(log.Event, exception, message);
            return log.Logger;
        }

        /// <summary>Fatals the specified exception.</summary>
        /// <param name="log">The log.Logger.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public static ILogger Fatal(this LogClassification log, Exception exception, string message, params object[] parameters)
        {
            log.Logger.LogCritical(log.Event, exception, message, parameters);
            return log.Logger;
        }

        
    }
}
