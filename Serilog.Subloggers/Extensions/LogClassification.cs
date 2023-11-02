using System;

namespace Microsoft.Extensions.Logging
{
    public class LogClassification : LogClassificationBase
    {
        public LogClassification(ILogger logger, EventId eventId) : base(logger, eventId)
        {
        }

        public static LogClassification Factory(int id, string type, ILogger logger)
        {
            if (logger == null) throw new ArgumentNullException("logger can't be null in LogClassification Factory", nameof(logger));
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("'type' must be a valid value in LogClassification Factory", nameof(type));
            return new LogClassification(logger, new EventId(id, type));
        }

        internal static LogClassification Factory(ILogger logger, EventId eventId)
        {
            return new LogClassification(logger, eventId);
        }

        public static LogClassification CustomSubloggerFactory(ILogger logger, string subloggerName)
        {
            if (logger == null) throw new ArgumentNullException("logger can't be null in LogClassification Factory", nameof(logger));
            if (string.IsNullOrWhiteSpace(subloggerName)) throw new ArgumentException("'name' must be a valid value in CustomSubloggerFactory", nameof(subloggerName));

            return new LogClassification(logger, EventFactory.CustomSubloggerFactory(subloggerName));
        }
    }
}
