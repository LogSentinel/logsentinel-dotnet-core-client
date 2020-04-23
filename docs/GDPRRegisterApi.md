# LogSentinel.Client.Api.GDPRRegisterApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEntity**](GDPRRegisterApi.md#addentity) | **POST** /api/gdpr/addEntity | Adds entitity to the GDPR register
[**DeleteEntity**](GDPRRegisterApi.md#deleteentity) | **DELETE** /api/gdpr/entity | Deletes entity in the GDPR register
[**DeleteRecord**](GDPRRegisterApi.md#deleterecord) | **DELETE** /api/gdpr/record | Deletes record  from the GDPR register
[**GdprEntities**](GDPRRegisterApi.md#gdprentities) | **GET** /api/gdpr/entities | Fetch entities from the GDPR register
[**GetEntity**](GDPRRegisterApi.md#getentity) | **GET** /api/gdpr/entity | Gets entity by id from the GDPR register
[**GetRecord**](GDPRRegisterApi.md#getrecord) | **GET** /api/gdpr/record | Gets record by id from the GDPR register
[**GetRecords**](GDPRRegisterApi.md#getrecords) | **GET** /api/gdpr/records | Fetch records from the GDPR register
[**SaveEntity**](GDPRRegisterApi.md#saveentity) | **POST** /api/gdpr/entity | Updates entity in the GDPR register
[**SaveRecord**](GDPRRegisterApi.md#saverecord) | **POST** /api/gdpr/saveRecord | Saves record in the GDPR register


<a name="addentity"></a>
# **AddEntity**
> Guid? AddEntity (GDPRResponsibleEntity request)

Adds entitity to the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class AddEntityExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var request = new GDPRResponsibleEntity(); // GDPRResponsibleEntity | request

            try
            {
                // Adds entitity to the GDPR register
                Guid? result = apiInstance.AddEntity(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.AddEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GDPRResponsibleEntity**](GDPRResponsibleEntity.md)| request | 

### Return type

**Guid?**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteentity"></a>
# **DeleteEntity**
> GDPRResponsibleEntity DeleteEntity (Guid? id)

Deletes entity in the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class DeleteEntityExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var id = new Guid?(); // Guid? | id

            try
            {
                // Deletes entity in the GDPR register
                GDPRResponsibleEntity result = apiInstance.DeleteEntity(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.DeleteEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| id | 

### Return type

[**GDPRResponsibleEntity**](GDPRResponsibleEntity.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterecord"></a>
# **DeleteRecord**
> GDPRRegisterRecord DeleteRecord (Guid? id)

Deletes record  from the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class DeleteRecordExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var id = new Guid?(); // Guid? | id

            try
            {
                // Deletes record  from the GDPR register
                GDPRRegisterRecord result = apiInstance.DeleteRecord(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.DeleteRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| id | 

### Return type

[**GDPRRegisterRecord**](GDPRRegisterRecord.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gdprentities"></a>
# **GdprEntities**
> List<GDPRResponsibleEntity> GdprEntities ()

Fetch entities from the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GdprEntitiesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();

            try
            {
                // Fetch entities from the GDPR register
                List&lt;GDPRResponsibleEntity&gt; result = apiInstance.GdprEntities();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.GdprEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<GDPRResponsibleEntity>**](GDPRResponsibleEntity.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentity"></a>
# **GetEntity**
> GDPRResponsibleEntity GetEntity (Guid? id)

Gets entity by id from the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetEntityExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var id = new Guid?(); // Guid? | id

            try
            {
                // Gets entity by id from the GDPR register
                GDPRResponsibleEntity result = apiInstance.GetEntity(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.GetEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| id | 

### Return type

[**GDPRResponsibleEntity**](GDPRResponsibleEntity.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecord"></a>
# **GetRecord**
> GDPRRegisterRecord GetRecord (Guid? id)

Gets record by id from the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetRecordExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var id = new Guid?(); // Guid? | id

            try
            {
                // Gets record by id from the GDPR register
                GDPRRegisterRecord result = apiInstance.GetRecord(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.GetRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| id | 

### Return type

[**GDPRRegisterRecord**](GDPRRegisterRecord.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecords"></a>
# **GetRecords**
> List<GDPRRegisterRecordDto> GetRecords (string role, List<string> filterTags = null)

Fetch records from the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetRecordsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var role = role_example;  // string | role
            var filterTags = new List<string>(); // List<string> | Limit the response by providing specific tags (optional) 

            try
            {
                // Fetch records from the GDPR register
                List&lt;GDPRRegisterRecordDto&gt; result = apiInstance.GetRecords(role, filterTags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.GetRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| role | 
 **filterTags** | [**List&lt;string&gt;**](string.md)| Limit the response by providing specific tags | [optional] 

### Return type

[**List<GDPRRegisterRecordDto>**](GDPRRegisterRecordDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveentity"></a>
# **SaveEntity**
> Guid? SaveEntity (GDPRResponsibleEntity request)

Updates entity in the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class SaveEntityExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var request = new GDPRResponsibleEntity(); // GDPRResponsibleEntity | request

            try
            {
                // Updates entity in the GDPR register
                Guid? result = apiInstance.SaveEntity(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.SaveEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GDPRResponsibleEntity**](GDPRResponsibleEntity.md)| request | 

### Return type

**Guid?**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saverecord"></a>
# **SaveRecord**
> Guid? SaveRecord (GDPRRegisterRecord record)

Saves record in the GDPR register

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class SaveRecordExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GDPRRegisterApi();
            var record = new GDPRRegisterRecord(); // GDPRRegisterRecord | record

            try
            {
                // Saves record in the GDPR register
                Guid? result = apiInstance.SaveRecord(record);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GDPRRegisterApi.SaveRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **record** | [**GDPRRegisterRecord**](GDPRRegisterRecord.md)| record | 

### Return type

**Guid?**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

