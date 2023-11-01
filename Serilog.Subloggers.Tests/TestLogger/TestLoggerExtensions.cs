using Microsoft.Extensions.Logging;

namespace Serilog.Subloggers.Tests
{
    internal static class TestLoggerExtensions
    {
        public static void AssertContains(this TestLogger logger, LogLevel level, string message)
        {
            Assert.IsNotNull(logger.logEntries.FirstOrDefault(p => p.LogLevel == level && p.Message == message));
        }

        public static void AssertContainsException(this TestLogger logger, LogLevel level, string message, string messageEx)
        {
            var item = logger.logEntries.FirstOrDefault(p => p.LogLevel == level && p.Message == message);
            
            Assert.IsNotNull(item);
            Assert.IsNotNull(item.Exception);
            Assert.AreEqual(messageEx, item.Exception.Message);
        }
    }
}