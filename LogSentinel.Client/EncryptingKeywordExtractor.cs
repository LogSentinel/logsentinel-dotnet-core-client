using System;
using System.Collections.Generic;
using System.Text;

namespace LogSentinel.Client
{
    public interface EncryptingKeywordExtractor
    {

        List<String> extract(String text);
    }
}
