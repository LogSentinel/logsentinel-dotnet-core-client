/* 
 * LogSentinel RESTful API
 *
 * Read more at https://docs.logsentinel.com/en/latest/index.html
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = LogSentinel.Client.Client.SwaggerDateConverter;

namespace LogSentinel.Client.Model
{
    /// <summary>
    /// LogResponse
    /// </summary>
    [DataContract]
    public partial class LogResponse :  IEquatable<LogResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogResponse" /> class.
        /// </summary>
        /// <param name="lastKnownHash">lastKnownHash.</param>
        /// <param name="logEntryId">logEntryId.</param>
        /// <param name="standaloneHash">standaloneHash.</param>
        public LogResponse(string lastKnownHash = default(string), string logEntryId = default(string), string standaloneHash = default(string))
        {
            this.LastKnownHash = lastKnownHash;
            this.LogEntryId = logEntryId;
            this.StandaloneHash = standaloneHash;
        }
        
        /// <summary>
        /// Gets or Sets LastKnownHash
        /// </summary>
        [DataMember(Name="lastKnownHash", EmitDefaultValue=false)]
        public string LastKnownHash { get; set; }

        /// <summary>
        /// Gets or Sets LogEntryId
        /// </summary>
        [DataMember(Name="logEntryId", EmitDefaultValue=false)]
        public string LogEntryId { get; set; }

        /// <summary>
        /// Gets or Sets StandaloneHash
        /// </summary>
        [DataMember(Name="standaloneHash", EmitDefaultValue=false)]
        public string StandaloneHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogResponse {\n");
            sb.Append("  LastKnownHash: ").Append(LastKnownHash).Append("\n");
            sb.Append("  LogEntryId: ").Append(LogEntryId).Append("\n");
            sb.Append("  StandaloneHash: ").Append(StandaloneHash).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogResponse);
        }

        /// <summary>
        /// Returns true if LogResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LogResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastKnownHash == input.LastKnownHash ||
                    (this.LastKnownHash != null &&
                    this.LastKnownHash.Equals(input.LastKnownHash))
                ) && 
                (
                    this.LogEntryId == input.LogEntryId ||
                    (this.LogEntryId != null &&
                    this.LogEntryId.Equals(input.LogEntryId))
                ) && 
                (
                    this.StandaloneHash == input.StandaloneHash ||
                    (this.StandaloneHash != null &&
                    this.StandaloneHash.Equals(input.StandaloneHash))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LastKnownHash != null)
                    hashCode = hashCode * 59 + this.LastKnownHash.GetHashCode();
                if (this.LogEntryId != null)
                    hashCode = hashCode * 59 + this.LogEntryId.GetHashCode();
                if (this.StandaloneHash != null)
                    hashCode = hashCode * 59 + this.StandaloneHash.GetHashCode();
                return hashCode;
            }
        }
    }

}
