// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// Successful deletion of a code scanning analysis
    /// </summary>
    public class CodeScanningAnalysisDeletion : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Next deletable analysis in chain, with last analysis deletion confirmation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfirmDeleteUrl { get; private set; }
#nullable restore
#else
        public string ConfirmDeleteUrl { get; private set; }
#endif
        /// <summary>Next deletable analysis in chain, without last analysis deletion confirmation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextAnalysisUrl { get; private set; }
#nullable restore
#else
        public string NextAnalysisUrl { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new codeScanningAnalysisDeletion and sets the default values.
        /// </summary>
        public CodeScanningAnalysisDeletion() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodeScanningAnalysisDeletion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodeScanningAnalysisDeletion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confirm_delete_url", n => { ConfirmDeleteUrl = n.GetStringValue(); } },
                {"next_analysis_url", n => { NextAnalysisUrl = n.GetStringValue(); } },
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
