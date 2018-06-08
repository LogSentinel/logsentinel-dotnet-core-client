/* 
 * LogSentinel RESTful API
 *
 * Read more at https://app.logsentinel.com/docs
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Application
    /// </summary>
    [DataContract]
    public partial class Application :  IEquatable<Application>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="ContainsPersonalData">ContainsPersonalData.</param>
        /// <param name="Created">Created.</param>
        /// <param name="DetailsTransformationScript">DetailsTransformationScript.</param>
        /// <param name="GenesisEntryId">GenesisEntryId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IpWhiteList">IpWhiteList.</param>
        /// <param name="LatestEthereumTxHash">LatestEthereumTxHash.</param>
        /// <param name="LatestGlacierArchiveId">LatestGlacierArchiveId.</param>
        /// <param name="LatestHashRecipientEmails">LatestHashRecipientEmails.</param>
        /// <param name="Name">Name.</param>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="PartialVerificationPeriodMinutes">PartialVerificationPeriodMinutes.</param>
        /// <param name="SignatureVerificationPublicKeys">SignatureVerificationPublicKeys.</param>
        /// <param name="StoreHashesInEthereum">StoreHashesInEthereum.</param>
        /// <param name="Updated">Updated.</param>
        /// <param name="VerificationFailureReportRecipientEmails">VerificationFailureReportRecipientEmails.</param>
        /// <param name="VerificationPeriodMinutes">VerificationPeriodMinutes.</param>
        public Application(bool? ContainsPersonalData = default(bool?), DateTime? Created = default(DateTime?), string DetailsTransformationScript = default(string), string GenesisEntryId = default(string), string Id = default(string), List<string> IpWhiteList = default(List<string>), string LatestEthereumTxHash = default(string), string LatestGlacierArchiveId = default(string), List<string> LatestHashRecipientEmails = default(List<string>), string Name = default(string), string OrganizationId = default(string), int? PartialVerificationPeriodMinutes = default(int?), List<string> SignatureVerificationPublicKeys = default(List<string>), bool? StoreHashesInEthereum = default(bool?), DateTime? Updated = default(DateTime?), List<string> VerificationFailureReportRecipientEmails = default(List<string>), int? VerificationPeriodMinutes = default(int?))
        {
            this.ContainsPersonalData = ContainsPersonalData;
            this.Created = Created;
            this.DetailsTransformationScript = DetailsTransformationScript;
            this.GenesisEntryId = GenesisEntryId;
            this.Id = Id;
            this.IpWhiteList = IpWhiteList;
            this.LatestEthereumTxHash = LatestEthereumTxHash;
            this.LatestGlacierArchiveId = LatestGlacierArchiveId;
            this.LatestHashRecipientEmails = LatestHashRecipientEmails;
            this.Name = Name;
            this.OrganizationId = OrganizationId;
            this.PartialVerificationPeriodMinutes = PartialVerificationPeriodMinutes;
            this.SignatureVerificationPublicKeys = SignatureVerificationPublicKeys;
            this.StoreHashesInEthereum = StoreHashesInEthereum;
            this.Updated = Updated;
            this.VerificationFailureReportRecipientEmails = VerificationFailureReportRecipientEmails;
            this.VerificationPeriodMinutes = VerificationPeriodMinutes;
        }
        
        /// <summary>
        /// Gets or Sets ContainsPersonalData
        /// </summary>
        [DataMember(Name="containsPersonalData", EmitDefaultValue=false)]
        public bool? ContainsPersonalData { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets DetailsTransformationScript
        /// </summary>
        [DataMember(Name="detailsTransformationScript", EmitDefaultValue=false)]
        public string DetailsTransformationScript { get; set; }

        /// <summary>
        /// Gets or Sets GenesisEntryId
        /// </summary>
        [DataMember(Name="genesisEntryId", EmitDefaultValue=false)]
        public string GenesisEntryId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IpWhiteList
        /// </summary>
        [DataMember(Name="ipWhiteList", EmitDefaultValue=false)]
        public List<string> IpWhiteList { get; set; }

        /// <summary>
        /// Gets or Sets LatestEthereumTxHash
        /// </summary>
        [DataMember(Name="latestEthereumTxHash", EmitDefaultValue=false)]
        public string LatestEthereumTxHash { get; set; }

        /// <summary>
        /// Gets or Sets LatestGlacierArchiveId
        /// </summary>
        [DataMember(Name="latestGlacierArchiveId", EmitDefaultValue=false)]
        public string LatestGlacierArchiveId { get; set; }

        /// <summary>
        /// Gets or Sets LatestHashRecipientEmails
        /// </summary>
        [DataMember(Name="latestHashRecipientEmails", EmitDefaultValue=false)]
        public List<string> LatestHashRecipientEmails { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets PartialVerificationPeriodMinutes
        /// </summary>
        [DataMember(Name="partialVerificationPeriodMinutes", EmitDefaultValue=false)]
        public int? PartialVerificationPeriodMinutes { get; set; }

        /// <summary>
        /// Gets or Sets SignatureVerificationPublicKeys
        /// </summary>
        [DataMember(Name="signatureVerificationPublicKeys", EmitDefaultValue=false)]
        public List<string> SignatureVerificationPublicKeys { get; set; }

        /// <summary>
        /// Gets or Sets StoreHashesInEthereum
        /// </summary>
        [DataMember(Name="storeHashesInEthereum", EmitDefaultValue=false)]
        public bool? StoreHashesInEthereum { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or Sets VerificationFailureReportRecipientEmails
        /// </summary>
        [DataMember(Name="verificationFailureReportRecipientEmails", EmitDefaultValue=false)]
        public List<string> VerificationFailureReportRecipientEmails { get; set; }

        /// <summary>
        /// Gets or Sets VerificationPeriodMinutes
        /// </summary>
        [DataMember(Name="verificationPeriodMinutes", EmitDefaultValue=false)]
        public int? VerificationPeriodMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Application {\n");
            sb.Append("  ContainsPersonalData: ").Append(ContainsPersonalData).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DetailsTransformationScript: ").Append(DetailsTransformationScript).Append("\n");
            sb.Append("  GenesisEntryId: ").Append(GenesisEntryId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IpWhiteList: ").Append(IpWhiteList).Append("\n");
            sb.Append("  LatestEthereumTxHash: ").Append(LatestEthereumTxHash).Append("\n");
            sb.Append("  LatestGlacierArchiveId: ").Append(LatestGlacierArchiveId).Append("\n");
            sb.Append("  LatestHashRecipientEmails: ").Append(LatestHashRecipientEmails).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  PartialVerificationPeriodMinutes: ").Append(PartialVerificationPeriodMinutes).Append("\n");
            sb.Append("  SignatureVerificationPublicKeys: ").Append(SignatureVerificationPublicKeys).Append("\n");
            sb.Append("  StoreHashesInEthereum: ").Append(StoreHashesInEthereum).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  VerificationFailureReportRecipientEmails: ").Append(VerificationFailureReportRecipientEmails).Append("\n");
            sb.Append("  VerificationPeriodMinutes: ").Append(VerificationPeriodMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Application);
        }

        /// <summary>
        /// Returns true if Application instances are equal
        /// </summary>
        /// <param name="input">Instance of Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Application input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainsPersonalData == input.ContainsPersonalData ||
                    (this.ContainsPersonalData != null &&
                    this.ContainsPersonalData.Equals(input.ContainsPersonalData))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.DetailsTransformationScript == input.DetailsTransformationScript ||
                    (this.DetailsTransformationScript != null &&
                    this.DetailsTransformationScript.Equals(input.DetailsTransformationScript))
                ) && 
                (
                    this.GenesisEntryId == input.GenesisEntryId ||
                    (this.GenesisEntryId != null &&
                    this.GenesisEntryId.Equals(input.GenesisEntryId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IpWhiteList == input.IpWhiteList ||
                    this.IpWhiteList != null &&
                    this.IpWhiteList.SequenceEqual(input.IpWhiteList)
                ) && 
                (
                    this.LatestEthereumTxHash == input.LatestEthereumTxHash ||
                    (this.LatestEthereumTxHash != null &&
                    this.LatestEthereumTxHash.Equals(input.LatestEthereumTxHash))
                ) && 
                (
                    this.LatestGlacierArchiveId == input.LatestGlacierArchiveId ||
                    (this.LatestGlacierArchiveId != null &&
                    this.LatestGlacierArchiveId.Equals(input.LatestGlacierArchiveId))
                ) && 
                (
                    this.LatestHashRecipientEmails == input.LatestHashRecipientEmails ||
                    this.LatestHashRecipientEmails != null &&
                    this.LatestHashRecipientEmails.SequenceEqual(input.LatestHashRecipientEmails)
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
                    this.PartialVerificationPeriodMinutes == input.PartialVerificationPeriodMinutes ||
                    (this.PartialVerificationPeriodMinutes != null &&
                    this.PartialVerificationPeriodMinutes.Equals(input.PartialVerificationPeriodMinutes))
                ) && 
                (
                    this.SignatureVerificationPublicKeys == input.SignatureVerificationPublicKeys ||
                    this.SignatureVerificationPublicKeys != null &&
                    this.SignatureVerificationPublicKeys.SequenceEqual(input.SignatureVerificationPublicKeys)
                ) && 
                (
                    this.StoreHashesInEthereum == input.StoreHashesInEthereum ||
                    (this.StoreHashesInEthereum != null &&
                    this.StoreHashesInEthereum.Equals(input.StoreHashesInEthereum))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.VerificationFailureReportRecipientEmails == input.VerificationFailureReportRecipientEmails ||
                    this.VerificationFailureReportRecipientEmails != null &&
                    this.VerificationFailureReportRecipientEmails.SequenceEqual(input.VerificationFailureReportRecipientEmails)
                ) && 
                (
                    this.VerificationPeriodMinutes == input.VerificationPeriodMinutes ||
                    (this.VerificationPeriodMinutes != null &&
                    this.VerificationPeriodMinutes.Equals(input.VerificationPeriodMinutes))
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
                if (this.ContainsPersonalData != null)
                    hashCode = hashCode * 59 + this.ContainsPersonalData.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.DetailsTransformationScript != null)
                    hashCode = hashCode * 59 + this.DetailsTransformationScript.GetHashCode();
                if (this.GenesisEntryId != null)
                    hashCode = hashCode * 59 + this.GenesisEntryId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpWhiteList != null)
                    hashCode = hashCode * 59 + this.IpWhiteList.GetHashCode();
                if (this.LatestEthereumTxHash != null)
                    hashCode = hashCode * 59 + this.LatestEthereumTxHash.GetHashCode();
                if (this.LatestGlacierArchiveId != null)
                    hashCode = hashCode * 59 + this.LatestGlacierArchiveId.GetHashCode();
                if (this.LatestHashRecipientEmails != null)
                    hashCode = hashCode * 59 + this.LatestHashRecipientEmails.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.PartialVerificationPeriodMinutes != null)
                    hashCode = hashCode * 59 + this.PartialVerificationPeriodMinutes.GetHashCode();
                if (this.SignatureVerificationPublicKeys != null)
                    hashCode = hashCode * 59 + this.SignatureVerificationPublicKeys.GetHashCode();
                if (this.StoreHashesInEthereum != null)
                    hashCode = hashCode * 59 + this.StoreHashesInEthereum.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.VerificationFailureReportRecipientEmails != null)
                    hashCode = hashCode * 59 + this.VerificationFailureReportRecipientEmails.GetHashCode();
                if (this.VerificationPeriodMinutes != null)
                    hashCode = hashCode * 59 + this.VerificationPeriodMinutes.GetHashCode();
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