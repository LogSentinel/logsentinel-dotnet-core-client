using System;
using System.Collections.Generic;
using System.Text;

namespace LogSentinel.Client.Auth
{
    class ApiKeyAuth : Authentication
    {
        private String location;
        private String paramName;

        private String apiKey;
        private String apiKeyPrefix;

        public ApiKeyAuth(String location, String paramName)
        {
            this.location = location;
            this.paramName = paramName;
        }

        public String getLocation()
        {
            return location;
        }

        public String getParamName()
        {
            return paramName;
        }

        public String getApiKey()
        {
            return apiKey;
        }

        public void setApiKey(String apiKey)
        {
            this.apiKey = apiKey;
        }

        public String getApiKeyPrefix()
        {
            return apiKeyPrefix;
        }

        public void setApiKeyPrefix(String apiKeyPrefix)
        {
            this.apiKeyPrefix = apiKeyPrefix;
        }

        public void applyToParams(List<Pair> queryParams, Dictionary<String, String> headerParams)
        {
            if (apiKey == null)
            {
                return;
            }
            String value;
            if (apiKeyPrefix != null)
            {
                value = apiKeyPrefix + " " + apiKey;
            }
            else
            {
                value = apiKey;
            }
            if ("query".Equals(location))
            {
                queryParams.Add(new Pair(paramName, value));
            }
            else if ("header".Equals(location))
            {
                headerParams.Add(paramName, value);
            }
        }
    }
}
