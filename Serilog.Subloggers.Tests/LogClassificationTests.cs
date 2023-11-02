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

        [TestMethod]
        public void LogClassification_CustomSubloggerFactory()
        {
            var log = LoggerContext.TestFactory();
            var result = Microsoft.Extensions.Logging.LogClassification.CustomSubloggerFactory(log, "CustomSubloggerFactory");

            Assert.IsInstanceOfType(result, typeof(LogClassification));
            Assert.IsNotNull(result.Logger);
            Assert.AreEqual(7, result.Event.Id);
            Assert.AreEqual("CustomSubloggerFactory", result.Event.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LogClassification_CustomSubloggerFactory_Log_Null()
        {
            Microsoft.Extensions.Logging.LogClassification.CustomSubloggerFactory(null, "CustomSubloggerFactory");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogClassification_CustomSubloggerFactory_subloggerName_Null()
        {
            var log = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.LogClassification.CustomSubloggerFactory(log, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogClassification_CustomSubloggerFactory_subloggerName_Empty()
        {
            var log = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.LogClassification.CustomSubloggerFactory(log, "");
        }

        [TestMethod]
        public void LogClassification_Factory()
        {
            var log = LoggerContext.TestFactory();
            var result = Microsoft.Extensions.Logging.LogClassification.Factory(log, new EventId(100, "test"));
            Assert.IsInstanceOfType(result, typeof(LogClassification));
            Assert.IsNotNull(result.Logger);
            Assert.AreEqual(100, result.Event.Id);
            Assert.AreEqual("test", result.Event.Name);
        }

        [TestMethod]
        public void LogClassification_Factory2()
        {
            var log = LoggerContext.TestFactory();
            var result = Microsoft.Extensions.Logging.LogClassification.Factory(101, "test", log);
            Assert.IsInstanceOfType(result, typeof(LogClassification));
            Assert.IsNotNull(result.Logger);
            Assert.AreEqual(101, result.Event.Id);
            Assert.AreEqual("test", result.Event.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogClassification_Factory_Type_Null()
        {
            var log = LoggerContext.TestFactory();
            Microsoft.Extensions.Logging.LogClassification.Factory(1, null, log);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LogClassification_Factory_Log_Null()
        {
            Microsoft.Extensions.Logging.LogClassification.CustomSubloggerFactory(null, "test");
        }
    }
}