// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Environments.Item.DeploymentBranchPolicies {
    #pragma warning disable CS1591
    public class DeploymentBranchPoliciesGetResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The branch_policies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeploymentBranchPolicy>? BranchPolicies { get; set; }
#nullable restore
#else
        public List<DeploymentBranchPolicy> BranchPolicies { get; set; }
#endif
        /// <summary>The number of deployment branch policies for the environment.</summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DeploymentBranchPoliciesGetResponse"/> and sets the default values.
        /// </summary>
        public DeploymentBranchPoliciesGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeploymentBranchPoliciesGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeploymentBranchPoliciesGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentBranchPoliciesGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"branch_policies", n => { BranchPolicies = n.GetCollectionOfObjectValues<DeploymentBranchPolicy>(DeploymentBranchPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"total_count", n => { TotalCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeploymentBranchPolicy>("branch_policies", BranchPolicies);
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
