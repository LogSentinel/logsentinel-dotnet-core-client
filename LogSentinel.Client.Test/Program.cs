using IO.Swagger.Client;
using IO.Swagger.Model;
using System;

namespace LogSentinel.Client.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LogSentinelClientBuilder builder = LogSentinelClientBuilder
                .create("", "", "");
            LogSentinelClient client = builder.build();

            try
            {
                var result = client.getAuditLogActions().LogUsingPOST1Async("actorId", "action", "details", "appId",
                    "", "auditLogEntry", "actorDispName", null, null, null
                );
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
               Console.WriteLine("Exception when calling AuditLogControllerApi#logAuthAction");
            }
        }
    }
}
