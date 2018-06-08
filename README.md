## LogSentinel DotNet Core Client


```
       public static void LogEntry()
        {
            LogSentinelClientBuilder builder = LogSentinelClientBuilder
                .create(applicationId, organizationId, secret);

            LogSentinelClient client = builder.build();    

            try
            {
                var result = client.getAuditLogActions().LogUsingPOST(
                    new ActorData().setActorDisplayName(actorName).setActorRoles(actorRoles)
			.setActorId(actorId),
                    new ActionData().setDetails(details).setAction(act)
			.setEntryType(entryType), 
		    applicationId,
                );

                Console.WriteLine(result.LogEntryId);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuditLogControllerApi#logAuthAction");
            }
        }
```