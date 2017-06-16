/**
 * OfficeTextMerge
 * <b>The Office Text API can generate office documents from a template and a JSON data file<</b>    The flow is generally as follows:      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.1
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


package com.sphereon.sdk.office_text.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;


/**
 * Output settings
 */
@ApiModel(description = "Output settings")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2017-06-16T16:45:46.803+02:00")
public class OutputSettings   {
  /**
   * Gets or Sets deliveryFormat
   */
  public enum DeliveryFormatEnum {
    @SerializedName("PLAIN")
    PLAIN("PLAIN"),
    
    @SerializedName("ZIP")
    ZIP("ZIP"),
    
    @SerializedName("_7ZIP")
    _7ZIP("_7ZIP");

    private String value;

    DeliveryFormatEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("deliveryFormat")
  private DeliveryFormatEnum deliveryFormat = null;

  /**
   * Gets or Sets outputFormat
   */
  public enum OutputFormatEnum {
    @SerializedName("DOC")
    DOC("DOC"),
    
    @SerializedName("DOCX")
    DOCX("DOCX"),
    
    @SerializedName("RTF")
    RTF("RTF"),
    
    @SerializedName("PDF")
    PDF("PDF"),
    
    @SerializedName("XPS")
    XPS("XPS"),
    
    @SerializedName("SVG")
    SVG("SVG"),
    
    @SerializedName("HTML")
    HTML("HTML"),
    
    @SerializedName("ODT")
    ODT("ODT"),
    
    @SerializedName("TIFF")
    TIFF("TIFF"),
    
    @SerializedName("PNG")
    PNG("PNG"),
    
    @SerializedName("BMP")
    BMP("BMP"),
    
    @SerializedName("JPEG")
    JPEG("JPEG"),
    
    @SerializedName("DEFAULT")
    DEFAULT("DEFAULT");

    private String value;

    OutputFormatEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("outputFormat")
  private OutputFormatEnum outputFormat = null;

  public OutputSettings deliveryFormat(DeliveryFormatEnum deliveryFormat) {
    this.deliveryFormat = deliveryFormat;
    return this;
  }

   /**
   * Get deliveryFormat
   * @return deliveryFormat
  **/
  @ApiModelProperty(example = "null", value = "")
  public DeliveryFormatEnum getDeliveryFormat() {
    return deliveryFormat;
  }

  public void setDeliveryFormat(DeliveryFormatEnum deliveryFormat) {
    this.deliveryFormat = deliveryFormat;
  }

  public OutputSettings outputFormat(OutputFormatEnum outputFormat) {
    this.outputFormat = outputFormat;
    return this;
  }

   /**
   * Get outputFormat
   * @return outputFormat
  **/
  @ApiModelProperty(example = "null", value = "")
  public OutputFormatEnum getOutputFormat() {
    return outputFormat;
  }

  public void setOutputFormat(OutputFormatEnum outputFormat) {
    this.outputFormat = outputFormat;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OutputSettings outputSettings = (OutputSettings) o;
    return Objects.equals(this.deliveryFormat, outputSettings.deliveryFormat) &&
        Objects.equals(this.outputFormat, outputSettings.outputFormat);
  }

  @Override
  public int hashCode() {
    return Objects.hash(deliveryFormat, outputFormat);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OutputSettings {\n");
    
    sb.append("    deliveryFormat: ").append(toIndentedString(deliveryFormat)).append("\n");
    sb.append("    outputFormat: ").append(toIndentedString(outputFormat)).append("\n");
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

