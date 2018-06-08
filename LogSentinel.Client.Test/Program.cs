using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;
using System;

namespace LogSentinel.Client.Test
{
    class Program
    {
        public enum EntryType
        {

        }

        public static void test()
        {
            LogSentinelClientBuilder builder = LogSentinelClientBuilder
                .create("38773350-6a64-11e8-a7b3-cfa432063561", "387648f0-6a64-11e8-a7b3-cfa432063561",
                "bedaac15925a2e46eed80d5b5276fd91764d3ea4fb5ac2b44bd6e06e4c83be87");

            LogSentinelClient client = builder.build();
            

            try
            {
                var result = client.getAuditLogActions().LogUsingPOST1(
                    new ActorData().setActorDisplayName("ActorName").setActorRoles("ActorRoles").setActorId("0885"),
                    new ActionData().setDetails("{\"test\"}").setAction("act"), "38773350-6a64-11e8-a7b3-cfa432063561",
                    "", "BUSINESS_LOGIC_ENTRY", null, null
                );

                Console.WriteLine(result.LogEntryId);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuditLogControllerApi#logAuthAction" + e.Message + e.StackTrace);
            }
        }
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
    }
}
