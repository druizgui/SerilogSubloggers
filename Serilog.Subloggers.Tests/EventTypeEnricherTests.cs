using Serilog.Events;
using System.Reflection;

namespace Serilog.Subloggers.Tests
{
    [TestClass]
    public partial class EventTypeEnricherTests
    {
        [TestMethod]
        public void EventTypeEnricher()
        {
            var loggeBuilder = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.Debug()
                    .Enrich.With<EventTypeEnricher>();

            FieldInfo field = typeof(LoggerConfiguration).GetField("_enrichers", BindingFlags.Instance | BindingFlags.NonPublic);
            var _enrichers = field.GetValue(loggeBuilder) as List<Serilog.Core.ILogEventEnricher>;
            Assert.AreEqual(1, _enrichers.Count(p => p.GetType() == typeof(EventTypeEnricher)));
        }

        [TestMethod]
        public void Enrich()
        {
            var logEvent = new LogEvent(DateTime.Now, LogEventLevel.Information, null, MessageTemplate.Empty, new[] { new LogEventProperty("test", new TestLogEventPropertyValue()) });
            var propertyFactory = new LogEventPropertyFactory();

            var enricher = new EventTypeEnricher();
            enricher.Enrich(logEvent, propertyFactory);
        }
    }
}