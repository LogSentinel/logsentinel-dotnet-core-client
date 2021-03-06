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
    ///  Class for testing ApplicationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ApplicationsApiTests
    {
        private ApplicationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ApplicationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApplicationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ApplicationsApi
            //Assert.IsInstanceOfType(typeof(ApplicationsApi), instance, "instance is a ApplicationsApi");
        }

        
        /// <summary>
        /// Test CreateApplication
        /// </summary>
        [Test]
        public void CreateApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateApplicationRequest application = null;
            //var response = instance.CreateApplication(application);
            //Assert.IsInstanceOf<Application> (response, "response is Application");
        }
        
        /// <summary>
        /// Test DeleteApplication
        /// </summary>
        [Test]
        public void DeleteApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? applicationId = null;
            //var response = instance.DeleteApplication(applicationId);
            //Assert.IsInstanceOf<Application> (response, "response is Application");
        }
        
        /// <summary>
        /// Test GetApplications
        /// </summary>
        [Test]
        public void GetApplicationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetApplications();
            //Assert.IsInstanceOf<List<Guid?>> (response, "response is List<Guid?>");
        }
        
        /// <summary>
        /// Test UpdateApplication
        /// </summary>
        [Test]
        public void UpdateApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateApplicationRequest application = null;
            //var response = instance.UpdateApplication(application);
            //Assert.IsInstanceOf<Application> (response, "response is Application");
        }
        
    }

}
