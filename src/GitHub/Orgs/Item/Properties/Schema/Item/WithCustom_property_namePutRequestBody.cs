// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Orgs.Item.Properties.Schema.Item {
    public class WithCustom_property_namePutRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An ordered list of the allowed values of the property.The property can have up to 200 allowed values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedValues { get; set; }
#nullable restore
#else
        public List<string> AllowedValues { get; set; }
#endif
        /// <summary>Default value of the property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue { get; set; }
#nullable restore
#else
        public string DefaultValue { get; set; }
#endif
        /// <summary>Short description of the property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Whether the property is required.</summary>
        public bool? Required { get; set; }
        /// <summary>The type of the value for the property</summary>
        public WithCustom_property_namePutRequestBody_value_type? ValueType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WithCustom_property_namePutRequestBody"/> and sets the default values.
        /// </summary>
        public WithCustom_property_namePutRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WithCustom_property_namePutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithCustom_property_namePutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithCustom_property_namePutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowed_values", n => { AllowedValues = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"default_value", n => { DefaultValue = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
                {"value_type", n => { ValueType = n.GetEnumValue<WithCustom_property_namePutRequestBody_value_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowed_values", AllowedValues);
            writer.WriteStringValue("default_value", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("required", Required);
            writer.WriteEnumValue<WithCustom_property_namePutRequestBody_value_type>("value_type", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
