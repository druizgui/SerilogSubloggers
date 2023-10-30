using System;
using System.Diagnostics;

namespace Microsoft.Extensions.Logging
{
    public class LogElapsedTimer : IDisposable
    {
        Stopwatch watch;

        private ILogger Log;
        private string Name;
        private EventId EventId;

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
            Log.LogInformation(EventId, $"{Name}. Elapsed: {watch.Elapsed:hh\\:mm\\:ss\\.fff}");
        }
    }
}