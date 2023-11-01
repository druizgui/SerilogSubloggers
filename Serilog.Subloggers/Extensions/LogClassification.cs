using System;

namespace Microsoft.Extensions.Logging
{
    public class LogClassificationBase
    {
        public EventId Event
        {
            get; private set;
        }
        public ILogger Logger
        {
            get; private set;
        }

        public LogClassificationBase(ILogger logger, EventId eventId)
        {
            if (logger == null) throw new ArgumentNullException("logger can't be null in LogClassification ctor", nameof(logger));
            if (string.IsNullOrWhiteSpace(eventId.Name)) throw new ArgumentException("eventId.Name must be a valid value in LogClassification ctor", nameof(eventId.Name));

            Event = eventId;
            Logger = logger;
        }

    }
    public class LogClassification : LogClassificationBase
    {
        public LogClassification(ILogger logger, EventId eventId) :base(logger, eventId)
        {
        }

        public static LogClassification Factory(int id, string type, ILogger logger)
        {
            if (logger == null) throw new ArgumentNullException("logger can't be null in LogClassification Factory", nameof(logger));
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("'type' must be a valid value in LogClassification Factory", nameof(type));
            return new LogClassification(logger, new EventId(id, type));
        }

        public static LogClassification Factory(ILogger logger, EventId eventId)
        {
            return new LogClassification(logger, eventId);
        }
    }
}
