using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LogSentinel.Client
{
    public class JsonBodySerializer : BodySerializer
    {
        private object json;

        public JsonBodySerializer(object json)
        {
            this.json = json;
        }

        public bool encryptionKeySet()
        {
            return false;
        }
        
        public String serialize(Object tobject)
        {
            return JsonConvert.SerializeObject(tobject);
        }
    }
}
