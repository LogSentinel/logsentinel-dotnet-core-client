# LogSentinel.Client.Api.SavedSearchesApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSavedSearch**](SavedSearchesApi.md#createsavedsearch) | **POST** /api/search/saved | Creates saved search
[**GetSavedSearchIds**](SavedSearchesApi.md#getsavedsearchids) | **GET** /api/search/saved/fetch | Fetches saved search ids of all users of an organization
[**PerformSavedSearch**](SavedSearchesApi.md#performsavedsearch) | **GET** /api/search/saved | Calls saved search by its id


<a name="createsavedsearch"></a>
# **CreateSavedSearch**
> List<SavedSearch> CreateSavedSearch (long? end, string name, int? page, int? pageSize, string query, long? start)

Creates saved search

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class CreateSavedSearchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SavedSearchesApi();
            var end = 789;  // long? | end
            var name = name_example;  // string | name
            var page = 56;  // int? | page
            var pageSize = 56;  // int? | pageSize
            var query = query_example;  // string | query
            var start = 789;  // long? | start

            try
            {
                // Creates saved search
                List&lt;SavedSearch&gt; result = apiInstance.CreateSavedSearch(end, name, page, pageSize, query, start);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SavedSearchesApi.CreateSavedSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **end** | **long?**| end | 
 **name** | **string**| name | 
 **page** | **int?**| page | 
 **pageSize** | **int?**| pageSize | 
 **query** | **string**| query | 
 **start** | **long?**| start | 

### Return type

[**List<SavedSearch>**](SavedSearch.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsavedsearchids"></a>
# **GetSavedSearchIds**
> List<SavedSearch> GetSavedSearchIds ()

Fetches saved search ids of all users of an organization

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetSavedSearchIdsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SavedSearchesApi();

            try
            {
                // Fetches saved search ids of all users of an organization
                List&lt;SavedSearch&gt; result = apiInstance.GetSavedSearchIds();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SavedSearchesApi.GetSavedSearchIds: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SavedSearch>**](SavedSearch.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performsavedsearch"></a>
# **PerformSavedSearch**
> List<AuditLogEntry> PerformSavedSearch (string savedSearchId)

Calls saved search by its id

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class PerformSavedSearchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SavedSearchesApi();
            var savedSearchId = savedSearchId_example;  // string | savedSearchId

            try
            {
                // Calls saved search by its id
                List&lt;AuditLogEntry&gt; result = apiInstance.PerformSavedSearch(savedSearchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SavedSearchesApi.PerformSavedSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **savedSearchId** | **string**| savedSearchId | 

### Return type

[**List<AuditLogEntry>**](AuditLogEntry.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

