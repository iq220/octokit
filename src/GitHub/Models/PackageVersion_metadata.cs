// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class PackageVersion_metadata : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The container property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PackageVersion_metadata_container? Container { get; set; }
#nullable restore
#else
        public PackageVersion_metadata_container Container { get; set; }
#endif
        /// <summary>The docker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PackageVersion_metadata_docker? Docker { get; set; }
#nullable restore
#else
        public PackageVersion_metadata_docker Docker { get; set; }
#endif
        /// <summary>The package_type property</summary>
        public PackageVersion_metadata_package_type? PackageType { get; set; }
        /// <summary>
        /// Instantiates a new packageVersion_metadata and sets the default values.
        /// </summary>
        public PackageVersion_metadata() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PackageVersion_metadata CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PackageVersion_metadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"container", n => { Container = n.GetObjectValue<PackageVersion_metadata_container>(PackageVersion_metadata_container.CreateFromDiscriminatorValue); } },
                {"docker", n => { Docker = n.GetObjectValue<PackageVersion_metadata_docker>(PackageVersion_metadata_docker.CreateFromDiscriminatorValue); } },
                {"package_type", n => { PackageType = n.GetEnumValue<PackageVersion_metadata_package_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PackageVersion_metadata_container>("container", Container);
            writer.WriteObjectValue<PackageVersion_metadata_docker>("docker", Docker);
            writer.WriteEnumValue<PackageVersion_metadata_package_type>("package_type", PackageType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
