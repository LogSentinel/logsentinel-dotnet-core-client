using System;
using System.Text;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace LogSentinel.Client.Util
{
    class EncryptUtil
    {
        private static byte[] _iv = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static String encrypt(String data, byte[] encryptionKey, bool appendRandomBlock)
        {

            AesEngine engine = new AesEngine();
            CbcBlockCipher blockCipher = new CbcBlockCipher(engine);
            PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(blockCipher);
            KeyParameter keyParam = new KeyParameter(encryptionKey);
            ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, _iv, 0, 16);
            
            cipher.Init(true, keyParamWithIV);
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            byte[] encValue;


            if (appendRandomBlock)
            {
                //using same IV with random beginning block of bytes is as secure as using random IV
                byte[] withRandomStart = appendRandomBeginning(bytes, (encryptionKey.Length / 8) + 12);
                encValue = cipher.DoFinal(withRandomStart);

            }
            else
            {
                encValue = cipher.DoFinal(bytes);
            }

            String result = Convert.ToBase64String(encValue);

            return result;
        }

        private static byte[] appendRandomBeginning(byte[] original, int lenght)
        {
            byte[] random = new byte[lenght];
            new Random().NextBytes(random);

            byte[] result = new byte[random.Length + original.Length];
            Array.Copy(random, 0, result, 0, random.Length);
            Array.Copy(original, 0, result, random.Length, original.Length);

            return result;
        }
    }
}
