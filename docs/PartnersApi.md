# LogSentinel.Client.Api.PartnersApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelOrganization**](PartnersApi.md#cancelorganization) | **DELETE** /api/partner/organizations/cancel | Cancels organization by Id and deletes all users
[**FetchAllOrganizations**](PartnersApi.md#fetchallorganizations) | **GET** /api/partner/organizations | Fetch all organizations
[**GetApiCredentials**](PartnersApi.md#getapicredentials) | **GET** /api/partner/organizations/apiCredentials | API credentials per organization from organizations owned by partner
[**GetOrganizationByUserEmail**](PartnersApi.md#getorganizationbyuseremail) | **GET** /api/partner/organizationByUserEmail | Get the organization for the supplied email
[**GetUserIdByEmail**](PartnersApi.md#getuseridbyemail) | **GET** /api/partner/userIdByEmail | Get user id by user email
[**RegisterUser**](PartnersApi.md#registeruser) | **POST** /api/partner/user/register | Register a user


<a name="cancelorganization"></a>
# **CancelOrganization**
> void CancelOrganization (Guid? organizationId)

Cancels organization by Id and deletes all users

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class CancelOrganizationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartnersApi();
            var organizationId = new Guid?(); // Guid? | organizationId

            try
            {
                // Cancels organization by Id and deletes all users
                apiInstance.CancelOrganization(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnersApi.CancelOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | [**Guid?**](Guid?.md)| organizationId | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetchallorganizations"></a>
# **FetchAllOrganizations**
> List<Guid?> FetchAllOrganizations ()

Fetch all organizations

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class FetchAllOrganizationsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartnersApi();

            try
            {
                // Fetch all organizations
                List&lt;Guid?&gt; result = apiInstance.FetchAllOrganizations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnersApi.FetchAllOrganizations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<Guid?>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapicredentials"></a>
# **GetApiCredentials**
> Dictionary<string, List<APICredentialsOrganization>> GetApiCredentials ()

API credentials per organization from organizations owned by partner

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetApiCredentialsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartnersApi();

            try
            {
                // API credentials per organization from organizations owned by partner
                Dictionary&lt;string, List&lt;APICredentialsOrganization&gt;&gt; result = apiInstance.GetApiCredentials();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnersApi.GetApiCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, List<APICredentialsOrganization>>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationbyuseremail"></a>
# **GetOrganizationByUserEmail**
> OrganizationDto GetOrganizationByUserEmail (string email)

Get the organization for the supplied email

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetOrganizationByUserEmailExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartnersApi();
            var email = email_example;  // string | email

            try
            {
                // Get the organization for the supplied email
                OrganizationDto result = apiInstance.GetOrganizationByUserEmail(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnersApi.GetOrganizationByUserEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| email | 

### Return type

[**OrganizationDto**](OrganizationDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseridbyemail"></a>
# **GetUserIdByEmail**
> Guid? GetUserIdByEmail (string email)

Get user id by user email

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetUserIdByEmailExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartnersApi();
            var email = email_example;  // string | email

            try
            {
                // Get user id by user email
                Guid? result = apiInstance.GetUserIdByEmail(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnersApi.GetUserIdByEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| email | 

### Return type

**Guid?**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeruser"></a>
# **RegisterUser**
> RegistrationResponse RegisterUser (UserRegistrationRequest request)

Register a user

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class RegisterUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartnersApi();
            var request = new UserRegistrationRequest(); // UserRegistrationRequest | request

            try
            {
                // Register a user
                RegistrationResponse result = apiInstance.RegisterUser(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartnersApi.RegisterUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserRegistrationRequest**](UserRegistrationRequest.md)| request | 

### Return type

[**RegistrationResponse**](RegistrationResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

