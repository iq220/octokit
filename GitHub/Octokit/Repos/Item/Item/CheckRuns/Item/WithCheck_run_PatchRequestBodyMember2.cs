// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Repos.Item.Item.CheckRuns.Item {
    public class WithCheck_run_PatchRequestBodyMember2 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The status property</summary>
        public WithCheck_run_PatchRequestBodyMember2_status? Status { get; set; }
        /// <summary>
        /// Instantiates a new WithCheck_run_PatchRequestBodyMember2 and sets the default values.
        /// </summary>
        public WithCheck_run_PatchRequestBodyMember2() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithCheck_run_PatchRequestBodyMember2 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithCheck_run_PatchRequestBodyMember2();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"status", n => { Status = n.GetEnumValue<WithCheck_run_PatchRequestBodyMember2_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<WithCheck_run_PatchRequestBodyMember2_status>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
