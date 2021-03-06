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
    ///  Class for testing MerkleTreeInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MerkleTreeInfoTests
    {
        // TODO uncomment below to declare an instance variable for MerkleTreeInfo
        //private MerkleTreeInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MerkleTreeInfo
            //instance = new MerkleTreeInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MerkleTreeInfo
        /// </summary>
        [Test]
        public void MerkleTreeInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MerkleTreeInfo
            //Assert.IsInstanceOfType<MerkleTreeInfo> (instance, "variable 'instance' is a MerkleTreeInfo");
        }


        /// <summary>
        /// Test the property 'HashAlgorithmOid'
        /// </summary>
        [Test]
        public void HashAlgorithmOidTest()
        {
            // TODO unit test for the property 'HashAlgorithmOid'
        }
        /// <summary>
        /// Test the property 'LeafHashAlgorithmOid'
        /// </summary>
        [Test]
        public void LeafHashAlgorithmOidTest()
        {
            // TODO unit test for the property 'LeafHashAlgorithmOid'
        }
        /// <summary>
        /// Test the property 'TimestampAlgorithmOid'
        /// </summary>
        [Test]
        public void TimestampAlgorithmOidTest()
        {
            // TODO unit test for the property 'TimestampAlgorithmOid'
        }
        /// <summary>
        /// Test the property 'TimestampPublicKey'
        /// </summary>
        [Test]
        public void TimestampPublicKeyTest()
        {
            // TODO unit test for the property 'TimestampPublicKey'
        }

    }

}
