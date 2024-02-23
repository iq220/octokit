// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runs.Item.Pending_deployments {
    public class Pending_deploymentsPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A comment to accompany the deployment review</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The list of environment ids to approve or reject</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? EnvironmentIds { get; set; }
#nullable restore
#else
        public List<int?> EnvironmentIds { get; set; }
#endif
        /// <summary>Whether to approve or reject deployment to the specified environments.</summary>
        public Pending_deploymentsPostRequestBody_state? State { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Pending_deploymentsPostRequestBody"/> and sets the default values.
        /// </summary>
        public Pending_deploymentsPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Pending_deploymentsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pending_deploymentsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pending_deploymentsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"environment_ids", n => { EnvironmentIds = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"state", n => { State = n.GetEnumValue<Pending_deploymentsPostRequestBody_state>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteCollectionOfPrimitiveValues<int?>("environment_ids", EnvironmentIds);
            writer.WriteEnumValue<Pending_deploymentsPostRequestBody_state>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
