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
    ///  Class for testing ErrorResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ErrorResponseTests
    {
        // TODO uncomment below to declare an instance variable for ErrorResponse
        //private ErrorResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ErrorResponse
            //instance = new ErrorResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ErrorResponse
        /// </summary>
        [Test]
        public void ErrorResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ErrorResponse
            //Assert.IsInstanceOfType<ErrorResponse> (instance, "variable 'instance' is a ErrorResponse");
        }

        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Test]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }

    }

}
