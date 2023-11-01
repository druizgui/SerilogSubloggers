using Serilog.Events;

namespace Serilog.Subloggers.Tests
{
    public partial class EventTypeEnricherTests
    {
        internal class TestLogEventPropertyValue : LogEventPropertyValue
        {
            public TestLogEventPropertyValue(string value = null)
            {
                Value = value ?? "Test";
            }

            public string Value { get; }

            public override void Render(TextWriter output, string? format = null, IFormatProvider? formatProvider = null) { output.Write(Value); }
        }
    }
}