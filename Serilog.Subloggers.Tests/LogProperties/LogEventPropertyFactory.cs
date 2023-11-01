using Serilog.Events;

namespace Serilog.Subloggers.Tests
{
    public partial class EventTypeEnricherTests
    {
        internal class LogEventPropertyFactory : Serilog.Core.ILogEventPropertyFactory
        {
            public LogEventProperty CreateProperty(string prop, object? value, bool destructureObjects = false)
            {
                return new LogEventProperty(prop, new StructureValue(new[] { new LogEventProperty("Name", new TestLogEventPropertyValue()) }));
            }

            public LogEventProperty CreateProperty(string prop, string name, object? value, bool destructureObjects = false)
            {
                if (value!=null)
                    return new LogEventProperty(prop, new StructureValue(new[] { new LogEventProperty(name, new TestLogEventPropertyValue(value.ToString())) }));

                return new LogEventProperty(prop, new StructureValue(new[] { new LogEventProperty(name, new TestLogEventPropertyValue()) }));
            }
        }
    }
}