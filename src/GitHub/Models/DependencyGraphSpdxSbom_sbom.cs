// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class DependencyGraphSpdxSbom_sbom : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The creationInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DependencyGraphSpdxSbom_sbom_creationInfo? CreationInfo { get; set; }
#nullable restore
#else
        public DependencyGraphSpdxSbom_sbom_creationInfo CreationInfo { get; set; }
#endif
        /// <summary>The license under which the SPDX document is licensed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataLicense { get; set; }
#nullable restore
#else
        public string DataLicense { get; set; }
#endif
        /// <summary>The name of the repository that the SPDX document describes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DocumentDescribes { get; set; }
#nullable restore
#else
        public List<string> DocumentDescribes { get; set; }
#endif
        /// <summary>The namespace for the SPDX document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentNamespace { get; set; }
#nullable restore
#else
        public string DocumentNamespace { get; set; }
#endif
        /// <summary>The name of the SPDX document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The packages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DependencyGraphSpdxSbom_sbom_packages>? Packages { get; set; }
#nullable restore
#else
        public List<DependencyGraphSpdxSbom_sbom_packages> Packages { get; set; }
#endif
        /// <summary>The SPDX identifier for the SPDX document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SPDXID { get; set; }
#nullable restore
#else
        public string SPDXID { get; set; }
#endif
        /// <summary>The version of the SPDX specification that this document conforms to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpdxVersion { get; set; }
#nullable restore
#else
        public string SpdxVersion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new dependencyGraphSpdxSbom_sbom and sets the default values.
        /// </summary>
        public DependencyGraphSpdxSbom_sbom() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependencyGraphSpdxSbom_sbom CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependencyGraphSpdxSbom_sbom();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"creationInfo", n => { CreationInfo = n.GetObjectValue<DependencyGraphSpdxSbom_sbom_creationInfo>(DependencyGraphSpdxSbom_sbom_creationInfo.CreateFromDiscriminatorValue); } },
                {"dataLicense", n => { DataLicense = n.GetStringValue(); } },
                {"documentDescribes", n => { DocumentDescribes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"documentNamespace", n => { DocumentNamespace = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"packages", n => { Packages = n.GetCollectionOfObjectValues<DependencyGraphSpdxSbom_sbom_packages>(DependencyGraphSpdxSbom_sbom_packages.CreateFromDiscriminatorValue)?.ToList(); } },
                {"SPDXID", n => { SPDXID = n.GetStringValue(); } },
                {"spdxVersion", n => { SpdxVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DependencyGraphSpdxSbom_sbom_creationInfo>("creationInfo", CreationInfo);
            writer.WriteStringValue("dataLicense", DataLicense);
            writer.WriteCollectionOfPrimitiveValues<string>("documentDescribes", DocumentDescribes);
            writer.WriteStringValue("documentNamespace", DocumentNamespace);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<DependencyGraphSpdxSbom_sbom_packages>("packages", Packages);
            writer.WriteStringValue("SPDXID", SPDXID);
            writer.WriteStringValue("spdxVersion", SpdxVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
