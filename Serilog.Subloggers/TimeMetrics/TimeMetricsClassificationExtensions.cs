namespace Microsoft.Extensions.Logging
{
    public static class TimeMetricsClassificationExtensions
    {
        public static LogElapsedTimer TimeMetrics(this ILogger log, string name)
        {
            return new LogElapsedTimer(log, name, new EventId(1, ClassificationLogs.TimeMetrics));
        }

        public static LogElapsedTimer TimeMetrics<T>(this ILogger log, string name)
        {
            return new LogElapsedTimer(log, $"{typeof(T).FullName}.{name}", new EventId(1, ClassificationLogs.TimeMetrics));
        }

        public static LogElapsedTimer TimeMetrics<T>(this ILogger log) where T : class
        {
            return new LogElapsedTimer(log, $"{typeof(T).FullName}", new EventId(1, ClassificationLogs.TimeMetrics));
        }
    }
}