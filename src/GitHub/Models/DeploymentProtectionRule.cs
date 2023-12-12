// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Deployment protection rule
    /// </summary>
    public class DeploymentProtectionRule : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub App that is providing a custom deployment protection rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomDeploymentRuleApp? App { get; set; }
#nullable restore
#else
        public CustomDeploymentRuleApp App { get; set; }
#endif
        /// <summary>Whether the deployment protection rule is enabled for the environment.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The unique identifier for the deployment protection rule.</summary>
        public int? Id { get; set; }
        /// <summary>The node ID for the deployment protection rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new deploymentProtectionRule and sets the default values.
        /// </summary>
        public DeploymentProtectionRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeploymentProtectionRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentProtectionRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"app", n => { App = n.GetObjectValue<CustomDeploymentRuleApp>(CustomDeploymentRuleApp.CreateFromDiscriminatorValue); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CustomDeploymentRuleApp>("app", App);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
