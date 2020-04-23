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
    /// AlertDestination
    /// </summary>
    [DataContract]
    public partial class AlertDestination :  IEquatable<AlertDestination>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAIL = 1,
            
            /// <summary>
            /// Enum TELEGRAM for value: TELEGRAM
            /// </summary>
            [EnumMember(Value = "TELEGRAM")]
            TELEGRAM = 2,
            
            /// <summary>
            /// Enum URL for value: URL
            /// </summary>
            [EnumMember(Value = "URL")]
            URL = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertDestination" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="created">created.</param>
        /// <param name="customHeaders">customHeaders.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="recipients">recipients.</param>
        /// <param name="recipientsNames">recipientsNames.</param>
        /// <param name="type">type.</param>
        /// <param name="updated">updated.</param>
        public AlertDestination(string code = default(string), DateTime? created = default(DateTime?), List<string> customHeaders = default(List<string>), Guid? id = default(Guid?), string name = default(string), Guid? organizationId = default(Guid?), List<string> recipients = default(List<string>), List<string> recipientsNames = default(List<string>), TypeEnum? type = default(TypeEnum?), DateTime? updated = default(DateTime?))
        {
            this.Code = code;
            this.Created = created;
            this.CustomHeaders = customHeaders;
            this.Id = id;
            this.Name = name;
            this.OrganizationId = organizationId;
            this.Recipients = recipients;
            this.RecipientsNames = recipientsNames;
            this.Type = type;
            this.Updated = updated;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets CustomHeaders
        /// </summary>
        [DataMember(Name="customHeaders", EmitDefaultValue=false)]
        public List<string> CustomHeaders { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

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
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<string> Recipients { get; set; }

        /// <summary>
        /// Gets or Sets RecipientsNames
        /// </summary>
        [DataMember(Name="recipientsNames", EmitDefaultValue=false)]
        public List<string> RecipientsNames { get; set; }


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
            sb.Append("class AlertDestination {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CustomHeaders: ").Append(CustomHeaders).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  RecipientsNames: ").Append(RecipientsNames).Append("\n");
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
            return this.Equals(input as AlertDestination);
        }

        /// <summary>
        /// Returns true if AlertDestination instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertDestination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertDestination input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CustomHeaders == input.CustomHeaders ||
                    this.CustomHeaders != null &&
                    this.CustomHeaders.SequenceEqual(input.CustomHeaders)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.RecipientsNames == input.RecipientsNames ||
                    this.RecipientsNames != null &&
                    this.RecipientsNames.SequenceEqual(input.RecipientsNames)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CustomHeaders != null)
                    hashCode = hashCode * 59 + this.CustomHeaders.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.RecipientsNames != null)
                    hashCode = hashCode * 59 + this.RecipientsNames.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
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
