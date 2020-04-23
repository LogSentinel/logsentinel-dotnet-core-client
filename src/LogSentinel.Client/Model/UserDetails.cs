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
    /// UserDetails
    /// </summary>
    [DataContract]
    public partial class UserDetails :  IEquatable<UserDetails>, IValidatableObject
    {
        /// <summary>
        /// Defines Language
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageEnum
        {
            
            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            [EnumMember(Value = "EN")]
            EN = 1,
            
            /// <summary>
            /// Enum BG for value: BG
            /// </summary>
            [EnumMember(Value = "BG")]
            BG = 2
        }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Defines OrganizationRole
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrganizationRoleEnum
        {
            
            /// <summary>
            /// Enum ADMIN for value: ADMIN
            /// </summary>
            [EnumMember(Value = "ADMIN")]
            ADMIN = 1,
            
            /// <summary>
            /// Enum AUDITOR for value: AUDITOR
            /// </summary>
            [EnumMember(Value = "AUDITOR")]
            AUDITOR = 2,
            
            /// <summary>
            /// Enum DEVELOPER for value: DEVELOPER
            /// </summary>
            [EnumMember(Value = "DEVELOPER")]
            DEVELOPER = 3,
            
            /// <summary>
            /// Enum MANAGER for value: MANAGER
            /// </summary>
            [EnumMember(Value = "MANAGER")]
            MANAGER = 4,
            
            /// <summary>
            /// Enum IT for value: IT
            /// </summary>
            [EnumMember(Value = "IT")]
            IT = 5,
            
            /// <summary>
            /// Enum PUBLICUSER for value: PUBLIC_USER
            /// </summary>
            [EnumMember(Value = "PUBLIC_USER")]
            PUBLICUSER = 6
        }

        /// <summary>
        /// Gets or Sets OrganizationRole
        /// </summary>
        [DataMember(Name="organizationRole", EmitDefaultValue=false)]
        public OrganizationRoleEnum? OrganizationRole { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetails" /> class.
        /// </summary>
        /// <param name="admin">admin.</param>
        /// <param name="allowedApplicationIds">allowedApplicationIds.</param>
        /// <param name="base64ProfilePicture">base64ProfilePicture.</param>
        /// <param name="confirmed">confirmed.</param>
        /// <param name="created">created.</param>
        /// <param name="demo">demo.</param>
        /// <param name="email">email.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="expired">expired.</param>
        /// <param name="features">features.</param>
        /// <param name="hasPassword">hasPassword.</param>
        /// <param name="id">id.</param>
        /// <param name="integratedCloudProviderId">integratedCloudProviderId.</param>
        /// <param name="language">language.</param>
        /// <param name="ldapProvided">ldapProvided.</param>
        /// <param name="names">names.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="organizationRole">organizationRole.</param>
        /// <param name="paymentsEnabled">paymentsEnabled.</param>
        /// <param name="position">position.</param>
        /// <param name="profilePicture">profilePicture.</param>
        /// <param name="publicUser">publicUser.</param>
        /// <param name="receiveUpdates">receiveUpdates.</param>
        /// <param name="seasonedUser">seasonedUser.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="twoFactorAuthEnabled">twoFactorAuthEnabled.</param>
        /// <param name="twoFactorAuthKey">twoFactorAuthKey.</param>
        /// <param name="whitelabelStyling">whitelabelStyling.</param>
        public UserDetails(bool? admin = default(bool?), List<Guid?> allowedApplicationIds = default(List<Guid?>), string base64ProfilePicture = default(string), bool? confirmed = default(bool?), DateTime? created = default(DateTime?), bool? demo = default(bool?), string email = default(string), DateTime? expirationDate = default(DateTime?), bool? expired = default(bool?), List<string> features = default(List<string>), bool? hasPassword = default(bool?), Guid? id = default(Guid?), string integratedCloudProviderId = default(string), LanguageEnum? language = default(LanguageEnum?), bool? ldapProvided = default(bool?), string names = default(string), Guid? organizationId = default(Guid?), string organizationName = default(string), OrganizationRoleEnum? organizationRole = default(OrganizationRoleEnum?), bool? paymentsEnabled = default(bool?), string position = default(string), ByteBuffer profilePicture = default(ByteBuffer), bool? publicUser = default(bool?), bool? receiveUpdates = default(bool?), bool? seasonedUser = default(bool?), string timezone = default(string), bool? twoFactorAuthEnabled = default(bool?), string twoFactorAuthKey = default(string), WhitelabelStyling whitelabelStyling = default(WhitelabelStyling))
        {
            this.Admin = admin;
            this.AllowedApplicationIds = allowedApplicationIds;
            this.Base64ProfilePicture = base64ProfilePicture;
            this.Confirmed = confirmed;
            this.Created = created;
            this.Demo = demo;
            this.Email = email;
            this.ExpirationDate = expirationDate;
            this.Expired = expired;
            this.Features = features;
            this.HasPassword = hasPassword;
            this.Id = id;
            this.IntegratedCloudProviderId = integratedCloudProviderId;
            this.Language = language;
            this.LdapProvided = ldapProvided;
            this.Names = names;
            this.OrganizationId = organizationId;
            this.OrganizationName = organizationName;
            this.OrganizationRole = organizationRole;
            this.PaymentsEnabled = paymentsEnabled;
            this.Position = position;
            this.ProfilePicture = profilePicture;
            this.PublicUser = publicUser;
            this.ReceiveUpdates = receiveUpdates;
            this.SeasonedUser = seasonedUser;
            this.Timezone = timezone;
            this.TwoFactorAuthEnabled = twoFactorAuthEnabled;
            this.TwoFactorAuthKey = twoFactorAuthKey;
            this.WhitelabelStyling = whitelabelStyling;
        }
        
        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public bool? Admin { get; set; }

        /// <summary>
        /// Gets or Sets AllowedApplicationIds
        /// </summary>
        [DataMember(Name="allowedApplicationIds", EmitDefaultValue=false)]
        public List<Guid?> AllowedApplicationIds { get; set; }

        /// <summary>
        /// Gets or Sets Base64ProfilePicture
        /// </summary>
        [DataMember(Name="base64ProfilePicture", EmitDefaultValue=false)]
        public string Base64ProfilePicture { get; set; }

        /// <summary>
        /// Gets or Sets Confirmed
        /// </summary>
        [DataMember(Name="confirmed", EmitDefaultValue=false)]
        public bool? Confirmed { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Demo
        /// </summary>
        [DataMember(Name="demo", EmitDefaultValue=false)]
        public bool? Demo { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// Gets or Sets HasPassword
        /// </summary>
        [DataMember(Name="hasPassword", EmitDefaultValue=false)]
        public bool? HasPassword { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets IntegratedCloudProviderId
        /// </summary>
        [DataMember(Name="integratedCloudProviderId", EmitDefaultValue=false)]
        public string IntegratedCloudProviderId { get; set; }


        /// <summary>
        /// Gets or Sets LdapProvided
        /// </summary>
        [DataMember(Name="ldapProvided", EmitDefaultValue=false)]
        public bool? LdapProvided { get; set; }

        /// <summary>
        /// Gets or Sets Names
        /// </summary>
        [DataMember(Name="names", EmitDefaultValue=false)]
        public string Names { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName
        /// </summary>
        [DataMember(Name="organizationName", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }


        /// <summary>
        /// Gets or Sets PaymentsEnabled
        /// </summary>
        [DataMember(Name="paymentsEnabled", EmitDefaultValue=false)]
        public bool? PaymentsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicture
        /// </summary>
        [DataMember(Name="profilePicture", EmitDefaultValue=false)]
        public ByteBuffer ProfilePicture { get; set; }

        /// <summary>
        /// Gets or Sets PublicUser
        /// </summary>
        [DataMember(Name="publicUser", EmitDefaultValue=false)]
        public bool? PublicUser { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveUpdates
        /// </summary>
        [DataMember(Name="receiveUpdates", EmitDefaultValue=false)]
        public bool? ReceiveUpdates { get; set; }

        /// <summary>
        /// Gets or Sets SeasonedUser
        /// </summary>
        [DataMember(Name="seasonedUser", EmitDefaultValue=false)]
        public bool? SeasonedUser { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets TwoFactorAuthEnabled
        /// </summary>
        [DataMember(Name="twoFactorAuthEnabled", EmitDefaultValue=false)]
        public bool? TwoFactorAuthEnabled { get; set; }

        /// <summary>
        /// Gets or Sets TwoFactorAuthKey
        /// </summary>
        [DataMember(Name="twoFactorAuthKey", EmitDefaultValue=false)]
        public string TwoFactorAuthKey { get; set; }

        /// <summary>
        /// Gets or Sets WhitelabelStyling
        /// </summary>
        [DataMember(Name="whitelabelStyling", EmitDefaultValue=false)]
        public WhitelabelStyling WhitelabelStyling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDetails {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  AllowedApplicationIds: ").Append(AllowedApplicationIds).Append("\n");
            sb.Append("  Base64ProfilePicture: ").Append(Base64ProfilePicture).Append("\n");
            sb.Append("  Confirmed: ").Append(Confirmed).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Demo: ").Append(Demo).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IntegratedCloudProviderId: ").Append(IntegratedCloudProviderId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LdapProvided: ").Append(LdapProvided).Append("\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  OrganizationRole: ").Append(OrganizationRole).Append("\n");
            sb.Append("  PaymentsEnabled: ").Append(PaymentsEnabled).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ProfilePicture: ").Append(ProfilePicture).Append("\n");
            sb.Append("  PublicUser: ").Append(PublicUser).Append("\n");
            sb.Append("  ReceiveUpdates: ").Append(ReceiveUpdates).Append("\n");
            sb.Append("  SeasonedUser: ").Append(SeasonedUser).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  TwoFactorAuthEnabled: ").Append(TwoFactorAuthEnabled).Append("\n");
            sb.Append("  TwoFactorAuthKey: ").Append(TwoFactorAuthKey).Append("\n");
            sb.Append("  WhitelabelStyling: ").Append(WhitelabelStyling).Append("\n");
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
            return this.Equals(input as UserDetails);
        }

        /// <summary>
        /// Returns true if UserDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.AllowedApplicationIds == input.AllowedApplicationIds ||
                    this.AllowedApplicationIds != null &&
                    this.AllowedApplicationIds.SequenceEqual(input.AllowedApplicationIds)
                ) && 
                (
                    this.Base64ProfilePicture == input.Base64ProfilePicture ||
                    (this.Base64ProfilePicture != null &&
                    this.Base64ProfilePicture.Equals(input.Base64ProfilePicture))
                ) && 
                (
                    this.Confirmed == input.Confirmed ||
                    (this.Confirmed != null &&
                    this.Confirmed.Equals(input.Confirmed))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Demo == input.Demo ||
                    (this.Demo != null &&
                    this.Demo.Equals(input.Demo))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Expired == input.Expired ||
                    (this.Expired != null &&
                    this.Expired.Equals(input.Expired))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.HasPassword == input.HasPassword ||
                    (this.HasPassword != null &&
                    this.HasPassword.Equals(input.HasPassword))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IntegratedCloudProviderId == input.IntegratedCloudProviderId ||
                    (this.IntegratedCloudProviderId != null &&
                    this.IntegratedCloudProviderId.Equals(input.IntegratedCloudProviderId))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LdapProvided == input.LdapProvided ||
                    (this.LdapProvided != null &&
                    this.LdapProvided.Equals(input.LdapProvided))
                ) && 
                (
                    this.Names == input.Names ||
                    (this.Names != null &&
                    this.Names.Equals(input.Names))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.OrganizationRole == input.OrganizationRole ||
                    (this.OrganizationRole != null &&
                    this.OrganizationRole.Equals(input.OrganizationRole))
                ) && 
                (
                    this.PaymentsEnabled == input.PaymentsEnabled ||
                    (this.PaymentsEnabled != null &&
                    this.PaymentsEnabled.Equals(input.PaymentsEnabled))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.ProfilePicture == input.ProfilePicture ||
                    (this.ProfilePicture != null &&
                    this.ProfilePicture.Equals(input.ProfilePicture))
                ) && 
                (
                    this.PublicUser == input.PublicUser ||
                    (this.PublicUser != null &&
                    this.PublicUser.Equals(input.PublicUser))
                ) && 
                (
                    this.ReceiveUpdates == input.ReceiveUpdates ||
                    (this.ReceiveUpdates != null &&
                    this.ReceiveUpdates.Equals(input.ReceiveUpdates))
                ) && 
                (
                    this.SeasonedUser == input.SeasonedUser ||
                    (this.SeasonedUser != null &&
                    this.SeasonedUser.Equals(input.SeasonedUser))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.TwoFactorAuthEnabled == input.TwoFactorAuthEnabled ||
                    (this.TwoFactorAuthEnabled != null &&
                    this.TwoFactorAuthEnabled.Equals(input.TwoFactorAuthEnabled))
                ) && 
                (
                    this.TwoFactorAuthKey == input.TwoFactorAuthKey ||
                    (this.TwoFactorAuthKey != null &&
                    this.TwoFactorAuthKey.Equals(input.TwoFactorAuthKey))
                ) && 
                (
                    this.WhitelabelStyling == input.WhitelabelStyling ||
                    (this.WhitelabelStyling != null &&
                    this.WhitelabelStyling.Equals(input.WhitelabelStyling))
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
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.AllowedApplicationIds != null)
                    hashCode = hashCode * 59 + this.AllowedApplicationIds.GetHashCode();
                if (this.Base64ProfilePicture != null)
                    hashCode = hashCode * 59 + this.Base64ProfilePicture.GetHashCode();
                if (this.Confirmed != null)
                    hashCode = hashCode * 59 + this.Confirmed.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Demo != null)
                    hashCode = hashCode * 59 + this.Demo.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Expired != null)
                    hashCode = hashCode * 59 + this.Expired.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.HasPassword != null)
                    hashCode = hashCode * 59 + this.HasPassword.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IntegratedCloudProviderId != null)
                    hashCode = hashCode * 59 + this.IntegratedCloudProviderId.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LdapProvided != null)
                    hashCode = hashCode * 59 + this.LdapProvided.GetHashCode();
                if (this.Names != null)
                    hashCode = hashCode * 59 + this.Names.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.OrganizationName != null)
                    hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
                if (this.OrganizationRole != null)
                    hashCode = hashCode * 59 + this.OrganizationRole.GetHashCode();
                if (this.PaymentsEnabled != null)
                    hashCode = hashCode * 59 + this.PaymentsEnabled.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.ProfilePicture != null)
                    hashCode = hashCode * 59 + this.ProfilePicture.GetHashCode();
                if (this.PublicUser != null)
                    hashCode = hashCode * 59 + this.PublicUser.GetHashCode();
                if (this.ReceiveUpdates != null)
                    hashCode = hashCode * 59 + this.ReceiveUpdates.GetHashCode();
                if (this.SeasonedUser != null)
                    hashCode = hashCode * 59 + this.SeasonedUser.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TwoFactorAuthEnabled != null)
                    hashCode = hashCode * 59 + this.TwoFactorAuthEnabled.GetHashCode();
                if (this.TwoFactorAuthKey != null)
                    hashCode = hashCode * 59 + this.TwoFactorAuthKey.GetHashCode();
                if (this.WhitelabelStyling != null)
                    hashCode = hashCode * 59 + this.WhitelabelStyling.GetHashCode();
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