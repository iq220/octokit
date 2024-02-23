// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class DependencyGraphDiff_vulnerabilities : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The advisory_ghsa_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdvisoryGhsaId { get; set; }
#nullable restore
#else
        public string AdvisoryGhsaId { get; set; }
#endif
        /// <summary>The advisory_summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdvisorySummary { get; set; }
#nullable restore
#else
        public string AdvisorySummary { get; set; }
#endif
        /// <summary>The advisory_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdvisoryUrl { get; set; }
#nullable restore
#else
        public string AdvisoryUrl { get; set; }
#endif
        /// <summary>The severity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Severity { get; set; }
#nullable restore
#else
        public string Severity { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DependencyGraphDiff_vulnerabilities"/> and sets the default values.
        /// </summary>
        public DependencyGraphDiff_vulnerabilities() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DependencyGraphDiff_vulnerabilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependencyGraphDiff_vulnerabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependencyGraphDiff_vulnerabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"advisory_ghsa_id", n => { AdvisoryGhsaId = n.GetStringValue(); } },
                {"advisory_summary", n => { AdvisorySummary = n.GetStringValue(); } },
                {"advisory_url", n => { AdvisoryUrl = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("advisory_ghsa_id", AdvisoryGhsaId);
            writer.WriteStringValue("advisory_summary", AdvisorySummary);
            writer.WriteStringValue("advisory_url", AdvisoryUrl);
            writer.WriteStringValue("severity", Severity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
