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
    ///  Class for testing OrganizationUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganizationUsersApiTests
    {
        private OrganizationUsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationUsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationUsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrganizationUsersApi
            //Assert.IsInstanceOfType(typeof(OrganizationUsersApi), instance, "instance is a OrganizationUsersApi");
        }

        
        /// <summary>
        /// Test ChangeRole
        /// </summary>
        [Test]
        public void ChangeRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string role = null;
            //Guid? userId = null;
            //var response = instance.ChangeRole(role, userId);
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserRegistrationRequest request = null;
            //var response = instance.Create(request);
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        
        /// <summary>
        /// Test ForgetUser
        /// </summary>
        [Test]
        public void ForgetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //var response = instance.ForgetUser(userId);
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        
        /// <summary>
        /// Test GetUserDetailsByEmail
        /// </summary>
        [Test]
        public void GetUserDetailsByEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.GetUserDetailsByEmail(email);
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        
        /// <summary>
        /// Test GetUserDetailsById
        /// </summary>
        [Test]
        public void GetUserDetailsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //var response = instance.GetUserDetailsById(userId);
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateUserRequest request = null;
            //var response = instance.Update(request);
            //Assert.IsInstanceOf<UserDetails> (response, "response is UserDetails");
        }
        
    }

}