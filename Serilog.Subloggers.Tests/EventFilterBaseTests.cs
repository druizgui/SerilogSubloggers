using Serilog.Events;
using System.Reflection.Emit;
using System;
using static Serilog.Subloggers.Tests.EventTypeEnricherTests;

namespace Serilog.Subloggers.Tests
{
    [TestClass]
    public class EventFilterBaseTests
    {
        [TestMethod]
        public void EventFilterBase_Enabled()
        {
            var filter = new TestEventFilter();
            var propertyFactory = new LogEventPropertyFactory();
            LogEventProperty eventId = propertyFactory.CreateProperty("EventId", new StructureValue(new[] { propertyFactory.CreateProperty("Name", null) }));

            var logEvent = new LogEvent(DateTime.Now, LogEventLevel.Information, null, MessageTemplate.Empty, new[] { eventId});
            
            Assert.IsTrue(filter.IsEnabled(logEvent));
        }

        [TestMethod]
        public void EventFilterBase_EventId_NoName()
        {
            var filter = new TestEventFilter();
            var propertyFactory = new LogEventPropertyFactory();
            LogEventProperty eventId = propertyFactory.CreateProperty("EventId", "No", new StructureValue(new[] { propertyFactory.CreateProperty("Test", null) }));

            var logEvent = new LogEvent(DateTime.Now, LogEventLevel.Information, null, MessageTemplate.Empty, new[] { eventId });

            Assert.IsFalse(filter.IsEnabled(logEvent));
        }


        [TestMethod]
        public void EventFilterBase_No_EventId()
        {
            var filter = new TestEventFilter();
            var propertyFactory = new LogEventPropertyFactory();
            LogEventProperty eventId = propertyFactory.CreateProperty("no", new StructureValue(new[] { propertyFactory.CreateProperty("Other","other", "Test") }));

            var logEvent = new LogEvent(DateTime.Now, LogEventLevel.Information, null, MessageTemplate.Empty, new[] { eventId });

            Assert.IsFalse(filter.IsEnabled(logEvent));
        }

        [TestMethod]
        public void EventFilterBase_EventId_NoProp()
        {
            var filter = new TestEventFilter();
            var propertyFactory = new LogEventPropertyFactory();
            LogEventProperty eventId = propertyFactory.CreateProperty("EventId","Other", new StructureValue(new[] { propertyFactory.CreateProperty("Other", "other", "val") }));
            var logEvent = new LogEvent(DateTime.Now, LogEventLevel.Information, null, MessageTemplate.Empty, new[] { eventId });

            Assert.IsFalse(filter.IsEnabled(logEvent));
        }


        [TestMethod]
        public void EventFilterBase_Enabled_False()
        {
            var filter = new TestEventFilter();
            var logEvent = new LogEvent(DateTime.Now, LogEventLevel.Information, null, MessageTemplate.Empty,
                new[] { new LogEventProperty("Disabled", new TestLogEventPropertyValue()) });
            Assert.IsFalse(filter.IsEnabled(logEvent));
        }
    }

    internal class TestEventFilter : EventFilterBase
    {
        public override string FilterName => "Test";
    }


}