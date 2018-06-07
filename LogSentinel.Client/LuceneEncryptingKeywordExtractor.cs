using LogSentinel.Client.Util;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Analysis.Tokenattributes;
using System;
using System.Collections.Generic;
using System.IO;

namespace LogSentinel.Client
{
    class LuceneEncryptingKeywordExtractor : EncryptingKeywordExtractor
    {
        private static Analyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_CURRENT);

        private byte[] encryptionKey;

        public LuceneEncryptingKeywordExtractor(byte[] encryptionKey)
        {
            this.encryptionKey = encryptionKey;
        }

        public List<string> extract(string text)
        {
            List<string> result = new List<string>();

            try
            {
                TokenStream stream = analyzer.TokenStream(null, new StringReader(text));
                stream.Reset();
                
                while (stream.IncrementToken())
                {
                    result.Add(encrypt(stream.GetAttribute<TermAttribute>().ToString()));
                }
            }
            catch (IOException e)
            {
                throw new IOException(e.Message);
            }

            return result;
        }

        private string encrypt(string keyWord)
        {
            if (encryptionKey == null)
            {
                return keyWord;
            }
            try
            {
                return EncryptUtil.encrypt(keyWord, encryptionKey, false);
            }
            catch (Exception e)
            {
                throw new Exception("Failed to perform keyword encryption", e);
            }
        }
    }
}
