using System.Collections.Generic;

namespace LogSentinel.Client.Test
{
    class LogEntry
    {
        public string ActorName { get; set; }
        public string ActorId { get; set; }
        public List<string> ActorRoles { get; set; }

        public string Action { get; set; }
        public object ActionDetails { get; set; }
        public string EntryType { get; set; }
    }
}
