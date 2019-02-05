/* 
 * Template-Processor
 *
 * <b>The Template-Processor API can generate office, xml and json documents from a template and a JSON data file. Supported templates are MS Office files and freemarker files.<</b>    The flow is generally as follows:      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Sphereon.SDK.Template.Processor.Client;
using Sphereon.SDK.Template.Processor.Model;

namespace Sphereon.SDK.Template.Processor.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataSetApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Store dataset
        /// </summary>
        /// <remarks>
        /// Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>DataSetResponse</returns>
        DataSetResponse CreateDataSet (string payload);

        /// <summary>
        /// Store dataset
        /// </summary>
        /// <remarks>
        /// Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>ApiResponse of DataSetResponse</returns>
        ApiResponse<DataSetResponse> CreateDataSetWithHttpInfo (string payload);
        /// <summary>
        /// Delete a stored data set
        /// </summary>
        /// <remarks>
        /// Delete a stored data set
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>DataSetResponse</returns>
        DataSetResponse DeleteDataSet (string dataSetId);

        /// <summary>
        /// Delete a stored data set
        /// </summary>
        /// <remarks>
        /// Delete a stored data set
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>ApiResponse of DataSetResponse</returns>
        ApiResponse<DataSetResponse> DeleteDataSetWithHttpInfo (string dataSetId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Store dataset
        /// </summary>
        /// <remarks>
        /// Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>Task of DataSetResponse</returns>
        System.Threading.Tasks.Task<DataSetResponse> CreateDataSetAsync (string payload);

        /// <summary>
        /// Store dataset
        /// </summary>
        /// <remarks>
        /// Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>Task of ApiResponse (DataSetResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataSetResponse>> CreateDataSetAsyncWithHttpInfo (string payload);
        /// <summary>
        /// Delete a stored data set
        /// </summary>
        /// <remarks>
        /// Delete a stored data set
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>Task of DataSetResponse</returns>
        System.Threading.Tasks.Task<DataSetResponse> DeleteDataSetAsync (string dataSetId);

        /// <summary>
        /// Delete a stored data set
        /// </summary>
        /// <remarks>
        /// Delete a stored data set
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>Task of ApiResponse (DataSetResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataSetResponse>> DeleteDataSetAsyncWithHttpInfo (string dataSetId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataSetApi : IDataSetApi
    {
        private Sphereon.SDK.Template.Processor.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataSetApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Sphereon.SDK.Template.Processor.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataSetApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Sphereon.SDK.Template.Processor.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Sphereon.SDK.Template.Processor.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Store dataset Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>DataSetResponse</returns>
        public DataSetResponse CreateDataSet (string payload)
        {
             ApiResponse<DataSetResponse> localVarResponse = CreateDataSetWithHttpInfo(payload);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Store dataset Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>ApiResponse of DataSetResponse</returns>
        public ApiResponse< DataSetResponse > CreateDataSetWithHttpInfo (string payload)
        {
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling DataSetApi->CreateDataSet");

            var localVarPath = "/template/processor/0.1/datasets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (payload != null && payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateDataSet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataSetResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataSetResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSetResponse)));
            
        }

        /// <summary>
        /// Store dataset Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>Task of DataSetResponse</returns>
        public async System.Threading.Tasks.Task<DataSetResponse> CreateDataSetAsync (string payload)
        {
             ApiResponse<DataSetResponse> localVarResponse = await CreateDataSetAsyncWithHttpInfo(payload);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Store dataset Upload and store a data set. Currently only JSON is supported. This call returns an id which can be specified when submitting a merge job.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload">The dates for the merge [   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   },   {     \&quot;Field1\&quot;: \&quot;Field1 value\&quot;,     \&quot;Field2\&quot;: \&quot;Field2 value\&quot;,   } ]</param>
        /// <returns>Task of ApiResponse (DataSetResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataSetResponse>> CreateDataSetAsyncWithHttpInfo (string payload)
        {
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling DataSetApi->CreateDataSet");

            var localVarPath = "/template/processor/0.1/datasets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (payload != null && payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateDataSet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataSetResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataSetResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSetResponse)));
            
        }

        /// <summary>
        /// Delete a stored data set Delete a stored data set
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>DataSetResponse</returns>
        public DataSetResponse DeleteDataSet (string dataSetId)
        {
             ApiResponse<DataSetResponse> localVarResponse = DeleteDataSetWithHttpInfo(dataSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a stored data set Delete a stored data set
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>ApiResponse of DataSetResponse</returns>
        public ApiResponse< DataSetResponse > DeleteDataSetWithHttpInfo (string dataSetId)
        {
            // verify the required parameter 'dataSetId' is set
            if (dataSetId == null)
                throw new ApiException(400, "Missing required parameter 'dataSetId' when calling DataSetApi->DeleteDataSet");

            var localVarPath = "/template/processor/0.1/datasets/{dataSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dataSetId != null) localVarPathParams.Add("dataSetId", Configuration.ApiClient.ParameterToString(dataSetId)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteDataSet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataSetResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataSetResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSetResponse)));
            
        }

        /// <summary>
        /// Delete a stored data set Delete a stored data set
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>Task of DataSetResponse</returns>
        public async System.Threading.Tasks.Task<DataSetResponse> DeleteDataSetAsync (string dataSetId)
        {
             ApiResponse<DataSetResponse> localVarResponse = await DeleteDataSetAsyncWithHttpInfo(dataSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a stored data set Delete a stored data set
        /// </summary>
        /// <exception cref="Sphereon.SDK.Template.Processor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataSetId">dataSetId</param>
        /// <returns>Task of ApiResponse (DataSetResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataSetResponse>> DeleteDataSetAsyncWithHttpInfo (string dataSetId)
        {
            // verify the required parameter 'dataSetId' is set
            if (dataSetId == null)
                throw new ApiException(400, "Missing required parameter 'dataSetId' when calling DataSetApi->DeleteDataSet");

            var localVarPath = "/template/processor/0.1/datasets/{dataSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dataSetId != null) localVarPathParams.Add("dataSetId", Configuration.ApiClient.ParameterToString(dataSetId)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteDataSet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataSetResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataSetResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataSetResponse)));
            
        }

    }
}
