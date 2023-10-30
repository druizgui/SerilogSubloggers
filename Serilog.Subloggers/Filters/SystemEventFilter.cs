namespace Serilog
{
    public class SystemEventFilter : EventFilterBase
    {
        public override string FilterName => ClassificationLogs.System;
    }
}
