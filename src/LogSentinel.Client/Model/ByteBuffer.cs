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
    /// ByteBuffer
    /// </summary>
    [DataContract]
    public partial class ByteBuffer :  IEquatable<ByteBuffer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByteBuffer" /> class.
        /// </summary>
        /// <param name="_char">_char.</param>
        /// <param name="direct">direct.</param>
        /// <param name="_double">_double.</param>
        /// <param name="_float">_float.</param>
        /// <param name="_int">_int.</param>
        /// <param name="_long">_long.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="_short">_short.</param>
        public ByteBuffer(string _char = default(string), bool? direct = default(bool?), double? _double = default(double?), float? _float = default(float?), int? _int = default(int?), long? _long = default(long?), bool? readOnly = default(bool?), int? _short = default(int?))
        {
            this.Char = _char;
            this.Direct = direct;
            this.Double = _double;
            this.Float = _float;
            this.Int = _int;
            this.Long = _long;
            this.ReadOnly = readOnly;
            this.Short = _short;
        }
        
        /// <summary>
        /// Gets or Sets Char
        /// </summary>
        [DataMember(Name="char", EmitDefaultValue=false)]
        public string Char { get; set; }

        /// <summary>
        /// Gets or Sets Direct
        /// </summary>
        [DataMember(Name="direct", EmitDefaultValue=false)]
        public bool? Direct { get; set; }

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public double? Double { get; set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public float? Float { get; set; }

        /// <summary>
        /// Gets or Sets Int
        /// </summary>
        [DataMember(Name="int", EmitDefaultValue=false)]
        public int? Int { get; set; }

        /// <summary>
        /// Gets or Sets Long
        /// </summary>
        [DataMember(Name="long", EmitDefaultValue=false)]
        public long? Long { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets Short
        /// </summary>
        [DataMember(Name="short", EmitDefaultValue=false)]
        public int? Short { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ByteBuffer {\n");
            sb.Append("  Char: ").Append(Char).Append("\n");
            sb.Append("  Direct: ").Append(Direct).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Int: ").Append(Int).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Short: ").Append(Short).Append("\n");
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
            return this.Equals(input as ByteBuffer);
        }

        /// <summary>
        /// Returns true if ByteBuffer instances are equal
        /// </summary>
        /// <param name="input">Instance of ByteBuffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ByteBuffer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Char == input.Char ||
                    (this.Char != null &&
                    this.Char.Equals(input.Char))
                ) && 
                (
                    this.Direct == input.Direct ||
                    (this.Direct != null &&
                    this.Direct.Equals(input.Direct))
                ) && 
                (
                    this.Double == input.Double ||
                    (this.Double != null &&
                    this.Double.Equals(input.Double))
                ) && 
                (
                    this.Float == input.Float ||
                    (this.Float != null &&
                    this.Float.Equals(input.Float))
                ) && 
                (
                    this.Int == input.Int ||
                    (this.Int != null &&
                    this.Int.Equals(input.Int))
                ) && 
                (
                    this.Long == input.Long ||
                    (this.Long != null &&
                    this.Long.Equals(input.Long))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.Short == input.Short ||
                    (this.Short != null &&
                    this.Short.Equals(input.Short))
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
                if (this.Char != null)
                    hashCode = hashCode * 59 + this.Char.GetHashCode();
                if (this.Direct != null)
                    hashCode = hashCode * 59 + this.Direct.GetHashCode();
                if (this.Double != null)
                    hashCode = hashCode * 59 + this.Double.GetHashCode();
                if (this.Float != null)
                    hashCode = hashCode * 59 + this.Float.GetHashCode();
                if (this.Int != null)
                    hashCode = hashCode * 59 + this.Int.GetHashCode();
                if (this.Long != null)
                    hashCode = hashCode * 59 + this.Long.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.Short != null)
                    hashCode = hashCode * 59 + this.Short.GetHashCode();
                return hashCode;
            }
        }
    }

}
