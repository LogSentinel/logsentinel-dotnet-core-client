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
    ///  Class for testing AlertsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AlertsApiTests
    {
        private AlertsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AlertsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AlertsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AlertsApi
            //Assert.IsInstanceOfType(typeof(AlertsApi), instance, "instance is a AlertsApi");
        }

        
        /// <summary>
        /// Test CreateActionChainRule
        /// </summary>
        [Test]
        public void CreateActionChainRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ActionChainAlertRule alertRule = null;
            //var response = instance.CreateActionChainRule(alertRule);
            //Assert.IsInstanceOf<ActionChainAlertRule> (response, "response is ActionChainAlertRule");
        }
        
        /// <summary>
        /// Test CreateDestination
        /// </summary>
        [Test]
        public void CreateDestinationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AlertDestinationRequest request = null;
            //var response = instance.CreateDestination(request);
            //Assert.IsInstanceOf<AlertDestination> (response, "response is AlertDestination");
        }
        
        /// <summary>
        /// Test CreateRule
        /// </summary>
        [Test]
        public void CreateRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AlertRuleRequest request = null;
            //var response = instance.CreateRule(request);
            //Assert.IsInstanceOf<AlertRule> (response, "response is AlertRule");
        }
        
        /// <summary>
        /// Test DeleteActionChainRule
        /// </summary>
        [Test]
        public void DeleteActionChainRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteActionChainRule(id);
            
        }
        
        /// <summary>
        /// Test DeleteDestination
        /// </summary>
        [Test]
        public void DeleteDestinationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteDestination(id);
            
        }
        
        /// <summary>
        /// Test DeleteRule
        /// </summary>
        [Test]
        public void DeleteRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteRule(id);
            
        }
        
        /// <summary>
        /// Test GetActionChainAlertRules
        /// </summary>
        [Test]
        public void GetActionChainAlertRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetActionChainAlertRules();
            //Assert.IsInstanceOf<List<ActionChainAlertRule>> (response, "response is List<ActionChainAlertRule>");
        }
        
        /// <summary>
        /// Test GetAlertDestinations
        /// </summary>
        [Test]
        public void GetAlertDestinationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAlertDestinations();
            //Assert.IsInstanceOf<List<AlertDestination>> (response, "response is List<AlertDestination>");
        }
        
        /// <summary>
        /// Test GetAlertRuleRuns
        /// </summary>
        [Test]
        public void GetAlertRuleRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAlertRuleRuns();
            //Assert.IsInstanceOf<List<AlertRuleRun>> (response, "response is List<AlertRuleRun>");
        }
        
        /// <summary>
        /// Test GetAlertRules
        /// </summary>
        [Test]
        public void GetAlertRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAlertRules();
            //Assert.IsInstanceOf<List<AlertRule>> (response, "response is List<AlertRule>");
        }
        
        /// <summary>
        /// Test UpdateActionChainRule
        /// </summary>
        [Test]
        public void UpdateActionChainRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ActionChainAlertRule rule = null;
            //var response = instance.UpdateActionChainRule(id, rule);
            //Assert.IsInstanceOf<ActionChainAlertRule> (response, "response is ActionChainAlertRule");
        }
        
        /// <summary>
        /// Test UpdateDestination
        /// </summary>
        [Test]
        public void UpdateDestinationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AlertDestinationRequest request = null;
            //var response = instance.UpdateDestination(id, request);
            //Assert.IsInstanceOf<AlertDestination> (response, "response is AlertDestination");
        }
        
        /// <summary>
        /// Test UpdateRule
        /// </summary>
        [Test]
        public void UpdateRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AlertRuleRequest request = null;
            //var response = instance.UpdateRule(id, request);
            //Assert.IsInstanceOf<AlertRule> (response, "response is AlertRule");
        }
        
        /// <summary>
        /// Test UpdateWorkingHours
        /// </summary>
        [Test]
        public void UpdateWorkingHoursTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WorkingHoursDto workingHoursDto = null;
            //instance.UpdateWorkingHours(workingHoursDto);
            
        }
        
    }

}
