/*
 * Template-Processor
 * <b>The Template-Processor API can generate office, xml and json documents from a template and a JSON data file. Supported templates are MS Office files and freemarker files.<</b>    The flow is generally as follows:      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.sphereon.sdk.template_processor.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.sphereon.sdk.template_processor.model.OutputSettings;
import com.sphereon.sdk.template_processor.model.StreamLocation;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * A request to download a specific result stream.
 */
@ApiModel(description = "A request to download a specific result stream.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-09-20T13:28:56.163+02:00")
public class ResultStreamRequest {
  @SerializedName("streamLocation")
  private StreamLocation streamLocation = null;

  @SerializedName("outputSettings")
  private OutputSettings outputSettings = null;

  public ResultStreamRequest streamLocation(StreamLocation streamLocation) {
    this.streamLocation = streamLocation;
    return this;
  }

   /**
   * The stream location
   * @return streamLocation
  **/
  @ApiModelProperty(required = true, value = "The stream location")
  public StreamLocation getStreamLocation() {
    return streamLocation;
  }

  public void setStreamLocation(StreamLocation streamLocation) {
    this.streamLocation = streamLocation;
  }

  public ResultStreamRequest outputSettings(OutputSettings outputSettings) {
    this.outputSettings = outputSettings;
    return this;
  }

   /**
   * The Output settings
   * @return outputSettings
  **/
  @ApiModelProperty(value = "The Output settings")
  public OutputSettings getOutputSettings() {
    return outputSettings;
  }

  public void setOutputSettings(OutputSettings outputSettings) {
    this.outputSettings = outputSettings;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ResultStreamRequest resultStreamRequest = (ResultStreamRequest) o;
    return Objects.equals(this.streamLocation, resultStreamRequest.streamLocation) &&
        Objects.equals(this.outputSettings, resultStreamRequest.outputSettings);
  }

  @Override
  public int hashCode() {
    return Objects.hash(streamLocation, outputSettings);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ResultStreamRequest {\n");
    
    sb.append("    streamLocation: ").append(toIndentedString(streamLocation)).append("\n");
    sb.append("    outputSettings: ").append(toIndentedString(outputSettings)).append("\n");
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

