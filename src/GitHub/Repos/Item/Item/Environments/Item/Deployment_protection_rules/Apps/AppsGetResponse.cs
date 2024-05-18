// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Environments.Item.Deployment_protection_rules.Apps
{
    #pragma warning disable CS1591
    public class AppsGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The available_custom_deployment_protection_rule_integrations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomDeploymentRuleApp>? AvailableCustomDeploymentProtectionRuleIntegrations { get; set; }
#nullable restore
#else
        public List<CustomDeploymentRuleApp> AvailableCustomDeploymentProtectionRuleIntegrations { get; set; }
#endif
        /// <summary>The total number of custom deployment protection rule integrations available for this environment.</summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AppsGetResponse"/> and sets the default values.
        /// </summary>
        public AppsGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AppsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "available_custom_deployment_protection_rule_integrations", n => { AvailableCustomDeploymentProtectionRuleIntegrations = n.GetCollectionOfObjectValues<CustomDeploymentRuleApp>(CustomDeploymentRuleApp.CreateFromDiscriminatorValue)?.ToList(); } },
                { "total_count", n => { TotalCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CustomDeploymentRuleApp>("available_custom_deployment_protection_rule_integrations", AvailableCustomDeploymentProtectionRuleIntegrations);
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
