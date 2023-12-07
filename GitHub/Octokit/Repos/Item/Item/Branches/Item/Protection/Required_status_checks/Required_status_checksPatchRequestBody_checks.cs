// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Required_status_checks {
    public class Required_status_checksPatchRequestBody_checks : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the GitHub App that must provide this check. Omit this field to automatically select the GitHub App that has recently provided this check, or any app if it was not set by a GitHub App. Pass -1 to explicitly allow any app to set the status.</summary>
        public int? AppId { get; set; }
        /// <summary>The name of the required check</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Context { get; set; }
#nullable restore
#else
        public string Context { get; set; }
#endif
        /// <summary>
        /// Instantiates a new required_status_checksPatchRequestBody_checks and sets the default values.
        /// </summary>
        public Required_status_checksPatchRequestBody_checks() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Required_status_checksPatchRequestBody_checks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Required_status_checksPatchRequestBody_checks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"app_id", n => { AppId = n.GetIntValue(); } },
                {"context", n => { Context = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("app_id", AppId);
            writer.WriteStringValue("context", Context);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
