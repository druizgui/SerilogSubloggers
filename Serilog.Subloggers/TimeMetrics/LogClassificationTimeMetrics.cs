namespace Microsoft.Extensions.Logging
{
    public class LogClassificationTimeMetrics : LogClassificationBase
    {
        public string Name { get; }

        public LogClassificationTimeMetrics(ILogger logger, string name) : base(logger, EventFactory.TimeMetricsFactory())
        {
            Name = name;
        }
    }
}
