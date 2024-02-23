// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Deployments.Item.Statuses {
    public class StatusesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Adds a new `inactive` status to all prior non-transient, non-production environment deployments with the same repository and `environment` name as the created status&apos;s deployment. An `inactive` status is only added to deployments that had a `success` state. Default: `true`</summary>
        public bool? AutoInactive { get; set; }
        /// <summary>A short description of the status. The maximum description length is 140 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name for the target deployment environment, which can be changed when setting a deploy status. For example, `production`, `staging`, or `qa`. If not defined, the environment of the previous status on the deployment will be used, if it exists. Otherwise, the environment of the deployment will be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Environment { get; set; }
#nullable restore
#else
        public string Environment { get; set; }
#endif
        /// <summary>Sets the URL for accessing your environment. Default: `&quot;&quot;`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnvironmentUrl { get; set; }
#nullable restore
#else
        public string EnvironmentUrl { get; set; }
#endif
        /// <summary>The full URL of the deployment&apos;s output. This parameter replaces `target_url`. We will continue to accept `target_url` to support legacy uses, but we recommend replacing `target_url` with `log_url`. Setting `log_url` will automatically set `target_url` to the same value. Default: `&quot;&quot;`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogUrl { get; set; }
#nullable restore
#else
        public string LogUrl { get; set; }
#endif
        /// <summary>The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.</summary>
        public StatusesPostRequestBody_state? State { get; set; }
        /// <summary>The target URL to associate with this status. This URL should contain output to keep the user updated while the task is running or serve as historical information for what happened in the deployment. **Note:** It&apos;s recommended to use the `log_url` parameter, which replaces `target_url`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetUrl { get; set; }
#nullable restore
#else
        public string TargetUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="StatusesPostRequestBody"/> and sets the default values.
        /// </summary>
        public StatusesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StatusesPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StatusesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StatusesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"auto_inactive", n => { AutoInactive = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"environment", n => { Environment = n.GetStringValue(); } },
                {"environment_url", n => { EnvironmentUrl = n.GetStringValue(); } },
                {"log_url", n => { LogUrl = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<StatusesPostRequestBody_state>(); } },
                {"target_url", n => { TargetUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("auto_inactive", AutoInactive);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("environment", Environment);
            writer.WriteStringValue("environment_url", EnvironmentUrl);
            writer.WriteStringValue("log_url", LogUrl);
            writer.WriteEnumValue<StatusesPostRequestBody_state>("state", State);
            writer.WriteStringValue("target_url", TargetUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
