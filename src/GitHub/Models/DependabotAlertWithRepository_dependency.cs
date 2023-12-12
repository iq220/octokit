// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Details for the vulnerable dependency.
    /// </summary>
    public class DependabotAlertWithRepository_dependency : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The full path to the dependency manifest file, relative to the root of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManifestPath { get; private set; }
#nullable restore
#else
        public string ManifestPath { get; private set; }
#endif
        /// <summary>Details for the vulnerable package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DependabotAlertPackage? Package { get; private set; }
#nullable restore
#else
        public DependabotAlertPackage Package { get; private set; }
#endif
        /// <summary>The execution scope of the vulnerable dependency.</summary>
        public DependabotAlertWithRepository_dependency_scope? Scope { get; private set; }
        /// <summary>
        /// Instantiates a new dependabotAlertWithRepository_dependency and sets the default values.
        /// </summary>
        public DependabotAlertWithRepository_dependency() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependabotAlertWithRepository_dependency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependabotAlertWithRepository_dependency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"manifest_path", n => { ManifestPath = n.GetStringValue(); } },
                {"package", n => { Package = n.GetObjectValue<DependabotAlertPackage>(DependabotAlertPackage.CreateFromDiscriminatorValue); } },
                {"scope", n => { Scope = n.GetEnumValue<DependabotAlertWithRepository_dependency_scope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
