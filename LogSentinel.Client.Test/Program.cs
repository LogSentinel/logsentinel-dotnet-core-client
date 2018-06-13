using System;
using LogSentinel.Client.Model;

namespace LogSentinel.Client.Test
{
    class Program
    {
        public static void LogEntry()
        {
            LogSentinelClientBuilder builder = LogSentinelClientBuilder
                .create("applicationId", "organizationId",
                "secret");

            builder.setEncryptionKey(Convert.FromBase64String("NWFhMTQ0YWI3ZmU5YTJmNDk2MmVhZmU2ZTFkZWUzNWQ="));

            LogSentinelClient client = builder.build();

            try
            {
                var logEntry = new LogEntry
                {
                    ActorName = "John Doe",
                    ActorId = "1234-5678",
                    ActorRoles = new System.Collections.Generic.List<string> { "CTO", "CEO" },

                    Action = "Sample action",
                    ActionDetails = new Consent() { AdditionalDetails = "1", DataSubjectId = "1234" },
                    EntryType = "BUSINESS_LOGIC_ENTRY"
                };

                var result = client.getAuditLogActions().LogUsingPOST(
                    new ActorData().setActorDisplayName(logEntry.ActorName).setActorRoles(logEntry.ActorRoles)
                        .setActorId(logEntry.ActorId),
                    new ActionData().setDetails(logEntry.ActionDetails).setAction(logEntry.Action)
                        .setEntryType(logEntry.EntryType), 
                    "applicationId"
                );

                Console.WriteLine(result.LogEntryId);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuditLogControllerApi#logAuthAction");
            }
        }

        static void Main(string[] args)
        {
            LogEntry();
            Console.ReadKey();
        }
    }
}
