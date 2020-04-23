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
    /// AuditLogEntry
    /// </summary>
    [DataContract]
    public partial class AuditLogEntry :  IEquatable<AuditLogEntry>, IValidatableObject
    {
        /// <summary>
        /// Defines LogLevel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LogLevelEnum
        {
            
            /// <summary>
            /// Enum TRACE for value: TRACE
            /// </summary>
            [EnumMember(Value = "TRACE")]
            TRACE = 1,
            
            /// <summary>
            /// Enum DEBUG for value: DEBUG
            /// </summary>
            [EnumMember(Value = "DEBUG")]
            DEBUG = 2,
            
            /// <summary>
            /// Enum INFO for value: INFO
            /// </summary>
            [EnumMember(Value = "INFO")]
            INFO = 3,
            
            /// <summary>
            /// Enum WARN for value: WARN
            /// </summary>
            [EnumMember(Value = "WARN")]
            WARN = 4,
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 5,
            
            /// <summary>
            /// Enum CRITICAL for value: CRITICAL
            /// </summary>
            [EnumMember(Value = "CRITICAL")]
            CRITICAL = 6,
            
            /// <summary>
            /// Enum FATAL for value: FATAL
            /// </summary>
            [EnumMember(Value = "FATAL")]
            FATAL = 7
        }

        /// <summary>
        /// Gets or Sets LogLevel
        /// </summary>
        [DataMember(Name="logLevel", EmitDefaultValue=false)]
        public LogLevelEnum? LogLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEntry" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="actorDisplayName">actorDisplayName.</param>
        /// <param name="actorId">actorId.</param>
        /// <param name="actorRoles">actorRoles.</param>
        /// <param name="additionalParams">additionalParams.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="details">details.</param>
        /// <param name="encryptedKeywordsList">encryptedKeywordsList.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="entryType">entryType.</param>
        /// <param name="hash">hash.</param>
        /// <param name="hashVersion">hashVersion.</param>
        /// <param name="id">id.</param>
        /// <param name="insideWorkingHours">insideWorkingHours.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="logLevel">logLevel.</param>
        /// <param name="numericParams">numericParams.</param>
        /// <param name="originalEventTimestamp">originalEventTimestamp.</param>
        /// <param name="previousEntryId">previousEntryId.</param>
        /// <param name="standaloneHash">standaloneHash.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="timestampGroupHash">timestampGroupHash.</param>
        /// <param name="timestampGroupSize">timestampGroupSize.</param>
        /// <param name="timestampTime">timestampTime.</param>
        /// <param name="timestampTokenId">timestampTokenId.</param>
        public AuditLogEntry(string action = default(string), string actorDisplayName = default(string), string actorId = default(string), List<string> actorRoles = default(List<string>), Dictionary<string, string> additionalParams = default(Dictionary<string, string>), Guid? applicationId = default(Guid?), string details = default(string), List<string> encryptedKeywordsList = default(List<string>), string entityId = default(string), string entityType = default(string), string entryType = default(string), string hash = default(string), int? hashVersion = default(int?), Guid? id = default(Guid?), bool? insideWorkingHours = default(bool?), string ipAddress = default(string), LogLevelEnum? logLevel = default(LogLevelEnum?), Dictionary<string, double?> numericParams = default(Dictionary<string, double?>), long? originalEventTimestamp = default(long?), Guid? previousEntryId = default(Guid?), string standaloneHash = default(string), long? timestamp = default(long?), string timestampGroupHash = default(string), int? timestampGroupSize = default(int?), DateTime? timestampTime = default(DateTime?), Guid? timestampTokenId = default(Guid?))
        {
            this.Action = action;
            this.ActorDisplayName = actorDisplayName;
            this.ActorId = actorId;
            this.ActorRoles = actorRoles;
            this.AdditionalParams = additionalParams;
            this.ApplicationId = applicationId;
            this.Details = details;
            this.EncryptedKeywordsList = encryptedKeywordsList;
            this.EntityId = entityId;
            this.EntityType = entityType;
            this.EntryType = entryType;
            this.Hash = hash;
            this.HashVersion = hashVersion;
            this.Id = id;
            this.InsideWorkingHours = insideWorkingHours;
            this.IpAddress = ipAddress;
            this.LogLevel = logLevel;
            this.NumericParams = numericParams;
            this.OriginalEventTimestamp = originalEventTimestamp;
            this.PreviousEntryId = previousEntryId;
            this.StandaloneHash = standaloneHash;
            this.Timestamp = timestamp;
            this.TimestampGroupHash = timestampGroupHash;
            this.TimestampGroupSize = timestampGroupSize;
            this.TimestampTime = timestampTime;
            this.TimestampTokenId = timestampTokenId;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

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
        /// Gets or Sets AdditionalParams
        /// </summary>
        [DataMember(Name="additionalParams", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalParams { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets EncryptedKeywordsList
        /// </summary>
        [DataMember(Name="encryptedKeywordsList", EmitDefaultValue=false)]
        public List<string> EncryptedKeywordsList { get; set; }

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
        /// Gets or Sets EntryType
        /// </summary>
        [DataMember(Name="entryType", EmitDefaultValue=false)]
        public string EntryType { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets HashVersion
        /// </summary>
        [DataMember(Name="hashVersion", EmitDefaultValue=false)]
        public int? HashVersion { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets InsideWorkingHours
        /// </summary>
        [DataMember(Name="insideWorkingHours", EmitDefaultValue=false)]
        public bool? InsideWorkingHours { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }


        /// <summary>
        /// Gets or Sets NumericParams
        /// </summary>
        [DataMember(Name="numericParams", EmitDefaultValue=false)]
        public Dictionary<string, double?> NumericParams { get; set; }

        /// <summary>
        /// Gets or Sets OriginalEventTimestamp
        /// </summary>
        [DataMember(Name="originalEventTimestamp", EmitDefaultValue=false)]
        public long? OriginalEventTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets PreviousEntryId
        /// </summary>
        [DataMember(Name="previousEntryId", EmitDefaultValue=false)]
        public Guid? PreviousEntryId { get; set; }

        /// <summary>
        /// Gets or Sets StandaloneHash
        /// </summary>
        [DataMember(Name="standaloneHash", EmitDefaultValue=false)]
        public string StandaloneHash { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets TimestampGroupHash
        /// </summary>
        [DataMember(Name="timestampGroupHash", EmitDefaultValue=false)]
        public string TimestampGroupHash { get; set; }

        /// <summary>
        /// Gets or Sets TimestampGroupSize
        /// </summary>
        [DataMember(Name="timestampGroupSize", EmitDefaultValue=false)]
        public int? TimestampGroupSize { get; set; }

        /// <summary>
        /// Gets or Sets TimestampTime
        /// </summary>
        [DataMember(Name="timestampTime", EmitDefaultValue=false)]
        public DateTime? TimestampTime { get; set; }

        /// <summary>
        /// Gets or Sets TimestampTokenId
        /// </summary>
        [DataMember(Name="timestampTokenId", EmitDefaultValue=false)]
        public Guid? TimestampTokenId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditLogEntry {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActorDisplayName: ").Append(ActorDisplayName).Append("\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  ActorRoles: ").Append(ActorRoles).Append("\n");
            sb.Append("  AdditionalParams: ").Append(AdditionalParams).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  EncryptedKeywordsList: ").Append(EncryptedKeywordsList).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  HashVersion: ").Append(HashVersion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InsideWorkingHours: ").Append(InsideWorkingHours).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  LogLevel: ").Append(LogLevel).Append("\n");
            sb.Append("  NumericParams: ").Append(NumericParams).Append("\n");
            sb.Append("  OriginalEventTimestamp: ").Append(OriginalEventTimestamp).Append("\n");
            sb.Append("  PreviousEntryId: ").Append(PreviousEntryId).Append("\n");
            sb.Append("  StandaloneHash: ").Append(StandaloneHash).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TimestampGroupHash: ").Append(TimestampGroupHash).Append("\n");
            sb.Append("  TimestampGroupSize: ").Append(TimestampGroupSize).Append("\n");
            sb.Append("  TimestampTime: ").Append(TimestampTime).Append("\n");
            sb.Append("  TimestampTokenId: ").Append(TimestampTokenId).Append("\n");
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
            return this.Equals(input as AuditLogEntry);
        }

        /// <summary>
        /// Returns true if AuditLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogEntry input)
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
                    this.AdditionalParams == input.AdditionalParams ||
                    this.AdditionalParams != null &&
                    this.AdditionalParams.SequenceEqual(input.AdditionalParams)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.EncryptedKeywordsList == input.EncryptedKeywordsList ||
                    this.EncryptedKeywordsList != null &&
                    this.EncryptedKeywordsList.SequenceEqual(input.EncryptedKeywordsList)
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
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.HashVersion == input.HashVersion ||
                    (this.HashVersion != null &&
                    this.HashVersion.Equals(input.HashVersion))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InsideWorkingHours == input.InsideWorkingHours ||
                    (this.InsideWorkingHours != null &&
                    this.InsideWorkingHours.Equals(input.InsideWorkingHours))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.LogLevel == input.LogLevel ||
                    (this.LogLevel != null &&
                    this.LogLevel.Equals(input.LogLevel))
                ) && 
                (
                    this.NumericParams == input.NumericParams ||
                    this.NumericParams != null &&
                    this.NumericParams.SequenceEqual(input.NumericParams)
                ) && 
                (
                    this.OriginalEventTimestamp == input.OriginalEventTimestamp ||
                    (this.OriginalEventTimestamp != null &&
                    this.OriginalEventTimestamp.Equals(input.OriginalEventTimestamp))
                ) && 
                (
                    this.PreviousEntryId == input.PreviousEntryId ||
                    (this.PreviousEntryId != null &&
                    this.PreviousEntryId.Equals(input.PreviousEntryId))
                ) && 
                (
                    this.StandaloneHash == input.StandaloneHash ||
                    (this.StandaloneHash != null &&
                    this.StandaloneHash.Equals(input.StandaloneHash))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.TimestampGroupHash == input.TimestampGroupHash ||
                    (this.TimestampGroupHash != null &&
                    this.TimestampGroupHash.Equals(input.TimestampGroupHash))
                ) && 
                (
                    this.TimestampGroupSize == input.TimestampGroupSize ||
                    (this.TimestampGroupSize != null &&
                    this.TimestampGroupSize.Equals(input.TimestampGroupSize))
                ) && 
                (
                    this.TimestampTime == input.TimestampTime ||
                    (this.TimestampTime != null &&
                    this.TimestampTime.Equals(input.TimestampTime))
                ) && 
                (
                    this.TimestampTokenId == input.TimestampTokenId ||
                    (this.TimestampTokenId != null &&
                    this.TimestampTokenId.Equals(input.TimestampTokenId))
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
                if (this.ActorDisplayName != null)
                    hashCode = hashCode * 59 + this.ActorDisplayName.GetHashCode();
                if (this.ActorId != null)
                    hashCode = hashCode * 59 + this.ActorId.GetHashCode();
                if (this.ActorRoles != null)
                    hashCode = hashCode * 59 + this.ActorRoles.GetHashCode();
                if (this.AdditionalParams != null)
                    hashCode = hashCode * 59 + this.AdditionalParams.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.EncryptedKeywordsList != null)
                    hashCode = hashCode * 59 + this.EncryptedKeywordsList.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.EntryType != null)
                    hashCode = hashCode * 59 + this.EntryType.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.HashVersion != null)
                    hashCode = hashCode * 59 + this.HashVersion.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InsideWorkingHours != null)
                    hashCode = hashCode * 59 + this.InsideWorkingHours.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.LogLevel != null)
                    hashCode = hashCode * 59 + this.LogLevel.GetHashCode();
                if (this.NumericParams != null)
                    hashCode = hashCode * 59 + this.NumericParams.GetHashCode();
                if (this.OriginalEventTimestamp != null)
                    hashCode = hashCode * 59 + this.OriginalEventTimestamp.GetHashCode();
                if (this.PreviousEntryId != null)
                    hashCode = hashCode * 59 + this.PreviousEntryId.GetHashCode();
                if (this.StandaloneHash != null)
                    hashCode = hashCode * 59 + this.StandaloneHash.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TimestampGroupHash != null)
                    hashCode = hashCode * 59 + this.TimestampGroupHash.GetHashCode();
                if (this.TimestampGroupSize != null)
                    hashCode = hashCode * 59 + this.TimestampGroupSize.GetHashCode();
                if (this.TimestampTime != null)
                    hashCode = hashCode * 59 + this.TimestampTime.GetHashCode();
                if (this.TimestampTokenId != null)
                    hashCode = hashCode * 59 + this.TimestampTokenId.GetHashCode();
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
    }

}