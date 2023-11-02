namespace Serilog
{
    public class ErrorsEventFilter : EventFilterBase
    {
        public override string FilterName => ClassificationLogs.Errors;
    }
}
