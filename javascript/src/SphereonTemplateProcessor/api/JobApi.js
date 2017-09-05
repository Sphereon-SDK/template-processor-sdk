/**
 * Template-Processor
 * <b>The Template-Processor API can generate office, xml and json documents from a template and a JSON data file. Supported templates are MS Office files and freemarker files.<</b>    The flow is generally as follows:      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['SphereonTemplateProcessor/ApiClient', 'SphereonTemplateProcessor/model/MergeJobResponse', 'SphereonTemplateProcessor/model/ErrorResponse', 'SphereonTemplateProcessor/model/OutputSettings', 'SphereonTemplateProcessor/model/MergeSettings'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/MergeJobResponse'), require('../model/ErrorResponse'), require('../model/OutputSettings'), require('../model/MergeSettings'));
  } else {
    // Browser globals (root is window)
    if (!root.TemplateProcessor) {
      root.TemplateProcessor = {};
    }
    root.TemplateProcessor.JobApi = factory(root.TemplateProcessor.ApiClient, root.TemplateProcessor.MergeJobResponse, root.TemplateProcessor.ErrorResponse, root.TemplateProcessor.OutputSettings, root.TemplateProcessor.MergeSettings);
  }
}(this, function(ApiClient, MergeJobResponse, ErrorResponse, OutputSettings, MergeSettings) {
  'use strict';

  /**
   * Job service.
   * @module SphereonTemplateProcessor/api/JobApi
   * @version 0.1
   */

  /**
   * Constructs a new JobApi. 
   * @alias module:SphereonTemplateProcessor/api/JobApi
   * @class
   * @param {module:SphereonTemplateProcessor/ApiClient} apiClient Optional API client implementation to use,
   * default to {@link module:SphereonTemplateProcessor/ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the getJob operation.
     * @callback module:SphereonTemplateProcessor/api/JobApi~getJobCallback
     * @param {String} error Error message, if any.
     * @param {module:SphereonTemplateProcessor/model/MergeJobResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Job definition and state
     * Get the merge job definition and current state. Please not that you can differentiate based on http response status
     * @param {String} jobId jobId
     * @param {module:SphereonTemplateProcessor/api/JobApi~getJobCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:SphereonTemplateProcessor/model/MergeJobResponse}
     */
    this.getJob = function(jobId, callback) {
      var postBody = null;

      // verify the required parameter 'jobId' is set
      if (jobId == undefined || jobId == null) {
        throw "Missing the required parameter 'jobId' when calling getJob";
      }


      var pathParams = {
        'jobId': jobId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = MergeJobResponse;

      return this.apiClient.callApi(
        '/template/processor/0.1/jobs/{jobId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getJobs operation.
     * @callback module:SphereonTemplateProcessor/api/JobApi~getJobsCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:SphereonTemplateProcessor/model/MergeJobResponse>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get all jobs
     * Get all office text job definitions and their current state.
     * @param {Object} opts Optional parameters
     * @param {Array.<module:SphereonTemplateProcessor/model/String>} opts.status A list of status to filter on.
     * @param {module:SphereonTemplateProcessor/api/JobApi~getJobsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link Array.<module:SphereonTemplateProcessor/model/MergeJobResponse>}
     */
    this.getJobs = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
        'status': this.apiClient.buildCollectionParam(opts['status'], 'multi')
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = [MergeJobResponse];

      return this.apiClient.callApi(
        '/template/processor/0.1/jobs', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResultStreamById operation.
     * @callback module:SphereonTemplateProcessor/api/JobApi~getResultStreamByIdCallback
     * @param {String} error Error message, if any.
     * @param {'String'} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get the result file
     * Get a merge result document as a binary stream.   
     * @param {String} jobId jobId
     * @param {String} streamId streamId
     * @param {Object} opts Optional parameters
     * @param {module:SphereonTemplateProcessor/model/OutputSettings} opts.outputSettings outputSettings
     * @param {module:SphereonTemplateProcessor/api/JobApi~getResultStreamByIdCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link 'String'}
     */
    this.getResultStreamById = function(jobId, streamId, opts, callback) {
      opts = opts || {};
      var postBody = opts['outputSettings'];

      // verify the required parameter 'jobId' is set
      if (jobId == undefined || jobId == null) {
        throw "Missing the required parameter 'jobId' when calling getResultStreamById";
      }

      // verify the required parameter 'streamId' is set
      if (streamId == undefined || streamId == null) {
        throw "Missing the required parameter 'streamId' when calling getResultStreamById";
      }


      var pathParams = {
        'jobId': jobId,
        'streamId': streamId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['application/json;charset=UTF-8'];
      var accepts = ['application/octet-stream'];
      var returnType = 'String';

      return this.apiClient.callApi(
        '/template/processor/0.1/jobs/{jobId}/result/file/{streamId}', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResultStreamsAsContainer operation.
     * @callback module:SphereonTemplateProcessor/api/JobApi~getResultStreamsAsContainerCallback
     * @param {String} error Error message, if any.
     * @param {'String'} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get the result file
     * Get all documents inside a compressed container as a binary stream.   
     * @param {String} jobId jobId
     * @param {Object} opts Optional parameters
     * @param {module:SphereonTemplateProcessor/model/OutputSettings} opts.outputSettings outputSettings
     * @param {module:SphereonTemplateProcessor/api/JobApi~getResultStreamsAsContainerCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link 'String'}
     */
    this.getResultStreamsAsContainer = function(jobId, opts, callback) {
      opts = opts || {};
      var postBody = opts['outputSettings'];

      // verify the required parameter 'jobId' is set
      if (jobId == undefined || jobId == null) {
        throw "Missing the required parameter 'jobId' when calling getResultStreamsAsContainer";
      }


      var pathParams = {
        'jobId': jobId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['application/json;charset=UTF-8'];
      var accepts = ['application/octet-stream'];
      var returnType = 'String';

      return this.apiClient.callApi(
        '/template/processor/0.1/jobs/{jobId}/result/container', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the submitJob operation.
     * @callback module:SphereonTemplateProcessor/api/JobApi~submitJobCallback
     * @param {String} error Error message, if any.
     * @param {module:SphereonTemplateProcessor/model/MergeJobResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Submit merge job for processing
     * Submit merge job run.
     * @param {module:SphereonTemplateProcessor/model/MergeSettings} mergesettings The merge- and output settings
     * @param {module:SphereonTemplateProcessor/api/JobApi~submitJobCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:SphereonTemplateProcessor/model/MergeJobResponse}
     */
    this.submitJob = function(mergesettings, callback) {
      var postBody = mergesettings;

      // verify the required parameter 'mergesettings' is set
      if (mergesettings == undefined || mergesettings == null) {
        throw "Missing the required parameter 'mergesettings' when calling submitJob";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['application/json;charset=UTF-8'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = MergeJobResponse;

      return this.apiClient.callApi(
        '/template/processor/0.1/jobs', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));