using Microsoft.Extensions.Logging;

namespace Serilog.Subloggers.Tests
{
    [TestClass]
    public class LogClassificationTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LogClassification_Logger_Null()
        {
            new LogClassification(null, new EventId(1, "test)"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogClassification_EventId_Null()
        {
            new LogClassification(LoggerContext.Factory(), new EventId(-1, null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogClassification_EventId_Empty()
        {
            new LogClassification(LoggerContext.Factory(), new EventId(-1, ""));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogClassification_EventId_Space()
        {
            new LogClassification(LoggerContext.Factory(), new EventId(-1, " "));
        }

        [TestMethod]
        public void LogClassification()
        {
            var result = new LogClassification(LoggerContext.Factory(), new EventId(1, "test"));

            Assert.IsNotNull(result.Logger);
            Assert.AreEqual(1, result.Event.Id);
            Assert.AreEqual("test", result.Event.Name);
        }
    }
}