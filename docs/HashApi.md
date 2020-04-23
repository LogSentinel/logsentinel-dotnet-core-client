# LogSentinel.Client.Api.HashApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHash**](HashApi.md#gethash) | **POST** /api/getStandaloneHash | Get the standalone (non-chained) hash for an entry
[**GetHashableContent**](HashApi.md#gethashablecontent) | **POST** /api/getHashableContent/{actorId}/{action} | Get the content over which to compute the hash of a request for simple (minimal metadata) actions
[**GetHashableContentForAuthAction**](HashApi.md#gethashablecontentforauthaction) | **POST** /api/getHashableContent/{actorId}/auth/{authAction} | Get the content over which to compute the hash of a request for auth actions
[**GetHashableContentForStandardAction**](HashApi.md#gethashablecontentforstandardaction) | **POST** /api/getHashableContent/{actorId}/{action}/{entityType}/{entityId} | Get the content over which to compute the hash of a request for standard actions
[**GetHashableContentSimple**](HashApi.md#gethashablecontentsimple) | **POST** /api/getHashableContent | Get the content over which to compute the hash of a request without any additional metadata (including encrypted request bodies)


<a name="gethash"></a>
# **GetHash**
> string GetHash (string applicationId, Guid? entryId)

Get the standalone (non-chained) hash for an entry

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetHashExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HashApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var entryId = new Guid?(); // Guid? | ID of the audit log entry to verify

            try
            {
                // Get the standalone (non-chained) hash for an entry
                string result = apiInstance.GetHash(applicationId, entryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HashApi.GetHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **entryId** | [**Guid?**](Guid?.md)| ID of the audit log entry to verify | 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethashablecontent"></a>
# **GetHashableContent**
> string GetHashableContent (string applicationId, string action, string actorId, string auditLogEntryType = null, string signature = null, string actorDepartment = null, string actorDisplayName = null, List<string> actorRoles = null, string details = null, string logLevel = null, long? originalEventTimestamp = null)

Get the content over which to compute the hash of a request for simple (minimal metadata) actions

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetHashableContentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HashApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var action = action_example;  // string | The name of the action being logged
            var actorId = actorId_example;  // string | ID of the actor performing the action being logged
            var auditLogEntryType = auditLogEntryType_example;  // string | The type of the event (optional)  (default to BUSINESS_LOGIC_ENTRY)
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var actorDepartment = actorDepartment_example;  // string | actorDepartment (optional) 
            var actorDisplayName = actorDisplayName_example;  // string | Display name of the actor (e.g. a name, in case ID is not human-readable) (optional) 
            var actorRoles = new List<string>(); // List<string> | The roles of the actor (optional) 
            var details = details_example;  // string | Any details in any format about the event that you want to store in the log (optional) 
            var logLevel = logLevel_example;  // string | logLevel (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 

            try
            {
                // Get the content over which to compute the hash of a request for simple (minimal metadata) actions
                string result = apiInstance.GetHashableContent(applicationId, action, actorId, auditLogEntryType, signature, actorDepartment, actorDisplayName, actorRoles, details, logLevel, originalEventTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HashApi.GetHashableContent: " + e.Message );
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
 **details** | **string**| Any details in any format about the event that you want to store in the log | [optional] 
 **logLevel** | **string**| logLevel | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethashablecontentforauthaction"></a>
# **GetHashableContentForAuthAction**
> string GetHashableContentForAuthAction (string applicationId, string actorId, string authAction, string signature = null, string signedLoginChallenge = null, string userPublicKey = null, string actorDepartment = null, string actorDisplayName = null, List<string> actorRoles = null, string details = null, long? originalEventTimestamp = null)

Get the content over which to compute the hash of a request for auth actions

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetHashableContentForAuthActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HashApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var actorId = actorId_example;  // string | ID of the actor performing the action being logged
            var authAction = authAction_example;  // string | Specific action related to user authentication
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var signedLoginChallenge = signedLoginChallenge_example;  // string | Signed-Login-Challenge (optional) 
            var userPublicKey = userPublicKey_example;  // string | User-Public-Key (optional) 
            var actorDepartment = actorDepartment_example;  // string | actorDepartment (optional) 
            var actorDisplayName = actorDisplayName_example;  // string | Display name of the actor (e.g. a name, in case ID is not human-readable) (optional) 
            var actorRoles = new List<string>(); // List<string> | The roles of the actor (optional) 
            var details = details_example;  // string | Any details in any format about the event that you want to store in the log (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 

            try
            {
                // Get the content over which to compute the hash of a request for auth actions
                string result = apiInstance.GetHashableContentForAuthAction(applicationId, actorId, authAction, signature, signedLoginChallenge, userPublicKey, actorDepartment, actorDisplayName, actorRoles, details, originalEventTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HashApi.GetHashableContentForAuthAction: " + e.Message );
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
 **details** | **string**| Any details in any format about the event that you want to store in the log | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethashablecontentforstandardaction"></a>
# **GetHashableContentForStandardAction**
> string GetHashableContentForStandardAction (string applicationId, string action, string actorId, string entityId, string entityType, string auditLogEntryType = null, string signature = null, string actorDepartment = null, string actorDisplayName = null, List<string> actorRoles = null, string details = null, string logLevel = null, long? originalEventTimestamp = null)

Get the content over which to compute the hash of a request for standard actions

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetHashableContentForStandardActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HashApi();
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
            var details = details_example;  // string | Any details in any format about the event that you want to store in the log (optional) 
            var logLevel = logLevel_example;  // string | logLevel (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 

            try
            {
                // Get the content over which to compute the hash of a request for standard actions
                string result = apiInstance.GetHashableContentForStandardAction(applicationId, action, actorId, entityId, entityType, auditLogEntryType, signature, actorDepartment, actorDisplayName, actorRoles, details, logLevel, originalEventTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HashApi.GetHashableContentForStandardAction: " + e.Message );
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
 **details** | **string**| Any details in any format about the event that you want to store in the log | [optional] 
 **logLevel** | **string**| logLevel | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethashablecontentsimple"></a>
# **GetHashableContentSimple**
> string GetHashableContentSimple (string applicationId, string auditLogEntryType = null, string signature = null, string details = null, string logLevel = null, long? originalEventTimestamp = null)

Get the content over which to compute the hash of a request without any additional metadata (including encrypted request bodies)

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetHashableContentSimpleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HashApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var auditLogEntryType = auditLogEntryType_example;  // string | The type of the event (optional)  (default to BUSINESS_LOGIC_ENTRY)
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var details = details_example;  // string | Any details in any format about the event that you want to store in the log (optional) 
            var logLevel = logLevel_example;  // string | logLevel (optional) 
            var originalEventTimestamp = 789;  // long? | originalEventTimestamp (optional) 

            try
            {
                // Get the content over which to compute the hash of a request without any additional metadata (including encrypted request bodies)
                string result = apiInstance.GetHashableContentSimple(applicationId, auditLogEntryType, signature, details, logLevel, originalEventTimestamp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HashApi.GetHashableContentSimple: " + e.Message );
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
 **details** | **string**| Any details in any format about the event that you want to store in the log | [optional] 
 **logLevel** | **string**| logLevel | [optional] 
 **originalEventTimestamp** | **long?**| originalEventTimestamp | [optional] 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

