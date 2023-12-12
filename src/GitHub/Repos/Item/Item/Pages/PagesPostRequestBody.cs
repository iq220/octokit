// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Pages {
    /// <summary>
    /// The source branch and directory used to publish your Pages site.
    /// </summary>
    public class PagesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The process in which the Page will be built. Possible values are `&quot;legacy&quot;` and `&quot;workflow&quot;`.</summary>
        public PagesPostRequestBody_build_type? BuildType { get; set; }
        /// <summary>The source branch and directory used to publish your Pages site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PagesPostRequestBody_source? Source { get; set; }
#nullable restore
#else
        public PagesPostRequestBody_source Source { get; set; }
#endif
        /// <summary>
        /// Instantiates a new pagesPostRequestBody and sets the default values.
        /// </summary>
        public PagesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PagesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PagesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"build_type", n => { BuildType = n.GetEnumValue<PagesPostRequestBody_build_type>(); } },
                {"source", n => { Source = n.GetObjectValue<PagesPostRequestBody_source>(PagesPostRequestBody_source.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PagesPostRequestBody_build_type>("build_type", BuildType);
            writer.WriteObjectValue<PagesPostRequestBody_source>("source", Source);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
