# LogSentinel.Client.Api.SearchApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatch**](SearchApi.md#getbatch) | **GET** /api/search/batch | Search entries in batches by field
[**GetEntityHistory**](SearchApi.md#getentityhistory) | **GET** /api/search/entityHistory | Get entity history
[**Search**](SearchApi.md#search) | **POST** /api/search | Search logged entries


<a name="getbatch"></a>
# **GetBatch**
> List<AuditLogEntry> GetBatch (string applicationId, string field, List<string> values, int? batchSize = null, string entityType = null, int? page = null)

Search entries in batches by field

Search entries by specifying a list of actorIds or entityIds. If entityId is specified, entityType should also be specified.

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetBatchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SearchApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var field = field_example;  // string | Field to search in for the supplied values
            var values = new List<string>(); // List<string> | Values that match the specified field
            var batchSize = 56;  // int? | batchSize (optional)  (default to 1000)
            var entityType = entityType_example;  // string | When the event is about a particular model entity, you can set its type here (optional) 
            var page = 56;  // int? | page (optional)  (default to 0)

            try
            {
                // Search entries in batches by field
                List&lt;AuditLogEntry&gt; result = apiInstance.GetBatch(applicationId, field, values, batchSize, entityType, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **field** | **string**| Field to search in for the supplied values | 
 **values** | [**List&lt;string&gt;**](string.md)| Values that match the specified field | 
 **batchSize** | **int?**| batchSize | [optional] [default to 1000]
 **entityType** | **string**| When the event is about a particular model entity, you can set its type here | [optional] 
 **page** | **int?**| page | [optional] [default to 0]

### Return type

[**List<AuditLogEntry>**](AuditLogEntry.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentityhistory"></a>
# **GetEntityHistory**
> List<AuditLogEntry> GetEntityHistory (string applicationId, string entityId, string entityType)

Get entity history

Fetches all entries related to a specific entity (specified by type and id). Entity modifications can consist of diffs, so that fetching the whole history can be used for reconstructing the current state of the entity

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetEntityHistoryExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SearchApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var entityId = entityId_example;  // string | When the event is about a particular model entity, you can set its ID here
            var entityType = entityType_example;  // string | When the event is about a particular model entity, you can set its type here

            try
            {
                // Get entity history
                List&lt;AuditLogEntry&gt; result = apiInstance.GetEntityHistory(applicationId, entityId, entityType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetEntityHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **entityId** | **string**| When the event is about a particular model entity, you can set its ID here | 
 **entityType** | **string**| When the event is about a particular model entity, you can set its type here | 

### Return type

[**List<AuditLogEntry>**](AuditLogEntry.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> List<AuditLogEntry> Search (string applicationId, SearchRequest searchRequest)

Search logged entries

Perform search using a Lucene query. The lucene query syntax can be <a href=\"https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-query-string-query.html#query-string-syntax\">found here</a>

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SearchApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var searchRequest = new SearchRequest(); // SearchRequest | searchRequest

            try
            {
                // Search logged entries
                List&lt;AuditLogEntry&gt; result = apiInstance.Search(applicationId, searchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **searchRequest** | [**SearchRequest**](SearchRequest.md)| searchRequest | 

### Return type

[**List<AuditLogEntry>**](AuditLogEntry.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

