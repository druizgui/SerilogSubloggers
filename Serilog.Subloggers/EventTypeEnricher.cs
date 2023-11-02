using Serilog.Core;
using Serilog.Events;
using System;

namespace Serilog
{
    [Obsolete("Use 'SubloggerEnricher' instead of this class")]
    public class EventTypeEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var eventId = propertyFactory.CreateProperty("EventType", Environment.MachineName);
            logEvent.AddPropertyIfAbsent(eventId);
        }
    }
}
