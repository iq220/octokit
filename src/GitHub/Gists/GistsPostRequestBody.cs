// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Gists {
    public class GistsPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Description of the gist</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Names and content for the files that make up the gist</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GistsPostRequestBody_files? Files { get; set; }
#nullable restore
#else
        public GistsPostRequestBody_files Files { get; set; }
#endif
        /// <summary>The public property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GistsPostRequestBody_public? Public { get; set; }
#nullable restore
#else
        public GistsPostRequestBody_public Public { get; set; }
#endif
        /// <summary>
        /// Instantiates a new gistsPostRequestBody and sets the default values.
        /// </summary>
        public GistsPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GistsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GistsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"files", n => { Files = n.GetObjectValue<GistsPostRequestBody_files>(GistsPostRequestBody_files.CreateFromDiscriminatorValue); } },
                {"public", n => { Public = n.GetObjectValue<GistsPostRequestBody_public>(GistsPostRequestBody_public.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<GistsPostRequestBody_files>("files", Files);
            writer.WriteObjectValue<GistsPostRequestBody_public>("public", Public);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes boolean, string
        /// </summary>
        public class GistsPostRequestBody_public : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type boolean</summary>
            public bool? Boolean { get; set; }
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static GistsPostRequestBody_public CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new GistsPostRequestBody_public();
                if(parseNode.GetBoolValue() is bool booleanValue) {
                    result.Boolean = booleanValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Boolean != null) {
                    writer.WriteBoolValue(null, Boolean);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
            }
        }
    }
}
