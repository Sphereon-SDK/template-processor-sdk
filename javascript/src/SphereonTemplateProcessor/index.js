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

(function(factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['SphereonTemplateProcessor/ApiClient', 'SphereonTemplateProcessor/model/DataSetResponse', 'SphereonTemplateProcessor/model/Error', 'SphereonTemplateProcessor/model/ErrorResponse', 'SphereonTemplateProcessor/model/Lifecycle', 'SphereonTemplateProcessor/model/MergeJob', 'SphereonTemplateProcessor/model/MergeJobResponse', 'SphereonTemplateProcessor/model/MergeSettings', 'SphereonTemplateProcessor/model/OutputSettings', 'SphereonTemplateProcessor/model/OwnerInfo', 'SphereonTemplateProcessor/model/StorageLocation', 'SphereonTemplateProcessor/model/StreamLocation', 'SphereonTemplateProcessor/model/TemplateContext', 'SphereonTemplateProcessor/model/TemplateContextRequest', 'SphereonTemplateProcessor/model/TemplateContextResponse', 'SphereonTemplateProcessor/api/AllApi', 'SphereonTemplateProcessor/api/DataSetApi', 'SphereonTemplateProcessor/api/JobApi', 'SphereonTemplateProcessor/api/TemplateApi'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('./ApiClient'), require('./model/DataSetResponse'), require('./model/Error'), require('./model/ErrorResponse'), require('./model/Lifecycle'), require('./model/MergeJob'), require('./model/MergeJobResponse'), require('./model/MergeSettings'), require('./model/OutputSettings'), require('./model/OwnerInfo'), require('./model/StorageLocation'), require('./model/StreamLocation'), require('./model/TemplateContext'), require('./model/TemplateContextRequest'), require('./model/TemplateContextResponse'), require('./api/AllApi'), require('./api/DataSetApi'), require('./api/JobApi'), require('./api/TemplateApi'));
  }
}(function(ApiClient, DataSetResponse, Error, ErrorResponse, Lifecycle, MergeJob, MergeJobResponse, MergeSettings, OutputSettings, OwnerInfo, StorageLocation, StreamLocation, TemplateContext, TemplateContextRequest, TemplateContextResponse, AllApi, DataSetApi, JobApi, TemplateApi) {
  'use strict';

  /**
   * bThe_Template_Processor_API_can_generate_office_xml_and_json_documents_from_a_template_and_a_JSON_data_file__Supported_templates_are_MS_Office_files_and_freemarker_files_bThe_flow_is_generally_as_followsbInteractive_testing_bA_web_based_test_console_is_available_in_the_a_hrefhttpsstore_sphereon_comSphereon_API_Storea.<br>
   * The <code>index</code> module provides access to constructors for all the classes which comprise the public API.
   * <p>
   * An AMD (recommended!) or CommonJS application will generally do something equivalent to the following:
   * <pre>
   * var TemplateProcessor = require('SphereonTemplateProcessor/index'); // See note below*.
   * var xxxSvc = new TemplateProcessor.XxxApi(); // Allocate the API class we're going to use.
   * var yyyModel = new TemplateProcessor.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * <em>*NOTE: For a top-level AMD script, use require(['SphereonTemplateProcessor/index'], function(){...})
   * and put the application logic within the callback function.</em>
   * </p>
   * <p>
   * A non-AMD browser application (discouraged) might do something like this:
   * <pre>
   * var xxxSvc = new TemplateProcessor.XxxApi(); // Allocate the API class we're going to use.
   * var yyy = new TemplateProcessor.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * </p>
   * @module SphereonTemplateProcessor/index
   * @version 0.1
   */
  var exports = {
    /**
     * The ApiClient constructor.
     * @property {module:SphereonTemplateProcessor/ApiClient}
     */
    ApiClient: ApiClient,
    /**
     * The DataSetResponse model constructor.
     * @property {module:SphereonTemplateProcessor/model/DataSetResponse}
     */
    DataSetResponse: DataSetResponse,
    /**
     * The Error model constructor.
     * @property {module:SphereonTemplateProcessor/model/Error}
     */
    Error: Error,
    /**
     * The ErrorResponse model constructor.
     * @property {module:SphereonTemplateProcessor/model/ErrorResponse}
     */
    ErrorResponse: ErrorResponse,
    /**
     * The Lifecycle model constructor.
     * @property {module:SphereonTemplateProcessor/model/Lifecycle}
     */
    Lifecycle: Lifecycle,
    /**
     * The MergeJob model constructor.
     * @property {module:SphereonTemplateProcessor/model/MergeJob}
     */
    MergeJob: MergeJob,
    /**
     * The MergeJobResponse model constructor.
     * @property {module:SphereonTemplateProcessor/model/MergeJobResponse}
     */
    MergeJobResponse: MergeJobResponse,
    /**
     * The MergeSettings model constructor.
     * @property {module:SphereonTemplateProcessor/model/MergeSettings}
     */
    MergeSettings: MergeSettings,
    /**
     * The OutputSettings model constructor.
     * @property {module:SphereonTemplateProcessor/model/OutputSettings}
     */
    OutputSettings: OutputSettings,
    /**
     * The OwnerInfo model constructor.
     * @property {module:SphereonTemplateProcessor/model/OwnerInfo}
     */
    OwnerInfo: OwnerInfo,
    /**
     * The StorageLocation model constructor.
     * @property {module:SphereonTemplateProcessor/model/StorageLocation}
     */
    StorageLocation: StorageLocation,
    /**
     * The StreamLocation model constructor.
     * @property {module:SphereonTemplateProcessor/model/StreamLocation}
     */
    StreamLocation: StreamLocation,
    /**
     * The TemplateContext model constructor.
     * @property {module:SphereonTemplateProcessor/model/TemplateContext}
     */
    TemplateContext: TemplateContext,
    /**
     * The TemplateContextRequest model constructor.
     * @property {module:SphereonTemplateProcessor/model/TemplateContextRequest}
     */
    TemplateContextRequest: TemplateContextRequest,
    /**
     * The TemplateContextResponse model constructor.
     * @property {module:SphereonTemplateProcessor/model/TemplateContextResponse}
     */
    TemplateContextResponse: TemplateContextResponse,
    /**
     * The AllApi service constructor.
     * @property {module:SphereonTemplateProcessor/api/AllApi}
     */
    AllApi: AllApi,
    /**
     * The DataSetApi service constructor.
     * @property {module:SphereonTemplateProcessor/api/DataSetApi}
     */
    DataSetApi: DataSetApi,
    /**
     * The JobApi service constructor.
     * @property {module:SphereonTemplateProcessor/api/JobApi}
     */
    JobApi: JobApi,
    /**
     * The TemplateApi service constructor.
     * @property {module:SphereonTemplateProcessor/api/TemplateApi}
     */
    TemplateApi: TemplateApi
  };

  return exports;
}));