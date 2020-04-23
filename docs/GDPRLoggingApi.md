# LogSentinel.Client.Api.GDPRLoggingApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogConsent**](GDPRLoggingApi.md#logconsent) | **POST** /api/log-gdpr/consent | Log the consent by a given user
[**LogGdprRequest**](GDPRLoggingApi.md#loggdprrequest) | **POST** /api/log-gdpr/request/{requestType} | Log a GDPR request by a given user
[**LogRequestResults**](GDPRLoggingApi.md#logrequestresults) | **POST** /api/log-gdpr/request-result/{requestType} | Push data about the result of a GDPR request


<a name="logconsent"></a>
# **LogConsent**
> LogResponse LogConsent (Consent consent, string signature = null, List<string> encryptedKeywords = null)

Log the consent by a given user

Logs GDPR consent. Include any consent-related data (e.g. data subject ID, data subject names, processing activity or any other details). You can also log consent withdrawal (include \"withdrawal\" in the additional details field). 

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogConsentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRLoggingApi();
            var consent = new Consent(); // Consent | Details about the consent. You should normally pass the data subject ID and the processing activity for which the consent is given.
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 

            try
            {
                // Log the consent by a given user
                LogResponse result = apiInstance.LogConsent(consent, signature, encryptedKeywords);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRLoggingApi.LogConsent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consent** | [**Consent**](Consent.md)| Details about the consent. You should normally pass the data subject ID and the processing activity for which the consent is given. | 
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loggdprrequest"></a>
# **LogGdprRequest**
> LogResponse LogGdprRequest (GDPRRequest gdprRequest, string requestType, string signature = null, List<string> encryptedKeywords = null)

Log a GDPR request by a given user

Log a request for data subject rights under GDPR. Include the data subject details as well as any relevant additional details.

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogGdprRequestExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRLoggingApi();
            var gdprRequest = new GDPRRequest(); // GDPRRequest | gdprRequest
            var requestType = requestType_example;  // string | requestType
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 

            try
            {
                // Log a GDPR request by a given user
                LogResponse result = apiInstance.LogGdprRequest(gdprRequest, requestType, signature, encryptedKeywords);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRLoggingApi.LogGdprRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gdprRequest** | [**GDPRRequest**](GDPRRequest.md)| gdprRequest | 
 **requestType** | **string**| requestType | 
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logrequestresults"></a>
# **LogRequestResults**
> LogResponse LogRequestResults (string requestType, Result result, string signature = null, List<string> encryptedKeywords = null)

Push data about the result of a GDPR request

Log the result of handling a GDPR request. E.g. after manually reviewing a request for erasure or for data portability, you should log whether the request was approved and executed or not, including the reasons why.

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogRequestResultsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRLoggingApi();
            var requestType = requestType_example;  // string | requestType
            var result = new Result(); // Result | result
            var signature = signature_example;  // string | Base64-encoded digital signature on the entry details (the request body) (optional) 
            var encryptedKeywords = new List<string>(); // List<string> | If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text (optional) 

            try
            {
                // Push data about the result of a GDPR request
                LogResponse result = apiInstance.LogRequestResults(requestType, result, signature, encryptedKeywords);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRLoggingApi.LogRequestResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestType** | **string**| requestType | 
 **result** | [**Result**](Result.md)| result | 
 **signature** | **string**| Base64-encoded digital signature on the entry details (the request body) | [optional] 
 **encryptedKeywords** | [**List&lt;string&gt;**](string.md)| If you are encrypting the parameters in your request, you can extract and encrypt keywords client-side and send them to us in order to make use of our search functionality over encrypted text | [optional] 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

