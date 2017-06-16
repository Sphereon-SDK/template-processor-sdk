/* 
 * OfficeTextMerge
 *
 * <b>The Office Text API can generate office documents from a template and a JSON data file<</b>    The flow is generally as follows:      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.1
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

namespace Sphereon.SDK.Office-text.Model
{
    /// <summary>
    /// The merge template request.
    /// </summary>
    [DataContract]
    public partial class TemplateContextRequest :  IEquatable<TemplateContextRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateContextRequest" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="OwnerInfo">OwnerInfo.</param>
        /// <param name="TemplateId">The template context id.</param>
        public TemplateContextRequest(string Description = null, OwnerInfo OwnerInfo = null, string TemplateId = null)
        {
            this.Description = Description;
            this.OwnerInfo = OwnerInfo;
            this.TemplateId = TemplateId;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets OwnerInfo
        /// </summary>
        [DataMember(Name="ownerInfo", EmitDefaultValue=false)]
        public OwnerInfo OwnerInfo { get; set; }
        /// <summary>
        /// The template context id
        /// </summary>
        /// <value>The template context id</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateContextRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OwnerInfo: ").Append(OwnerInfo).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(obj as TemplateContextRequest);
        }

        /// <summary>
        /// Returns true if TemplateContextRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateContextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateContextRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.OwnerInfo == other.OwnerInfo ||
                    this.OwnerInfo != null &&
                    this.OwnerInfo.Equals(other.OwnerInfo)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.OwnerInfo != null)
                    hash = hash * 59 + this.OwnerInfo.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                return hash;
            }
        }
    }

}
