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
    /// GDPRResponsibleEntity
    /// </summary>
    [DataContract]
    public partial class GDPRResponsibleEntity :  IEquatable<GDPRResponsibleEntity>, IValidatableObject
    {
        /// <summary>
        /// Defines LegalEntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LegalEntityTypeEnum
        {
            
            /// <summary>
            /// Enum LEGALPERSON for value: LEGAL_PERSON
            /// </summary>
            [EnumMember(Value = "LEGAL_PERSON")]
            LEGALPERSON = 1,
            
            /// <summary>
            /// Enum NATURALPERSON for value: NATURAL_PERSON
            /// </summary>
            [EnumMember(Value = "NATURAL_PERSON")]
            NATURALPERSON = 2,
            
            /// <summary>
            /// Enum PUBLICAUTHORITY for value: PUBLIC_AUTHORITY
            /// </summary>
            [EnumMember(Value = "PUBLIC_AUTHORITY")]
            PUBLICAUTHORITY = 3
        }

        /// <summary>
        /// Gets or Sets LegalEntityType
        /// </summary>
        [DataMember(Name="legalEntityType", EmitDefaultValue=false)]
        public LegalEntityTypeEnum? LegalEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GDPRResponsibleEntity" /> class.
        /// </summary>
        /// <param name="aboveGDPREmployeeThreshold">aboveGDPREmployeeThreshold.</param>
        /// <param name="address">address.</param>
        /// <param name="created">created.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="dpoEmail">dpoEmail.</param>
        /// <param name="dpoName">dpoName.</param>
        /// <param name="dpoPhone">dpoPhone.</param>
        /// <param name="entityName">entityName.</param>
        /// <param name="id">id.</param>
        /// <param name="legalEntityType">legalEntityType.</param>
        /// <param name="legalIdentifier">legalIdentifier.</param>
        /// <param name="owningOrganizationId">owningOrganizationId.</param>
        /// <param name="representativeEmail">representativeEmail.</param>
        /// <param name="representativeName">representativeName.</param>
        /// <param name="representativePhone">representativePhone.</param>
        /// <param name="updated">updated.</param>
        public GDPRResponsibleEntity(bool? aboveGDPREmployeeThreshold = default(bool?), string address = default(string), DateTime? created = default(DateTime?), bool? deleted = default(bool?), string dpoEmail = default(string), string dpoName = default(string), string dpoPhone = default(string), string entityName = default(string), Guid? id = default(Guid?), LegalEntityTypeEnum? legalEntityType = default(LegalEntityTypeEnum?), string legalIdentifier = default(string), Guid? owningOrganizationId = default(Guid?), string representativeEmail = default(string), string representativeName = default(string), string representativePhone = default(string), DateTime? updated = default(DateTime?))
        {
            this.AboveGDPREmployeeThreshold = aboveGDPREmployeeThreshold;
            this.Address = address;
            this.Created = created;
            this.Deleted = deleted;
            this.DpoEmail = dpoEmail;
            this.DpoName = dpoName;
            this.DpoPhone = dpoPhone;
            this.EntityName = entityName;
            this.Id = id;
            this.LegalEntityType = legalEntityType;
            this.LegalIdentifier = legalIdentifier;
            this.OwningOrganizationId = owningOrganizationId;
            this.RepresentativeEmail = representativeEmail;
            this.RepresentativeName = representativeName;
            this.RepresentativePhone = representativePhone;
            this.Updated = updated;
        }
        
        /// <summary>
        /// Gets or Sets AboveGDPREmployeeThreshold
        /// </summary>
        [DataMember(Name="aboveGDPREmployeeThreshold", EmitDefaultValue=false)]
        public bool? AboveGDPREmployeeThreshold { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or Sets DpoEmail
        /// </summary>
        [DataMember(Name="dpoEmail", EmitDefaultValue=false)]
        public string DpoEmail { get; set; }

        /// <summary>
        /// Gets or Sets DpoName
        /// </summary>
        [DataMember(Name="dpoName", EmitDefaultValue=false)]
        public string DpoName { get; set; }

        /// <summary>
        /// Gets or Sets DpoPhone
        /// </summary>
        [DataMember(Name="dpoPhone", EmitDefaultValue=false)]
        public string DpoPhone { get; set; }

        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }


        /// <summary>
        /// Gets or Sets LegalIdentifier
        /// </summary>
        [DataMember(Name="legalIdentifier", EmitDefaultValue=false)]
        public string LegalIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets OwningOrganizationId
        /// </summary>
        [DataMember(Name="owningOrganizationId", EmitDefaultValue=false)]
        public Guid? OwningOrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets RepresentativeEmail
        /// </summary>
        [DataMember(Name="representativeEmail", EmitDefaultValue=false)]
        public string RepresentativeEmail { get; set; }

        /// <summary>
        /// Gets or Sets RepresentativeName
        /// </summary>
        [DataMember(Name="representativeName", EmitDefaultValue=false)]
        public string RepresentativeName { get; set; }

        /// <summary>
        /// Gets or Sets RepresentativePhone
        /// </summary>
        [DataMember(Name="representativePhone", EmitDefaultValue=false)]
        public string RepresentativePhone { get; set; }

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
            sb.Append("class GDPRResponsibleEntity {\n");
            sb.Append("  AboveGDPREmployeeThreshold: ").Append(AboveGDPREmployeeThreshold).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  DpoEmail: ").Append(DpoEmail).Append("\n");
            sb.Append("  DpoName: ").Append(DpoName).Append("\n");
            sb.Append("  DpoPhone: ").Append(DpoPhone).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LegalEntityType: ").Append(LegalEntityType).Append("\n");
            sb.Append("  LegalIdentifier: ").Append(LegalIdentifier).Append("\n");
            sb.Append("  OwningOrganizationId: ").Append(OwningOrganizationId).Append("\n");
            sb.Append("  RepresentativeEmail: ").Append(RepresentativeEmail).Append("\n");
            sb.Append("  RepresentativeName: ").Append(RepresentativeName).Append("\n");
            sb.Append("  RepresentativePhone: ").Append(RepresentativePhone).Append("\n");
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
            return this.Equals(input as GDPRResponsibleEntity);
        }

        /// <summary>
        /// Returns true if GDPRResponsibleEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of GDPRResponsibleEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GDPRResponsibleEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AboveGDPREmployeeThreshold == input.AboveGDPREmployeeThreshold ||
                    (this.AboveGDPREmployeeThreshold != null &&
                    this.AboveGDPREmployeeThreshold.Equals(input.AboveGDPREmployeeThreshold))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.DpoEmail == input.DpoEmail ||
                    (this.DpoEmail != null &&
                    this.DpoEmail.Equals(input.DpoEmail))
                ) && 
                (
                    this.DpoName == input.DpoName ||
                    (this.DpoName != null &&
                    this.DpoName.Equals(input.DpoName))
                ) && 
                (
                    this.DpoPhone == input.DpoPhone ||
                    (this.DpoPhone != null &&
                    this.DpoPhone.Equals(input.DpoPhone))
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LegalEntityType == input.LegalEntityType ||
                    (this.LegalEntityType != null &&
                    this.LegalEntityType.Equals(input.LegalEntityType))
                ) && 
                (
                    this.LegalIdentifier == input.LegalIdentifier ||
                    (this.LegalIdentifier != null &&
                    this.LegalIdentifier.Equals(input.LegalIdentifier))
                ) && 
                (
                    this.OwningOrganizationId == input.OwningOrganizationId ||
                    (this.OwningOrganizationId != null &&
                    this.OwningOrganizationId.Equals(input.OwningOrganizationId))
                ) && 
                (
                    this.RepresentativeEmail == input.RepresentativeEmail ||
                    (this.RepresentativeEmail != null &&
                    this.RepresentativeEmail.Equals(input.RepresentativeEmail))
                ) && 
                (
                    this.RepresentativeName == input.RepresentativeName ||
                    (this.RepresentativeName != null &&
                    this.RepresentativeName.Equals(input.RepresentativeName))
                ) && 
                (
                    this.RepresentativePhone == input.RepresentativePhone ||
                    (this.RepresentativePhone != null &&
                    this.RepresentativePhone.Equals(input.RepresentativePhone))
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
                if (this.AboveGDPREmployeeThreshold != null)
                    hashCode = hashCode * 59 + this.AboveGDPREmployeeThreshold.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.DpoEmail != null)
                    hashCode = hashCode * 59 + this.DpoEmail.GetHashCode();
                if (this.DpoName != null)
                    hashCode = hashCode * 59 + this.DpoName.GetHashCode();
                if (this.DpoPhone != null)
                    hashCode = hashCode * 59 + this.DpoPhone.GetHashCode();
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LegalEntityType != null)
                    hashCode = hashCode * 59 + this.LegalEntityType.GetHashCode();
                if (this.LegalIdentifier != null)
                    hashCode = hashCode * 59 + this.LegalIdentifier.GetHashCode();
                if (this.OwningOrganizationId != null)
                    hashCode = hashCode * 59 + this.OwningOrganizationId.GetHashCode();
                if (this.RepresentativeEmail != null)
                    hashCode = hashCode * 59 + this.RepresentativeEmail.GetHashCode();
                if (this.RepresentativeName != null)
                    hashCode = hashCode * 59 + this.RepresentativeName.GetHashCode();
                if (this.RepresentativePhone != null)
                    hashCode = hashCode * 59 + this.RepresentativePhone.GetHashCode();
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