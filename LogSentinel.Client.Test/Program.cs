using LogSentinel.Client.Model;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using Org.BouncyCastle.Math;
using System.Text;
using Newtonsoft.Json;

namespace LogSentinel.Client.Test
{
    class Program
    {
        public static void LogEntry()
        {
            LogSentinelClientBuilder builder = LogSentinelClientBuilder
                .create("38773350-6a64-11e8-a7b3-cfa432063561", "387648f0-6a64-11e8-a7b3-cfa432063561",
                "bedaac15925a2e46eed80d5b5276fd91764d3ea4fb5ac2b44bd6e06e4c83be87");

            builder.setEncryptionKey(Convert.FromBase64String("NWFhMTQ0YWI3ZmU5YTJmNDk2MmVhZmU2ZTFkZWUzNWQ="));

            LogSentinelClient client = builder.build();

            // RsaKeyParameters k = new RsaKeyParameters(true, new BigInteger("11111"), new BigInteger("111"));
            var luceneEnc = new LuceneEncryptingKeywordExtractor(Encoding.ASCII.GetBytes("test"));
            luceneEnc.extract(JsonConvert.SerializeObject(new Consent() { AdditionalDetails = "1" }));


            try
            {
                var result = client.getAuditLogActions().LogUsingPOST(
                    new ActorData().setActorDisplayName("ActorName").setActorRoles("ActorRoles").setActorId("0885"),
                    new ActionData().setDetails(new Consent() { AdditionalDetails = "1" }).setAction("act")
                        .setEntryType("BUSINESSLOGICENTRY"), 
                    "38773350-6a64-11e8-a7b3-cfa432063561"
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
