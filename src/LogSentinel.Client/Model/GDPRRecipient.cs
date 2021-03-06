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
    /// GDPRRecipient
    /// </summary>
    [DataContract]
    public partial class GDPRRecipient :  IEquatable<GDPRRecipient>
    {
        /// <summary>
        /// Defines Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum STAFF for value: STAFF
            /// </summary>
            [EnumMember(Value = "STAFF")]
            STAFF = 1,
            
            /// <summary>
            /// Enum PUBLICAUTHORITY for value: PUBLIC_AUTHORITY
            /// </summary>
            [EnumMember(Value = "PUBLIC_AUTHORITY")]
            PUBLICAUTHORITY = 2,
            
            /// <summary>
            /// Enum CONTRACTOR for value: CONTRACTOR
            /// </summary>
            [EnumMember(Value = "CONTRACTOR")]
            CONTRACTOR = 3,
            
            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 4
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Defines EntityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityTypeEnum
        {
            
            /// <summary>
            /// Enum CONTROLLER for value: CONTROLLER
            /// </summary>
            [EnumMember(Value = "CONTROLLER")]
            CONTROLLER = 1,
            
            /// <summary>
            /// Enum PROCESSOR for value: PROCESSOR
            /// </summary>
            [EnumMember(Value = "PROCESSOR")]
            PROCESSOR = 2,
            
            /// <summary>
            /// Enum NONEUENTITYREPRESENTATIVE for value: NON_EU_ENTITY_REPRESENTATIVE
            /// </summary>
            [EnumMember(Value = "NON_EU_ENTITY_REPRESENTATIVE")]
            NONEUENTITYREPRESENTATIVE = 3,
            
            /// <summary>
            /// Enum THIRDPARTY for value: THIRD_PARTY
            /// </summary>
            [EnumMember(Value = "THIRD_PARTY")]
            THIRDPARTY = 4
        }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
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
        /// Initializes a new instance of the <see cref="GDPRRecipient" /> class.
        /// </summary>
        /// <param name="category">category.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="legalEntityType">legalEntityType.</param>
        /// <param name="legalIdentifier">legalIdentifier.</param>
        /// <param name="name">name.</param>
        public GDPRRecipient(CategoryEnum? category = default(CategoryEnum?), EntityTypeEnum? entityType = default(EntityTypeEnum?), LegalEntityTypeEnum? legalEntityType = default(LegalEntityTypeEnum?), string legalIdentifier = default(string), string name = default(string))
        {
            this.Category = category;
            this.EntityType = entityType;
            this.LegalEntityType = legalEntityType;
            this.LegalIdentifier = legalIdentifier;
            this.Name = name;
        }
        



        /// <summary>
        /// Gets or Sets LegalIdentifier
        /// </summary>
        [DataMember(Name="legalIdentifier", EmitDefaultValue=false)]
        public string LegalIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GDPRRecipient {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  LegalEntityType: ").Append(LegalEntityType).Append("\n");
            sb.Append("  LegalIdentifier: ").Append(LegalIdentifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as GDPRRecipient);
        }

        /// <summary>
        /// Returns true if GDPRRecipient instances are equal
        /// </summary>
        /// <param name="input">Instance of GDPRRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GDPRRecipient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.LegalEntityType != null)
                    hashCode = hashCode * 59 + this.LegalEntityType.GetHashCode();
                if (this.LegalIdentifier != null)
                    hashCode = hashCode * 59 + this.LegalIdentifier.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
