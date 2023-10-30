namespace Serilog
{
    public class TimeMetricsEventFilter : EventFilterBase
    {
        public override string FilterName => ClassificationLogs.TimeMetrics;
    }
}
