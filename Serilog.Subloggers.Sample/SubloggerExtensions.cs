using Microsoft.Extensions.Logging;

namespace Serilog.Subloggers.Sample
{
    public static class SubloggerExtensions
    {
        public const string MyCustomKey = "Custom";
        /// <summary> Use a Sublogger of type System </summary>
        /// <param name="log">ILogger instance</param>
        /// <returns>An instance of Sublogger for use as System log.</returns>
        public static LogClassification MyCustom(this Microsoft.Extensions.Logging.ILogger log) => LogClassification.CustomSubloggerFactory(log, MyCustomKey);
    }
}