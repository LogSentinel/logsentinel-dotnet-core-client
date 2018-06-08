## LogSentinel DotNet Core Client

[![Build Status](https://travis-ci.org/LogSentinel/logsentinel-dotnet-core-client.svg?branch=master)](https://travis-ci.org/LogSentinel/logsentinel-dotnet-core-client)

### Getting started
First, please ensure that you have the DotNet Core SDK installed on your working environment. This project runs on DotNet core version 2.0.

The ```dotnet build``` command builds the project and all of its dependencies. 

Enter the _LogSentinel.Client_ folder (```cd LogSentinel.Client```) and run  the ```dotnet build``` command. 

You can find the compiled binary in the _bin/[Debug/Release]/netcoreapp2.0_ folder. Now you can add the LogSentinel.Client.dll file to your project's dependencies and use the LogSentinel C# API.

### Code sample
```csharp

using LogSentinel.Client.Model;

...

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
			applicationId
		);

		Console.WriteLine(result.LogEntryId);
	}
	catch (ApiException e)
	{
		Console.WriteLine("Exception when calling AuditLogControllerApi#logAuthAction");
	}
}
```
