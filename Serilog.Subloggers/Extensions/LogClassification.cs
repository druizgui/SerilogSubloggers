namespace Microsoft.Extensions.Logging
{
    public class LogClassification 
    {
        public EventId Event { get; set; }
        public ILogger Logger { get; set; }

        public static LogClassification Factory(int id, string type, ILogger logger)
        {
            return new LogClassification
            {
                Event = new EventId(id, type),
                Logger = logger
            };
        }
    }
}
