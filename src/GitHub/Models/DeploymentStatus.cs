// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// The status of a deployment.
    /// </summary>
    public class DeploymentStatus : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Creator { get; set; }
#nullable restore
#else
        public NullableSimpleUser Creator { get; set; }
#endif
        /// <summary>The deployment_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeploymentUrl { get; set; }
#nullable restore
#else
        public string DeploymentUrl { get; set; }
#endif
        /// <summary>A short description of the status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The environment of the deployment that the status is for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Environment { get; set; }
#nullable restore
#else
        public string Environment { get; set; }
#endif
        /// <summary>The URL for accessing your environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnvironmentUrl { get; set; }
#nullable restore
#else
        public string EnvironmentUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The URL to associate with this status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogUrl { get; set; }
#nullable restore
#else
        public string LogUrl { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>The repository_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoryUrl { get; set; }
#nullable restore
#else
        public string RepositoryUrl { get; set; }
#endif
        /// <summary>The state of the status.</summary>
        public DeploymentStatus_state? State { get; set; }
        /// <summary>Deprecated: the URL to associate with this status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetUrl { get; set; }
#nullable restore
#else
        public string TargetUrl { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DeploymentStatus"/> and sets the default values.
        /// </summary>
        public DeploymentStatus()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeploymentStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"creator", n => { Creator = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"deployment_url", n => { DeploymentUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"environment", n => { Environment = n.GetStringValue(); } },
                {"environment_url", n => { EnvironmentUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"log_url", n => { LogUrl = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<NullableIntegration>(NullableIntegration.CreateFromDiscriminatorValue); } },
                {"repository_url", n => { RepositoryUrl = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<DeploymentStatus_state>(); } },
                {"target_url", n => { TargetUrl = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteObjectValue<NullableSimpleUser>("creator", Creator);
            writer.WriteStringValue("deployment_url", DeploymentUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("environment", Environment);
            writer.WriteStringValue("environment_url", EnvironmentUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("log_url", LogUrl);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteObjectValue<NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteStringValue("repository_url", RepositoryUrl);
            writer.WriteEnumValue<DeploymentStatus_state>("state", State);
            writer.WriteStringValue("target_url", TargetUrl);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
