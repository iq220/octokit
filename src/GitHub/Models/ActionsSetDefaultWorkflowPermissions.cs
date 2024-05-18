// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    #pragma warning disable CS1591
    public class ActionsSetDefaultWorkflowPermissions : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.</summary>
        public bool? CanApprovePullRequestReviews { get; set; }
        /// <summary>The default workflow permissions granted to the GITHUB_TOKEN when running workflows.</summary>
        public ActionsDefaultWorkflowPermissions? DefaultWorkflowPermissions { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ActionsSetDefaultWorkflowPermissions"/> and sets the default values.
        /// </summary>
        public ActionsSetDefaultWorkflowPermissions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActionsSetDefaultWorkflowPermissions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ActionsSetDefaultWorkflowPermissions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionsSetDefaultWorkflowPermissions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "can_approve_pull_request_reviews", n => { CanApprovePullRequestReviews = n.GetBoolValue(); } },
                { "default_workflow_permissions", n => { DefaultWorkflowPermissions = n.GetEnumValue<ActionsDefaultWorkflowPermissions>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("can_approve_pull_request_reviews", CanApprovePullRequestReviews);
            writer.WriteEnumValue<ActionsDefaultWorkflowPermissions>("default_workflow_permissions", DefaultWorkflowPermissions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
