## LogSentinel DotNet Core Client


```
       public static void LogEntry()
        {
            LogSentinelClientBuilder builder = LogSentinelClientBuilder
                .create(applicationId, organizationId, secret);

            LogSentinelClient client = builder.build();    

            try
            {
                var result = client.getAuditLogActions().LogUsingPOST1(
                    new ActorData().setActorDisplayName(actorName).setActorRoles(actorRoles).setActorId(actorId),
                    new ActionData().setDetails(details).setAction(act), applicationId,
                    signature, entryType, null, null
                );

                Console.WriteLine(result.LogEntryId);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuditLogControllerApi#logAuthAction");
            }
        }
```