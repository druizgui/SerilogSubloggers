 namespace Microsoft.Extensions.Logging
{
    public static class LoggerClassificationExtensions
    {
        /// <summary> Use a Sublogger of type System </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as System log.</returns>
        public static LogClassification System(this ILogger log) => LogClassification.Factory(log, EventFactory.SystemFactory());

        /// <summary> Use a Sublogger of type Security </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as Security log.</returns>
        public static LogClassification Security(this ILogger log) => LogClassification.Factory(log, EventFactory.SecurityFactory());

        /// <summary> Use a Sublogger of type Analytics </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as Analytics log.</returns>
        public static LogClassification Analytics(this ILogger log) => LogClassification.Factory(log, EventFactory.AnalyticsFactory());

        /// <summary> Use a Sublogger of type Business </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as Business log.</returns>
        public static LogClassification Business(this ILogger log) => LogClassification.Factory(log, EventFactory.BusinessFactory());

        /// <summary> Use a Sublogger of type Erros </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as TimeMetrics log.</returns>
        public static LogClassification Errors(this ILogger log) => LogClassification.Factory(log, EventFactory.ErrorsFactory());

        /// <summary> Use a Sublogger of type TimeMetrics </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as TimeMetrics log.</returns>
        public static LogClassificationTimeMetrics Time(this ILogger log, string name) => new LogClassificationTimeMetrics(log, name);

        /// <summary> Use a Sublogger of type TimeMetrics </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as TimeMetrics log.</returns>
        public static LogClassificationTimeMetrics Time<T>(this ILogger log, string name) => new LogClassificationTimeMetrics(log, $"{typeof(T).FullName}.{name}");

        /// <summary> Use a Sublogger of type TimeMetrics </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as TimeMetrics log.</returns>
        public static LogClassificationTimeMetrics Time<T>(this ILogger log) => new LogClassificationTimeMetrics(log, $"{typeof(T).FullName}");
    }
}
