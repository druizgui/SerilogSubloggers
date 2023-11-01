namespace Serilog.Subloggers.Tests
{
    [TestClass]
    public class ClassificationLogsTests
    {
        [TestMethod]
        public void ClassificationLogsSystem()
        {
            Assert.AreEqual("System", ClassificationLogs.System);
        }
        [TestMethod]
        public void ClassificationLogsSecurity()
        {
            Assert.AreEqual("Security", ClassificationLogs.Security);
        }
        [TestMethod]
        public void ClassificationLogsBusiness()
        {
            Assert.AreEqual("Business", ClassificationLogs.Business);
        }
        [TestMethod]
        public void ClassificationLogsAnalytics()
        {
            Assert.AreEqual("Analytics", ClassificationLogs.Analytics);
        }
        [TestMethod]
        public void ClassificationLogsTimeMetrics()
        {
            Assert.AreEqual("TimeMetrics", ClassificationLogs.TimeMetrics);
        }
    }
}