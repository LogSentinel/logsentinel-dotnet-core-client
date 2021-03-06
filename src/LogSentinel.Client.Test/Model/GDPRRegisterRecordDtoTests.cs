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
    ///  Class for testing GDPRRegisterRecordDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GDPRRegisterRecordDtoTests
    {
        // TODO uncomment below to declare an instance variable for GDPRRegisterRecordDto
        //private GDPRRegisterRecordDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GDPRRegisterRecordDto
            //instance = new GDPRRegisterRecordDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GDPRRegisterRecordDto
        /// </summary>
        [Test]
        public void GDPRRegisterRecordDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GDPRRegisterRecordDto
            //Assert.IsInstanceOfType<GDPRRegisterRecordDto> (instance, "variable 'instance' is a GDPRRegisterRecordDto");
        }


        /// <summary>
        /// Test the property 'AuditTrailCorrelationKey'
        /// </summary>
        [Test]
        public void AuditTrailCorrelationKeyTest()
        {
            // TODO unit test for the property 'AuditTrailCorrelationKey'
        }
        /// <summary>
        /// Test the property 'Branch'
        /// </summary>
        [Test]
        public void BranchTest()
        {
            // TODO unit test for the property 'Branch'
        }
        /// <summary>
        /// Test the property 'Controller'
        /// </summary>
        [Test]
        public void ControllerTest()
        {
            // TODO unit test for the property 'Controller'
        }
        /// <summary>
        /// Test the property 'ControllersDescription'
        /// </summary>
        [Test]
        public void ControllersDescriptionTest()
        {
            // TODO unit test for the property 'ControllersDescription'
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
        /// Test the property 'DataRecipientCategories'
        /// </summary>
        [Test]
        public void DataRecipientCategoriesTest()
        {
            // TODO unit test for the property 'DataRecipientCategories'
        }
        /// <summary>
        /// Test the property 'DataRecipientCategoriesOther'
        /// </summary>
        [Test]
        public void DataRecipientCategoriesOtherTest()
        {
            // TODO unit test for the property 'DataRecipientCategoriesOther'
        }
        /// <summary>
        /// Test the property 'DataSubjectCategory'
        /// </summary>
        [Test]
        public void DataSubjectCategoryTest()
        {
            // TODO unit test for the property 'DataSubjectCategory'
        }
        /// <summary>
        /// Test the property 'DataSubjectCategoryOther'
        /// </summary>
        [Test]
        public void DataSubjectCategoryOtherTest()
        {
            // TODO unit test for the property 'DataSubjectCategoryOther'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'JointControllers'
        /// </summary>
        [Test]
        public void JointControllersTest()
        {
            // TODO unit test for the property 'JointControllers'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
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
        /// Test the property 'PersonalDataCategory'
        /// </summary>
        [Test]
        public void PersonalDataCategoryTest()
        {
            // TODO unit test for the property 'PersonalDataCategory'
        }
        /// <summary>
        /// Test the property 'PersonalDataCategoryOther'
        /// </summary>
        [Test]
        public void PersonalDataCategoryOtherTest()
        {
            // TODO unit test for the property 'PersonalDataCategoryOther'
        }
        /// <summary>
        /// Test the property 'PersonalDataFields'
        /// </summary>
        [Test]
        public void PersonalDataFieldsTest()
        {
            // TODO unit test for the property 'PersonalDataFields'
        }
        /// <summary>
        /// Test the property 'ProcessOwner'
        /// </summary>
        [Test]
        public void ProcessOwnerTest()
        {
            // TODO unit test for the property 'ProcessOwner'
        }
        /// <summary>
        /// Test the property 'ProcessingActivityCode'
        /// </summary>
        [Test]
        public void ProcessingActivityCodeTest()
        {
            // TODO unit test for the property 'ProcessingActivityCode'
        }
        /// <summary>
        /// Test the property 'ProcessingActivityName'
        /// </summary>
        [Test]
        public void ProcessingActivityNameTest()
        {
            // TODO unit test for the property 'ProcessingActivityName'
        }
        /// <summary>
        /// Test the property 'ProcessingLegalBasis'
        /// </summary>
        [Test]
        public void ProcessingLegalBasisTest()
        {
            // TODO unit test for the property 'ProcessingLegalBasis'
        }
        /// <summary>
        /// Test the property 'Processor'
        /// </summary>
        [Test]
        public void ProcessorTest()
        {
            // TODO unit test for the property 'Processor'
        }
        /// <summary>
        /// Test the property 'Purposes'
        /// </summary>
        [Test]
        public void PurposesTest()
        {
            // TODO unit test for the property 'Purposes'
        }
        /// <summary>
        /// Test the property 'Recipients'
        /// </summary>
        [Test]
        public void RecipientsTest()
        {
            // TODO unit test for the property 'Recipients'
        }
        /// <summary>
        /// Test the property 'RelevantDepartment'
        /// </summary>
        [Test]
        public void RelevantDepartmentTest()
        {
            // TODO unit test for the property 'RelevantDepartment'
        }
        /// <summary>
        /// Test the property 'RetentionMonths'
        /// </summary>
        [Test]
        public void RetentionMonthsTest()
        {
            // TODO unit test for the property 'RetentionMonths'
        }
        /// <summary>
        /// Test the property 'RiskDescription'
        /// </summary>
        [Test]
        public void RiskDescriptionTest()
        {
            // TODO unit test for the property 'RiskDescription'
        }
        /// <summary>
        /// Test the property 'SensitivePersonalDataCategory'
        /// </summary>
        [Test]
        public void SensitivePersonalDataCategoryTest()
        {
            // TODO unit test for the property 'SensitivePersonalDataCategory'
        }
        /// <summary>
        /// Test the property 'Software'
        /// </summary>
        [Test]
        public void SoftwareTest()
        {
            // TODO unit test for the property 'Software'
        }
        /// <summary>
        /// Test the property 'SubProcessors'
        /// </summary>
        [Test]
        public void SubProcessorsTest()
        {
            // TODO unit test for the property 'SubProcessors'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'TechnicalMeasures'
        /// </summary>
        [Test]
        public void TechnicalMeasuresTest()
        {
            // TODO unit test for the property 'TechnicalMeasures'
        }
        /// <summary>
        /// Test the property 'TechnicalMeasuresOther'
        /// </summary>
        [Test]
        public void TechnicalMeasuresOtherTest()
        {
            // TODO unit test for the property 'TechnicalMeasuresOther'
        }
        /// <summary>
        /// Test the property 'ThirdCountryTransferSafeguards'
        /// </summary>
        [Test]
        public void ThirdCountryTransferSafeguardsTest()
        {
            // TODO unit test for the property 'ThirdCountryTransferSafeguards'
        }
        /// <summary>
        /// Test the property 'ThirdCountryTransfers'
        /// </summary>
        [Test]
        public void ThirdCountryTransfersTest()
        {
            // TODO unit test for the property 'ThirdCountryTransfers'
        }
        /// <summary>
        /// Test the property 'Updated'
        /// </summary>
        [Test]
        public void UpdatedTest()
        {
            // TODO unit test for the property 'Updated'
        }

    }

}
