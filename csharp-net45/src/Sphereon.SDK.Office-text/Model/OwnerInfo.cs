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
    /// Owner info
    /// </summary>
    [DataContract]
    public partial class OwnerInfo :  IEquatable<OwnerInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerInfo" /> class.
        /// </summary>
        /// <param name="Phone">The owner&#39;s phone number.</param>
        /// <param name="CompanyDepartment">The owner&#39;s company/department.</param>
        /// <param name="Name">The owner&#39;s name.</param>
        /// <param name="Email">The owner&#39;s email address.</param>
        public OwnerInfo(string Phone = null, string CompanyDepartment = null, string Name = null, string Email = null)
        {
            this.Phone = Phone;
            this.CompanyDepartment = CompanyDepartment;
            this.Name = Name;
            this.Email = Email;
        }
        
        /// <summary>
        /// The owner&#39;s phone number
        /// </summary>
        /// <value>The owner&#39;s phone number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// The owner&#39;s company/department
        /// </summary>
        /// <value>The owner&#39;s company/department</value>
        [DataMember(Name="companyDepartment", EmitDefaultValue=false)]
        public string CompanyDepartment { get; set; }
        /// <summary>
        /// The owner&#39;s name
        /// </summary>
        /// <value>The owner&#39;s name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The owner&#39;s email address
        /// </summary>
        /// <value>The owner&#39;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OwnerInfo {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  CompanyDepartment: ").Append(CompanyDepartment).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(obj as OwnerInfo);
        }

        /// <summary>
        /// Returns true if OwnerInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of OwnerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnerInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.CompanyDepartment == other.CompanyDepartment ||
                    this.CompanyDepartment != null &&
                    this.CompanyDepartment.Equals(other.CompanyDepartment)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.CompanyDepartment != null)
                    hash = hash * 59 + this.CompanyDepartment.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                return hash;
            }
        }
    }

}
