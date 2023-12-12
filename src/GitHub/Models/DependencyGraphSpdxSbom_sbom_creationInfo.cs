// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class DependencyGraphSpdxSbom_sbom_creationInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time the SPDX document was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Created { get; set; }
#nullable restore
#else
        public string Created { get; set; }
#endif
        /// <summary>The tools that were used to generate the SPDX document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Creators { get; set; }
#nullable restore
#else
        public List<string> Creators { get; set; }
#endif
        /// <summary>
        /// Instantiates a new dependencyGraphSpdxSbom_sbom_creationInfo and sets the default values.
        /// </summary>
        public DependencyGraphSpdxSbom_sbom_creationInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependencyGraphSpdxSbom_sbom_creationInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependencyGraphSpdxSbom_sbom_creationInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"created", n => { Created = n.GetStringValue(); } },
                {"creators", n => { Creators = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("created", Created);
            writer.WriteCollectionOfPrimitiveValues<string>("creators", Creators);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
