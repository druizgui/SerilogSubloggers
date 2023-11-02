namespace Serilog.Subloggers.Tests
{
    [TestClass]
    public class EventFilterTests
    {
        [TestMethod]
        public void Security()
        {
            var filter = new SecurityEventFilter();
            Assert.AreEqual(ClassificationLogs.Security, filter.FilterName);
        }

        [TestMethod]
        public void System()
        {
            var filter = new SystemEventFilter();
            Assert.AreEqual(ClassificationLogs.System, filter.FilterName);
        }

        [TestMethod]
        public void Business()
        {
            var filter = new BusinessEventFilter();
            Assert.AreEqual(ClassificationLogs.Business, filter.FilterName);
        }

        [TestMethod]
        public void Analytics()
        {
            var filter = new AnalyticsEventFilter();
            Assert.AreEqual(ClassificationLogs.Analytics, filter.FilterName);
        }

        [TestMethod]
        public void Errors()
        {
            var filter = new ErrorsEventFilter();
            Assert.AreEqual(ClassificationLogs.Errors, filter.FilterName);
        }

        [TestMethod]
        public void TimeMetrics()
        {
            var filter = new TimeMetricsEventFilter();
            Assert.AreEqual(ClassificationLogs.TimeMetrics, filter.FilterName);
        }
    }
}