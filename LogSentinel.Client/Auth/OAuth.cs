using System;
using System.Collections.Generic;
using System.Text;

namespace LogSentinel.Client.Auth
{
    class OAuth
    {
        private String accessToken;

        public String getAccessToken()
        {
            return accessToken;
        }

        public void setAccessToken(String accessToken)
        {
            this.accessToken = accessToken;
        }

        public void applyToParams(List<Pair> queryParams, Dictionary<String, String> headerParams)
        {
            if (accessToken != null)
            {
                headerParams.Add("Authorization", "Bearer " + accessToken);
            }
        }
    }
}
