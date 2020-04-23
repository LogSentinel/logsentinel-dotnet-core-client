# LogSentinel.Client.Api.VerificationApi

All URIs are relative to *https://api.logsentinel.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConsistencyProof**](VerificationApi.md#getconsistencyproof) | **GET** /api/verification/merkle/proofs/consistency | Get consistency proof for an application merkle tree. Async operation, as the generation may be slow
[**GetEntriesBetweenHashes**](VerificationApi.md#getentriesbetweenhashes) | **GET** /api/verification/entries | Get all entries between two hashes
[**GetEthereumEntries**](VerificationApi.md#getethereumentries) | **GET** /api/verification/ethereumEntries | Fetch all hashes pushed to Ethereum for a given application
[**GetInclusionProof**](VerificationApi.md#getinclusionproof) | **GET** /api/verification/merkle/proofs/inclusion | Get inclusion proof for the application merkle tree. Async operation, as the generation may be slow
[**GetLatestTreeHead**](VerificationApi.md#getlatesttreehead) | **GET** /api/verification/merkle/latestTreeHead | Get latest tree head of the application merkle tree. Async operation, as the operation may be slow
[**GetMerkleTreeInfo**](VerificationApi.md#getmerkletreeinfo) | **GET** /api/verification/merkle/info | Get general info about merkle tree parameters
[**GetResolvedVerificationFailures**](VerificationApi.md#getresolvedverificationfailures) | **GET** /api/verification/resolved-failures | Get all resolved verification failures
[**Verify**](VerificationApi.md#verify) | **POST** /api/verification/verify | Verify whether a given hash is present, indicating that the log is intact
[**VerifyEntry**](VerificationApi.md#verifyentry) | **POST** /api/verification/verifyEntry | Verify whether a given entry&#39;s hash is present, indicating that the log is intact


<a name="getconsistencyproof"></a>
# **GetConsistencyProof**
> ConsistencyProof GetConsistencyProof (Guid? applicationId, string firstTreeHash, string secondTreeHash = null)

Get consistency proof for an application merkle tree. Async operation, as the generation may be slow

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetConsistencyProofExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = new Guid?(); // Guid? | Application ID, identifying a target application (obtained from the API credentials page)
            var firstTreeHash = firstTreeHash_example;  // string | firstTreeHash
            var secondTreeHash = secondTreeHash_example;  // string | secondTreeHash (optional)  (default to -1)

            try
            {
                // Get consistency proof for an application merkle tree. Async operation, as the generation may be slow
                ConsistencyProof result = apiInstance.GetConsistencyProof(applicationId, firstTreeHash, secondTreeHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetConsistencyProof: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)| Application ID, identifying a target application (obtained from the API credentials page) | 
 **firstTreeHash** | **string**| firstTreeHash | 
 **secondTreeHash** | **string**| secondTreeHash | [optional] [default to -1]

### Return type

[**ConsistencyProof**](ConsistencyProof.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentriesbetweenhashes"></a>
# **GetEntriesBetweenHashes**
> List<AuditLogEntry> GetEntriesBetweenHashes (Guid? applicationId, string endHash, string startHash)

Get all entries between two hashes

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetEntriesBetweenHashesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = new Guid?(); // Guid? | Application ID, identifying a target application (obtained from the API credentials page)
            var endHash = endHash_example;  // string | endHash
            var startHash = startHash_example;  // string | startHash

            try
            {
                // Get all entries between two hashes
                List&lt;AuditLogEntry&gt; result = apiInstance.GetEntriesBetweenHashes(applicationId, endHash, startHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetEntriesBetweenHashes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)| Application ID, identifying a target application (obtained from the API credentials page) | 
 **endHash** | **string**| endHash | 
 **startHash** | **string**| startHash | 

### Return type

[**List<AuditLogEntry>**](AuditLogEntry.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getethereumentries"></a>
# **GetEthereumEntries**
> List<EthereumData> GetEthereumEntries (Guid? applicationId)

Fetch all hashes pushed to Ethereum for a given application

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetEthereumEntriesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = new Guid?(); // Guid? | applicationId

            try
            {
                // Fetch all hashes pushed to Ethereum for a given application
                List&lt;EthereumData&gt; result = apiInstance.GetEthereumEntries(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetEthereumEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)| applicationId | 

### Return type

[**List<EthereumData>**](EthereumData.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinclusionproof"></a>
# **GetInclusionProof**
> InclusionProof GetInclusionProof (Guid? applicationId, string hash)

Get inclusion proof for the application merkle tree. Async operation, as the generation may be slow

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetInclusionProofExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = new Guid?(); // Guid? | Application ID, identifying a target application (obtained from the API credentials page)
            var hash = hash_example;  // string | Hash of the entry to verify

            try
            {
                // Get inclusion proof for the application merkle tree. Async operation, as the generation may be slow
                InclusionProof result = apiInstance.GetInclusionProof(applicationId, hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetInclusionProof: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)| Application ID, identifying a target application (obtained from the API credentials page) | 
 **hash** | **string**| Hash of the entry to verify | 

### Return type

[**InclusionProof**](InclusionProof.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatesttreehead"></a>
# **GetLatestTreeHead**
> TreeHead GetLatestTreeHead (Guid? applicationId)

Get latest tree head of the application merkle tree. Async operation, as the operation may be slow

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetLatestTreeHeadExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = new Guid?(); // Guid? | Application ID, identifying a target application (obtained from the API credentials page)

            try
            {
                // Get latest tree head of the application merkle tree. Async operation, as the operation may be slow
                TreeHead result = apiInstance.GetLatestTreeHead(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetLatestTreeHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)| Application ID, identifying a target application (obtained from the API credentials page) | 

### Return type

[**TreeHead**](TreeHead.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmerkletreeinfo"></a>
# **GetMerkleTreeInfo**
> MerkleTreeInfo GetMerkleTreeInfo ()

Get general info about merkle tree parameters

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetMerkleTreeInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();

            try
            {
                // Get general info about merkle tree parameters
                MerkleTreeInfo result = apiInstance.GetMerkleTreeInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetMerkleTreeInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MerkleTreeInfo**](MerkleTreeInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresolvedverificationfailures"></a>
# **GetResolvedVerificationFailures**
> List<ResolvedVerificationFailureResponse> GetResolvedVerificationFailures (Guid? applicationId)

Get all resolved verification failures

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class GetResolvedVerificationFailuresExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = new Guid?(); // Guid? | Application ID, identifying a target application (obtained from the API credentials page)

            try
            {
                // Get all resolved verification failures
                List&lt;ResolvedVerificationFailureResponse&gt; result = apiInstance.GetResolvedVerificationFailures(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.GetResolvedVerificationFailures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)| Application ID, identifying a target application (obtained from the API credentials page) | 

### Return type

[**List<ResolvedVerificationFailureResponse>**](ResolvedVerificationFailureResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verify"></a>
# **Verify**
> Verification Verify (string applicationId, string hash)

Verify whether a given hash is present, indicating that the log is intact

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class VerifyExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var hash = hash_example;  // string | Hash of the entry to verify

            try
            {
                // Verify whether a given hash is present, indicating that the log is intact
                Verification result = apiInstance.Verify(applicationId, hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.Verify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **hash** | **string**| Hash of the entry to verify | 

### Return type

[**Verification**](Verification.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyentry"></a>
# **VerifyEntry**
> Verification VerifyEntry (string applicationId, string entryId)

Verify whether a given entry's hash is present, indicating that the log is intact

### Example
```csharp
using System;
using System.Diagnostics;
using LogSentinel.Client.Api;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace Example
{
    public class VerifyEntryExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new VerificationApi();
            var applicationId = applicationId_example;  // string | Application ID, identifying a target application (obtained from the API credentials page)
            var entryId = entryId_example;  // string | ID of the audit log entry to verify

            try
            {
                // Verify whether a given entry's hash is present, indicating that the log is intact
                Verification result = apiInstance.VerifyEntry(applicationId, entryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerificationApi.VerifyEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| Application ID, identifying a target application (obtained from the API credentials page) | 
 **entryId** | **string**| ID of the audit log entry to verify | 

### Return type

[**Verification**](Verification.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

