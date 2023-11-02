using System;

namespace Microsoft.Extensions.Logging
{
    internal static class EventFactory
    {
        private static int NewEventId = 6;

        internal static EventId TimeMetricsFactory() => new EventId(1, ClassificationLogs.TimeMetrics);
        internal static EventId SystemFactory() => new EventId(2, ClassificationLogs.System);
        internal static EventId SecurityFactory() => new EventId(3, ClassificationLogs.Security);
        internal static EventId AnalyticsFactory() => new EventId(4, ClassificationLogs.Analytics);
        internal static EventId BusinessFactory() => new EventId(5, ClassificationLogs.Business);
        internal static EventId ErrorsFactory() => new EventId(6, ClassificationLogs.Errors);

        internal static EventId CustomSubloggerFactory(string subloggerName)
        {
            if (string.IsNullOrWhiteSpace(subloggerName)) throw new ArgumentException("'name' must be a valid value in CustomSubloggerFactory", nameof(subloggerName));
            
            NewEventId++;

            return new EventId(NewEventId, subloggerName);
        }
    }
}
