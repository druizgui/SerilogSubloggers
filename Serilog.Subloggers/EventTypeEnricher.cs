using Serilog.Core;
using Serilog.Events;
using System;

namespace Serilog
{
    public class EventTypeEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var eventId = propertyFactory.CreateProperty("EventType", Environment.MachineName);
            logEvent.AddPropertyIfAbsent(eventId);
        }
    }
}
