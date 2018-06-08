﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using IO.Swagger.Client;
using IO.Swagger.Api;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace LogSentinel.Client
{
    public class LogSentinelClientBuilder
    {

        private String applicationId;
        private String organizationId;
        private String secret;

        private byte[] encryptionKey;
        private RsaKeyParameters signingKey;
        private BodySerializer bodySerializer;
        private String basePath;
        private String contentType;
        private EncryptingKeywordExtractor encryptingKeywordExtractor;

        public static LogSentinelClientBuilder create(String applicationId, String organizationId, String secret)
        {
            LogSentinelClientBuilder builder = new LogSentinelClientBuilder();
            return builder.setApplicationId(applicationId)
                    .setOrganizationId(organizationId)
                    .setSecret(secret);
        }

        public LogSentinelClient build()
        {
            ApiClient apiClient = new ApiClient("https://api.logsentinel.com/api/");
            apiClient.setUsername(organizationId.Trim());
            apiClient.setPassword(secret.Trim());
            apiClient.addDefaultHeader("Application-Id", applicationId.Trim());

            BodySerializer serializer = bodySerializer != null ? bodySerializer : new JsonBodySerializer(apiClient.getJSON());
            if (encryptionKey != null)
            {
                serializer = new EncryptingBodySerializer(encryptionKey, serializer);
            }
            BodySigner signer = null;
            if (signingKey != null)
            {
                signer = new BodySigner(signingKey);
            }
            if (contentType == null)
            {
                contentType = "application/json;charsets=UTF-8";
            }

            AuditLogControllerApi auditLogActions = new AuditLogControllerApi(
                apiClient, serializer, signer, contentType, encryptingKeywordExtractor);

            HashControllerApi hashActions = new HashControllerApi(apiClient, serializer, signer, contentType);
            

            LogSentinelClient client = new LogSentinelClient(auditLogActions, hashActions);
            return client;
        }

        public String getApplicationId()
        {
            return applicationId;
        }

        public LogSentinelClientBuilder setApplicationId(String applicationId)
        {
            this.applicationId = applicationId;
            return this;
        }

        public String getOrganizationId()
        {
            return organizationId;
        }

        public LogSentinelClientBuilder setOrganizationId(String organizationId)
        {
            this.organizationId = organizationId;
            return this;
        }

        public String getSecret()
        {
            return secret;
        }

        public LogSentinelClientBuilder setSecret(String secret)
        {
            this.secret = secret;
            return this;
        }

        public byte[] getEncryptionKey()
        {
            return encryptionKey;
        }

        /**
         * Sets the (symmetric) key used to encrypt outgoing messages. If not set, messages are
         * set unencrypted. Also sets encrypting keyword extractor and so enable encrypted search.
         * Refer to the LogSentniel documentation to get more
         * information on when and why you should encrypt the requests
         *
         * @param keyPhrase keyPhrase to generate AES key. Must be 8 or 16 characters long
         * @return the builder
         */
        public LogSentinelClientBuilder setEncryptionKey(String keyPhrase)
        {
            validateEncryptionKeyPhraseLength(keyPhrase);
            //encode with 2 bytes per char to have predictability of key length
            this.encryptionKey = Encoding.ASCII.GetBytes(keyPhrase);
            this.encryptingKeywordExtractor = new LuceneEncryptingKeywordExtractor(encryptionKey);
            return this;
        }

        /**
         * Sets the (symmetric) key used to encrypt outgoing messages. If not set, messages are
         * set unencrypted. Also sets encrypting keyword extractor and so enable encrypted search.
         * Refer to the LogSentniel documentation to get more
         * information on when and why you should encrypt the requests
         *
         * @param keyBytes The key. Must be 16 or 32 bytes (128/256 bit)
         * @return the builder
         */
        public LogSentinelClientBuilder setEncryptionKey(byte[] keyBytes)
        {
            validateEncryptionKeyBytesLength(keyBytes);
            this.encryptionKey = keyBytes;
            this.encryptingKeywordExtractor = new LuceneEncryptingKeywordExtractor(encryptionKey);
            return this;
        }

        public BodySerializer getBodySerializer()
        {
            return bodySerializer;
        }

        /**
         * Sets a custom body serializer. If none is specified, JSON serializer is used for the body
         *
         * @param bodySerializer an implementation of body serializer
         * @return the builder
         */
        public LogSentinelClientBuilder setBodySerializer(BodySerializer bodySerializer)
        {
            this.bodySerializer = bodySerializer;
            return this;
        }

        public String getBasePath()
        {
            return basePath;
        }

        /**
         * Sets a custom base path for the API, other than logsentinel.com. Should
         * be used when running a local/hosted instance rather than using the cloud
         * one
         *
         * @param basePath the root url of the logsentinel installation
         * @return the builder
         */
        public LogSentinelClientBuilder setBasePath(String basePath)
        {
            this.basePath = basePath;
            return this;
        }

        /**
         * Sets a signing key for this client. The signing key is used to sign request details in order
         * to make sure no attacker can insert fake records if they gain control on a logging server
         *
         * @param signingKey the private key to use for request body signing
         * @return the builder
         */
        public LogSentinelClientBuilder setSigningKey(RsaKeyParameters signingKey)
        {
            this.signingKey = signingKey;
            return this;
        }

        /**
         * Sets the content type for sending requests
         *
         * @param contentType the value for the Content-Type header
         * @return the builder
         */
        public LogSentinelClientBuilder setContentType(String contentType)
        {
            this.contentType = contentType;
            return this;
        }

        private void validateEncryptionKeyPhraseLength(String keyPhrase)
        {
            if (keyPhrase.Length != 8 && keyPhrase.Length != 16)
            {
                throw new ArgumentException("Illegal key phrase length: " + keyPhrase.Length
                        + ". Must be 8 or 16");
            }
        }

        private void validateEncryptionKeyBytesLength(byte[] keyBytes)
        {
            if (keyBytes.Length != 16 && keyBytes.Length != 32)
            {
                throw new ArgumentException("Illegal key length: " + keyBytes.Length
                        + ". Must be 16 or 32");
            }
        }
    }
}