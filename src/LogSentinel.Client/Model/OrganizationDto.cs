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
    /// OrganizationDto
    /// </summary>
    [DataContract]
    public partial class OrganizationDto :  IEquatable<OrganizationDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDto" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="defaultTimezone">defaultTimezone.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="reportRecipients">reportRecipients.</param>
        /// <param name="secret">secret.</param>
        public OrganizationDto(Dictionary<string, string> attributes = default(Dictionary<string, string>), string defaultTimezone = default(string), Guid? id = default(Guid?), string name = default(string), List<string> reportRecipients = default(List<string>), string secret = default(string))
        {
            this.Attributes = attributes;
            this.DefaultTimezone = defaultTimezone;
            this.Id = id;
            this.Name = name;
            this.ReportRecipients = reportRecipients;
            this.Secret = secret;
        }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTimezone
        /// </summary>
        [DataMember(Name="defaultTimezone", EmitDefaultValue=false)]
        public string DefaultTimezone { get; set; }

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
        /// Gets or Sets ReportRecipients
        /// </summary>
        [DataMember(Name="reportRecipients", EmitDefaultValue=false)]
        public List<string> ReportRecipients { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationDto {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  DefaultTimezone: ").Append(DefaultTimezone).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReportRecipients: ").Append(ReportRecipients).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
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
            return this.Equals(input as OrganizationDto);
        }

        /// <summary>
        /// Returns true if OrganizationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.DefaultTimezone == input.DefaultTimezone ||
                    (this.DefaultTimezone != null &&
                    this.DefaultTimezone.Equals(input.DefaultTimezone))
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
                    this.ReportRecipients == input.ReportRecipients ||
                    this.ReportRecipients != null &&
                    this.ReportRecipients.SequenceEqual(input.ReportRecipients)
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.DefaultTimezone != null)
                    hashCode = hashCode * 59 + this.DefaultTimezone.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReportRecipients != null)
                    hashCode = hashCode * 59 + this.ReportRecipients.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                return hashCode;
            }
        }
    }

}
