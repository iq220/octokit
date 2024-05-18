// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public class TeamFull : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>Unique identifier of the team</summary>
        public int? Id { get; set; }
        /// <summary>Distinguished Name (DN) that team maps to within LDAP environment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LdapDn { get; set; }
#nullable restore
#else
        public string LdapDn { get; set; }
#endif
        /// <summary>The members_count property</summary>
        public int? MembersCount { get; set; }
        /// <summary>The members_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembersUrl { get; set; }
#nullable restore
#else
        public string MembersUrl { get; set; }
#endif
        /// <summary>Name of the team</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The notification setting the team has set</summary>
        public TeamFull_notification_setting? NotificationSetting { get; set; }
        /// <summary>Team Organization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamOrganization? Organization { get; set; }
#nullable restore
#else
        public TeamOrganization Organization { get; set; }
#endif
        /// <summary>Groups of organization members that gives permissions on specified repositories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableTeamSimple? Parent { get; set; }
#nullable restore
#else
        public NullableTeamSimple Parent { get; set; }
#endif
        /// <summary>Permission that the team will have for its repositories</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Permission { get; set; }
#nullable restore
#else
        public string Permission { get; set; }
#endif
        /// <summary>The level of privacy this team should have</summary>
        public TeamFull_privacy? Privacy { get; set; }
        /// <summary>The repos_count property</summary>
        public int? ReposCount { get; set; }
        /// <summary>The repositories_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoriesUrl { get; set; }
#nullable restore
#else
        public string RepositoriesUrl { get; set; }
#endif
        /// <summary>The slug property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>URL for the team</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TeamFull"/> and sets the default values.
        /// </summary>
        public TeamFull()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamFull"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamFull CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamFull();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "ldap_dn", n => { LdapDn = n.GetStringValue(); } },
                { "members_count", n => { MembersCount = n.GetIntValue(); } },
                { "members_url", n => { MembersUrl = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "notification_setting", n => { NotificationSetting = n.GetEnumValue<TeamFull_notification_setting>(); } },
                { "organization", n => { Organization = n.GetObjectValue<TeamOrganization>(TeamOrganization.CreateFromDiscriminatorValue); } },
                { "parent", n => { Parent = n.GetObjectValue<NullableTeamSimple>(NullableTeamSimple.CreateFromDiscriminatorValue); } },
                { "permission", n => { Permission = n.GetStringValue(); } },
                { "privacy", n => { Privacy = n.GetEnumValue<TeamFull_privacy>(); } },
                { "repos_count", n => { ReposCount = n.GetIntValue(); } },
                { "repositories_url", n => { RepositoriesUrl = n.GetStringValue(); } },
                { "slug", n => { Slug = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("ldap_dn", LdapDn);
            writer.WriteIntValue("members_count", MembersCount);
            writer.WriteStringValue("members_url", MembersUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteEnumValue<TeamFull_notification_setting>("notification_setting", NotificationSetting);
            writer.WriteObjectValue<TeamOrganization>("organization", Organization);
            writer.WriteObjectValue<NullableTeamSimple>("parent", Parent);
            writer.WriteStringValue("permission", Permission);
            writer.WriteEnumValue<TeamFull_privacy>("privacy", Privacy);
            writer.WriteIntValue("repos_count", ReposCount);
            writer.WriteStringValue("repositories_url", RepositoriesUrl);
            writer.WriteStringValue("slug", Slug);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
