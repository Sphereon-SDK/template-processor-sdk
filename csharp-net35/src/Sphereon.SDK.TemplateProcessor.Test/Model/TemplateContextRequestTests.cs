/* 
 * Template-Processor
 *
 * <b>The Template-Processor API can generate office, xml and json documents from a template and a JSON data file. Supported templates are MS Office files and freemarker files.<</b>    The flow is generally as follows:      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Sphereon.SDK.TemplateProcessor.Api;
using Sphereon.SDK.TemplateProcessor.Model;
using Sphereon.SDK.TemplateProcessor.Client;
using System.Reflection;

namespace Sphereon.SDK.TemplateProcessor.Test
{
    /// <summary>
    ///  Class for testing TemplateContextRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TemplateContextRequestTests
    {
        // TODO uncomment below to declare an instance variable for TemplateContextRequest
        //private TemplateContextRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TemplateContextRequest
            //instance = new TemplateContextRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TemplateContextRequest
        /// </summary>
        [Test]
        public void TemplateContextRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TemplateContextRequest
            //Assert.IsInstanceOfType<TemplateContextRequest> (instance, "variable 'instance' is a TemplateContextRequest");
        }

        /// <summary>
        /// Test the property 'TemplateType'
        /// </summary>
        [Test]
        public void TemplateTypeTest()
        {
            // TODO unit test for the property 'TemplateType'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'OwnerInfo'
        /// </summary>
        [Test]
        public void OwnerInfoTest()
        {
            // TODO unit test for the property 'OwnerInfo'
        }
        /// <summary>
        /// Test the property 'TemplateId'
        /// </summary>
        [Test]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }

    }

}
