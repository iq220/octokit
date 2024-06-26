// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Orgs.Item.Actions.Permissions {
    #pragma warning disable CS1591
    public class PermissionsPutRequestBody : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The permissions policy that controls the actions and reusable workflows that are allowed to run.</summary>
        public GitHub.Models.AllowedActions? AllowedActions { get; set; }
        /// <summary>The policy that controls the repositories in the organization that are allowed to run GitHub Actions.</summary>
        public GitHub.Models.EnabledRepositories? EnabledRepositories { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PermissionsPutRequestBody"/> and sets the default values.
        /// </summary>
        public PermissionsPutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PermissionsPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PermissionsPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionsPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allowed_actions", n => { AllowedActions = n.GetEnumValue<AllowedActions>(); } },
                {"enabled_repositories", n => { EnabledRepositories = n.GetEnumValue<EnabledRepositories>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AllowedActions>("allowed_actions", AllowedActions);
            writer.WriteEnumValue<EnabledRepositories>("enabled_repositories", EnabledRepositories);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
