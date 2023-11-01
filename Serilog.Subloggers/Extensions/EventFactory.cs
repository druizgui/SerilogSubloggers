namespace Microsoft.Extensions.Logging
{
    internal static class EventFactory
    {
        internal static EventId Factory(int id, string type) => new EventId(id, type);
        internal static EventId TimeMetricsFactory() => new EventId(1, ClassificationLogs.TimeMetrics);
        internal static EventId SystemFactory() => new EventId(2, ClassificationLogs.System);
        internal static EventId SecurityFactory() => new EventId(3, ClassificationLogs.Security);
        internal static EventId AnalyticsFactory() => new EventId(4, ClassificationLogs.Analytics);
        internal static EventId BusinessFactory() => new EventId(4, ClassificationLogs.Business);
    }
}
