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
    /// ActionChainAlertRule
    /// </summary>
    [DataContract]
    public partial class ActionChainAlertRule :  IEquatable<ActionChainAlertRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionChainAlertRule" /> class.
        /// </summary>
        /// <param name="actions">actions.</param>
        /// <param name="advancedFilters">advancedFilters.</param>
        /// <param name="aggregationPeriod">aggregationPeriod.</param>
        /// <param name="alertDestinationIds">alertDestinationIds.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="count">count.</param>
        /// <param name="created">created.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="id">id.</param>
        /// <param name="initialAction">initialAction.</param>
        /// <param name="insideWorkingHours">insideWorkingHours.</param>
        /// <param name="less">less.</param>
        /// <param name="name">name.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="searchPeriod">searchPeriod.</param>
        /// <param name="sumAction">sumAction.</param>
        /// <param name="sumActionTypes">sumActionTypes.</param>
        /// <param name="sumTimeFrame">sumTimeFrame.</param>
        /// <param name="sumValuePath">sumValuePath.</param>
        /// <param name="timeFrames">timeFrames.</param>
        /// <param name="updated">updated.</param>
        /// <param name="withActorsOnly">withActorsOnly.</param>
        public ActionChainAlertRule(List<string> actions = default(List<string>), List<string> advancedFilters = default(List<string>), string aggregationPeriod = default(string), List<Guid?> alertDestinationIds = default(List<Guid?>), Guid? applicationId = default(Guid?), List<int?> count = default(List<int?>), DateTime? created = default(DateTime?), bool? enabled = default(bool?), string entityType = default(string), Guid? id = default(Guid?), string initialAction = default(string), bool? insideWorkingHours = default(bool?), List<bool?> less = default(List<bool?>), string name = default(string), Guid? organizationId = default(Guid?), int? percentage = default(int?), string searchPeriod = default(string), string sumAction = default(string), string sumActionTypes = default(string), long? sumTimeFrame = default(long?), string sumValuePath = default(string), List<long?> timeFrames = default(List<long?>), DateTime? updated = default(DateTime?), bool? withActorsOnly = default(bool?))
        {
            this.Actions = actions;
            this.AdvancedFilters = advancedFilters;
            this.AggregationPeriod = aggregationPeriod;
            this.AlertDestinationIds = alertDestinationIds;
            this.ApplicationId = applicationId;
            this.Count = count;
            this.Created = created;
            this.Enabled = enabled;
            this.EntityType = entityType;
            this.Id = id;
            this.InitialAction = initialAction;
            this.InsideWorkingHours = insideWorkingHours;
            this.Less = less;
            this.Name = name;
            this.OrganizationId = organizationId;
            this.Percentage = percentage;
            this.SearchPeriod = searchPeriod;
            this.SumAction = sumAction;
            this.SumActionTypes = sumActionTypes;
            this.SumTimeFrame = sumTimeFrame;
            this.SumValuePath = sumValuePath;
            this.TimeFrames = timeFrames;
            this.Updated = updated;
            this.WithActorsOnly = withActorsOnly;
        }
        
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// Gets or Sets AdvancedFilters
        /// </summary>
        [DataMember(Name="advancedFilters", EmitDefaultValue=false)]
        public List<string> AdvancedFilters { get; set; }

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
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public List<int?> Count { get; set; }

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
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets InitialAction
        /// </summary>
        [DataMember(Name="initialAction", EmitDefaultValue=false)]
        public string InitialAction { get; set; }

        /// <summary>
        /// Gets or Sets InsideWorkingHours
        /// </summary>
        [DataMember(Name="insideWorkingHours", EmitDefaultValue=false)]
        public bool? InsideWorkingHours { get; set; }

        /// <summary>
        /// Gets or Sets Less
        /// </summary>
        [DataMember(Name="less", EmitDefaultValue=false)]
        public List<bool?> Less { get; set; }

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
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public int? Percentage { get; set; }

        /// <summary>
        /// Gets or Sets SearchPeriod
        /// </summary>
        [DataMember(Name="searchPeriod", EmitDefaultValue=false)]
        public string SearchPeriod { get; set; }

        /// <summary>
        /// Gets or Sets SumAction
        /// </summary>
        [DataMember(Name="sumAction", EmitDefaultValue=false)]
        public string SumAction { get; set; }

        /// <summary>
        /// Gets or Sets SumActionTypes
        /// </summary>
        [DataMember(Name="sumActionTypes", EmitDefaultValue=false)]
        public string SumActionTypes { get; set; }

        /// <summary>
        /// Gets or Sets SumTimeFrame
        /// </summary>
        [DataMember(Name="sumTimeFrame", EmitDefaultValue=false)]
        public long? SumTimeFrame { get; set; }

        /// <summary>
        /// Gets or Sets SumValuePath
        /// </summary>
        [DataMember(Name="sumValuePath", EmitDefaultValue=false)]
        public string SumValuePath { get; set; }

        /// <summary>
        /// Gets or Sets TimeFrames
        /// </summary>
        [DataMember(Name="timeFrames", EmitDefaultValue=false)]
        public List<long?> TimeFrames { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or Sets WithActorsOnly
        /// </summary>
        [DataMember(Name="withActorsOnly", EmitDefaultValue=false)]
        public bool? WithActorsOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionChainAlertRule {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  AdvancedFilters: ").Append(AdvancedFilters).Append("\n");
            sb.Append("  AggregationPeriod: ").Append(AggregationPeriod).Append("\n");
            sb.Append("  AlertDestinationIds: ").Append(AlertDestinationIds).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitialAction: ").Append(InitialAction).Append("\n");
            sb.Append("  InsideWorkingHours: ").Append(InsideWorkingHours).Append("\n");
            sb.Append("  Less: ").Append(Less).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  SearchPeriod: ").Append(SearchPeriod).Append("\n");
            sb.Append("  SumAction: ").Append(SumAction).Append("\n");
            sb.Append("  SumActionTypes: ").Append(SumActionTypes).Append("\n");
            sb.Append("  SumTimeFrame: ").Append(SumTimeFrame).Append("\n");
            sb.Append("  SumValuePath: ").Append(SumValuePath).Append("\n");
            sb.Append("  TimeFrames: ").Append(TimeFrames).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  WithActorsOnly: ").Append(WithActorsOnly).Append("\n");
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
            return this.Equals(input as ActionChainAlertRule);
        }

        /// <summary>
        /// Returns true if ActionChainAlertRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionChainAlertRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionChainAlertRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.AdvancedFilters == input.AdvancedFilters ||
                    this.AdvancedFilters != null &&
                    this.AdvancedFilters.SequenceEqual(input.AdvancedFilters)
                ) && 
                (
                    this.AggregationPeriod == input.AggregationPeriod ||
                    (this.AggregationPeriod != null &&
                    this.AggregationPeriod.Equals(input.AggregationPeriod))
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
                    this.Count == input.Count ||
                    this.Count != null &&
                    this.Count.SequenceEqual(input.Count)
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
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InitialAction == input.InitialAction ||
                    (this.InitialAction != null &&
                    this.InitialAction.Equals(input.InitialAction))
                ) && 
                (
                    this.InsideWorkingHours == input.InsideWorkingHours ||
                    (this.InsideWorkingHours != null &&
                    this.InsideWorkingHours.Equals(input.InsideWorkingHours))
                ) && 
                (
                    this.Less == input.Less ||
                    this.Less != null &&
                    this.Less.SequenceEqual(input.Less)
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
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
                ) && 
                (
                    this.SearchPeriod == input.SearchPeriod ||
                    (this.SearchPeriod != null &&
                    this.SearchPeriod.Equals(input.SearchPeriod))
                ) && 
                (
                    this.SumAction == input.SumAction ||
                    (this.SumAction != null &&
                    this.SumAction.Equals(input.SumAction))
                ) && 
                (
                    this.SumActionTypes == input.SumActionTypes ||
                    (this.SumActionTypes != null &&
                    this.SumActionTypes.Equals(input.SumActionTypes))
                ) && 
                (
                    this.SumTimeFrame == input.SumTimeFrame ||
                    (this.SumTimeFrame != null &&
                    this.SumTimeFrame.Equals(input.SumTimeFrame))
                ) && 
                (
                    this.SumValuePath == input.SumValuePath ||
                    (this.SumValuePath != null &&
                    this.SumValuePath.Equals(input.SumValuePath))
                ) && 
                (
                    this.TimeFrames == input.TimeFrames ||
                    this.TimeFrames != null &&
                    this.TimeFrames.SequenceEqual(input.TimeFrames)
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.WithActorsOnly == input.WithActorsOnly ||
                    (this.WithActorsOnly != null &&
                    this.WithActorsOnly.Equals(input.WithActorsOnly))
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
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.AdvancedFilters != null)
                    hashCode = hashCode * 59 + this.AdvancedFilters.GetHashCode();
                if (this.AggregationPeriod != null)
                    hashCode = hashCode * 59 + this.AggregationPeriod.GetHashCode();
                if (this.AlertDestinationIds != null)
                    hashCode = hashCode * 59 + this.AlertDestinationIds.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InitialAction != null)
                    hashCode = hashCode * 59 + this.InitialAction.GetHashCode();
                if (this.InsideWorkingHours != null)
                    hashCode = hashCode * 59 + this.InsideWorkingHours.GetHashCode();
                if (this.Less != null)
                    hashCode = hashCode * 59 + this.Less.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Percentage != null)
                    hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                if (this.SearchPeriod != null)
                    hashCode = hashCode * 59 + this.SearchPeriod.GetHashCode();
                if (this.SumAction != null)
                    hashCode = hashCode * 59 + this.SumAction.GetHashCode();
                if (this.SumActionTypes != null)
                    hashCode = hashCode * 59 + this.SumActionTypes.GetHashCode();
                if (this.SumTimeFrame != null)
                    hashCode = hashCode * 59 + this.SumTimeFrame.GetHashCode();
                if (this.SumValuePath != null)
                    hashCode = hashCode * 59 + this.SumValuePath.GetHashCode();
                if (this.TimeFrames != null)
                    hashCode = hashCode * 59 + this.TimeFrames.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.WithActorsOnly != null)
                    hashCode = hashCode * 59 + this.WithActorsOnly.GetHashCode();
                return hashCode;
            }
        }
    }

}
