using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Context;
using Serilog.Subloggers.Tests;
using Serilog.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Microsoft.Extensions.Logging.Tests
{
    [TestClass()]
    public class LogElapsedTimerTests
    {
        [TestMethod()]
        public void LogElapsedTimer_Name()
        {
            var timer = new LogElapsedTimer(LoggerContext.TestFactory(), "test");
            Assert.IsNotNull(timer.Log);
            Assert.AreEqual("test", timer.Name);
            Assert.AreEqual(ClassificationLogs.TimeMetrics, timer.EventId.Name);
        }

        [TestMethod()]
        public void LogElapsedTimer_EventId()
        {
            var timer = new LogElapsedTimer(LoggerContext.TestFactory(), "test", new EventId(1, ClassificationLogs.TimeMetrics));
            Assert.IsNotNull(timer.Log);
            Assert.AreEqual("test", timer.Name);
            Assert.AreEqual(ClassificationLogs.TimeMetrics, timer.EventId.Name);
        }

        [TestMethod()]
        public void DisposeTest()
        {
            var log = LoggerContext.TestFactory();
            using (log.TimeMetrics("TestMetrics")) // Trace elapsed time in a time metric log event
            {
                Thread.Sleep(100);
            }

            foreach (var item in log.logEntries) Console.WriteLine($"[{item.EventId.Name}] {item.Message}");

            Assert.IsNotNull(log.logEntries.FirstOrDefault(p => p.EventId.Name == "TimeMetrics" && p.Message != null && p.Message.Contains("TestMetrics")));
        }
    }
}