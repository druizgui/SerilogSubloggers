namespace Serilog
{
    public class SecurityEventFilter : EventFilterBase
    {
        public override string FilterName => ClassificationLogs.Security;
    }
}
