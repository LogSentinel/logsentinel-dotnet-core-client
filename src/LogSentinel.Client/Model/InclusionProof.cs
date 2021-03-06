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
    /// InclusionProof
    /// </summary>
    [DataContract]
    public partial class InclusionProof :  IEquatable<InclusionProof>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InclusionProof" /> class.
        /// </summary>
        /// <param name="hash">hash.</param>
        /// <param name="index">index.</param>
        /// <param name="path">path.</param>
        /// <param name="rootHash">rootHash.</param>
        /// <param name="treeSize">treeSize.</param>
        public InclusionProof(string hash = default(string), int? index = default(int?), List<string> path = default(List<string>), string rootHash = default(string), int? treeSize = default(int?))
        {
            this.Hash = hash;
            this.Index = index;
            this.Path = path;
            this.RootHash = rootHash;
            this.TreeSize = treeSize;
        }
        
        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// Gets or Sets RootHash
        /// </summary>
        [DataMember(Name="rootHash", EmitDefaultValue=false)]
        public string RootHash { get; set; }

        /// <summary>
        /// Gets or Sets TreeSize
        /// </summary>
        [DataMember(Name="treeSize", EmitDefaultValue=false)]
        public int? TreeSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InclusionProof {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  RootHash: ").Append(RootHash).Append("\n");
            sb.Append("  TreeSize: ").Append(TreeSize).Append("\n");
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
            return this.Equals(input as InclusionProof);
        }

        /// <summary>
        /// Returns true if InclusionProof instances are equal
        /// </summary>
        /// <param name="input">Instance of InclusionProof to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InclusionProof input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Path == input.Path ||
                    this.Path != null &&
                    this.Path.SequenceEqual(input.Path)
                ) && 
                (
                    this.RootHash == input.RootHash ||
                    (this.RootHash != null &&
                    this.RootHash.Equals(input.RootHash))
                ) && 
                (
                    this.TreeSize == input.TreeSize ||
                    (this.TreeSize != null &&
                    this.TreeSize.Equals(input.TreeSize))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.RootHash != null)
                    hashCode = hashCode * 59 + this.RootHash.GetHashCode();
                if (this.TreeSize != null)
                    hashCode = hashCode * 59 + this.TreeSize.GetHashCode();
                return hashCode;
            }
        }
    }

}
