# LogSentinel.Client.Api.LoggingApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEntryById**](LoggingApi.md#getentrybyid) | **GET** /api/getEntryById | Get entry by id
[**GetHashByEntryId**](LoggingApi.md#gethashbyentryid) | **GET** /api/getHashByEntryId | getHashByEntryId
[**Log**](LoggingApi.md#log) | **POST** /api/log/{actorId}/{action} | Log an event by a given actor
[**LogAuthAction**](LoggingApi.md#logauthaction) | **POST** /api/log/{actorId}/auth/{authAction} | Log an authentication event with the option to pass actor public key and signature
[**LogBatch**](LoggingApi.md#logbatch) | **POST** /api/log/batch | Log multiple events at the same time. This should rarely be used, but allows background processes to push multiple events at the same time
[**LogDocument**](LoggingApi.md#logdocument) | **POST** /api/log/document/{actorId}/{action}/{documentId} | Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action
[**LogFull**](LoggingApi.md#logfull) | **POST** /api/log/{actorId}/{action}/{entityType}/{entityId} | Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action
[**LogSimple**](LoggingApi.md#logsimple) | **POST** /api/log/simple | Log an event by providing just the body without any additional metadata. The body can be fully encrypted or can represent just the hash of the data/document


<a name="getentrybyid"></a>
# **GetEntryById**
> AuditLogEntry GetEntryById (string applicationId, string entryId)

Get entry by id

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetEntryByIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var entryId = entryId_example;  // string | ID of the audit log entry to verify

            try
            {
                // Get entry by id
                AuditLogEntry result = apiInstance.GetEntryById(applicationId, entryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.GetEntryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **entryId** | **string**| ID of the audit log entry to verify | 

### Return type

[**AuditLogEntry**](AuditLogEntry.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethashbyentryid"></a>
# **GetHashByEntryId**
> LogResponse GetHashByEntryId (string applicationId, string entryId)

getHashByEntryId

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetHashByEntryIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var entryId = entryId_example;  // string | ID of the audit log entry to verify

            try
            {
                // getHashByEntryId
                LogResponse result = apiInstance.GetHashByEntryId(applicationId, entryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.GetHashByEntryId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **entryId** | **string**| ID of the audit log entry to verify | 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="log"></a>
# **Log**
> LogResponse Log (string applicationId, string action, string actorId, string auditLogEntryType = null, string signature = null, string actorDepartment = null, string actorDisplayName = null, List<string> actorRoles = null, bool? binaryContent = null, byte[] details = null, List<string> directExternalPush = null, List<string> encryptedKeywords = null, string gdprCorrelationKey = null, string logLevel = null, long? originalEventTimestamp = null, string process = null)

Log an event by a given actor

Log an event by specifying actor and action, as well as the request body. There are no limitations to the structure of the request body.

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var action = action_example;  // string | The name of the action being logged
            var actorId = actorId_example;  // string | ID of the actor performing the action being logged
            var auditLogEntryType = auditLogEntryType_example;  // string | The type of the event (optional)  (default to BUSINESS_LOGIC_ENTRY)
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var actorDepartment = actorDepartment_example;  // string | actorDepartment (optional) 
            var actorDisplayName = actorDisplayName_example;  // string | Display name of the actor (e.g. a name, in case ID is not human-readable) (optional) 
            var actorRoles = new List<string>(); // List<string> | The roles of the actor (optional) 
            var binaryContent = true;  // bool? | binaryContent (optional) 
            var details = BINARY_DATA_HERE;  // byte[] | Any details in any format about the event that you want to store in the log (optional) 
            var directExternalPush = directExternalPush_example;  // List<string> | directExternalPush (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 
            var gdprCorrelationKey = gdprCorrelationKey_example;  // string | If the event is about GDPR-related action, you can correlate it with a process in the GDPR register (optional) 
            var logLevel = logLevel_example;  // string | logLevel (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 
            var process = process_example;  // string | process (optional) 

            try
            {
                // Log an event by a given actor
                LogResponse result = apiInstance.Log(applicationId, action, actorId, auditLogEntryType, signature, actorDepartment, actorDisplayName, actorRoles, binaryContent, details, directExternalPush, encryptedKeywords, gdprCorrelationKey, logLevel, originalEventTimestamp, process);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.Log: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **action** | **string**| The name of the action being logged | 
 **actorId** | **string**| ID of the actor performing the action being logged | 
 **auditLogEntryType** | **string**| The type of the event | [optional] [default to BUSINESS_LOGIC_ENTRY]
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **actorDepartment** | **string**| actorDepartment | [optional] 
 **actorDisplayName** | **string**| Display name of the actor (e.g. a name, in case ID is not human-readable) | [optional] 
 **actorRoles** | [**List&lt;string&gt;**](string.md)| The roles of the actor | [optional] 
 **binaryContent** | **bool?**| binaryContent | [optional] 
 **details** | **byte[]**| Any details in any format about the event that you want to store in the log | [optional] 
 **directExternalPush** | **List&lt;string&gt;**| directExternalPush | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 
 **gdprCorrelationKey** | **string**| If the event is about GDPR-related action, you can correlate it with a process in the GDPR register | [optional] 
 **logLevel** | **string**| logLevel | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 
 **process** | **string**| process | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logauthaction"></a>
# **LogAuthAction**
> LogResponse LogAuthAction (string applicationId, string actorId, string authAction, string signature = null, string signedLoginChallenge = null, string userPublicKey = null, string actorDepartment = null, string actorDisplayName = null, List<string> actorRoles = null, bool? binaryContent = null, byte[] details = null, List<string> directExternalPush = null, List<string> encryptedKeywords = null, string gdprCorrelationKey = null, long? originalEventTimestamp = null, string process = null)

Log an authentication event with the option to pass actor public key and signature

Log an authentication action (e.g. login, signup, logout, auto-login).

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogAuthActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var actorId = actorId_example;  // string | ID of the actor performing the action being logged
            var authAction = authAction_example;  // string | Specific action related to user authentication
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var signedLoginChallenge = signedLoginChallenge_example;  // string | Signed-Login-Challenge (optional) 
            var userPublicKey = userPublicKey_example;  // string | User-Public-Key (optional) 
            var actorDepartment = actorDepartment_example;  // string | actorDepartment (optional) 
            var actorDisplayName = actorDisplayName_example;  // string | Display name of the actor (e.g. a name, in case ID is not human-readable) (optional) 
            var actorRoles = new List<string>(); // List<string> | The roles of the actor (optional) 
            var binaryContent = true;  // bool? | binaryContent (optional) 
            var details = BINARY_DATA_HERE;  // byte[] | Any details in any format about the event that you want to store in the log (optional) 
            var directExternalPush = directExternalPush_example;  // List<string> | directExternalPush (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 
            var gdprCorrelationKey = gdprCorrelationKey_example;  // string | If the event is about GDPR-related action, you can correlate it with a process in the GDPR register (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 
            var process = process_example;  // string | process (optional) 

            try
            {
                // Log an authentication event with the option to pass actor public key and signature
                LogResponse result = apiInstance.LogAuthAction(applicationId, actorId, authAction, signature, signedLoginChallenge, userPublicKey, actorDepartment, actorDisplayName, actorRoles, binaryContent, details, directExternalPush, encryptedKeywords, gdprCorrelationKey, originalEventTimestamp, process);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.LogAuthAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **actorId** | **string**| ID of the actor performing the action being logged | 
 **authAction** | **string**| Specific action related to user authentication | 
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **signedLoginChallenge** | **string**| Signed-Login-Challenge | [optional] 
 **userPublicKey** | **string**| User-Public-Key | [optional] 
 **actorDepartment** | **string**| actorDepartment | [optional] 
 **actorDisplayName** | **string**| Display name of the actor (e.g. a name, in case ID is not human-readable) | [optional] 
 **actorRoles** | [**List&lt;string&gt;**](string.md)| The roles of the actor | [optional] 
 **binaryContent** | **bool?**| binaryContent | [optional] 
 **details** | **byte[]**| Any details in any format about the event that you want to store in the log | [optional] 
 **directExternalPush** | **List&lt;string&gt;**| directExternalPush | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 
 **gdprCorrelationKey** | **string**| If the event is about GDPR-related action, you can correlate it with a process in the GDPR register | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 
 **process** | **string**| process | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logbatch"></a>
# **LogBatch**
> LogResponse LogBatch (string applicationId, List<BatchLogRequestEntry> requestData)

Log multiple events at the same time. This should rarely be used, but allows background processes to push multiple events at the same time

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogBatchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var requestData = new List<BatchLogRequestEntry>(); // List<BatchLogRequestEntry> | A list of log requests

            try
            {
                // Log multiple events at the same time. This should rarely be used, but allows background processes to push multiple events at the same time
                LogResponse result = apiInstance.LogBatch(applicationId, requestData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.LogBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **requestData** | [**List&lt;BatchLogRequestEntry&gt;**](BatchLogRequestEntry.md)| A list of log requests | 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logdocument"></a>
# **LogDocument**
> LogResponse LogDocument (string applicationId, string action, string actorId, byte[] details, string documentId, string signature = null, string actorDepartment = null, string actorDisplayName = null, List<string> actorRoles = null, bool? binaryContent = null, List<string> directExternalPush = null, string documentName = null, string documentType = null, List<string> encryptedKeywords = null, string gdprCorrelationKey = null, long? originalEventTimestamp = null, string process = null)

Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action

Log a document action. If working with documents, use this to store all events relating to a particular document - creation, modification, deletion, retrieval. You can store the hash of the document in the request body to ensure its integrity.

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogDocumentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var action = action_example;  // string | The name of the action being logged
            var actorId = actorId_example;  // string | ID of the actor performing the action being logged
            var details = BINARY_DATA_HERE;  // byte[] | Any details in any format about the event that you want to store in the log
            var documentId = documentId_example;  // string | documentId
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var actorDepartment = actorDepartment_example;  // string | actorDepartment (optional) 
            var actorDisplayName = actorDisplayName_example;  // string | Display name of the actor (e.g. a name, in case ID is not human-readable) (optional) 
            var actorRoles = new List<string>(); // List<string> | The roles of the actor (optional) 
            var binaryContent = true;  // bool? | binaryContent (optional)  (default to true)
            var directExternalPush = directExternalPush_example;  // List<string> | directExternalPush (optional) 
            var documentName = documentName_example;  // string | documentName (optional) 
            var documentType = documentType_example;  // string | documentType (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 
            var gdprCorrelationKey = gdprCorrelationKey_example;  // string | If the event is about GDPR-related action, you can correlate it with a process in the GDPR register (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 
            var process = process_example;  // string | process (optional) 

            try
            {
                // Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action
                LogResponse result = apiInstance.LogDocument(applicationId, action, actorId, details, documentId, signature, actorDepartment, actorDisplayName, actorRoles, binaryContent, directExternalPush, documentName, documentType, encryptedKeywords, gdprCorrelationKey, originalEventTimestamp, process);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.LogDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **action** | **string**| The name of the action being logged | 
 **actorId** | **string**| ID of the actor performing the action being logged | 
 **details** | **byte[]**| Any details in any format about the event that you want to store in the log | 
 **documentId** | **string**| documentId | 
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **actorDepartment** | **string**| actorDepartment | [optional] 
 **actorDisplayName** | **string**| Display name of the actor (e.g. a name, in case ID is not human-readable) | [optional] 
 **actorRoles** | [**List&lt;string&gt;**](string.md)| The roles of the actor | [optional] 
 **binaryContent** | **bool?**| binaryContent | [optional] [default to true]
 **directExternalPush** | **List&lt;string&gt;**| directExternalPush | [optional] 
 **documentName** | **string**| documentName | [optional] 
 **documentType** | **string**| documentType | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 
 **gdprCorrelationKey** | **string**| If the event is about GDPR-related action, you can correlate it with a process in the GDPR register | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 
 **process** | **string**| process | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logfull"></a>
# **LogFull**
> LogResponse LogFull (string applicationId, string action, string actorId, string entityId, string entityType, string auditLogEntryType = null, string signature = null, string actorDepartment = null, string actorDisplayName = null, List<string> actorRoles = null, bool? binaryContent = null, byte[] details = null, List<string> directExternalPush = null, List<string> encryptedKeywords = null, string gdprCorrelationKey = null, string logLevel = null, long? originalEventTimestamp = null, string process = null)

Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action

Log an even by specifying all relevant details - actor, action and the entity about which the action is, as well as the request body. There are no limitations to the structure of the request body.

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogFullExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var action = action_example;  // string | The name of the action being logged
            var actorId = actorId_example;  // string | ID of the actor performing the action being logged
            var entityId = entityId_example;  // string | When the event is about a particular model entity, you can set its ID here
            var entityType = entityType_example;  // string | When the event is about a particular model entity, you can set its type here
            var auditLogEntryType = auditLogEntryType_example;  // string | The type of the event (optional)  (default to BUSINESS_LOGIC_ENTRY)
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var actorDepartment = actorDepartment_example;  // string | actorDepartment (optional) 
            var actorDisplayName = actorDisplayName_example;  // string | Display name of the actor (e.g. a name, in case ID is not human-readable) (optional) 
            var actorRoles = new List<string>(); // List<string> | The roles of the actor (optional) 
            var binaryContent = true;  // bool? | binaryContent (optional) 
            var details = BINARY_DATA_HERE;  // byte[] | Any details in any format about the event that you want to store in the log (optional) 
            var directExternalPush = directExternalPush_example;  // List<string> | directExternalPush (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 
            var gdprCorrelationKey = gdprCorrelationKey_example;  // string | If the event is about GDPR-related action, you can correlate it with a process in the GDPR register (optional) 
            var logLevel = logLevel_example;  // string | logLevel (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 
            var process = process_example;  // string | process (optional) 

            try
            {
                // Log an event by providing full details. Action can be INSERT/UPDATE/DELETE/GET or any custom action
                LogResponse result = apiInstance.LogFull(applicationId, action, actorId, entityId, entityType, auditLogEntryType, signature, actorDepartment, actorDisplayName, actorRoles, binaryContent, details, directExternalPush, encryptedKeywords, gdprCorrelationKey, logLevel, originalEventTimestamp, process);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.LogFull: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **action** | **string**| The name of the action being logged | 
 **actorId** | **string**| ID of the actor performing the action being logged | 
 **entityId** | **string**| When the event is about a particular model entity, you can set its ID here | 
 **entityType** | **string**| When the event is about a particular model entity, you can set its type here | 
 **auditLogEntryType** | **string**| The type of the event | [optional] [default to BUSINESS_LOGIC_ENTRY]
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **actorDepartment** | **string**| actorDepartment | [optional] 
 **actorDisplayName** | **string**| Display name of the actor (e.g. a name, in case ID is not human-readable) | [optional] 
 **actorRoles** | [**List&lt;string&gt;**](string.md)| The roles of the actor | [optional] 
 **binaryContent** | **bool?**| binaryContent | [optional] 
 **details** | **byte[]**| Any details in any format about the event that you want to store in the log | [optional] 
 **directExternalPush** | **List&lt;string&gt;**| directExternalPush | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 
 **gdprCorrelationKey** | **string**| If the event is about GDPR-related action, you can correlate it with a process in the GDPR register | [optional] 
 **logLevel** | **string**| logLevel | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 
 **process** | **string**| process | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logsimple"></a>
# **LogSimple**
> LogResponse LogSimple (string applicationId, string auditLogEntryType = null, string signature = null, bool? binaryContent = null, byte[] details = null, List<string> directExternalPush = null, List<string> encryptedKeywords = null, string logLevel = null, long? originalEventTimestamp = null)

Log an event by providing just the body without any additional metadata. The body can be fully encrypted or can represent just the hash of the data/document

Log an event by just specifying the request body. There are no limitations to the structure of the request body.

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogSimpleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LoggingApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var auditLogEntryType = auditLogEntryType_example;  // string | The type of the event (optional)  (default to BUSINESS_LOGIC_ENTRY)
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var binaryContent = true;  // bool? | binaryContent (optional) 
            var details = BINARY_DATA_HERE;  // byte[] | Any details in any format about the event that you want to store in the log (optional) 
            var directExternalPush = directExternalPush_example;  // List<string> | directExternalPush (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 
            var logLevel = logLevel_example;  // string | logLevel (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 

            try
            {
                // Log an event by providing just the body without any additional metadata. The body can be fully encrypted or can represent just the hash of the data/document
                LogResponse result = apiInstance.LogSimple(applicationId, auditLogEntryType, signature, binaryContent, details, directExternalPush, encryptedKeywords, logLevel, originalEventTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoggingApi.LogSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **auditLogEntryType** | **string**| The type of the event | [optional] [default to BUSINESS_LOGIC_ENTRY]
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **binaryContent** | **bool?**| binaryContent | [optional] 
 **details** | **byte[]**| Any details in any format about the event that you want to store in the log | [optional] 
 **directExternalPush** | **List&lt;string&gt;**| directExternalPush | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 
 **logLevel** | **string**| logLevel | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

