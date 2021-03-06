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
    /// UserRegistrationRequest
    /// </summary>
    [DataContract]
    public partial class UserRegistrationRequest :  IEquatable<UserRegistrationRequest>
    {
        /// <summary>
        /// Defines Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
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
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationRequest" /> class.
        /// </summary>
        /// <param name="allowedApplicationIds">allowedApplicationIds.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="awsCustomerId">awsCustomerId.</param>
        /// <param name="email">email.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="industry">industry.</param>
        /// <param name="names">names.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="password">password.</param>
        /// <param name="position">position.</param>
        /// <param name="role">role.</param>
        /// <param name="serverName">serverName.</param>
        /// <param name="subscriptionPlanCode">subscriptionPlanCode.</param>
        /// <param name="timezone">timezone.</param>
        public UserRegistrationRequest(List<Guid?> allowedApplicationIds = default(List<Guid?>), Dictionary<string, string> attributes = default(Dictionary<string, string>), string awsCustomerId = default(string), string email = default(string), string expirationDate = default(string), string industry = default(string), string names = default(string), string organizationName = default(string), string password = default(string), string position = default(string), RoleEnum? role = default(RoleEnum?), string serverName = default(string), string subscriptionPlanCode = default(string), string timezone = default(string))
        {
            this.AllowedApplicationIds = allowedApplicationIds;
            this.Attributes = attributes;
            this.AwsCustomerId = awsCustomerId;
            this.Email = email;
            this.ExpirationDate = expirationDate;
            this.Industry = industry;
            this.Names = names;
            this.OrganizationName = organizationName;
            this.Password = password;
            this.Position = position;
            this.Role = role;
            this.ServerName = serverName;
            this.SubscriptionPlanCode = subscriptionPlanCode;
            this.Timezone = timezone;
        }
        
        /// <summary>
        /// Gets or Sets AllowedApplicationIds
        /// </summary>
        [DataMember(Name="allowedApplicationIds", EmitDefaultValue=false)]
        public List<Guid?> AllowedApplicationIds { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets AwsCustomerId
        /// </summary>
        [DataMember(Name="awsCustomerId", EmitDefaultValue=false)]
        public string AwsCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or Sets Names
        /// </summary>
        [DataMember(Name="names", EmitDefaultValue=false)]
        public string Names { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName
        /// </summary>
        [DataMember(Name="organizationName", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }


        /// <summary>
        /// Gets or Sets ServerName
        /// </summary>
        [DataMember(Name="serverName", EmitDefaultValue=false)]
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPlanCode
        /// </summary>
        [DataMember(Name="subscriptionPlanCode", EmitDefaultValue=false)]
        public string SubscriptionPlanCode { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRegistrationRequest {\n");
            sb.Append("  AllowedApplicationIds: ").Append(AllowedApplicationIds).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AwsCustomerId: ").Append(AwsCustomerId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  ServerName: ").Append(ServerName).Append("\n");
            sb.Append("  SubscriptionPlanCode: ").Append(SubscriptionPlanCode).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(input as UserRegistrationRequest);
        }

        /// <summary>
        /// Returns true if UserRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRegistrationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedApplicationIds == input.AllowedApplicationIds ||
                    this.AllowedApplicationIds != null &&
                    this.AllowedApplicationIds.SequenceEqual(input.AllowedApplicationIds)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.AwsCustomerId == input.AwsCustomerId ||
                    (this.AwsCustomerId != null &&
                    this.AwsCustomerId.Equals(input.AwsCustomerId))
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
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Names == input.Names ||
                    (this.Names != null &&
                    this.Names.Equals(input.Names))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.SubscriptionPlanCode == input.SubscriptionPlanCode ||
                    (this.SubscriptionPlanCode != null &&
                    this.SubscriptionPlanCode.Equals(input.SubscriptionPlanCode))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                if (this.AllowedApplicationIds != null)
                    hashCode = hashCode * 59 + this.AllowedApplicationIds.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.AwsCustomerId != null)
                    hashCode = hashCode * 59 + this.AwsCustomerId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Names != null)
                    hashCode = hashCode * 59 + this.Names.GetHashCode();
                if (this.OrganizationName != null)
                    hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.SubscriptionPlanCode != null)
                    hashCode = hashCode * 59 + this.SubscriptionPlanCode.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                return hashCode;
            }
        }
    }

}
