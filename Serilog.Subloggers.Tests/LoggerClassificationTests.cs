using Microsoft.Extensions.Logging;
using System.Linq;

namespace Serilog.Subloggers.Tests
{
    [TestClass]
    public class LoggerClassificationTests
    {
        [TestMethod]
        public void LogClassification()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;

            log.System().Information("System message");
            log.Security().Information("Security message");
            log.Business().Information("Business message");
            log.Analytics().Information("Analytics message");
            log.Errors().Error("Errors message");
            using (log.TimeMetrics<LoggerClassificationTests>()) { }
            using (log.TimeMetrics<Serilog.ILogger>("TestName")) { }
            using (log.TimeMetrics("SingleTestName")) { }

            foreach (var item in instance.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");
            

            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "System" && p.Message == "System message"));
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "Security" && p.Message == "Security message"));
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "Business" && p.Message == "Business message"));
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "Analytics" && p.Message == "Analytics message"));
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" && p.Message != null && p.Message.Contains("Serilog.Subloggers.Tests.LoggerClassificationTests")));
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" && p.Message != null && p.Message.Contains("Serilog.ILogger.TestName")));
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" && p.Message != null && p.Message.Contains("SingleTestName")));
        }

        [TestMethod]
        public void LogClassification_TimeMetrics()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            
            var result = log.Time("Test time metric");
            Assert.IsInstanceOfType(result, typeof(LogClassificationTimeMetrics));
            Assert.AreEqual("Test time metric", result.Name);

            result = log.Time<ILogger>();
            Assert.IsInstanceOfType(result, typeof(LogClassificationTimeMetrics));
            Assert.AreEqual("Serilog.ILogger", result.Name);

            result = log.Time<Serilog.ILogger>("Name");
            Assert.IsInstanceOfType(result, typeof(LogClassificationTimeMetrics));
            Assert.AreEqual("Serilog.ILogger.Name", result.Name);
        }
    }
}