/* 
 * LogSentinel RESTful API
 *
 * Read more at https://app.logsentinel.com/docs
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = LogSentinel.Client.Client.SwaggerDateConverter;

namespace LogSentinel.Client.Model
{
    /// <summary>
    /// ActionData
    /// </summary>
    [DataContract]
    public partial class ActionData :  IEquatable<ActionData>, IValidatableObject
    {
        /// <summary>
        /// Defines EntryType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntryTypeEnum
        {
            
            /// <summary>
            /// Enum BUSINESSLOGICENTRY for value: BUSINESS_LOGIC_ENTRY
            /// </summary>
            [EnumMember(Value = "BUSINESS_LOGIC_ENTRY")]
            BUSINESSLOGICENTRY = 1,
            
            /// <summary>
            /// Enum DATABASEQUERY for value: DATABASE_QUERY
            /// </summary>
            [EnumMember(Value = "DATABASE_QUERY")]
            DATABASEQUERY = 2,
            
            /// <summary>
            /// Enum SYSTEMEVENT for value: SYSTEM_EVENT
            /// </summary>
            [EnumMember(Value = "SYSTEM_EVENT")]
            SYSTEMEVENT = 3,
            
            /// <summary>
            /// Enum ANONYMIZEDENTRY for value: ANONYMIZED_ENTRY
            /// </summary>
            [EnumMember(Value = "ANONYMIZED_ENTRY")]
            ANONYMIZEDENTRY = 4
        }

        /// <summary>
        /// Gets or Sets EntryType
        /// </summary>
        [DataMember(Name="entryType", EmitDefaultValue=false)]
        public EntryTypeEnum? EntryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionData" /> class.
        /// </summary>
        /// <param name="Action">Action.</param>
        /// <param name="Details">Details.</param>
        /// <param name="EntityId">EntityId.</param>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="EntryType">EntryType.</param>
        public ActionData(string Action = default(string), string Details = default(string), string EntityId = default(string), string EntityType = default(string), EntryTypeEnum? EntryType = default(EntryTypeEnum?))
        {
            this.Action = Action;
            this.Details = Details;
            this.EntityId = EntityId;
            this.EntityType = EntityType;
            this.EntryType = EntryType;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public object Details { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionData {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionData);
        }

        /// <summary>
        /// Returns true if ActionData instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.EntryType == input.EntryType ||
                    (this.EntryType != null &&
                    this.EntryType.Equals(input.EntryType))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.EntryType != null)
                    hashCode = hashCode * 59 + this.EntryType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        public ActionData setAction(string v)
        {
            this.Action = v;
            return this;
        }

        public ActionData setDetails(object v)
        {
            this.Details = v;
            return this;
        }

        public ActionData setEntryType(string v)
        {
            this.EntityType = v;
            return this;
        }
    }

}
