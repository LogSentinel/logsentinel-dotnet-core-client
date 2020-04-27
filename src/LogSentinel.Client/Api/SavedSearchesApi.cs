/* 
 * LogSentinel RESTful API
 *
 * Read more at https://docs.logsentinel.com/en/latest/index.html
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using LogSentinel.Client.Client;
using LogSentinel.Client.Model;

namespace LogSentinel.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISavedSearchesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates saved search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>List&lt;SavedSearch&gt;</returns>
        List<SavedSearch> CreateSavedSearch (long? end, string name, int? page, int? pageSize, string query, long? start);

        /// <summary>
        /// Creates saved search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>ApiResponse of List&lt;SavedSearch&gt;</returns>
        ApiResponse<List<SavedSearch>> CreateSavedSearchWithHttpInfo (long? end, string name, int? page, int? pageSize, string query, long? start);
        /// <summary>
        /// Fetches saved search ids of all users of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SavedSearch&gt;</returns>
        List<SavedSearch> GetSavedSearchIds ();

        /// <summary>
        /// Fetches saved search ids of all users of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SavedSearch&gt;</returns>
        ApiResponse<List<SavedSearch>> GetSavedSearchIdsWithHttpInfo ();
        /// <summary>
        /// Calls saved search by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>List&lt;AuditLogEntry&gt;</returns>
        List<AuditLogEntry> PerformSavedSearch (string savedSearchId);

        /// <summary>
        /// Calls saved search by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>ApiResponse of List&lt;AuditLogEntry&gt;</returns>
        ApiResponse<List<AuditLogEntry>> PerformSavedSearchWithHttpInfo (string savedSearchId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Creates saved search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>Task of List&lt;SavedSearch&gt;</returns>
        System.Threading.Tasks.Task<List<SavedSearch>> CreateSavedSearchAsync (long? end, string name, int? page, int? pageSize, string query, long? start);

        /// <summary>
        /// Creates saved search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>Task of ApiResponse (List&lt;SavedSearch&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SavedSearch>>> CreateSavedSearchAsyncWithHttpInfo (long? end, string name, int? page, int? pageSize, string query, long? start);
        /// <summary>
        /// Fetches saved search ids of all users of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SavedSearch&gt;</returns>
        System.Threading.Tasks.Task<List<SavedSearch>> GetSavedSearchIdsAsync ();

        /// <summary>
        /// Fetches saved search ids of all users of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SavedSearch&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SavedSearch>>> GetSavedSearchIdsAsyncWithHttpInfo ();
        /// <summary>
        /// Calls saved search by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>Task of List&lt;AuditLogEntry&gt;</returns>
        System.Threading.Tasks.Task<List<AuditLogEntry>> PerformSavedSearchAsync (string savedSearchId);

        /// <summary>
        /// Calls saved search by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>Task of ApiResponse (List&lt;AuditLogEntry&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AuditLogEntry>>> PerformSavedSearchAsyncWithHttpInfo (string savedSearchId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SavedSearchesApi : ISavedSearchesApi
    {
        private LogSentinel.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedSearchesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SavedSearchesApi(String basePath)
        {
            this.Configuration = new LogSentinel.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = LogSentinel.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedSearchesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SavedSearchesApi(LogSentinel.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = LogSentinel.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = LogSentinel.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public LogSentinel.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public LogSentinel.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Creates saved search 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>List&lt;SavedSearch&gt;</returns>
        public List<SavedSearch> CreateSavedSearch (long? end, string name, int? page, int? pageSize, string query, long? start)
        {
             ApiResponse<List<SavedSearch>> localVarResponse = CreateSavedSearchWithHttpInfo(end, name, page, pageSize, query, start);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates saved search 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>ApiResponse of List&lt;SavedSearch&gt;</returns>
        public ApiResponse< List<SavedSearch> > CreateSavedSearchWithHttpInfo (long? end, string name, int? page, int? pageSize, string query, long? start)
        {
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'page' is set
            if (page == null)
                throw new ApiException(400, "Missing required parameter 'page' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'pageSize' is set
            if (pageSize == null)
                throw new ApiException(400, "Missing required parameter 'pageSize' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling SavedSearchesApi->CreateSavedSearch");

            var localVarPath = "./api/search/saved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (end != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end", end)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSavedSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SavedSearch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<SavedSearch>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SavedSearch>)));
        }

        /// <summary>
        /// Creates saved search 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>Task of List&lt;SavedSearch&gt;</returns>
        public async System.Threading.Tasks.Task<List<SavedSearch>> CreateSavedSearchAsync (long? end, string name, int? page, int? pageSize, string query, long? start)
        {
             ApiResponse<List<SavedSearch>> localVarResponse = await CreateSavedSearchAsyncWithHttpInfo(end, name, page, pageSize, query, start);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates saved search 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="end">end</param>
        /// <param name="name">name</param>
        /// <param name="page">page</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="query">query</param>
        /// <param name="start">start</param>
        /// <returns>Task of ApiResponse (List&lt;SavedSearch&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SavedSearch>>> CreateSavedSearchAsyncWithHttpInfo (long? end, string name, int? page, int? pageSize, string query, long? start)
        {
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'page' is set
            if (page == null)
                throw new ApiException(400, "Missing required parameter 'page' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'pageSize' is set
            if (pageSize == null)
                throw new ApiException(400, "Missing required parameter 'pageSize' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SavedSearchesApi->CreateSavedSearch");
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling SavedSearchesApi->CreateSavedSearch");

            var localVarPath = "./api/search/saved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (end != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end", end)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter
            if (query != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSavedSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SavedSearch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<SavedSearch>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SavedSearch>)));
        }

        /// <summary>
        /// Fetches saved search ids of all users of an organization 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SavedSearch&gt;</returns>
        public List<SavedSearch> GetSavedSearchIds ()
        {
             ApiResponse<List<SavedSearch>> localVarResponse = GetSavedSearchIdsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetches saved search ids of all users of an organization 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SavedSearch&gt;</returns>
        public ApiResponse< List<SavedSearch> > GetSavedSearchIdsWithHttpInfo ()
        {

            var localVarPath = "./api/search/saved/fetch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSavedSearchIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SavedSearch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<SavedSearch>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SavedSearch>)));
        }

        /// <summary>
        /// Fetches saved search ids of all users of an organization 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SavedSearch&gt;</returns>
        public async System.Threading.Tasks.Task<List<SavedSearch>> GetSavedSearchIdsAsync ()
        {
             ApiResponse<List<SavedSearch>> localVarResponse = await GetSavedSearchIdsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetches saved search ids of all users of an organization 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SavedSearch&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SavedSearch>>> GetSavedSearchIdsAsyncWithHttpInfo ()
        {

            var localVarPath = "./api/search/saved/fetch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSavedSearchIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SavedSearch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<SavedSearch>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SavedSearch>)));
        }

        /// <summary>
        /// Calls saved search by its id 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>List&lt;AuditLogEntry&gt;</returns>
        public List<AuditLogEntry> PerformSavedSearch (string savedSearchId)
        {
             ApiResponse<List<AuditLogEntry>> localVarResponse = PerformSavedSearchWithHttpInfo(savedSearchId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Calls saved search by its id 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>ApiResponse of List&lt;AuditLogEntry&gt;</returns>
        public ApiResponse< List<AuditLogEntry> > PerformSavedSearchWithHttpInfo (string savedSearchId)
        {
            // verify the required parameter 'savedSearchId' is set
            if (savedSearchId == null)
                throw new ApiException(400, "Missing required parameter 'savedSearchId' when calling SavedSearchesApi->PerformSavedSearch");

            var localVarPath = "./api/search/saved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (savedSearchId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "savedSearchId", savedSearchId)); // query parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PerformSavedSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AuditLogEntry>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<AuditLogEntry>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AuditLogEntry>)));
        }

        /// <summary>
        /// Calls saved search by its id 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>Task of List&lt;AuditLogEntry&gt;</returns>
        public async System.Threading.Tasks.Task<List<AuditLogEntry>> PerformSavedSearchAsync (string savedSearchId)
        {
             ApiResponse<List<AuditLogEntry>> localVarResponse = await PerformSavedSearchAsyncWithHttpInfo(savedSearchId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Calls saved search by its id 
        /// </summary>
        /// <exception cref="LogSentinel.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="savedSearchId">savedSearchId</param>
        /// <returns>Task of ApiResponse (List&lt;AuditLogEntry&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AuditLogEntry>>> PerformSavedSearchAsyncWithHttpInfo (string savedSearchId)
        {
            // verify the required parameter 'savedSearchId' is set
            if (savedSearchId == null)
                throw new ApiException(400, "Missing required parameter 'savedSearchId' when calling SavedSearchesApi->PerformSavedSearch");

            var localVarPath = "./api/search/saved";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (savedSearchId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "savedSearchId", savedSearchId)); // query parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PerformSavedSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AuditLogEntry>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<AuditLogEntry>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AuditLogEntry>)));
        }

    }
}
