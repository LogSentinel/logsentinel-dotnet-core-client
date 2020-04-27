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
    /// AlertRule
    /// </summary>
    [DataContract]
    public partial class AlertRule :  IEquatable<AlertRule>
    {
        /// <summary>
        /// Defines AggregationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationTypeEnum
        {
            
            /// <summary>
            /// Enum COUNT for value: COUNT
            /// </summary>
            [EnumMember(Value = "COUNT")]
            COUNT = 1,
            
            /// <summary>
            /// Enum AVG for value: AVG
            /// </summary>
            [EnumMember(Value = "AVG")]
            AVG = 2,
            
            /// <summary>
            /// Enum SUM for value: SUM
            /// </summary>
            [EnumMember(Value = "SUM")]
            SUM = 3
        }

        /// <summary>
        /// Gets or Sets AggregationType
        /// </summary>
        [DataMember(Name="aggregationType", EmitDefaultValue=false)]
        public AggregationTypeEnum? AggregationType { get; set; }
        /// <summary>
        /// Defines ThresholdType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ThresholdTypeEnum
        {
            
            /// <summary>
            /// Enum ABOVE for value: ABOVE
            /// </summary>
            [EnumMember(Value = "ABOVE")]
            ABOVE = 1,
            
            /// <summary>
            /// Enum BELOW for value: BELOW
            /// </summary>
            [EnumMember(Value = "BELOW")]
            BELOW = 2,
            
            /// <summary>
            /// Enum BOTH for value: BOTH
            /// </summary>
            [EnumMember(Value = "BOTH")]
            BOTH = 3
        }

        /// <summary>
        /// Gets or Sets ThresholdType
        /// </summary>
        [DataMember(Name="thresholdType", EmitDefaultValue=false)]
        public ThresholdTypeEnum? ThresholdType { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum STDEV for value: ST_DEV
            /// </summary>
            [EnumMember(Value = "ST_DEV")]
            STDEV = 1,
            
            /// <summary>
            /// Enum MEAN for value: MEAN
            /// </summary>
            [EnumMember(Value = "MEAN")]
            MEAN = 2,
            
            /// <summary>
            /// Enum FIXED for value: FIXED
            /// </summary>
            [EnumMember(Value = "FIXED")]
            FIXED = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRule" /> class.
        /// </summary>
        /// <param name="aggregationPeriod">aggregationPeriod.</param>
        /// <param name="aggregationType">aggregationType.</param>
        /// <param name="alertDestinationIds">alertDestinationIds.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="created">created.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="groupByField">groupByField.</param>
        /// <param name="id">id.</param>
        /// <param name="insideWorkingHours">insideWorkingHours.</param>
        /// <param name="name">name.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="searchPeriod">searchPeriod.</param>
        /// <param name="thresholdType">thresholdType.</param>
        /// <param name="thresholdValue">thresholdValue.</param>
        /// <param name="type">type.</param>
        /// <param name="updated">updated.</param>
        public AlertRule(string aggregationPeriod = default(string), AggregationTypeEnum? aggregationType = default(AggregationTypeEnum?), List<Guid?> alertDestinationIds = default(List<Guid?>), Guid? applicationId = default(Guid?), DateTime? created = default(DateTime?), bool? enabled = default(bool?), string groupByField = default(string), Guid? id = default(Guid?), bool? insideWorkingHours = default(bool?), string name = default(string), Guid? organizationId = default(Guid?), string searchPeriod = default(string), ThresholdTypeEnum? thresholdType = default(ThresholdTypeEnum?), double? thresholdValue = default(double?), TypeEnum? type = default(TypeEnum?), DateTime? updated = default(DateTime?))
        {
            this.AggregationPeriod = aggregationPeriod;
            this.AggregationType = aggregationType;
            this.AlertDestinationIds = alertDestinationIds;
            this.ApplicationId = applicationId;
            this.Created = created;
            this.Enabled = enabled;
            this.GroupByField = groupByField;
            this.Id = id;
            this.InsideWorkingHours = insideWorkingHours;
            this.Name = name;
            this.OrganizationId = organizationId;
            this.SearchPeriod = searchPeriod;
            this.ThresholdType = thresholdType;
            this.ThresholdValue = thresholdValue;
            this.Type = type;
            this.Updated = updated;
        }
        
        /// <summary>
        /// Gets or Sets AggregationPeriod
        /// </summary>
        [DataMember(Name="aggregationPeriod", EmitDefaultValue=false)]
        public string AggregationPeriod { get; set; }


        /// <summary>
        /// Gets or Sets AlertDestinationIds
        /// </summary>
        [DataMember(Name="alertDestinationIds", EmitDefaultValue=false)]
        public List<Guid?> AlertDestinationIds { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets GroupByField
        /// </summary>
        [DataMember(Name="groupByField", EmitDefaultValue=false)]
        public string GroupByField { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets SearchPeriod
        /// </summary>
        [DataMember(Name="searchPeriod", EmitDefaultValue=false)]
        public string SearchPeriod { get; set; }


        /// <summary>
        /// Gets or Sets ThresholdValue
        /// </summary>
        [DataMember(Name="thresholdValue", EmitDefaultValue=false)]
        public double? ThresholdValue { get; set; }


        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertRule {\n");
            sb.Append("  AggregationPeriod: ").Append(AggregationPeriod).Append("\n");
            sb.Append("  AggregationType: ").Append(AggregationType).Append("\n");
            sb.Append("  AlertDestinationIds: ").Append(AlertDestinationIds).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  GroupByField: ").Append(GroupByField).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InsideWorkingHours: ").Append(InsideWorkingHours).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  SearchPeriod: ").Append(SearchPeriod).Append("\n");
            sb.Append("  ThresholdType: ").Append(ThresholdType).Append("\n");
            sb.Append("  ThresholdValue: ").Append(ThresholdValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(input as AlertRule);
        }

        /// <summary>
        /// Returns true if AlertRule instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregationPeriod == input.AggregationPeriod ||
                    (this.AggregationPeriod != null &&
                    this.AggregationPeriod.Equals(input.AggregationPeriod))
                ) && 
                (
                    this.AggregationType == input.AggregationType ||
                    (this.AggregationType != null &&
                    this.AggregationType.Equals(input.AggregationType))
                ) && 
                (
                    this.AlertDestinationIds == input.AlertDestinationIds ||
                    this.AlertDestinationIds != null &&
                    this.AlertDestinationIds.SequenceEqual(input.AlertDestinationIds)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.GroupByField == input.GroupByField ||
                    (this.GroupByField != null &&
                    this.GroupByField.Equals(input.GroupByField))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.SearchPeriod == input.SearchPeriod ||
                    (this.SearchPeriod != null &&
                    this.SearchPeriod.Equals(input.SearchPeriod))
                ) && 
                (
                    this.ThresholdType == input.ThresholdType ||
                    (this.ThresholdType != null &&
                    this.ThresholdType.Equals(input.ThresholdType))
                ) && 
                (
                    this.ThresholdValue == input.ThresholdValue ||
                    (this.ThresholdValue != null &&
                    this.ThresholdValue.Equals(input.ThresholdValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.AggregationPeriod != null)
                    hashCode = hashCode * 59 + this.AggregationPeriod.GetHashCode();
                if (this.AggregationType != null)
                    hashCode = hashCode * 59 + this.AggregationType.GetHashCode();
                if (this.AlertDestinationIds != null)
                    hashCode = hashCode * 59 + this.AlertDestinationIds.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.GroupByField != null)
                    hashCode = hashCode * 59 + this.GroupByField.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InsideWorkingHours != null)
                    hashCode = hashCode * 59 + this.InsideWorkingHours.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.SearchPeriod != null)
                    hashCode = hashCode * 59 + this.SearchPeriod.GetHashCode();
                if (this.ThresholdType != null)
                    hashCode = hashCode * 59 + this.ThresholdType.GetHashCode();
                if (this.ThresholdValue != null)
                    hashCode = hashCode * 59 + this.ThresholdValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                return hashCode;
            }
        }
    }

}
