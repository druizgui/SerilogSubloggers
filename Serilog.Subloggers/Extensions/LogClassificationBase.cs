using System;

namespace Microsoft.Extensions.Logging
{
    public class LogClassificationBase
    {
        public EventId Event { get; private set; }
        public ILogger Logger { get; private set; }

        public LogClassificationBase(ILogger logger, EventId eventId)
        {
            if (logger == null) throw new ArgumentNullException("logger can't be null in LogClassification ctor", nameof(logger));
            if (string.IsNullOrWhiteSpace(eventId.Name)) throw new ArgumentException("eventId.Name must be a valid value in LogClassification ctor", nameof(eventId.Name));

            Event = eventId;
            Logger = logger;
        }
    }
}
