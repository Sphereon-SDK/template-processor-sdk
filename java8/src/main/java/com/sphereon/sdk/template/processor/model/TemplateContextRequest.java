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


package com.sphereon.sdk.template.processor.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import com.sphereon.sdk.template.processor.model.OwnerInfo;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;


/**
 * The merge template request.
 */
@ApiModel(description = "The merge template request.")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2017-08-07T23:35:11.957+02:00")
public class TemplateContextRequest   {
  /**
   * Gets or Sets templateType
   */
  public enum TemplateTypeEnum {
    @SerializedName("OFFICE")
    OFFICE("OFFICE"),
    
    @SerializedName("FREEMARKER")
    FREEMARKER("FREEMARKER");

    private String value;

    TemplateTypeEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("templateType")
  private TemplateTypeEnum templateType = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("ownerInfo")
  private OwnerInfo ownerInfo = null;

  @SerializedName("templateId")
  private String templateId = null;

  public TemplateContextRequest templateType(TemplateTypeEnum templateType) {
    this.templateType = templateType;
    return this;
  }

   /**
   * Get templateType
   * @return templateType
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public TemplateTypeEnum getTemplateType() {
    return templateType;
  }

  public void setTemplateType(TemplateTypeEnum templateType) {
    this.templateType = templateType;
  }

  public TemplateContextRequest description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public TemplateContextRequest ownerInfo(OwnerInfo ownerInfo) {
    this.ownerInfo = ownerInfo;
    return this;
  }

   /**
   * Get ownerInfo
   * @return ownerInfo
  **/
  @ApiModelProperty(example = "null", value = "")
  public OwnerInfo getOwnerInfo() {
    return ownerInfo;
  }

  public void setOwnerInfo(OwnerInfo ownerInfo) {
    this.ownerInfo = ownerInfo;
  }

  public TemplateContextRequest templateId(String templateId) {
    this.templateId = templateId;
    return this;
  }

   /**
   * The template context id
   * @return templateId
  **/
  @ApiModelProperty(example = "null", value = "The template context id")
  public String getTemplateId() {
    return templateId;
  }

  public void setTemplateId(String templateId) {
    this.templateId = templateId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TemplateContextRequest templateContextRequest = (TemplateContextRequest) o;
    return Objects.equals(this.templateType, templateContextRequest.templateType) &&
        Objects.equals(this.description, templateContextRequest.description) &&
        Objects.equals(this.ownerInfo, templateContextRequest.ownerInfo) &&
        Objects.equals(this.templateId, templateContextRequest.templateId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(templateType, description, ownerInfo, templateId);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TemplateContextRequest {\n");
    
    sb.append("    templateType: ").append(toIndentedString(templateType)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    ownerInfo: ").append(toIndentedString(ownerInfo)).append("\n");
    sb.append("    templateId: ").append(toIndentedString(templateId)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

