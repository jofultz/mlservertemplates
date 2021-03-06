/*
 * MLServer
 * Integration technology for deploying R and Python analytics inside web, desktop, mobile, and dashboard applications as well as backend systems. Turn your R or Python scripts into analytics web services, so code can be easily executed by applications running on a secure server.  The core APIs can be grouped into several categories, including: [Authentication](#authentication-apis), [Web Services](#services-management-apis), [Sessions](#session-apis), [Snapshots](#snapshot-apis), [Status](#status-apis), and [Centralized Configuration](#centralized-configuration-apis). 
 *
 * OpenAPI spec version: 9.2.1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * Snapshot
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-10-09T05:46:27.738Z")
public class Snapshot {
  @SerializedName("id")
  private String id = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("owner")
  private String owner = null;

  @SerializedName("creationTime")
  private String creationTime = null;

  @SerializedName("contentSize")
  private Integer contentSize = null;

  public Snapshot id(String id) {
    this.id = id;
    return this;
  }

   /**
   * Unique identifier representing the snapshot.
   * @return id
  **/
  @ApiModelProperty(value = "Unique identifier representing the snapshot.")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public Snapshot name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Name of the snapshot.
   * @return name
  **/
  @ApiModelProperty(value = "Name of the snapshot.")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Snapshot owner(String owner) {
    this.owner = owner;
    return this;
  }

   /**
   * Owner of the snapshot.
   * @return owner
  **/
  @ApiModelProperty(value = "Owner of the snapshot.")
  public String getOwner() {
    return owner;
  }

  public void setOwner(String owner) {
    this.owner = owner;
  }

  public Snapshot creationTime(String creationTime) {
    this.creationTime = creationTime;
    return this;
  }

   /**
   * Creation time of the snapshot.
   * @return creationTime
  **/
  @ApiModelProperty(value = "Creation time of the snapshot.")
  public String getCreationTime() {
    return creationTime;
  }

  public void setCreationTime(String creationTime) {
    this.creationTime = creationTime;
  }

  public Snapshot contentSize(Integer contentSize) {
    this.contentSize = contentSize;
    return this;
  }

   /**
   * Size of the zip file of the snapshot.
   * @return contentSize
  **/
  @ApiModelProperty(value = "Size of the zip file of the snapshot.")
  public Integer getContentSize() {
    return contentSize;
  }

  public void setContentSize(Integer contentSize) {
    this.contentSize = contentSize;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Snapshot snapshot = (Snapshot) o;
    return Objects.equals(this.id, snapshot.id) &&
        Objects.equals(this.name, snapshot.name) &&
        Objects.equals(this.owner, snapshot.owner) &&
        Objects.equals(this.creationTime, snapshot.creationTime) &&
        Objects.equals(this.contentSize, snapshot.contentSize);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, name, owner, creationTime, contentSize);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Snapshot {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    owner: ").append(toIndentedString(owner)).append("\n");
    sb.append("    creationTime: ").append(toIndentedString(creationTime)).append("\n");
    sb.append("    contentSize: ").append(toIndentedString(contentSize)).append("\n");
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

