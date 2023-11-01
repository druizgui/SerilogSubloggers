using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Subloggers.Tests;

namespace Microsoft.Extensions.Logging.Tests
{
    [TestClass()]
    public class LogClassificationTimeMetricsExtensionsTests
    {
        [TestMethod()]
        public void Write()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Time("TM-TEST").Write(LogLevel.Trace, TimeSpan.FromSeconds(2));
            foreach (var item in instance.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" && p.Message != null && p.Message.Contains("TM-TEST")));
        }

        [TestMethod()]
        public void Verbose()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Time("TM-TEST").Verbose(TimeSpan.FromSeconds(2));
            foreach (var item in instance.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" 
                && p.LogLevel == LogLevel.Debug && p.Message != null && p.Message.Contains("TM-TEST")));
        }

        [TestMethod()]
        public void Debug()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Time("TM-TEST").Debug(TimeSpan.FromSeconds(2));
            foreach (var item in instance.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics"
                && p.LogLevel == LogLevel.Debug&& p.LogLevel == LogLevel.Debug && p.Message != null && p.Message.Contains("TM-TEST")));
        }

        [TestMethod()]
        public void Information()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Time("TM-TEST").Information(TimeSpan.FromSeconds(2));
            foreach (var item in instance.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics"
                && p.LogLevel == LogLevel.Information && p.Message != null && p.Message.Contains("TM-TEST")));
        }

        [TestMethod()]
        public void Info()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Time("TM-TEST").Info(TimeSpan.FromSeconds(2));
            foreach (var item in instance.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" 
                && p.LogLevel == LogLevel.Information && p.Message != null && p.Message.Contains("TM-TEST")));
        }

        [TestMethod()]
        public void Warning()
        {
            TestLogger instance = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.ILogger log = instance;
            log.Time("TM-TEST").Warning(TimeSpan.FromSeconds(2));
            foreach (var item in instance.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");
            Assert.IsNotNull(instance.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" 
                && p.LogLevel == LogLevel.Warning && p.Message != null && p.Message.Contains("TM-TEST")));
        }
    }
}