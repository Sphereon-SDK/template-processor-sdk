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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Sphereon.SDK.Template.Processor.Api;
using Sphereon.SDK.Template.Processor.Model;
using Sphereon.SDK.Template.Processor.Client;
using System.Reflection;

namespace Sphereon.SDK.Template.Processor.Test
{
    /// <summary>
    ///  Class for testing StreamLocation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StreamLocationTests
    {
        // TODO uncomment below to declare an instance variable for StreamLocation
        //private StreamLocation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of StreamLocation
            //instance = new StreamLocation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StreamLocation
        /// </summary>
        [Test]
        public void StreamLocationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" StreamLocation
            //Assert.IsInstanceOfType<StreamLocation> (instance, "variable 'instance' is a StreamLocation");
        }

        /// <summary>
        /// Test the property 'FolderPath'
        /// </summary>
        [Test]
        public void FolderPathTest()
        {
            // TODO unit test for the property 'FolderPath'
        }
        /// <summary>
        /// Test the property 'OriginalFileName'
        /// </summary>
        [Test]
        public void OriginalFileNameTest()
        {
            // TODO unit test for the property 'OriginalFileName'
        }
        /// <summary>
        /// Test the property 'ContainerId'
        /// </summary>
        [Test]
        public void ContainerIdTest()
        {
            // TODO unit test for the property 'ContainerId'
        }
        /// <summary>
        /// Test the property 'FileId'
        /// </summary>
        [Test]
        public void FileIdTest()
        {
            // TODO unit test for the property 'FileId'
        }

    }

}