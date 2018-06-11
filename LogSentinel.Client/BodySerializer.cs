using System;
using System.Collections.Generic;
using System.Text;

namespace LogSentinel.Client
{
    public interface BodySerializer
    {
        String serialize(Object tobject);
        bool encryptionKeySet();
    }
}
