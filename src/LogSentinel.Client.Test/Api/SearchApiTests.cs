/* 
 * LogSentinel RESTful API
 *
 * Read more at https://docs.logsentinel.com/en/latest/index.html
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using LogSentinel.Client.Client;
using LogSentinel.Client.Api;
using LogSentinel.Client.Model;

namespace LogSentinel.Client.Test
{
    /// <summary>
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SearchApiTests
    {
        private SearchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SearchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SearchApi
            //Assert.IsInstanceOfType(typeof(SearchApi), instance, "instance is a SearchApi");
        }

        
        /// <summary>
        /// Test GetBatch
        /// </summary>
        [Test]
        public void GetBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //string field = null;
            //List<string> values = null;
            //int? batchSize = null;
            //string entityType = null;
            //int? page = null;
            //var response = instance.GetBatch(applicationId, field, values, batchSize, entityType, page);
            //Assert.IsInstanceOf<List<AuditLogEntry>> (response, "response is List<AuditLogEntry>");
        }
        
        /// <summary>
        /// Test GetEntityHistory
        /// </summary>
        [Test]
        public void GetEntityHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //string entityId = null;
            //string entityType = null;
            //var response = instance.GetEntityHistory(applicationId, entityId, entityType);
            //Assert.IsInstanceOf<List<AuditLogEntry>> (response, "response is List<AuditLogEntry>");
        }
        
        /// <summary>
        /// Test Search
        /// </summary>
        [Test]
        public void SearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //SearchRequest searchRequest = null;
            //var response = instance.Search(applicationId, searchRequest);
            //Assert.IsInstanceOf<List<AuditLogEntry>> (response, "response is List<AuditLogEntry>");
        }
        
    }

}
