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
    /// Verification
    /// </summary>
    [DataContract]
    public partial class Verification :  IEquatable<Verification>
    {
        /// <summary>
        /// Defines Failure
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FailureEnum
        {
            
            /// <summary>
            /// Enum HASHNOTFOUND for value: HASH_NOT_FOUND
            /// </summary>
            [EnumMember(Value = "HASH_NOT_FOUND")]
            HASHNOTFOUND = 1,
            
            /// <summary>
            /// Enum HASHMISMATCH for value: HASH_MISMATCH
            /// </summary>
            [EnumMember(Value = "HASH_MISMATCH")]
            HASHMISMATCH = 2,
            
            /// <summary>
            /// Enum SEARCHENGINEANDDBMISMATCH for value: SEARCH_ENGINE_AND_DB_MISMATCH
            /// </summary>
            [EnumMember(Value = "SEARCH_ENGINE_AND_DB_MISMATCH")]
            SEARCHENGINEANDDBMISMATCH = 3,
            
            /// <summary>
            /// Enum MISSINGPREVIOUSENTRY for value: MISSING_PREVIOUS_ENTRY
            /// </summary>
            [EnumMember(Value = "MISSING_PREVIOUS_ENTRY")]
            MISSINGPREVIOUSENTRY = 4,
            
            /// <summary>
            /// Enum MISSINGDBENTRY for value: MISSING_DB_ENTRY
            /// </summary>
            [EnumMember(Value = "MISSING_DB_ENTRY")]
            MISSINGDBENTRY = 5,
            
            /// <summary>
            /// Enum TIMESTAMPVALIDATIONFAILED for value: TIMESTAMP_VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "TIMESTAMP_VALIDATION_FAILED")]
            TIMESTAMPVALIDATIONFAILED = 6,
            
            /// <summary>
            /// Enum TIMESTAMPGROUPHASHMISMATCH for value: TIMESTAMP_GROUP_HASH_MISMATCH
            /// </summary>
            [EnumMember(Value = "TIMESTAMP_GROUP_HASH_MISMATCH")]
            TIMESTAMPGROUPHASHMISMATCH = 7,
            
            /// <summary>
            /// Enum SIGNATUREMISMATCH for value: SIGNATURE_MISMATCH
            /// </summary>
            [EnumMember(Value = "SIGNATURE_MISMATCH")]
            SIGNATUREMISMATCH = 8,
            
            /// <summary>
            /// Enum MISSINGSIGNATURE for value: MISSING_SIGNATURE
            /// </summary>
            [EnumMember(Value = "MISSING_SIGNATURE")]
            MISSINGSIGNATURE = 9,
            
            /// <summary>
            /// Enum MISSINGPREVIOUSTIMESTAMPTOKEN for value: MISSING_PREVIOUS_TIMESTAMP_TOKEN
            /// </summary>
            [EnumMember(Value = "MISSING_PREVIOUS_TIMESTAMP_TOKEN")]
            MISSINGPREVIOUSTIMESTAMPTOKEN = 10,
            
            /// <summary>
            /// Enum PREVIOUSTIMESTAMPTOKENHASHMISMATCH for value: PREVIOUS_TIMESTAMP_TOKEN_HASH_MISMATCH
            /// </summary>
            [EnumMember(Value = "PREVIOUS_TIMESTAMP_TOKEN_HASH_MISMATCH")]
            PREVIOUSTIMESTAMPTOKENHASHMISMATCH = 11,
            
            /// <summary>
            /// Enum TIMESTAMPGROUPINVALID for value: TIMESTAMP_GROUP_INVALID
            /// </summary>
            [EnumMember(Value = "TIMESTAMP_GROUP_INVALID")]
            TIMESTAMPGROUPINVALID = 12,
            
            /// <summary>
            /// Enum ETHEREUMSTOREDDATANOTFOUND for value: ETHEREUM_STORED_DATA_NOT_FOUND
            /// </summary>
            [EnumMember(Value = "ETHEREUM_STORED_DATA_NOT_FOUND")]
            ETHEREUMSTOREDDATANOTFOUND = 13,
            
            /// <summary>
            /// Enum ETHEREUMCONSISTENCYPROOFFAILED for value: ETHEREUM_CONSISTENCY_PROOF_FAILED
            /// </summary>
            [EnumMember(Value = "ETHEREUM_CONSISTENCY_PROOF_FAILED")]
            ETHEREUMCONSISTENCYPROOFFAILED = 14
        }

        /// <summary>
        /// Gets or Sets Failure
        /// </summary>
        [DataMember(Name="failure", EmitDefaultValue=false)]
        public FailureEnum? Failure { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 1,
            
            /// <summary>
            /// Enum APICALL for value: API_CALL
            /// </summary>
            [EnumMember(Value = "API_CALL")]
            APICALL = 2,
            
            /// <summary>
            /// Enum BACKGROUND for value: BACKGROUND
            /// </summary>
            [EnumMember(Value = "BACKGROUND")]
            BACKGROUND = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Verification" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="attemptedHash">attemptedHash.</param>
        /// <param name="auditLogEntryId">auditLogEntryId.</param>
        /// <param name="created">created.</param>
        /// <param name="failure">failure.</param>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        public Verification(Guid? applicationId = default(Guid?), string attemptedHash = default(string), Guid? auditLogEntryId = default(Guid?), DateTime? created = default(DateTime?), FailureEnum? failure = default(FailureEnum?), Guid? id = default(Guid?), TypeEnum? type = default(TypeEnum?))
        {
            this.ApplicationId = applicationId;
            this.AttemptedHash = attemptedHash;
            this.AuditLogEntryId = auditLogEntryId;
            this.Created = created;
            this.Failure = failure;
            this.Id = id;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets AttemptedHash
        /// </summary>
        [DataMember(Name="attemptedHash", EmitDefaultValue=false)]
        public string AttemptedHash { get; set; }

        /// <summary>
        /// Gets or Sets AuditLogEntryId
        /// </summary>
        [DataMember(Name="auditLogEntryId", EmitDefaultValue=false)]
        public Guid? AuditLogEntryId { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Verification {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  AttemptedHash: ").Append(AttemptedHash).Append("\n");
            sb.Append("  AuditLogEntryId: ").Append(AuditLogEntryId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Verification);
        }

        /// <summary>
        /// Returns true if Verification instances are equal
        /// </summary>
        /// <param name="input">Instance of Verification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Verification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.AttemptedHash == input.AttemptedHash ||
                    (this.AttemptedHash != null &&
                    this.AttemptedHash.Equals(input.AttemptedHash))
                ) && 
                (
                    this.AuditLogEntryId == input.AuditLogEntryId ||
                    (this.AuditLogEntryId != null &&
                    this.AuditLogEntryId.Equals(input.AuditLogEntryId))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Failure == input.Failure ||
                    (this.Failure != null &&
                    this.Failure.Equals(input.Failure))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.AttemptedHash != null)
                    hashCode = hashCode * 59 + this.AttemptedHash.GetHashCode();
                if (this.AuditLogEntryId != null)
                    hashCode = hashCode * 59 + this.AuditLogEntryId.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Failure != null)
                    hashCode = hashCode * 59 + this.Failure.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}
