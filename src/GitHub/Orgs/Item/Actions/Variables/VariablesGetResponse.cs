// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Orgs.Item.Actions.Variables {
    public class VariablesGetResponse : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total_count property</summary>
        public int? TotalCount { get; set; }
        /// <summary>The variables property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OrganizationActionsVariable>? Variables { get; set; }
#nullable restore
#else
        public List<OrganizationActionsVariable> Variables { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="VariablesGetResponse"/> and sets the default values.
        /// </summary>
        public VariablesGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VariablesGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VariablesGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VariablesGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"total_count", n => { TotalCount = n.GetIntValue(); } },
                {"variables", n => { Variables = n.GetCollectionOfObjectValues<OrganizationActionsVariable>(OrganizationActionsVariable.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteCollectionOfObjectValues<OrganizationActionsVariable>("variables", Variables);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
