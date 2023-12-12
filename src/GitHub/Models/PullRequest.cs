// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Pull requests let you tell others about changes you&apos;ve pushed to a repository on GitHub. Once a pull request is sent, interested parties can review the set of changes, discuss potential modifications, and even push follow-up commits if necessary.
    /// </summary>
    public class PullRequest : IAdditionalDataHolder, IParsable {
        /// <summary>The active_lock_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActiveLockReason { get; set; }
#nullable restore
#else
        public string ActiveLockReason { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additions property</summary>
        public int? Additions { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Assignee { get; set; }
#nullable restore
#else
        public NullableSimpleUser Assignee { get; set; }
#endif
        /// <summary>The assignees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? Assignees { get; set; }
#nullable restore
#else
        public List<SimpleUser> Assignees { get; set; }
#endif
        /// <summary>How the author is associated with the repository.</summary>
        public GitHub.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>The status of auto merging a pull request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Models.AutoMerge? AutoMerge { get; set; }
#nullable restore
#else
        public GitHub.Models.AutoMerge AutoMerge { get; set; }
#endif
        /// <summary>The base property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequest_base? Base { get; set; }
#nullable restore
#else
        public PullRequest_base Base { get; set; }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The changed_files property</summary>
        public int? ChangedFiles { get; set; }
        /// <summary>The closed_at property</summary>
        public DateTimeOffset? ClosedAt { get; set; }
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
        /// <summary>The commits property</summary>
        public int? Commits { get; set; }
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
        /// <summary>The deletions property</summary>
        public int? Deletions { get; set; }
        /// <summary>The diff_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiffUrl { get; set; }
#nullable restore
#else
        public string DiffUrl { get; set; }
#endif
        /// <summary>Indicates whether or not the pull request is a draft.</summary>
        public bool? Draft { get; set; }
        /// <summary>The head property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequest_head? Head { get; set; }
#nullable restore
#else
        public PullRequest_head Head { get; set; }
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
        public int? Id { get; set; }
        /// <summary>The issue_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueUrl { get; set; }
#nullable restore
#else
        public string IssueUrl { get; set; }
#endif
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PullRequest_labels>? Labels { get; set; }
#nullable restore
#else
        public List<PullRequest_labels> Labels { get; set; }
#endif
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequest__links? Links { get; set; }
#nullable restore
#else
        public PullRequest__links Links { get; set; }
#endif
        /// <summary>The locked property</summary>
        public bool? Locked { get; set; }
        /// <summary>Indicates whether maintainers can modify the pull request.</summary>
        public bool? MaintainerCanModify { get; set; }
        /// <summary>The mergeable property</summary>
        public bool? Mergeable { get; set; }
        /// <summary>The mergeable_state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MergeableState { get; set; }
#nullable restore
#else
        public string MergeableState { get; set; }
#endif
        /// <summary>The merge_commit_sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MergeCommitSha { get; set; }
#nullable restore
#else
        public string MergeCommitSha { get; set; }
#endif
        /// <summary>The merged property</summary>
        public bool? Merged { get; set; }
        /// <summary>The merged_at property</summary>
        public DateTimeOffset? MergedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? MergedBy { get; set; }
#nullable restore
#else
        public NullableSimpleUser MergedBy { get; set; }
#endif
        /// <summary>A collection of related issues and pull requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableMilestone? Milestone { get; set; }
#nullable restore
#else
        public NullableMilestone Milestone { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>Number uniquely identifying the pull request within its repository.</summary>
        public int? Number { get; set; }
        /// <summary>The patch_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PatchUrl { get; set; }
#nullable restore
#else
        public string PatchUrl { get; set; }
#endif
        /// <summary>The rebaseable property</summary>
        public bool? Rebaseable { get; set; }
        /// <summary>The requested_reviewers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? RequestedReviewers { get; set; }
#nullable restore
#else
        public List<SimpleUser> RequestedReviewers { get; set; }
#endif
        /// <summary>The requested_teams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamSimple>? RequestedTeams { get; set; }
#nullable restore
#else
        public List<TeamSimple> RequestedTeams { get; set; }
#endif
        /// <summary>The review_comments property</summary>
        public int? ReviewComments { get; set; }
        /// <summary>The review_comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewCommentsUrl { get; set; }
#nullable restore
#else
        public string ReviewCommentsUrl { get; set; }
#endif
        /// <summary>The review_comment_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewCommentUrl { get; set; }
#nullable restore
#else
        public string ReviewCommentUrl { get; set; }
#endif
        /// <summary>State of this Pull Request. Either `open` or `closed`.</summary>
        public PullRequest_state? State { get; set; }
        /// <summary>The statuses_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusesUrl { get; set; }
#nullable restore
#else
        public string StatusesUrl { get; set; }
#endif
        /// <summary>The title of the pull request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
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
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? User { get; set; }
#nullable restore
#else
        public SimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new pullRequest and sets the default values.
        /// </summary>
        public PullRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"active_lock_reason", n => { ActiveLockReason = n.GetStringValue(); } },
                {"additions", n => { Additions = n.GetIntValue(); } },
                {"assignee", n => { Assignee = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"assignees", n => { Assignees = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"author_association", n => { AuthorAssociation = n.GetEnumValue<AuthorAssociation>(); } },
                {"auto_merge", n => { AutoMerge = n.GetObjectValue<GitHub.Models.AutoMerge>(GitHub.Models.AutoMerge.CreateFromDiscriminatorValue); } },
                {"base", n => { Base = n.GetObjectValue<PullRequest_base>(PullRequest_base.CreateFromDiscriminatorValue); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"changed_files", n => { ChangedFiles = n.GetIntValue(); } },
                {"closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                {"comments", n => { Comments = n.GetIntValue(); } },
                {"comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                {"commits", n => { Commits = n.GetIntValue(); } },
                {"commits_url", n => { CommitsUrl = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"deletions", n => { Deletions = n.GetIntValue(); } },
                {"diff_url", n => { DiffUrl = n.GetStringValue(); } },
                {"draft", n => { Draft = n.GetBoolValue(); } },
                {"head", n => { Head = n.GetObjectValue<PullRequest_head>(PullRequest_head.CreateFromDiscriminatorValue); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"issue_url", n => { IssueUrl = n.GetStringValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfObjectValues<PullRequest_labels>(PullRequest_labels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"_links", n => { Links = n.GetObjectValue<PullRequest__links>(PullRequest__links.CreateFromDiscriminatorValue); } },
                {"locked", n => { Locked = n.GetBoolValue(); } },
                {"maintainer_can_modify", n => { MaintainerCanModify = n.GetBoolValue(); } },
                {"merge_commit_sha", n => { MergeCommitSha = n.GetStringValue(); } },
                {"mergeable", n => { Mergeable = n.GetBoolValue(); } },
                {"mergeable_state", n => { MergeableState = n.GetStringValue(); } },
                {"merged", n => { Merged = n.GetBoolValue(); } },
                {"merged_at", n => { MergedAt = n.GetDateTimeOffsetValue(); } },
                {"merged_by", n => { MergedBy = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"milestone", n => { Milestone = n.GetObjectValue<NullableMilestone>(NullableMilestone.CreateFromDiscriminatorValue); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"number", n => { Number = n.GetIntValue(); } },
                {"patch_url", n => { PatchUrl = n.GetStringValue(); } },
                {"rebaseable", n => { Rebaseable = n.GetBoolValue(); } },
                {"requested_reviewers", n => { RequestedReviewers = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requested_teams", n => { RequestedTeams = n.GetCollectionOfObjectValues<TeamSimple>(TeamSimple.CreateFromDiscriminatorValue)?.ToList(); } },
                {"review_comment_url", n => { ReviewCommentUrl = n.GetStringValue(); } },
                {"review_comments", n => { ReviewComments = n.GetIntValue(); } },
                {"review_comments_url", n => { ReviewCommentsUrl = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<PullRequest_state>(); } },
                {"statuses_url", n => { StatusesUrl = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("active_lock_reason", ActiveLockReason);
            writer.WriteIntValue("additions", Additions);
            writer.WriteObjectValue<NullableSimpleUser>("assignee", Assignee);
            writer.WriteCollectionOfObjectValues<SimpleUser>("assignees", Assignees);
            writer.WriteEnumValue<AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteObjectValue<GitHub.Models.AutoMerge>("auto_merge", AutoMerge);
            writer.WriteObjectValue<PullRequest_base>("base", Base);
            writer.WriteStringValue("body", Body);
            writer.WriteIntValue("changed_files", ChangedFiles);
            writer.WriteDateTimeOffsetValue("closed_at", ClosedAt);
            writer.WriteIntValue("comments", Comments);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteIntValue("commits", Commits);
            writer.WriteStringValue("commits_url", CommitsUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("deletions", Deletions);
            writer.WriteStringValue("diff_url", DiffUrl);
            writer.WriteBoolValue("draft", Draft);
            writer.WriteObjectValue<PullRequest_head>("head", Head);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("issue_url", IssueUrl);
            writer.WriteCollectionOfObjectValues<PullRequest_labels>("labels", Labels);
            writer.WriteObjectValue<PullRequest__links>("_links", Links);
            writer.WriteBoolValue("locked", Locked);
            writer.WriteBoolValue("maintainer_can_modify", MaintainerCanModify);
            writer.WriteBoolValue("mergeable", Mergeable);
            writer.WriteStringValue("mergeable_state", MergeableState);
            writer.WriteStringValue("merge_commit_sha", MergeCommitSha);
            writer.WriteBoolValue("merged", Merged);
            writer.WriteDateTimeOffsetValue("merged_at", MergedAt);
            writer.WriteObjectValue<NullableSimpleUser>("merged_by", MergedBy);
            writer.WriteObjectValue<NullableMilestone>("milestone", Milestone);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("number", Number);
            writer.WriteStringValue("patch_url", PatchUrl);
            writer.WriteBoolValue("rebaseable", Rebaseable);
            writer.WriteCollectionOfObjectValues<SimpleUser>("requested_reviewers", RequestedReviewers);
            writer.WriteCollectionOfObjectValues<TeamSimple>("requested_teams", RequestedTeams);
            writer.WriteIntValue("review_comments", ReviewComments);
            writer.WriteStringValue("review_comments_url", ReviewCommentsUrl);
            writer.WriteStringValue("review_comment_url", ReviewCommentUrl);
            writer.WriteEnumValue<PullRequest_state>("state", State);
            writer.WriteStringValue("statuses_url", StatusesUrl);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<SimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
