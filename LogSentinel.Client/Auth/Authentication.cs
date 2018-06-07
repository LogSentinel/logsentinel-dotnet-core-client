using System;
using System.Collections.Generic;
using System.Text;

namespace LogSentinel.Client.Auth
{
    public interface Authentication
    {
        /**
         * Apply authentication settings to header and query params.
         *
         * @param queryParams List of query parameters
         * @param headerParams Map of header parameters
         */
        void applyToParams(List<Pair> queryParams, Dictionary<String, String> headerParams);
    }
}
