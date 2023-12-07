// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// A migration.
    /// </summary>
    public class Migration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The archive_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArchiveUrl { get; set; }
#nullable restore
#else
        public string ArchiveUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `&quot;repositories&quot;`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Exclude { get; set; }
#nullable restore
#else
        public List<string> Exclude { get; set; }
#endif
        /// <summary>The exclude_attachments property</summary>
        public bool? ExcludeAttachments { get; set; }
        /// <summary>The exclude_git_data property</summary>
        public bool? ExcludeGitData { get; set; }
        /// <summary>The exclude_metadata property</summary>
        public bool? ExcludeMetadata { get; set; }
        /// <summary>The exclude_owner_projects property</summary>
        public bool? ExcludeOwnerProjects { get; set; }
        /// <summary>The exclude_releases property</summary>
        public bool? ExcludeReleases { get; set; }
        /// <summary>The guid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Guid { get; set; }
#nullable restore
#else
        public string Guid { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The lock_repositories property</summary>
        public bool? LockRepositories { get; set; }
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The org_metadata_only property</summary>
        public bool? OrgMetadataOnly { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Owner { get; set; }
#nullable restore
#else
        public NullableSimpleUser Owner { get; set; }
#endif
        /// <summary>The repositories included in the migration. Only returned for export migrations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Repository>? Repositories { get; set; }
#nullable restore
#else
        public List<Repository> Repositories { get; set; }
#endif
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
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
        /// Instantiates a new migration and sets the default values.
        /// </summary>
        public Migration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Migration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Migration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archive_url", n => { ArchiveUrl = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"exclude", n => { Exclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"exclude_attachments", n => { ExcludeAttachments = n.GetBoolValue(); } },
                {"exclude_git_data", n => { ExcludeGitData = n.GetBoolValue(); } },
                {"exclude_metadata", n => { ExcludeMetadata = n.GetBoolValue(); } },
                {"exclude_owner_projects", n => { ExcludeOwnerProjects = n.GetBoolValue(); } },
                {"exclude_releases", n => { ExcludeReleases = n.GetBoolValue(); } },
                {"guid", n => { Guid = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"lock_repositories", n => { LockRepositories = n.GetBoolValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"org_metadata_only", n => { OrgMetadataOnly = n.GetBoolValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"repositories", n => { Repositories = n.GetCollectionOfObjectValues<Repository>(Repository.CreateFromDiscriminatorValue)?.ToList(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archive_url", ArchiveUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteCollectionOfPrimitiveValues<string>("exclude", Exclude);
            writer.WriteBoolValue("exclude_attachments", ExcludeAttachments);
            writer.WriteBoolValue("exclude_git_data", ExcludeGitData);
            writer.WriteBoolValue("exclude_metadata", ExcludeMetadata);
            writer.WriteBoolValue("exclude_owner_projects", ExcludeOwnerProjects);
            writer.WriteBoolValue("exclude_releases", ExcludeReleases);
            writer.WriteStringValue("guid", Guid);
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("lock_repositories", LockRepositories);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteBoolValue("org_metadata_only", OrgMetadataOnly);
            writer.WriteObjectValue<NullableSimpleUser>("owner", Owner);
            writer.WriteCollectionOfObjectValues<Repository>("repositories", Repositories);
            writer.WriteStringValue("state", State);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
