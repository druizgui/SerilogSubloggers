namespace Serilog
{
    public class AnalyticsEventFilter : EventFilterBase
    {
        public override string FilterName => ClassificationLogs.Analytics;
    }
}
