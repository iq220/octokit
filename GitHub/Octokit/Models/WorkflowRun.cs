// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// An invocation of a workflow
    /// </summary>
    public class WorkflowRun : IAdditionalDataHolder, IParsable {
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Actor { get; set; }
#nullable restore
#else
        public SimpleUser Actor { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The URL to the artifacts for the workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArtifactsUrl { get; set; }
#nullable restore
#else
        public string ArtifactsUrl { get; set; }
#endif
        /// <summary>The URL to cancel the workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CancelUrl { get; set; }
#nullable restore
#else
        public string CancelUrl { get; set; }
#endif
        /// <summary>The ID of the associated check suite.</summary>
        public int? CheckSuiteId { get; set; }
        /// <summary>The node ID of the associated check suite.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CheckSuiteNodeId { get; set; }
#nullable restore
#else
        public string CheckSuiteNodeId { get; set; }
#endif
        /// <summary>The URL to the associated check suite.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CheckSuiteUrl { get; set; }
#nullable restore
#else
        public string CheckSuiteUrl { get; set; }
#endif
        /// <summary>The conclusion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Conclusion { get; set; }
#nullable restore
#else
        public string Conclusion { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The event-specific title associated with the run or the run-name if set, or the value of `run-name` if it is set in the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayTitle { get; set; }
#nullable restore
#else
        public string DisplayTitle { get; set; }
#endif
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The head_branch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadBranch { get; set; }
#nullable restore
#else
        public string HeadBranch { get; set; }
#endif
        /// <summary>A commit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleCommit? HeadCommit { get; set; }
#nullable restore
#else
        public NullableSimpleCommit HeadCommit { get; set; }
#endif
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MinimalRepository? HeadRepository { get; set; }
#nullable restore
#else
        public MinimalRepository HeadRepository { get; set; }
#endif
        /// <summary>The head_repository_id property</summary>
        public int? HeadRepositoryId { get; set; }
        /// <summary>The SHA of the head commit that points to the version of the workflow being run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadSha { get; set; }
#nullable restore
#else
        public string HeadSha { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The ID of the workflow run.</summary>
        public int? Id { get; set; }
        /// <summary>The URL to the jobs for the workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobsUrl { get; set; }
#nullable restore
#else
        public string JobsUrl { get; set; }
#endif
        /// <summary>The URL to download the logs for the workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogsUrl { get; set; }
#nullable restore
#else
        public string LogsUrl { get; set; }
#endif
        /// <summary>The name of the workflow run.</summary>
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
        /// <summary>The full path of the workflow</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The URL to the previous attempted run of this workflow, if one exists.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviousAttemptUrl { get; set; }
#nullable restore
#else
        public string PreviousAttemptUrl { get; set; }
#endif
        /// <summary>Pull requests that are open with a `head_sha` or `head_branch` that matches the workflow run. The returned pull requests do not necessarily indicate pull requests that triggered the run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PullRequestMinimal>? PullRequests { get; set; }
#nullable restore
#else
        public List<PullRequestMinimal> PullRequests { get; set; }
#endif
        /// <summary>The referenced_workflows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ReferencedWorkflow>? ReferencedWorkflows { get; set; }
#nullable restore
#else
        public List<ReferencedWorkflow> ReferencedWorkflows { get; set; }
#endif
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MinimalRepository? Repository { get; set; }
#nullable restore
#else
        public MinimalRepository Repository { get; set; }
#endif
        /// <summary>The URL to rerun the workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RerunUrl { get; set; }
#nullable restore
#else
        public string RerunUrl { get; set; }
#endif
        /// <summary>Attempt number of the run, 1 for first attempt and higher if the workflow was re-run.</summary>
        public int? RunAttempt { get; set; }
        /// <summary>The auto incrementing run number for the workflow run.</summary>
        public int? RunNumber { get; set; }
        /// <summary>The start time of the latest run. Resets on re-run.</summary>
        public DateTimeOffset? RunStartedAt { get; set; }
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? TriggeringActor { get; set; }
#nullable restore
#else
        public SimpleUser TriggeringActor { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The URL to the workflow run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The ID of the parent workflow.</summary>
        public int? WorkflowId { get; set; }
        /// <summary>The URL to the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkflowUrl { get; set; }
#nullable restore
#else
        public string WorkflowUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new workflowRun and sets the default values.
        /// </summary>
        public WorkflowRun() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowRun CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowRun();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actor", n => { Actor = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"artifacts_url", n => { ArtifactsUrl = n.GetStringValue(); } },
                {"cancel_url", n => { CancelUrl = n.GetStringValue(); } },
                {"check_suite_id", n => { CheckSuiteId = n.GetIntValue(); } },
                {"check_suite_node_id", n => { CheckSuiteNodeId = n.GetStringValue(); } },
                {"check_suite_url", n => { CheckSuiteUrl = n.GetStringValue(); } },
                {"conclusion", n => { Conclusion = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"display_title", n => { DisplayTitle = n.GetStringValue(); } },
                {"event", n => { Event = n.GetStringValue(); } },
                {"head_branch", n => { HeadBranch = n.GetStringValue(); } },
                {"head_commit", n => { HeadCommit = n.GetObjectValue<NullableSimpleCommit>(NullableSimpleCommit.CreateFromDiscriminatorValue); } },
                {"head_repository", n => { HeadRepository = n.GetObjectValue<MinimalRepository>(MinimalRepository.CreateFromDiscriminatorValue); } },
                {"head_repository_id", n => { HeadRepositoryId = n.GetIntValue(); } },
                {"head_sha", n => { HeadSha = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"jobs_url", n => { JobsUrl = n.GetStringValue(); } },
                {"logs_url", n => { LogsUrl = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"previous_attempt_url", n => { PreviousAttemptUrl = n.GetStringValue(); } },
                {"pull_requests", n => { PullRequests = n.GetCollectionOfObjectValues<PullRequestMinimal>(PullRequestMinimal.CreateFromDiscriminatorValue)?.ToList(); } },
                {"referenced_workflows", n => { ReferencedWorkflows = n.GetCollectionOfObjectValues<ReferencedWorkflow>(ReferencedWorkflow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"repository", n => { Repository = n.GetObjectValue<MinimalRepository>(MinimalRepository.CreateFromDiscriminatorValue); } },
                {"rerun_url", n => { RerunUrl = n.GetStringValue(); } },
                {"run_attempt", n => { RunAttempt = n.GetIntValue(); } },
                {"run_number", n => { RunNumber = n.GetIntValue(); } },
                {"run_started_at", n => { RunStartedAt = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"triggering_actor", n => { TriggeringActor = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"workflow_id", n => { WorkflowId = n.GetIntValue(); } },
                {"workflow_url", n => { WorkflowUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SimpleUser>("actor", Actor);
            writer.WriteStringValue("artifacts_url", ArtifactsUrl);
            writer.WriteStringValue("cancel_url", CancelUrl);
            writer.WriteIntValue("check_suite_id", CheckSuiteId);
            writer.WriteStringValue("check_suite_node_id", CheckSuiteNodeId);
            writer.WriteStringValue("check_suite_url", CheckSuiteUrl);
            writer.WriteStringValue("conclusion", Conclusion);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("display_title", DisplayTitle);
            writer.WriteStringValue("event", Event);
            writer.WriteStringValue("head_branch", HeadBranch);
            writer.WriteObjectValue<NullableSimpleCommit>("head_commit", HeadCommit);
            writer.WriteObjectValue<MinimalRepository>("head_repository", HeadRepository);
            writer.WriteIntValue("head_repository_id", HeadRepositoryId);
            writer.WriteStringValue("head_sha", HeadSha);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("jobs_url", JobsUrl);
            writer.WriteStringValue("logs_url", LogsUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("path", Path);
            writer.WriteStringValue("previous_attempt_url", PreviousAttemptUrl);
            writer.WriteCollectionOfObjectValues<PullRequestMinimal>("pull_requests", PullRequests);
            writer.WriteCollectionOfObjectValues<ReferencedWorkflow>("referenced_workflows", ReferencedWorkflows);
            writer.WriteObjectValue<MinimalRepository>("repository", Repository);
            writer.WriteStringValue("rerun_url", RerunUrl);
            writer.WriteIntValue("run_attempt", RunAttempt);
            writer.WriteIntValue("run_number", RunNumber);
            writer.WriteDateTimeOffsetValue("run_started_at", RunStartedAt);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<SimpleUser>("triggering_actor", TriggeringActor);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteIntValue("workflow_id", WorkflowId);
            writer.WriteStringValue("workflow_url", WorkflowUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
