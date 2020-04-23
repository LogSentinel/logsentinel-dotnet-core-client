# LogSentinel.Client.Api.AlertsApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateActionChainRule**](AlertsApi.md#createactionchainrule) | **POST** /api/alerts/actionChainRule | Creates Action Chain Alert Rule
[**CreateDestination**](AlertsApi.md#createdestination) | **POST** /api/alerts/destination | Creates Alert destination. Type is EMAIL or TELEGRAM
[**CreateRule**](AlertsApi.md#createrule) | **POST** /api/alerts/rule | Creates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM
[**DeleteActionChainRule**](AlertsApi.md#deleteactionchainrule) | **DELETE** /api/alerts/actionChainRule | Deletes Action chain Alert rule
[**DeleteDestination**](AlertsApi.md#deletedestination) | **DELETE** /api/alerts/destination | Deletes Alert destination
[**DeleteRule**](AlertsApi.md#deleterule) | **DELETE** /api/alerts/rule | Deletes Alert rule
[**GetActionChainAlertRules**](AlertsApi.md#getactionchainalertrules) | **GET** /api/alerts/actionChainRules | Gets all Action Chain Alert rules in the organization
[**GetAlertDestinations**](AlertsApi.md#getalertdestinations) | **GET** /api/alerts/destinations | Gets all Alert destinations in the organization
[**GetAlertRuleRuns**](AlertsApi.md#getalertruleruns) | **GET** /api/alerts/runs | Gets all Alert rule runs in the organization
[**GetAlertRules**](AlertsApi.md#getalertrules) | **GET** /api/alerts/rules | Gets all Alert rules in the organization
[**UpdateActionChainRule**](AlertsApi.md#updateactionchainrule) | **PUT** /api/alerts/actionChainRule | Updates Action Chain Alert Rule
[**UpdateDestination**](AlertsApi.md#updatedestination) | **PUT** /api/alerts/destination | Updates Alert destination. Type cannot be changed
[**UpdateRule**](AlertsApi.md#updaterule) | **PUT** /api/alerts/rule | Updates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM
[**UpdateWorkingHours**](AlertsApi.md#updateworkinghours) | **POST** /api/alerts/updateWorkingHours | Updates the working hours for the organization


<a name="createactionchainrule"></a>
# **CreateActionChainRule**
> ActionChainAlertRule CreateActionChainRule (ActionChainAlertRule alertRule)

Creates Action Chain Alert Rule

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class CreateActionChainRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var alertRule = new ActionChainAlertRule(); // ActionChainAlertRule | alertRule

            try
            {
                // Creates Action Chain Alert Rule
                ActionChainAlertRule result = apiInstance.CreateActionChainRule(alertRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateActionChainRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alertRule** | [**ActionChainAlertRule**](ActionChainAlertRule.md)| alertRule | 

### Return type

[**ActionChainAlertRule**](ActionChainAlertRule.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdestination"></a>
# **CreateDestination**
> AlertDestination CreateDestination (AlertDestinationRequest request)

Creates Alert destination. Type is EMAIL or TELEGRAM

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class CreateDestinationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var request = new AlertDestinationRequest(); // AlertDestinationRequest | request

            try
            {
                // Creates Alert destination. Type is EMAIL or TELEGRAM
                AlertDestination result = apiInstance.CreateDestination(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AlertDestinationRequest**](AlertDestinationRequest.md)| request | 

### Return type

[**AlertDestination**](AlertDestination.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrule"></a>
# **CreateRule**
> AlertRule CreateRule (AlertRuleRequest request)

Creates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class CreateRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var request = new AlertRuleRequest(); // AlertRuleRequest | request

            try
            {
                // Creates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM
                AlertRule result = apiInstance.CreateRule(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AlertRuleRequest**](AlertRuleRequest.md)| request | 

### Return type

[**AlertRule**](AlertRule.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteactionchainrule"></a>
# **DeleteActionChainRule**
> void DeleteActionChainRule (string id)

Deletes Action chain Alert rule

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class DeleteActionChainRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes Action chain Alert rule
                apiInstance.DeleteActionChainRule(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.DeleteActionChainRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedestination"></a>
# **DeleteDestination**
> void DeleteDestination (string id)

Deletes Alert destination

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class DeleteDestinationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes Alert destination
                apiInstance.DeleteDestination(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.DeleteDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterule"></a>
# **DeleteRule**
> void DeleteRule (string id)

Deletes Alert rule

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class DeleteRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes Alert rule
                apiInstance.DeleteRule(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.DeleteRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactionchainalertrules"></a>
# **GetActionChainAlertRules**
> List<ActionChainAlertRule> GetActionChainAlertRules ()

Gets all Action Chain Alert rules in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetActionChainAlertRulesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();

            try
            {
                // Gets all Action Chain Alert rules in the organization
                List&lt;ActionChainAlertRule&gt; result = apiInstance.GetActionChainAlertRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetActionChainAlertRules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ActionChainAlertRule>**](ActionChainAlertRule.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalertdestinations"></a>
# **GetAlertDestinations**
> List<AlertDestination> GetAlertDestinations ()

Gets all Alert destinations in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetAlertDestinationsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();

            try
            {
                // Gets all Alert destinations in the organization
                List&lt;AlertDestination&gt; result = apiInstance.GetAlertDestinations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetAlertDestinations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AlertDestination>**](AlertDestination.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalertruleruns"></a>
# **GetAlertRuleRuns**
> List<AlertRuleRun> GetAlertRuleRuns ()

Gets all Alert rule runs in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetAlertRuleRunsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();

            try
            {
                // Gets all Alert rule runs in the organization
                List&lt;AlertRuleRun&gt; result = apiInstance.GetAlertRuleRuns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetAlertRuleRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AlertRuleRun>**](AlertRuleRun.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalertrules"></a>
# **GetAlertRules**
> List<AlertRule> GetAlertRules ()

Gets all Alert rules in the organization

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetAlertRulesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();

            try
            {
                // Gets all Alert rules in the organization
                List&lt;AlertRule&gt; result = apiInstance.GetAlertRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetAlertRules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AlertRule>**](AlertRule.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactionchainrule"></a>
# **UpdateActionChainRule**
> ActionChainAlertRule UpdateActionChainRule (string id, ActionChainAlertRule rule)

Updates Action Chain Alert Rule

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class UpdateActionChainRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | id
            var rule = new ActionChainAlertRule(); // ActionChainAlertRule | rule

            try
            {
                // Updates Action Chain Alert Rule
                ActionChainAlertRule result = apiInstance.UpdateActionChainRule(id, rule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.UpdateActionChainRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 
 **rule** | [**ActionChainAlertRule**](ActionChainAlertRule.md)| rule | 

### Return type

[**ActionChainAlertRule**](ActionChainAlertRule.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedestination"></a>
# **UpdateDestination**
> AlertDestination UpdateDestination (string id, AlertDestinationRequest request)

Updates Alert destination. Type cannot be changed

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class UpdateDestinationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | id
            var request = new AlertDestinationRequest(); // AlertDestinationRequest | request

            try
            {
                // Updates Alert destination. Type cannot be changed
                AlertDestination result = apiInstance.UpdateDestination(id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.UpdateDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 
 **request** | [**AlertDestinationRequest**](AlertDestinationRequest.md)| request | 

### Return type

[**AlertDestination**](AlertDestination.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterule"></a>
# **UpdateRule**
> AlertRule UpdateRule (string id, AlertRuleRequest request)

Updates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class UpdateRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | id
            var request = new AlertRuleRequest(); // AlertRuleRequest | request

            try
            {
                // Updates Alert rule. Type is ST_DEV or FIXED. Aggregation type is COUNT, AVG or SUM
                AlertRule result = apiInstance.UpdateRule(id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.UpdateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 
 **request** | [**AlertRuleRequest**](AlertRuleRequest.md)| request | 

### Return type

[**AlertRule**](AlertRule.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkinghours"></a>
# **UpdateWorkingHours**
> void UpdateWorkingHours (WorkingHoursDto workingHoursDto)

Updates the working hours for the organization

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class UpdateWorkingHoursExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AlertsApi();
            var workingHoursDto = new WorkingHoursDto(); // WorkingHoursDto | workingHoursDto

            try
            {
                // Updates the working hours for the organization
                apiInstance.UpdateWorkingHours(workingHoursDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.UpdateWorkingHours: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workingHoursDto** | [**WorkingHoursDto**](WorkingHoursDto.md)| workingHoursDto | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

