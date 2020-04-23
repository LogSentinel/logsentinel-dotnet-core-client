# LogSentinel.Client.Api.OrganizationUsersApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeRole**](OrganizationUsersApi.md#changerole) | **POST** /api/users/userId/{userId}/changeRole/{role} | Changes user role
[**Create**](OrganizationUsersApi.md#create) | **PUT** /api/users/create | Creates new user in the organization
[**ForgetUser**](OrganizationUsersApi.md#forgetuser) | **POST** /api/users/forget/{userId} | Forgets user profile
[**GetUserDetailsByEmail**](OrganizationUsersApi.md#getuserdetailsbyemail) | **GET** /api/users/email/{email} | Gets user details by email
[**GetUserDetailsById**](OrganizationUsersApi.md#getuserdetailsbyid) | **GET** /api/users/userId/{userId} | Gets user details by user id
[**Update**](OrganizationUsersApi.md#update) | **POST** /api/users/update | Updates user profile


<a name="changerole"></a>
# **ChangeRole**
> UserDetails ChangeRole (string role, Guid? userId)

Changes user role

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class ChangeRoleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationUsersApi();
            var role = role_example;  // string | role
            var userId = new Guid?(); // Guid? | userId

            try
            {
                // Changes user role
                UserDetails result = apiInstance.ChangeRole(role, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUsersApi.ChangeRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| role | 
 **userId** | [**Guid?**](Guid?.md)| userId | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> UserDetails Create (UserRegistrationRequest request)

Creates new user in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationUsersApi();
            var request = new UserRegistrationRequest(); // UserRegistrationRequest | request

            try
            {
                // Creates new user in the organization
                UserDetails result = apiInstance.Create(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUsersApi.Create: " + e.Message );
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

[**UserDetails**](UserDetails.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forgetuser"></a>
# **ForgetUser**
> UserDetails ForgetUser (Guid? userId)

Forgets user profile

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class ForgetUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationUsersApi();
            var userId = new Guid?(); // Guid? | userId

            try
            {
                // Forgets user profile
                UserDetails result = apiInstance.ForgetUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUsersApi.ForgetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | [**Guid?**](Guid?.md)| userId | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserdetailsbyemail"></a>
# **GetUserDetailsByEmail**
> UserDetails GetUserDetailsByEmail (string email)

Gets user details by email

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetUserDetailsByEmailExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationUsersApi();
            var email = email_example;  // string | email

            try
            {
                // Gets user details by email
                UserDetails result = apiInstance.GetUserDetailsByEmail(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUsersApi.GetUserDetailsByEmail: " + e.Message );
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

[**UserDetails**](UserDetails.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserdetailsbyid"></a>
# **GetUserDetailsById**
> UserDetails GetUserDetailsById (Guid? userId)

Gets user details by user id

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetUserDetailsByIdExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationUsersApi();
            var userId = new Guid?(); // Guid? | userId

            try
            {
                // Gets user details by user id
                UserDetails result = apiInstance.GetUserDetailsById(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUsersApi.GetUserDetailsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | [**Guid?**](Guid?.md)| userId | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> UserDetails Update (UpdateUserRequest request)

Updates user profile

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class UpdateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OrganizationUsersApi();
            var request = new UpdateUserRequest(); // UpdateUserRequest | request

            try
            {
                // Updates user profile
                UserDetails result = apiInstance.Update(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationUsersApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UpdateUserRequest**](UpdateUserRequest.md)| request | 

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

