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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sphereon.SDK.Template.Processor.Model
{
    /// <summary>
    /// Output settings
    /// </summary>
    [DataContract]
    public partial class OutputSettings :  IEquatable<OutputSettings>
    {
        /// <summary>
        /// Gets or Sets DeliveryFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryFormatEnum
        {
            
            /// <summary>
            /// Enum PLAIN for "PLAIN"
            /// </summary>
            [EnumMember(Value = "PLAIN")]
            PLAIN,
            
            /// <summary>
            /// Enum ZIP for "ZIP"
            /// </summary>
            [EnumMember(Value = "ZIP")]
            ZIP,
            
            /// <summary>
            /// Enum _7ZIP for "_7ZIP"
            /// </summary>
            [EnumMember(Value = "_7ZIP")]
            _7ZIP
        }

        /// <summary>
        /// Gets or Sets OutputFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutputFormatEnum
        {
            
            /// <summary>
            /// Enum DOC for "DOC"
            /// </summary>
            [EnumMember(Value = "DOC")]
            DOC,
            
            /// <summary>
            /// Enum DOCX for "DOCX"
            /// </summary>
            [EnumMember(Value = "DOCX")]
            DOCX,
            
            /// <summary>
            /// Enum RTF for "RTF"
            /// </summary>
            [EnumMember(Value = "RTF")]
            RTF,
            
            /// <summary>
            /// Enum PDF for "PDF"
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF,
            
            /// <summary>
            /// Enum XPS for "XPS"
            /// </summary>
            [EnumMember(Value = "XPS")]
            XPS,
            
            /// <summary>
            /// Enum SVG for "SVG"
            /// </summary>
            [EnumMember(Value = "SVG")]
            SVG,
            
            /// <summary>
            /// Enum HTML for "HTML"
            /// </summary>
            [EnumMember(Value = "HTML")]
            HTML,
            
            /// <summary>
            /// Enum ODT for "ODT"
            /// </summary>
            [EnumMember(Value = "ODT")]
            ODT,
            
            /// <summary>
            /// Enum TIFF for "TIFF"
            /// </summary>
            [EnumMember(Value = "TIFF")]
            TIFF,
            
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG,
            
            /// <summary>
            /// Enum BMP for "BMP"
            /// </summary>
            [EnumMember(Value = "BMP")]
            BMP,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG,
            
            /// <summary>
            /// Enum TXT for "TXT"
            /// </summary>
            [EnumMember(Value = "TXT")]
            TXT,
            
            /// <summary>
            /// Enum XML for "XML"
            /// </summary>
            [EnumMember(Value = "XML")]
            XML,
            
            /// <summary>
            /// Enum JSON for "JSON"
            /// </summary>
            [EnumMember(Value = "JSON")]
            JSON,
            
            /// <summary>
            /// Enum DEFAULT for "DEFAULT"
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT
        }

        /// <summary>
        /// Gets or Sets DeliveryFormat
        /// </summary>
        [DataMember(Name="deliveryFormat", EmitDefaultValue=false)]
        public DeliveryFormatEnum? DeliveryFormat { get; set; }
        /// <summary>
        /// Gets or Sets OutputFormat
        /// </summary>
        [DataMember(Name="outputFormat", EmitDefaultValue=false)]
        public OutputFormatEnum? OutputFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSettings" /> class.
        /// </summary>
        /// <param name="DeliveryFormat">DeliveryFormat.</param>
        /// <param name="OutputFormat">OutputFormat.</param>
        public OutputSettings(DeliveryFormatEnum? DeliveryFormat = null, OutputFormatEnum? OutputFormat = null)
        {
            this.DeliveryFormat = DeliveryFormat;
            this.OutputFormat = OutputFormat;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputSettings {\n");
            sb.Append("  DeliveryFormat: ").Append(DeliveryFormat).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OutputSettings);
        }

        /// <summary>
        /// Returns true if OutputSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of OutputSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryFormat == other.DeliveryFormat ||
                    this.DeliveryFormat != null &&
                    this.DeliveryFormat.Equals(other.DeliveryFormat)
                ) && 
                (
                    this.OutputFormat == other.OutputFormat ||
                    this.OutputFormat != null &&
                    this.OutputFormat.Equals(other.OutputFormat)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DeliveryFormat != null)
                    hash = hash * 59 + this.DeliveryFormat.GetHashCode();
                if (this.OutputFormat != null)
                    hash = hash * 59 + this.OutputFormat.GetHashCode();
                return hash;
            }
        }
    }

}
