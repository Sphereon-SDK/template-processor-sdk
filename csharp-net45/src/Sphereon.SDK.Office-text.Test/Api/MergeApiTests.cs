/* 
 * OfficeTextMerge
 *
 * <b>The Office Text API can generate office documents from a template and a JSON data file<</b>    The flow is generally as follows:      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Sphereon.SDK.Office-text.Client;
using Sphereon.SDK.Office-text.Api;
using Sphereon.SDK.Office-text.Model;

namespace Sphereon.SDK.Office-text.Test
{
    /// <summary>
    ///  Class for testing MergeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MergeApiTests
    {
        private MergeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MergeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MergeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MergeApi
            //Assert.IsInstanceOfType(typeof(MergeApi), instance, "instance is a MergeApi");
        }

        
        /// <summary>
        /// Test CreateDataSet
        /// </summary>
        [Test]
        public void CreateDataSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string payload = null;
            //var response = instance.CreateDataSet(payload);
            //Assert.IsInstanceOf<DataSetResponse> (response, "response is DataSetResponse");
        }
        
        /// <summary>
        /// Test CreateTemplateContext
        /// </summary>
        [Test]
        public void CreateTemplateContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateContextRequest templateRequest = null;
            //var response = instance.CreateTemplateContext(templateRequest);
            //Assert.IsInstanceOf<TemplateContextResponse> (response, "response is TemplateContextResponse");
        }
        
        /// <summary>
        /// Test DeleteDataSet
        /// </summary>
        [Test]
        public void DeleteDataSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dataSetId = null;
            //var response = instance.DeleteDataSet(dataSetId);
            //Assert.IsInstanceOf<DataSetResponse> (response, "response is DataSetResponse");
        }
        
        /// <summary>
        /// Test DeleteJob
        /// </summary>
        [Test]
        public void DeleteJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobId = null;
            //var response = instance.DeleteJob(jobId);
            //Assert.IsInstanceOf<MergeJobResponse> (response, "response is MergeJobResponse");
        }
        
        /// <summary>
        /// Test DeleteTemplateContext
        /// </summary>
        [Test]
        public void DeleteTemplateContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //var response = instance.DeleteTemplateContext(templateId);
            //Assert.IsInstanceOf<TemplateContextResponse> (response, "response is TemplateContextResponse");
        }
        
        /// <summary>
        /// Test GetJob
        /// </summary>
        [Test]
        public void GetJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobId = null;
            //var response = instance.GetJob(jobId);
            //Assert.IsInstanceOf<MergeJobResponse> (response, "response is MergeJobResponse");
        }
        
        /// <summary>
        /// Test GetJobs
        /// </summary>
        [Test]
        public void GetJobsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> status = null;
            //var response = instance.GetJobs(status);
            //Assert.IsInstanceOf<List<MergeJobResponse>> (response, "response is List<MergeJobResponse>");
        }
        
        /// <summary>
        /// Test GetResultStreamById
        /// </summary>
        [Test]
        public void GetResultStreamByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobId = null;
            //string streamId = null;
            //OutputSettings outputSettings = null;
            //var response = instance.GetResultStreamById(jobId, streamId, outputSettings);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetResultStreamsAsContainer
        /// </summary>
        [Test]
        public void GetResultStreamsAsContainerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobId = null;
            //OutputSettings outputSettings = null;
            //var response = instance.GetResultStreamsAsContainer(jobId, outputSettings);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetTemplateContext
        /// </summary>
        [Test]
        public void GetTemplateContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //var response = instance.GetTemplateContext(templateId);
            //Assert.IsInstanceOf<TemplateContextResponse> (response, "response is TemplateContextResponse");
        }
        
        /// <summary>
        /// Test SubmitJob
        /// </summary>
        [Test]
        public void SubmitJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MergeSettings mergesettings = null;
            //var response = instance.SubmitJob(mergesettings);
            //Assert.IsInstanceOf<MergeJobResponse> (response, "response is MergeJobResponse");
        }
        
        /// <summary>
        /// Test UpdateTemplateContext
        /// </summary>
        [Test]
        public void UpdateTemplateContextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateContextRequest templateContextRequest = null;
            //var response = instance.UpdateTemplateContext(templateContextRequest);
            //Assert.IsInstanceOf<TemplateContextResponse> (response, "response is TemplateContextResponse");
        }
        
        /// <summary>
        /// Test UploadTemplateFile
        /// </summary>
        [Test]
        public void UploadTemplateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //System.IO.Stream stream = null;
            //var response = instance.UploadTemplateFile(templateId, stream);
            //Assert.IsInstanceOf<TemplateContextResponse> (response, "response is TemplateContextResponse");
        }
        
    }

}