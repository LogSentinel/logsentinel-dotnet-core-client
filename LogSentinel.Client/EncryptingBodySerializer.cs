using LogSentinel.Client.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogSentinel.Client
{
    class EncryptingBodySerializer : BodySerializer
    {
        private byte[] encryptionKey;
        private BodySerializer originalSerializer;

        public EncryptingBodySerializer(byte[] encryptionKey, BodySerializer originalSerializer)
        {
            this.encryptionKey = encryptionKey;
            this.originalSerializer = originalSerializer;
        }

        public String serialize(Object tobject)
        {
            String content = originalSerializer.serialize(tobject);
            return encryptConent(content, encryptionKey);

        }

        private String encryptConent(String content, byte[] encryptionKey)
        {
            try
            {
                return EncryptUtil.encrypt(content, encryptionKey, true);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to perform symmetric encryption", ex);
            }
        }
    }
}
