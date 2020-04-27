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
    /// ActorData
    /// </summary>
    [DataContract]
    public partial class ActorData :  IEquatable<ActorData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActorData" /> class.
        /// </summary>
        /// <param name="actorDisplayName">actorDisplayName.</param>
        /// <param name="actorId">actorId.</param>
        /// <param name="actorRoles">actorRoles.</param>
        /// <param name="department">department.</param>
        public ActorData(string actorDisplayName = default(string), string actorId = default(string), List<string> actorRoles = default(List<string>), string department = default(string))
        {
            this.ActorDisplayName = actorDisplayName;
            this.ActorId = actorId;
            this.ActorRoles = actorRoles;
            this.Department = department;
        }
        
        /// <summary>
        /// Gets or Sets ActorDisplayName
        /// </summary>
        [DataMember(Name="actorDisplayName", EmitDefaultValue=false)]
        public string ActorDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ActorId
        /// </summary>
        [DataMember(Name="actorId", EmitDefaultValue=false)]
        public string ActorId { get; set; }

        /// <summary>
        /// Gets or Sets ActorRoles
        /// </summary>
        [DataMember(Name="actorRoles", EmitDefaultValue=false)]
        public List<string> ActorRoles { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActorData {\n");
            sb.Append("  ActorDisplayName: ").Append(ActorDisplayName).Append("\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  ActorRoles: ").Append(ActorRoles).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
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
            return this.Equals(input as ActorData);
        }

        /// <summary>
        /// Returns true if ActorData instances are equal
        /// </summary>
        /// <param name="input">Instance of ActorData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActorData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActorDisplayName == input.ActorDisplayName ||
                    (this.ActorDisplayName != null &&
                    this.ActorDisplayName.Equals(input.ActorDisplayName))
                ) && 
                (
                    this.ActorId == input.ActorId ||
                    (this.ActorId != null &&
                    this.ActorId.Equals(input.ActorId))
                ) && 
                (
                    this.ActorRoles == input.ActorRoles ||
                    this.ActorRoles != null &&
                    this.ActorRoles.SequenceEqual(input.ActorRoles)
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
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
                if (this.ActorDisplayName != null)
                    hashCode = hashCode * 59 + this.ActorDisplayName.GetHashCode();
                if (this.ActorId != null)
                    hashCode = hashCode * 59 + this.ActorId.GetHashCode();
                if (this.ActorRoles != null)
                    hashCode = hashCode * 59 + this.ActorRoles.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                return hashCode;
            }
        }
    }

}
