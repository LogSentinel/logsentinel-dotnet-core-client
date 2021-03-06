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
    /// MachineLearningSettings
    /// </summary>
    [DataContract]
    public partial class MachineLearningSettings :  IEquatable<MachineLearningSettings>
    {
        /// <summary>
        /// Defines TimestampField
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimestampFieldEnum
        {
            
            /// <summary>
            /// Enum RECEIVED for value: RECEIVED
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED = 1,
            
            /// <summary>
            /// Enum ORIGINAL for value: ORIGINAL
            /// </summary>
            [EnumMember(Value = "ORIGINAL")]
            ORIGINAL = 2
        }

        /// <summary>
        /// Gets or Sets TimestampField
        /// </summary>
        [DataMember(Name="timestampField", EmitDefaultValue=false)]
        public TimestampFieldEnum? TimestampField { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MachineLearningSettings" /> class.
        /// </summary>
        /// <param name="anomalyDetectionEnabled">anomalyDetectionEnabled.</param>
        /// <param name="anomalyDetectionEnabledDate">anomalyDetectionEnabledDate.</param>
        /// <param name="includeEntityFields">includeEntityFields.</param>
        /// <param name="timestampField">timestampField.</param>
        public MachineLearningSettings(bool? anomalyDetectionEnabled = default(bool?), DateTime? anomalyDetectionEnabledDate = default(DateTime?), bool? includeEntityFields = default(bool?), TimestampFieldEnum? timestampField = default(TimestampFieldEnum?))
        {
            this.AnomalyDetectionEnabled = anomalyDetectionEnabled;
            this.AnomalyDetectionEnabledDate = anomalyDetectionEnabledDate;
            this.IncludeEntityFields = includeEntityFields;
            this.TimestampField = timestampField;
        }
        
        /// <summary>
        /// Gets or Sets AnomalyDetectionEnabled
        /// </summary>
        [DataMember(Name="anomalyDetectionEnabled", EmitDefaultValue=false)]
        public bool? AnomalyDetectionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets AnomalyDetectionEnabledDate
        /// </summary>
        [DataMember(Name="anomalyDetectionEnabledDate", EmitDefaultValue=false)]
        public DateTime? AnomalyDetectionEnabledDate { get; set; }

        /// <summary>
        /// Gets or Sets IncludeEntityFields
        /// </summary>
        [DataMember(Name="includeEntityFields", EmitDefaultValue=false)]
        public bool? IncludeEntityFields { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MachineLearningSettings {\n");
            sb.Append("  AnomalyDetectionEnabled: ").Append(AnomalyDetectionEnabled).Append("\n");
            sb.Append("  AnomalyDetectionEnabledDate: ").Append(AnomalyDetectionEnabledDate).Append("\n");
            sb.Append("  IncludeEntityFields: ").Append(IncludeEntityFields).Append("\n");
            sb.Append("  TimestampField: ").Append(TimestampField).Append("\n");
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
            return this.Equals(input as MachineLearningSettings);
        }

        /// <summary>
        /// Returns true if MachineLearningSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of MachineLearningSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MachineLearningSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnomalyDetectionEnabled == input.AnomalyDetectionEnabled ||
                    (this.AnomalyDetectionEnabled != null &&
                    this.AnomalyDetectionEnabled.Equals(input.AnomalyDetectionEnabled))
                ) && 
                (
                    this.AnomalyDetectionEnabledDate == input.AnomalyDetectionEnabledDate ||
                    (this.AnomalyDetectionEnabledDate != null &&
                    this.AnomalyDetectionEnabledDate.Equals(input.AnomalyDetectionEnabledDate))
                ) && 
                (
                    this.IncludeEntityFields == input.IncludeEntityFields ||
                    (this.IncludeEntityFields != null &&
                    this.IncludeEntityFields.Equals(input.IncludeEntityFields))
                ) && 
                (
                    this.TimestampField == input.TimestampField ||
                    (this.TimestampField != null &&
                    this.TimestampField.Equals(input.TimestampField))
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
                if (this.AnomalyDetectionEnabled != null)
                    hashCode = hashCode * 59 + this.AnomalyDetectionEnabled.GetHashCode();
                if (this.AnomalyDetectionEnabledDate != null)
                    hashCode = hashCode * 59 + this.AnomalyDetectionEnabledDate.GetHashCode();
                if (this.IncludeEntityFields != null)
                    hashCode = hashCode * 59 + this.IncludeEntityFields.GetHashCode();
                if (this.TimestampField != null)
                    hashCode = hashCode * 59 + this.TimestampField.GetHashCode();
                return hashCode;
            }
        }
    }

}
