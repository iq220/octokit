// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public class CodeScanningDefaultSetup : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Languages to be analyzed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CodeScanningDefaultSetup_languages?>? Languages { get; set; }
#nullable restore
#else
        public List<CodeScanningDefaultSetup_languages?> Languages { get; set; }
#endif
        /// <summary>CodeQL query suite to be used.</summary>
        public CodeScanningDefaultSetup_query_suite? QuerySuite { get; set; }
        /// <summary>The frequency of the periodic analysis.</summary>
        public CodeScanningDefaultSetup_schedule? Schedule { get; set; }
        /// <summary>Code scanning default setup has been configured or not.</summary>
        public CodeScanningDefaultSetup_state? State { get; set; }
        /// <summary>Timestamp of latest configuration update.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new codeScanningDefaultSetup and sets the default values.
        /// </summary>
        public CodeScanningDefaultSetup() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodeScanningDefaultSetup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodeScanningDefaultSetup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"languages", n => { Languages = n.GetCollectionOfEnumValues<CodeScanningDefaultSetup_languages>()?.ToList(); } },
                {"query_suite", n => { QuerySuite = n.GetEnumValue<CodeScanningDefaultSetup_query_suite>(); } },
                {"schedule", n => { Schedule = n.GetEnumValue<CodeScanningDefaultSetup_schedule>(); } },
                {"state", n => { State = n.GetEnumValue<CodeScanningDefaultSetup_state>(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<CodeScanningDefaultSetup_languages>("languages", Languages);
            writer.WriteEnumValue<CodeScanningDefaultSetup_query_suite>("query_suite", QuerySuite);
            writer.WriteEnumValue<CodeScanningDefaultSetup_schedule>("schedule", Schedule);
            writer.WriteEnumValue<CodeScanningDefaultSetup_state>("state", State);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
