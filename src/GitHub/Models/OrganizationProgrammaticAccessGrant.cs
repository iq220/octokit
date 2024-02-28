// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Minimal representation of an organization programmatic access grant for enumerations
    /// </summary>
    public class OrganizationProgrammaticAccessGrant : IAdditionalDataHolder, IParsable {
        /// <summary>Date and time when the fine-grained personal access token was approved to access the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessGrantedAt { get; set; }
#nullable restore
#else
        public string AccessGrantedAt { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier of the fine-grained personal access token. The `pat_id` used to get details about an approved fine-grained personal access token.</summary>
        public int? Id { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Owner { get; set; }
#nullable restore
#else
        public SimpleUser Owner { get; set; }
#endif
        /// <summary>Permissions requested, categorized by type of permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OrganizationProgrammaticAccessGrant_permissions? Permissions { get; set; }
#nullable restore
#else
        public OrganizationProgrammaticAccessGrant_permissions Permissions { get; set; }
#endif
        /// <summary>URL to the list of repositories the fine-grained personal access token can access. Only follow when `repository_selection` is `subset`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoriesUrl { get; set; }
#nullable restore
#else
        public string RepositoriesUrl { get; set; }
#endif
        /// <summary>Type of repository selection requested.</summary>
        public OrganizationProgrammaticAccessGrant_repository_selection? RepositorySelection { get; set; }
        /// <summary>Whether the associated fine-grained personal access token has expired.</summary>
        public bool? TokenExpired { get; set; }
        /// <summary>Date and time when the associated fine-grained personal access token expires.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenExpiresAt { get; set; }
#nullable restore
#else
        public string TokenExpiresAt { get; set; }
#endif
        /// <summary>Date and time when the associated fine-grained personal access token was last used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenLastUsedAt { get; set; }
#nullable restore
#else
        public string TokenLastUsedAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="OrganizationProgrammaticAccessGrant"/> and sets the default values.
        /// </summary>
        public OrganizationProgrammaticAccessGrant() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OrganizationProgrammaticAccessGrant"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrganizationProgrammaticAccessGrant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationProgrammaticAccessGrant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"access_granted_at", n => { AccessGrantedAt = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"permissions", n => { Permissions = n.GetObjectValue<OrganizationProgrammaticAccessGrant_permissions>(OrganizationProgrammaticAccessGrant_permissions.CreateFromDiscriminatorValue); } },
                {"repositories_url", n => { RepositoriesUrl = n.GetStringValue(); } },
                {"repository_selection", n => { RepositorySelection = n.GetEnumValue<OrganizationProgrammaticAccessGrant_repository_selection>(); } },
                {"token_expired", n => { TokenExpired = n.GetBoolValue(); } },
                {"token_expires_at", n => { TokenExpiresAt = n.GetStringValue(); } },
                {"token_last_used_at", n => { TokenLastUsedAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("access_granted_at", AccessGrantedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<SimpleUser>("owner", Owner);
            writer.WriteObjectValue<OrganizationProgrammaticAccessGrant_permissions>("permissions", Permissions);
            writer.WriteStringValue("repositories_url", RepositoriesUrl);
            writer.WriteEnumValue<OrganizationProgrammaticAccessGrant_repository_selection>("repository_selection", RepositorySelection);
            writer.WriteBoolValue("token_expired", TokenExpired);
            writer.WriteStringValue("token_expires_at", TokenExpiresAt);
            writer.WriteStringValue("token_last_used_at", TokenLastUsedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
