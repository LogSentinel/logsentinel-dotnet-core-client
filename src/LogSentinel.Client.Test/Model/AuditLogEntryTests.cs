/* 
 * LogSentinel RESTful API
 *
 * Read more at https://docs.logsentinel.com/en/latest/index.html
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using LogSentinel.Client.Api;
using LogSentinel.Client.Model;
using LogSentinel.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace LogSentinel.Client.Test
{
    /// <summary>
    ///  Class for testing AuditLogEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AuditLogEntryTests
    {
        // TODO uncomment below to declare an instance variable for AuditLogEntry
        //private AuditLogEntry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AuditLogEntry
            //instance = new AuditLogEntry();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuditLogEntry
        /// </summary>
        [Test]
        public void AuditLogEntryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AuditLogEntry
            //Assert.IsInstanceOfType<AuditLogEntry> (instance, "variable 'instance' is a AuditLogEntry");
        }


        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Test]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }
        /// <summary>
        /// Test the property 'ActorDisplayName'
        /// </summary>
        [Test]
        public void ActorDisplayNameTest()
        {
            // TODO unit test for the property 'ActorDisplayName'
        }
        /// <summary>
        /// Test the property 'ActorId'
        /// </summary>
        [Test]
        public void ActorIdTest()
        {
            // TODO unit test for the property 'ActorId'
        }
        /// <summary>
        /// Test the property 'ActorRoles'
        /// </summary>
        [Test]
        public void ActorRolesTest()
        {
            // TODO unit test for the property 'ActorRoles'
        }
        /// <summary>
        /// Test the property 'AdditionalParams'
        /// </summary>
        [Test]
        public void AdditionalParamsTest()
        {
            // TODO unit test for the property 'AdditionalParams'
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Test]
        public void ApplicationIdTest()
        {
            // TODO unit test for the property 'ApplicationId'
        }
        /// <summary>
        /// Test the property 'Details'
        /// </summary>
        [Test]
        public void DetailsTest()
        {
            // TODO unit test for the property 'Details'
        }
        /// <summary>
        /// Test the property 'EncryptedKeywordsList'
        /// </summary>
        [Test]
        public void EncryptedKeywordsListTest()
        {
            // TODO unit test for the property 'EncryptedKeywordsList'
        }
        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Test]
        public void EntityIdTest()
        {
            // TODO unit test for the property 'EntityId'
        }
        /// <summary>
        /// Test the property 'EntityType'
        /// </summary>
        [Test]
        public void EntityTypeTest()
        {
            // TODO unit test for the property 'EntityType'
        }
        /// <summary>
        /// Test the property 'EntryType'
        /// </summary>
        [Test]
        public void EntryTypeTest()
        {
            // TODO unit test for the property 'EntryType'
        }
        /// <summary>
        /// Test the property 'Hash'
        /// </summary>
        [Test]
        public void HashTest()
        {
            // TODO unit test for the property 'Hash'
        }
        /// <summary>
        /// Test the property 'HashVersion'
        /// </summary>
        [Test]
        public void HashVersionTest()
        {
            // TODO unit test for the property 'HashVersion'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'InsideWorkingHours'
        /// </summary>
        [Test]
        public void InsideWorkingHoursTest()
        {
            // TODO unit test for the property 'InsideWorkingHours'
        }
        /// <summary>
        /// Test the property 'IpAddress'
        /// </summary>
        [Test]
        public void IpAddressTest()
        {
            // TODO unit test for the property 'IpAddress'
        }
        /// <summary>
        /// Test the property 'LogLevel'
        /// </summary>
        [Test]
        public void LogLevelTest()
        {
            // TODO unit test for the property 'LogLevel'
        }
        /// <summary>
        /// Test the property 'NumericParams'
        /// </summary>
        [Test]
        public void NumericParamsTest()
        {
            // TODO unit test for the property 'NumericParams'
        }
        /// <summary>
        /// Test the property 'OriginalEventTimestamp'
        /// </summary>
        [Test]
        public void OriginalEventTimestampTest()
        {
            // TODO unit test for the property 'OriginalEventTimestamp'
        }
        /// <summary>
        /// Test the property 'PreviousEntryId'
        /// </summary>
        [Test]
        public void PreviousEntryIdTest()
        {
            // TODO unit test for the property 'PreviousEntryId'
        }
        /// <summary>
        /// Test the property 'StandaloneHash'
        /// </summary>
        [Test]
        public void StandaloneHashTest()
        {
            // TODO unit test for the property 'StandaloneHash'
        }
        /// <summary>
        /// Test the property 'Timestamp'
        /// </summary>
        [Test]
        public void TimestampTest()
        {
            // TODO unit test for the property 'Timestamp'
        }
        /// <summary>
        /// Test the property 'TimestampGroupHash'
        /// </summary>
        [Test]
        public void TimestampGroupHashTest()
        {
            // TODO unit test for the property 'TimestampGroupHash'
        }
        /// <summary>
        /// Test the property 'TimestampGroupSize'
        /// </summary>
        [Test]
        public void TimestampGroupSizeTest()
        {
            // TODO unit test for the property 'TimestampGroupSize'
        }
        /// <summary>
        /// Test the property 'TimestampTime'
        /// </summary>
        [Test]
        public void TimestampTimeTest()
        {
            // TODO unit test for the property 'TimestampTime'
        }
        /// <summary>
        /// Test the property 'TimestampTokenId'
        /// </summary>
        [Test]
        public void TimestampTokenIdTest()
        {
            // TODO unit test for the property 'TimestampTokenId'
        }

    }

}
