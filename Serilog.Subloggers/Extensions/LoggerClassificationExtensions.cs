 namespace Microsoft.Extensions.Logging
{
    public static class LoggerClassificationExtensions
    {
        /// <summary> Use a Sublogger of type System </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as System log.</returns>
        public static LogClassification System(this ILogger log) => LogClassification.Factory(2, ClassificationLogs.System, log);

        /// <summary> Use a Sublogger of type Security </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as Security log.</returns>
        public static LogClassification Security(this ILogger log) => LogClassification.Factory(3, ClassificationLogs.Security, log);

        /// <summary> Use a Sublogger of type Analytics </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as Analytics log.</returns>
        public static LogClassification Analytics(this ILogger log) => LogClassification.Factory(4, ClassificationLogs.Analytics, log);

        /// <summary> Use a Sublogger of type Business </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as Business log.</returns>
        public static LogClassification Business(this ILogger log) => LogClassification.Factory(5, ClassificationLogs.Business, log);
    }
}
