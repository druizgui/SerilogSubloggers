namespace Serilog.Subloggers.Sample
{
    public class MyCustomEventFilter : EventFilterBase
    {
        public override string FilterName => SubloggerExtensions.MyCustomKey;
    }
}