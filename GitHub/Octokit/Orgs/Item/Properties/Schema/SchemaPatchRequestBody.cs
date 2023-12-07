// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Octokit.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Orgs.Item.Properties.Schema {
    public class SchemaPatchRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The array of custom properties to create or update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OrgCustomProperty>? Properties { get; set; }
#nullable restore
#else
        public List<OrgCustomProperty> Properties { get; set; }
#endif
        /// <summary>
        /// Instantiates a new schemaPatchRequestBody and sets the default values.
        /// </summary>
        public SchemaPatchRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SchemaPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SchemaPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"properties", n => { Properties = n.GetCollectionOfObjectValues<OrgCustomProperty>(OrgCustomProperty.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<OrgCustomProperty>("properties", Properties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
