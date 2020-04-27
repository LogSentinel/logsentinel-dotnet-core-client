# LogSentinel.Client - the C# library for the LogSentinel RESTful API

[![Build Status](https://travis-ci.org/LogSentinel/logsentinel-dotnet-core-client.svg?branch=master)](https://travis-ci.org/LogSentinel/logsentinel-dotnet-core-client)

Read more at https://docs.logsentinel.com/en/latest/index.html

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var alertRule = new ActionChainAlertRule(); // ActionChainAlertRule | alertRule

            try
            {
                // Creates Action Chain Alert Rule
                ActionChainAlertRule result = apiInstance.CreateActionChainRule(alertRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateActionChainRule: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.logsentinel.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AlertsApi* | [**CreateActionChainRule**](docs/AlertsApi.md#createactionchainrule) | **POST** /api/alerts/actionChainRule | Creates Action Chain Alert Rule
*AlertsApi* | [**CreateDestination**](docs/AlertsApi.md#createdestination) | **POST** /api/alerts/destination | Creates Alert destination. Type is EMAIL or TELEGRAM
*AlertsApi* | [**CreateRule**](docs/AlertsApi.md#createrule) | **POST** /api/alerts/rule | Creates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM
*AlertsApi* | [**DeleteActionChainRule**](docs/AlertsApi.md#deleteactionchainrule) | **DELETE** /api/alerts/actionChainRule | Deletes Action chain Alert rule
*AlertsApi* | [**DeleteDestination**](docs/AlertsApi.md#deletedestination) | **DELETE** /api/alerts/destination | Deletes Alert destination
*AlertsApi* | [**DeleteRule**](docs/AlertsApi.md#deleterule) | **DELETE** /api/alerts/rule | Deletes Alert rule
*AlertsApi* | [**GetActionChainAlertRules**](docs/AlertsApi.md#getactionchainalertrules) | **GET** /api/alerts/actionChainRules | Gets all Action Chain Alert rules in the organization
*AlertsApi* | [**GetAlertDestinations**](docs/AlertsApi.md#getalertdestinations) | **GET** /api/alerts/destinations | Gets all Alert destinations in the organization
*AlertsApi* | [**GetAlertRuleRuns**](docs/AlertsApi.md#getalertruleruns) | **GET** /api/alerts/runs | Gets all Alert rule runs in the organization
*AlertsApi* | [**GetAlertRules**](docs/AlertsApi.md#getalertrules) | **GET** /api/alerts/rules | Gets all Alert rules in the organization
*AlertsApi* | [**UpdateActionChainRule**](docs/AlertsApi.md#updateactionchainrule) | **PUT** /api/alerts/actionChainRule | Updates Action Chain Alert Rule
*AlertsApi* | [**UpdateDestination**](docs/AlertsApi.md#updatedestination) | **PUT** /api/alerts/destination | Updates Alert destination. Type cannot be changed
*AlertsApi* | [**UpdateRule**](docs/AlertsApi.md#updaterule) | **PUT** /api/alerts/rule | Updates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM
*AlertsApi* | [**UpdateWorkingHours**](docs/AlertsApi.md#updateworkinghours) | **POST** /api/alerts/updateWorkingHours | Updates the working hours for the organization
*ApplicationsApi* | [**CreateApplication**](docs/ApplicationsApi.md#createapplication) | **PUT** /api/application | Create a new application
*ApplicationsApi* | [**DeleteApplication**](docs/ApplicationsApi.md#deleteapplication) | **DELETE** /api/application | Delete an existing application
*ApplicationsApi* | [**GetApplications**](docs/ApplicationsApi.md#getapplications) | **GET** /api/application | Get all applications of an organization
*ApplicationsApi* | [**UpdateApplication**](docs/ApplicationsApi.md#updateapplication) | **POST** /api/application | Update an existing application
*GDPRLoggingApi* | [**LogConsent**](docs/GDPRLoggingApi.md#logconsent) | **POST** /api/log-gdpr/consent | Log the consent by a given user
*GDPRLoggingApi* | [**LogGdprRequest**](docs/GDPRLoggingApi.md#loggdprrequest) | **POST** /api/log-gdpr/request/{requestType} | Log a GDPR request by a given user
*GDPRLoggingApi* | [**LogRequestResults**](docs/GDPRLoggingApi.md#logrequestresults) | **POST** /api/log-gdpr/request-result/{requestType} | Push data about the result of a GDPR request
*GDPRRegisterApi* | [**AddEntity**](docs/GDPRRegisterApi.md#addentity) | **POST** /api/gdpr/addEntity | Adds entitity to the GDPR register
*GDPRRegisterApi* | [**DeleteEntity**](docs/GDPRRegisterApi.md#deleteentity) | **DELETE** /api/gdpr/entity | Deletes entity in the GDPR register
*GDPRRegisterApi* | [**DeleteRecord**](docs/GDPRRegisterApi.md#deleterecord) | **DELETE** /api/gdpr/record | Deletes record  from the GDPR register
*GDPRRegisterApi* | [**GdprEntities**](docs/GDPRRegisterApi.md#gdprentities) | **GET** /api/gdpr/entities | Fetch entities from the GDPR register
*GDPRRegisterApi* | [**GetEntity**](docs/GDPRRegisterApi.md#getentity) | **GET** /api/gdpr/entity | Gets entity by id from the GDPR register
*GDPRRegisterApi* | [**GetRecord**](docs/GDPRRegisterApi.md#getrecord) | **GET** /api/gdpr/record | Gets record by id from the GDPR register
*GDPRRegisterApi* | [**GetRecords**](docs/GDPRRegisterApi.md#getrecords) | **GET** /api/gdpr/records | Fetch records from the GDPR register
*GDPRRegisterApi* | [**SaveEntity**](docs/GDPRRegisterApi.md#saveentity) | **POST** /api/gdpr/entity | Updates entity in the GDPR register
*GDPRRegisterApi* | [**SaveRecord**](docs/GDPRRegisterApi.md#saverecord) | **POST** /api/gdpr/saveRecord | Saves record in the GDPR register
*HashApi* | [**GetHash**](docs/HashApi.md#gethash) | **POST** /api/getStandaloneHash | Get the standalone (non-chained) hash for an entry
*HashApi* | [**GetHashableContent**](docs/HashApi.md#gethashablecontent) | **POST** /api/getHashableContent/{actorId}/{action} | Get the content over which to compute the hash of a request for simple (minimal metadata) actions
*HashApi* | [**GetHashableContentForAuthAction**](docs/HashApi.md#gethashablecontentforauthaction) | **POST** /api/getHashableContent/{actorId}/auth/{authAction} | Get the content over which to compute the hash of a request for auth actions
*HashApi* | [**GetHashableContentForStandardAction**](docs/HashApi.md#gethashablecontentforstandardaction) | **POST** /api/getHashableContent/{actorId}/{action}/{entityType}/{entityId} | Get the content over which to compute the hash of a request for standard actions
*HashApi* | [**GetHashableContentSimple**](docs/HashApi.md#gethashablecontentsimple) | **POST** /api/getHashableContent | Get the content over which to compute the hash of a request without any additional metadata (including encrypted request bodies)
*LogHealthcareApi* | [**LogDicomEvent**](docs/LogHealthcareApi.md#logdicomevent) | **POST** /api/dicom/log | Logs a DICOM audit message
*LogHealthcareApi* | [**LogFhirEvent**](docs/LogHealthcareApi.md#logfhirevent) | **POST** /api/fhir/log | Logs a FHIR audit event in order to help with HIPAA compliance
*LogHealthcareApi* | [**LogIheEvent**](docs/LogHealthcareApi.md#logiheevent) | **POST** /api/ihe/log | Logs an IHE audit message
*LogSpecialApi* | [**LogProvenance**](docs/LogSpecialApi.md#logprovenance) | **POST** /api/provenance/log | Logs a Provenance document
*LoggingApi* | [**GetEntryById**](docs/LoggingApi.md#getentrybyid) | **GET** /api/getEntryById | Get entry by id
*LoggingApi* | [**GetHashByEntryId**](docs/LoggingApi.md#gethashbyentryid) | **GET** /api/getHashByEntryId | getHashByEntryId
*LoggingApi* | [**Log**](docs/LoggingApi.md#log) | **POST** /api/log/{actorId}/{action} | Log an event by a given actor
*LoggingApi* | [**LogAuthAction**](docs/LoggingApi.md#logauthaction) | **POST** /api/log/{actorId}/auth/{authAction} | Log an authentication event with the option to pass actor public key and signature
*LoggingApi* | [**LogBatch**](docs/LoggingApi.md#logbatch) | **POST** /api/log/batch | Log multiple events at the same time. This should rarely be used, but allows background processes to push multiple events at the same time
*LoggingApi* | [**LogDocument**](docs/LoggingApi.md#logdocument) | **POST** /api/log/document/{actorId}/{action}/{documentId} | Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action
*LoggingApi* | [**LogFull**](docs/LoggingApi.md#logfull) | **POST** /api/log/{actorId}/{action}/{entityType}/{entityId} | Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action
*LoggingApi* | [**LogSimple**](docs/LoggingApi.md#logsimple) | **POST** /api/log/simple | Log an event by providing just the body without any additional metadata. The body can be fully encrypted or can represent just the hash of the data/document
*OrganizationUsersApi* | [**ChangeRole**](docs/OrganizationUsersApi.md#changerole) | **POST** /api/users/userId/{userId}/changeRole/{role} | Changes user role
*OrganizationUsersApi* | [**Create**](docs/OrganizationUsersApi.md#create) | **PUT** /api/users/create | Creates new user in the organization
*OrganizationUsersApi* | [**ForgetUser**](docs/OrganizationUsersApi.md#forgetuser) | **POST** /api/users/forget/{userId} | Forgets user profile
*OrganizationUsersApi* | [**GetUserDetailsByEmail**](docs/OrganizationUsersApi.md#getuserdetailsbyemail) | **GET** /api/users/email/{email} | Gets user details by email
*OrganizationUsersApi* | [**GetUserDetailsById**](docs/OrganizationUsersApi.md#getuserdetailsbyid) | **GET** /api/users/userId/{userId} | Gets user details by user id
*OrganizationUsersApi* | [**Update**](docs/OrganizationUsersApi.md#update) | **POST** /api/users/update | Updates user profile
*PartnersApi* | [**CancelOrganization**](docs/PartnersApi.md#cancelorganization) | **DELETE** /api/partner/organizations/cancel | Cancels organization by Id and deletes all users
*PartnersApi* | [**FetchAllOrganizations**](docs/PartnersApi.md#fetchallorganizations) | **GET** /api/partner/organizations | Fetch all organizations
*PartnersApi* | [**GetApiCredentials**](docs/PartnersApi.md#getapicredentials) | **GET** /api/partner/organizations/apiCredentials | API credentials per organization from organizations owned by partner
*PartnersApi* | [**GetOrganizationByUserEmail**](docs/PartnersApi.md#getorganizationbyuseremail) | **GET** /api/partner/organizationByUserEmail | Get the organization for the supplied email
*PartnersApi* | [**GetUserIdByEmail**](docs/PartnersApi.md#getuseridbyemail) | **GET** /api/partner/userIdByEmail | Get user id by user email
*PartnersApi* | [**RegisterUser**](docs/PartnersApi.md#registeruser) | **POST** /api/partner/user/register | Register a user
*SavedSearchesApi* | [**CreateSavedSearch**](docs/SavedSearchesApi.md#createsavedsearch) | **POST** /api/search/saved | Creates saved search
*SavedSearchesApi* | [**GetSavedSearchIds**](docs/SavedSearchesApi.md#getsavedsearchids) | **GET** /api/search/saved/fetch | Fetches saved search ids of all users of an organization
*SavedSearchesApi* | [**PerformSavedSearch**](docs/SavedSearchesApi.md#performsavedsearch) | **GET** /api/search/saved | Calls saved search by its id
*SearchApi* | [**GetBatch**](docs/SearchApi.md#getbatch) | **GET** /api/search/batch | Search entries in batches by field
*SearchApi* | [**GetEntityHistory**](docs/SearchApi.md#getentityhistory) | **GET** /api/search/entityHistory | Get entity history
*SearchApi* | [**Search**](docs/SearchApi.md#search) | **POST** /api/search | Search logged entries
*VerificationApi* | [**GetConsistencyProof**](docs/VerificationApi.md#getconsistencyproof) | **GET** /api/verification/merkle/proofs/consistency | Get consistency proof for an application merkle tree. Async operation, as the generation may be slow
*VerificationApi* | [**GetEntriesBetweenHashes**](docs/VerificationApi.md#getentriesbetweenhashes) | **GET** /api/verification/entries | Get all entries between two hashes
*VerificationApi* | [**GetEthereumEntries**](docs/VerificationApi.md#getethereumentries) | **GET** /api/verification/ethereumEntries | Fetch all hashes pushed to Ethereum for a given application
*VerificationApi* | [**GetInclusionProof**](docs/VerificationApi.md#getinclusionproof) | **GET** /api/verification/merkle/proofs/inclusion | Get inclusion proof for the application merkle tree. Async operation, as the generation may be slow
*VerificationApi* | [**GetLatestTreeHead**](docs/VerificationApi.md#getlatesttreehead) | **GET** /api/verification/merkle/latestTreeHead | Get latest tree head of the application merkle tree. Async operation, as the operation may be slow
*VerificationApi* | [**GetMerkleTreeInfo**](docs/VerificationApi.md#getmerkletreeinfo) | **GET** /api/verification/merkle/info | Get general info about merkle tree parameters
*VerificationApi* | [**GetResolvedVerificationFailures**](docs/VerificationApi.md#getresolvedverificationfailures) | **GET** /api/verification/resolved-failures | Get all resolved verification failures
*VerificationApi* | [**Verify**](docs/VerificationApi.md#verify) | **POST** /api/verification/verify | Verify whether a given hash is present, indicating that the log is intact
*VerificationApi* | [**VerifyEntry**](docs/VerificationApi.md#verifyentry) | **POST** /api/verification/verifyEntry | Verify whether a given entry's hash is present, indicating that the log is intact


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.APICredentialsOrganization](docs/APICredentialsOrganization.md)
 - [Model.ActionChainAlertRule](docs/ActionChainAlertRule.md)
 - [Model.ActionData](docs/ActionData.md)
 - [Model.ActorData](docs/ActorData.md)
 - [Model.AlertDestination](docs/AlertDestination.md)
 - [Model.AlertDestinationRequest](docs/AlertDestinationRequest.md)
 - [Model.AlertRule](docs/AlertRule.md)
 - [Model.AlertRuleRequest](docs/AlertRuleRequest.md)
 - [Model.AlertRuleRun](docs/AlertRuleRun.md)
 - [Model.Application](docs/Application.md)
 - [Model.AsyncTaskExecutor](docs/AsyncTaskExecutor.md)
 - [Model.AuditLogEntry](docs/AuditLogEntry.md)
 - [Model.BatchLogRequestEntry](docs/BatchLogRequestEntry.md)
 - [Model.ByteBuffer](docs/ByteBuffer.md)
 - [Model.CallableOfobject](docs/CallableOfobject.md)
 - [Model.Consent](docs/Consent.md)
 - [Model.ConsistencyProof](docs/ConsistencyProof.md)
 - [Model.EthereumData](docs/EthereumData.md)
 - [Model.GDPRRecipient](docs/GDPRRecipient.md)
 - [Model.GDPRRegisterRecord](docs/GDPRRegisterRecord.md)
 - [Model.GDPRRegisterRecordDto](docs/GDPRRegisterRecordDto.md)
 - [Model.GDPRRequest](docs/GDPRRequest.md)
 - [Model.GDPRResponsibleEntity](docs/GDPRResponsibleEntity.md)
 - [Model.InclusionProof](docs/InclusionProof.md)
 - [Model.LogResponse](docs/LogResponse.md)
 - [Model.MachineLearningSettings](docs/MachineLearningSettings.md)
 - [Model.MerkleTreeInfo](docs/MerkleTreeInfo.md)
 - [Model.MetadataExtractionPaths](docs/MetadataExtractionPaths.md)
 - [Model.OrganizationDto](docs/OrganizationDto.md)
 - [Model.RegistrationResponse](docs/RegistrationResponse.md)
 - [Model.ResolvedVerificationFailure](docs/ResolvedVerificationFailure.md)
 - [Model.ResolvedVerificationFailureResponse](docs/ResolvedVerificationFailureResponse.md)
 - [Model.Result](docs/Result.md)
 - [Model.SavedSearch](docs/SavedSearch.md)
 - [Model.SearchRequest](docs/SearchRequest.md)
 - [Model.TreeHead](docs/TreeHead.md)
 - [Model.UpdateApplicationRequest](docs/UpdateApplicationRequest.md)
 - [Model.UpdateUserRequest](docs/UpdateUserRequest.md)
 - [Model.UserDetails](docs/UserDetails.md)
 - [Model.UserRegistrationRequest](docs/UserRegistrationRequest.md)
 - [Model.Verification](docs/Verification.md)
 - [Model.WebAsyncTaskOfConsistencyProof](docs/WebAsyncTaskOfConsistencyProof.md)
 - [Model.WebAsyncTaskOfInclusionProof](docs/WebAsyncTaskOfInclusionProof.md)
 - [Model.WebAsyncTaskOfTreeHead](docs/WebAsyncTaskOfTreeHead.md)
 - [Model.WhitelabelStyling](docs/WhitelabelStyling.md)
 - [Model.WorkingHoursDto](docs/WorkingHoursDto.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="basicAuth"></a>
### basicAuth

- **Type**: HTTP basic authentication

