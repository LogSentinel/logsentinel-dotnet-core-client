# LogSentinel.Client.Api.LogSpecialApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogProvenance**](LogSpecialApi.md#logprovenance) | **POST** /api/provenance/log | Logs a Provenance document


<a name="logprovenance"></a>
# **LogProvenance**
> LogResponse LogProvenance (string applicationId, string provenanceDocument)

Logs a Provenance document

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogProvenanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LogSpecialApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var provenanceDocument = provenanceDocument_example;  // string | Provenance model document, representing event that serves security log purposes. See https://www.w3.org/TR/2013/NOTE-prov-primer-20130430/

            try
            {
                // Logs a Provenance document
                LogResponse result = apiInstance.LogProvenance(applicationId, provenanceDocument);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogSpecialApi.LogProvenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **provenanceDocument** | **string**| Provenance model document, representing event that serves security log purposes. See https://www.w3.org/TR/2013/NOTE-prov-primer-20130430/ | 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

