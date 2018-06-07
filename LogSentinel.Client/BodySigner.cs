using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace LogSentinel.Client
{
    public class BodySigner
    {
        private RsaKeyParameters privateKey;

        public BodySigner(RsaKeyParameters privateKey)
        {
            this.privateKey = privateKey;
        }

        public String computeSignature(String requestBody)
        {
            ISigner sig = SignerUtilities.GetSigner("RSA");
            try
            {
                sig.Init(true, privateKey);

                var bytes = Encoding.UTF8.GetBytes(requestBody);

                sig.BlockUpdate(bytes, 0, bytes.Length);
                byte[] signature = sig.GenerateSignature();
                
                return Convert.ToBase64String(signature);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
