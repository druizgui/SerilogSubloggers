namespace Serilog
{
    public class BusinessEventFilter : EventFilterBase
    {
        public override string FilterName => ClassificationLogs.Business;
    }
}
