using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LogSentinel.Client.Auth
{
    class HttpBasicAuth : Authentication
    {
        private String username;
        private String password;

        public String getUsername()
        {
            return username;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void applyToParams(List<Pair> queryParams, Dictionary<String, String> headerParams)
        {
            if (username == null && password == null)
            {
                return;
            }
            headerParams.Add("Authorization", username + ":" + password);
        }
    }
}
