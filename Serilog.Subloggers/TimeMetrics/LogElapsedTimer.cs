using System;
using System.Diagnostics;

namespace Microsoft.Extensions.Logging
{
    public class LogElapsedTimer : IDisposable
    {
        Stopwatch watch;

        internal ILogger Log;
        internal string Name;
        internal EventId EventId;

        public LogElapsedTimer(ILogger log, string name, EventId? eventId = null)
        {
            this.Name = name;
            watch = new Stopwatch();
            EventId = eventId ?? new EventId(1, ClassificationLogs.TimeMetrics);
            Log = log;
            watch.Start();
        }

        public void Dispose()
        {
            watch.Stop();
            Log.LogInformation(EventId, TimeMetricLogFormatter(Name, watch.Elapsed));
        }

        internal static string TimeMetricLogFormatter(string name, TimeSpan elapsed)
        {
            return $"{name}\tElapsed:\t{elapsed:hh\\:mm\\:ss\\.fff}";
        }
    }
}