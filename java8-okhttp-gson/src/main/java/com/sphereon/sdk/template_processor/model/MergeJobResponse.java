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
import com.sphereon.sdk.template_processor.model.MergeJob;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * The merge job response.
 */
@ApiModel(description = "The merge job response.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-09-20T13:28:56.163+02:00")
public class MergeJobResponse {
  @SerializedName("jobId")
  private String jobId = null;

  @SerializedName("job")
  private MergeJob job = null;

  @SerializedName("statusMessage")
  private String statusMessage = null;

  /**
   * The status of the job
   */
  @JsonAdapter(StatusEnum.Adapter.class)
  public enum StatusEnum {
    CREATED("CREATED"),
    
    UPDATED("UPDATED"),
    
    PROCESSING("PROCESSING"),
    
    DONE("DONE"),
    
    ERROR("ERROR"),
    
    DELETED("DELETED");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static StatusEnum fromValue(String text) {
      for (StatusEnum b : StatusEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<StatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final StatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public StatusEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return StatusEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("status")
  private StatusEnum status = null;

  public MergeJobResponse jobId(String jobId) {
    this.jobId = jobId;
    return this;
  }

   /**
   * The server generated job jobId. This jobId is checked against the jobId in the request path on overy invocation
   * @return jobId
  **/
  @ApiModelProperty(required = true, value = "The server generated job jobId. This jobId is checked against the jobId in the request path on overy invocation")
  public String getJobId() {
    return jobId;
  }

  public void setJobId(String jobId) {
    this.jobId = jobId;
  }

  public MergeJobResponse job(MergeJob job) {
    this.job = job;
    return this;
  }

   /**
   * Get job
   * @return job
  **/
  @ApiModelProperty(value = "")
  public MergeJob getJob() {
    return job;
  }

  public void setJob(MergeJob job) {
    this.job = job;
  }

   /**
   * A status message, which can be informational, warning or error. AA message here does not indicate an error perse
   * @return statusMessage
  **/
  @ApiModelProperty(value = "A status message, which can be informational, warning or error. AA message here does not indicate an error perse")
  public String getStatusMessage() {
    return statusMessage;
  }

   /**
   * The status of the job
   * @return status
  **/
  @ApiModelProperty(required = true, value = "The status of the job")
  public StatusEnum getStatus() {
    return status;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MergeJobResponse mergeJobResponse = (MergeJobResponse) o;
    return Objects.equals(this.jobId, mergeJobResponse.jobId) &&
        Objects.equals(this.job, mergeJobResponse.job) &&
        Objects.equals(this.statusMessage, mergeJobResponse.statusMessage) &&
        Objects.equals(this.status, mergeJobResponse.status);
  }

  @Override
  public int hashCode() {
    return Objects.hash(jobId, job, statusMessage, status);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MergeJobResponse {\n");
    
    sb.append("    jobId: ").append(toIndentedString(jobId)).append("\n");
    sb.append("    job: ").append(toIndentedString(job)).append("\n");
    sb.append("    statusMessage: ").append(toIndentedString(statusMessage)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
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

