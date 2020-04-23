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
    ///  Class for testing UserDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserDetailsTests
    {
        // TODO uncomment below to declare an instance variable for UserDetails
        //private UserDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UserDetails
            //instance = new UserDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserDetails
        /// </summary>
        [Test]
        public void UserDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UserDetails
            //Assert.IsInstanceOfType<UserDetails> (instance, "variable 'instance' is a UserDetails");
        }


        /// <summary>
        /// Test the property 'Admin'
        /// </summary>
        [Test]
        public void AdminTest()
        {
            // TODO unit test for the property 'Admin'
        }
        /// <summary>
        /// Test the property 'AllowedApplicationIds'
        /// </summary>
        [Test]
        public void AllowedApplicationIdsTest()
        {
            // TODO unit test for the property 'AllowedApplicationIds'
        }
        /// <summary>
        /// Test the property 'Base64ProfilePicture'
        /// </summary>
        [Test]
        public void Base64ProfilePictureTest()
        {
            // TODO unit test for the property 'Base64ProfilePicture'
        }
        /// <summary>
        /// Test the property 'Confirmed'
        /// </summary>
        [Test]
        public void ConfirmedTest()
        {
            // TODO unit test for the property 'Confirmed'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'Demo'
        /// </summary>
        [Test]
        public void DemoTest()
        {
            // TODO unit test for the property 'Demo'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'ExpirationDate'
        /// </summary>
        [Test]
        public void ExpirationDateTest()
        {
            // TODO unit test for the property 'ExpirationDate'
        }
        /// <summary>
        /// Test the property 'Expired'
        /// </summary>
        [Test]
        public void ExpiredTest()
        {
            // TODO unit test for the property 'Expired'
        }
        /// <summary>
        /// Test the property 'Features'
        /// </summary>
        [Test]
        public void FeaturesTest()
        {
            // TODO unit test for the property 'Features'
        }
        /// <summary>
        /// Test the property 'HasPassword'
        /// </summary>
        [Test]
        public void HasPasswordTest()
        {
            // TODO unit test for the property 'HasPassword'
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
        /// Test the property 'IntegratedCloudProviderId'
        /// </summary>
        [Test]
        public void IntegratedCloudProviderIdTest()
        {
            // TODO unit test for the property 'IntegratedCloudProviderId'
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'LdapProvided'
        /// </summary>
        [Test]
        public void LdapProvidedTest()
        {
            // TODO unit test for the property 'LdapProvided'
        }
        /// <summary>
        /// Test the property 'Names'
        /// </summary>
        [Test]
        public void NamesTest()
        {
            // TODO unit test for the property 'Names'
        }
        /// <summary>
        /// Test the property 'OrganizationId'
        /// </summary>
        [Test]
        public void OrganizationIdTest()
        {
            // TODO unit test for the property 'OrganizationId'
        }
        /// <summary>
        /// Test the property 'OrganizationName'
        /// </summary>
        [Test]
        public void OrganizationNameTest()
        {
            // TODO unit test for the property 'OrganizationName'
        }
        /// <summary>
        /// Test the property 'OrganizationRole'
        /// </summary>
        [Test]
        public void OrganizationRoleTest()
        {
            // TODO unit test for the property 'OrganizationRole'
        }
        /// <summary>
        /// Test the property 'PaymentsEnabled'
        /// </summary>
        [Test]
        public void PaymentsEnabledTest()
        {
            // TODO unit test for the property 'PaymentsEnabled'
        }
        /// <summary>
        /// Test the property 'Position'
        /// </summary>
        [Test]
        public void PositionTest()
        {
            // TODO unit test for the property 'Position'
        }
        /// <summary>
        /// Test the property 'ProfilePicture'
        /// </summary>
        [Test]
        public void ProfilePictureTest()
        {
            // TODO unit test for the property 'ProfilePicture'
        }
        /// <summary>
        /// Test the property 'PublicUser'
        /// </summary>
        [Test]
        public void PublicUserTest()
        {
            // TODO unit test for the property 'PublicUser'
        }
        /// <summary>
        /// Test the property 'ReceiveUpdates'
        /// </summary>
        [Test]
        public void ReceiveUpdatesTest()
        {
            // TODO unit test for the property 'ReceiveUpdates'
        }
        /// <summary>
        /// Test the property 'SeasonedUser'
        /// </summary>
        [Test]
        public void SeasonedUserTest()
        {
            // TODO unit test for the property 'SeasonedUser'
        }
        /// <summary>
        /// Test the property 'Timezone'
        /// </summary>
        [Test]
        public void TimezoneTest()
        {
            // TODO unit test for the property 'Timezone'
        }
        /// <summary>
        /// Test the property 'TwoFactorAuthEnabled'
        /// </summary>
        [Test]
        public void TwoFactorAuthEnabledTest()
        {
            // TODO unit test for the property 'TwoFactorAuthEnabled'
        }
        /// <summary>
        /// Test the property 'TwoFactorAuthKey'
        /// </summary>
        [Test]
        public void TwoFactorAuthKeyTest()
        {
            // TODO unit test for the property 'TwoFactorAuthKey'
        }
        /// <summary>
        /// Test the property 'WhitelabelStyling'
        /// </summary>
        [Test]
        public void WhitelabelStylingTest()
        {
            // TODO unit test for the property 'WhitelabelStyling'
        }

    }

}