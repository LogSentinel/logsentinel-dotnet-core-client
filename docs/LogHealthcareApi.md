# LogSentinel.Client.Api.LogHealthcareApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogDicomEvent**](LogHealthcareApi.md#logdicomevent) | **POST** /api/dicom/log | Logs a DICOM audit message
[**LogFhirEvent**](LogHealthcareApi.md#logfhirevent) | **POST** /api/fhir/log | Logs a FHIR audit event in order to help with HIPAA compliance
[**LogIheEvent**](LogHealthcareApi.md#logiheevent) | **POST** /api/ihe/log | Logs an IHE audit message


<a name="logdicomevent"></a>
# **LogDicomEvent**
> LogResponse LogDicomEvent (string applicationId, string dicomAuditEvent)

Logs a DICOM audit message

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogDicomEventExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LogHealthcareApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var dicomAuditEvent = dicomAuditEvent_example;  // string | dicomAuditEvent

            try
            {
                // Logs a DICOM audit message
                LogResponse result = apiInstance.LogDicomEvent(applicationId, dicomAuditEvent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogHealthcareApi.LogDicomEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **dicomAuditEvent** | **string**| dicomAuditEvent | 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logfhirevent"></a>
# **LogFhirEvent**
> LogResponse LogFhirEvent (string applicationId, string fhirAuditEvent)

Logs a FHIR audit event in order to help with HIPAA compliance

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogFhirEventExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LogHealthcareApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var fhirAuditEvent = fhirAuditEvent_example;  // string | A record of an FHIR event made for purposes of maintaining a security log. See https://www.hl7.org/fhir/auditevent.html

            try
            {
                // Logs a FHIR audit event in order to help with HIPAA compliance
                LogResponse result = apiInstance.LogFhirEvent(applicationId, fhirAuditEvent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogHealthcareApi.LogFhirEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **fhirAuditEvent** | **string**| A record of an FHIR event made for purposes of maintaining a security log. See https://www.hl7.org/fhir/auditevent.html | 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logiheevent"></a>
# **LogIheEvent**
> LogResponse LogIheEvent (string applicationId, string iheAuditEvent)

Logs an IHE audit message

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class LogIheEventExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new LogHealthcareApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var iheAuditEvent = iheAuditEvent_example;  // string | iheAuditEvent

            try
            {
                // Logs an IHE audit message
                LogResponse result = apiInstance.LogIheEvent(applicationId, iheAuditEvent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogHealthcareApi.LogIheEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **iheAuditEvent** | **string**| iheAuditEvent | 

### Return type

[**LogResponse**](LogResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

