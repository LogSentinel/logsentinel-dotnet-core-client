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
    /// MetadataExtractionPaths
    /// </summary>
    [DataContract]
    public partial class MetadataExtractionPaths :  IEquatable<MetadataExtractionPaths>
    {
        /// <summary>
        /// Defines PathType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PathTypeEnum
        {
            
            /// <summary>
            /// Enum XPATH for value: XPATH
            /// </summary>
            [EnumMember(Value = "XPATH")]
            XPATH = 1,
            
            /// <summary>
            /// Enum JSONPATH for value: JSON_PATH
            /// </summary>
            [EnumMember(Value = "JSON_PATH")]
            JSONPATH = 2
        }

        /// <summary>
        /// Gets or Sets PathType
        /// </summary>
        [DataMember(Name="pathType", EmitDefaultValue=false)]
        public PathTypeEnum? PathType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataExtractionPaths" /> class.
        /// </summary>
        /// <param name="actionPaths">actionPaths.</param>
        /// <param name="actorDisplayNamePaths">actorDisplayNamePaths.</param>
        /// <param name="actorIdPaths">actorIdPaths.</param>
        /// <param name="actorRolesPaths">actorRolesPaths.</param>
        /// <param name="entityIdPaths">entityIdPaths.</param>
        /// <param name="entityTypePaths">entityTypePaths.</param>
        /// <param name="pathType">pathType.</param>
        /// <param name="set">set.</param>
        public MetadataExtractionPaths(List<string> actionPaths = default(List<string>), List<string> actorDisplayNamePaths = default(List<string>), List<string> actorIdPaths = default(List<string>), List<string> actorRolesPaths = default(List<string>), List<string> entityIdPaths = default(List<string>), List<string> entityTypePaths = default(List<string>), PathTypeEnum? pathType = default(PathTypeEnum?), bool? set = default(bool?))
        {
            this.ActionPaths = actionPaths;
            this.ActorDisplayNamePaths = actorDisplayNamePaths;
            this.ActorIdPaths = actorIdPaths;
            this.ActorRolesPaths = actorRolesPaths;
            this.EntityIdPaths = entityIdPaths;
            this.EntityTypePaths = entityTypePaths;
            this.PathType = pathType;
            this.Set = set;
        }
        
        /// <summary>
        /// Gets or Sets ActionPaths
        /// </summary>
        [DataMember(Name="actionPaths", EmitDefaultValue=false)]
        public List<string> ActionPaths { get; set; }

        /// <summary>
        /// Gets or Sets ActorDisplayNamePaths
        /// </summary>
        [DataMember(Name="actorDisplayNamePaths", EmitDefaultValue=false)]
        public List<string> ActorDisplayNamePaths { get; set; }

        /// <summary>
        /// Gets or Sets ActorIdPaths
        /// </summary>
        [DataMember(Name="actorIdPaths", EmitDefaultValue=false)]
        public List<string> ActorIdPaths { get; set; }

        /// <summary>
        /// Gets or Sets ActorRolesPaths
        /// </summary>
        [DataMember(Name="actorRolesPaths", EmitDefaultValue=false)]
        public List<string> ActorRolesPaths { get; set; }

        /// <summary>
        /// Gets or Sets EntityIdPaths
        /// </summary>
        [DataMember(Name="entityIdPaths", EmitDefaultValue=false)]
        public List<string> EntityIdPaths { get; set; }

        /// <summary>
        /// Gets or Sets EntityTypePaths
        /// </summary>
        [DataMember(Name="entityTypePaths", EmitDefaultValue=false)]
        public List<string> EntityTypePaths { get; set; }


        /// <summary>
        /// Gets or Sets Set
        /// </summary>
        [DataMember(Name="set", EmitDefaultValue=false)]
        public bool? Set { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataExtractionPaths {\n");
            sb.Append("  ActionPaths: ").Append(ActionPaths).Append("\n");
            sb.Append("  ActorDisplayNamePaths: ").Append(ActorDisplayNamePaths).Append("\n");
            sb.Append("  ActorIdPaths: ").Append(ActorIdPaths).Append("\n");
            sb.Append("  ActorRolesPaths: ").Append(ActorRolesPaths).Append("\n");
            sb.Append("  EntityIdPaths: ").Append(EntityIdPaths).Append("\n");
            sb.Append("  EntityTypePaths: ").Append(EntityTypePaths).Append("\n");
            sb.Append("  PathType: ").Append(PathType).Append("\n");
            sb.Append("  Set: ").Append(Set).Append("\n");
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
            return this.Equals(input as MetadataExtractionPaths);
        }

        /// <summary>
        /// Returns true if MetadataExtractionPaths instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataExtractionPaths to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataExtractionPaths input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionPaths == input.ActionPaths ||
                    this.ActionPaths != null &&
                    this.ActionPaths.SequenceEqual(input.ActionPaths)
                ) && 
                (
                    this.ActorDisplayNamePaths == input.ActorDisplayNamePaths ||
                    this.ActorDisplayNamePaths != null &&
                    this.ActorDisplayNamePaths.SequenceEqual(input.ActorDisplayNamePaths)
                ) && 
                (
                    this.ActorIdPaths == input.ActorIdPaths ||
                    this.ActorIdPaths != null &&
                    this.ActorIdPaths.SequenceEqual(input.ActorIdPaths)
                ) && 
                (
                    this.ActorRolesPaths == input.ActorRolesPaths ||
                    this.ActorRolesPaths != null &&
                    this.ActorRolesPaths.SequenceEqual(input.ActorRolesPaths)
                ) && 
                (
                    this.EntityIdPaths == input.EntityIdPaths ||
                    this.EntityIdPaths != null &&
                    this.EntityIdPaths.SequenceEqual(input.EntityIdPaths)
                ) && 
                (
                    this.EntityTypePaths == input.EntityTypePaths ||
                    this.EntityTypePaths != null &&
                    this.EntityTypePaths.SequenceEqual(input.EntityTypePaths)
                ) && 
                (
                    this.PathType == input.PathType ||
                    (this.PathType != null &&
                    this.PathType.Equals(input.PathType))
                ) && 
                (
                    this.Set == input.Set ||
                    (this.Set != null &&
                    this.Set.Equals(input.Set))
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
                if (this.ActionPaths != null)
                    hashCode = hashCode * 59 + this.ActionPaths.GetHashCode();
                if (this.ActorDisplayNamePaths != null)
                    hashCode = hashCode * 59 + this.ActorDisplayNamePaths.GetHashCode();
                if (this.ActorIdPaths != null)
                    hashCode = hashCode * 59 + this.ActorIdPaths.GetHashCode();
                if (this.ActorRolesPaths != null)
                    hashCode = hashCode * 59 + this.ActorRolesPaths.GetHashCode();
                if (this.EntityIdPaths != null)
                    hashCode = hashCode * 59 + this.EntityIdPaths.GetHashCode();
                if (this.EntityTypePaths != null)
                    hashCode = hashCode * 59 + this.EntityTypePaths.GetHashCode();
                if (this.PathType != null)
                    hashCode = hashCode * 59 + this.PathType.GetHashCode();
                if (this.Set != null)
                    hashCode = hashCode * 59 + this.Set.GetHashCode();
                return hashCode;
            }
        }
    }

}
