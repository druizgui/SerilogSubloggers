namespace Microsoft.Extensions.Logging
{
    public static class LoggerClassificationExtensions
    {
        public static LogClassification System(this ILogger log) => LogClassification.Factory(2, ClassificationLogs.System, log);
        public static LogClassification Security(this ILogger log) => LogClassification.Factory(3, ClassificationLogs.Security, log);
        public static LogClassification Analytics(this ILogger log) => LogClassification.Factory(4, ClassificationLogs.Analytics, log);
        public static LogClassification Business(this ILogger log) => LogClassification.Factory(5, ClassificationLogs.Business, log);
    }
}
