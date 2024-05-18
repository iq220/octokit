// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Base Gist
    /// </summary>
    public class BaseGist : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The comments property</summary>
        public int? Comments { get; set; }
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The commits_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitsUrl { get; set; }
#nullable restore
#else
        public string CommitsUrl { get; set; }
#endif
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
        /// <summary>The files property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BaseGist_files? Files { get; set; }
#nullable restore
#else
        public BaseGist_files Files { get; set; }
#endif
        /// <summary>The forks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Forks { get; set; }
#nullable restore
#else
        public UntypedNode Forks { get; set; }
#endif
        /// <summary>The forks_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForksUrl { get; set; }
#nullable restore
#else
        public string ForksUrl { get; set; }
#endif
        /// <summary>The git_pull_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitPullUrl { get; set; }
#nullable restore
#else
        public string GitPullUrl { get; set; }
#endif
        /// <summary>The git_push_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitPushUrl { get; set; }
#nullable restore
#else
        public string GitPushUrl { get; set; }
#endif
        /// <summary>The history property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? History { get; set; }
#nullable restore
#else
        public UntypedNode History { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Owner { get; set; }
#nullable restore
#else
        public SimpleUser Owner { get; set; }
#endif
        /// <summary>The public property</summary>
        public bool? Public { get; set; }
        /// <summary>The truncated property</summary>
        public bool? Truncated { get; set; }
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
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? User { get; set; }
#nullable restore
#else
        public NullableSimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BaseGist"/> and sets the default values.
        /// </summary>
        public BaseGist()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BaseGist"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BaseGist CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BaseGist();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "comments", n => { Comments = n.GetIntValue(); } },
                { "comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                { "commits_url", n => { CommitsUrl = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "files", n => { Files = n.GetObjectValue<BaseGist_files>(BaseGist_files.CreateFromDiscriminatorValue); } },
                { "forks", n => { Forks = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "forks_url", n => { ForksUrl = n.GetStringValue(); } },
                { "git_pull_url", n => { GitPullUrl = n.GetStringValue(); } },
                { "git_push_url", n => { GitPushUrl = n.GetStringValue(); } },
                { "history", n => { History = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                { "public", n => { Public = n.GetBoolValue(); } },
                { "truncated", n => { Truncated = n.GetBoolValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "user", n => { User = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("comments", Comments);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteStringValue("commits_url", CommitsUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<BaseGist_files>("files", Files);
            writer.WriteObjectValue<UntypedNode>("forks", Forks);
            writer.WriteStringValue("forks_url", ForksUrl);
            writer.WriteStringValue("git_pull_url", GitPullUrl);
            writer.WriteStringValue("git_push_url", GitPushUrl);
            writer.WriteObjectValue<UntypedNode>("history", History);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteObjectValue<SimpleUser>("owner", Owner);
            writer.WriteBoolValue("public", Public);
            writer.WriteBoolValue("truncated", Truncated);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
