using Microsoft.Extensions.Logging;
using Serilog.Core;
using Serilog.Events;
using System.Linq;

namespace Serilog
{
    public abstract class EventFilterBase : ILogEventFilter
    {
        public abstract string FilterName { get; }

        public bool IsEnabled(LogEvent logEvent)
        {
            if (logEvent.Properties.ContainsKey(nameof(EventId)))
            {
                StructureValue? propsValues = logEvent.Properties[nameof(EventId)] as StructureValue;

                if (propsValues != null)
                {
                    var result = propsValues.Properties.OfType<LogEventProperty>().Any(p => p.Name == "Name" && p.Value.ToString().Trim('"') == FilterName);
                    return result;
                }

                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
