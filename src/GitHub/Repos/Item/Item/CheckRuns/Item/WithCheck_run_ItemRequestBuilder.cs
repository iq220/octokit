// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.CheckRuns.Item.Annotations;
using GitHub.Repos.Item.Item.CheckRuns.Item.Rerequest;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.CheckRuns.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\check-runs\{check_run_id}
    /// </summary>
    public class WithCheck_run_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The annotations property</summary>
        public AnnotationsRequestBuilder Annotations { get =>
            new AnnotationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rerequest property</summary>
        public RerequestRequestBuilder Rerequest { get =>
            new RerequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithCheck_run_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCheck_run_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/check-runs/{check_run_id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithCheck_run_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCheck_run_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/check-runs/{check_run_id}", rawUrl) {
        }
        /// <summary>
        /// Gets a single check run using its `id`.**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// API method documentation <see href="https://docs.github.com/rest/checks/runs#get-a-check-run" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CheckRun?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CheckRun> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CheckRun>(requestInfo, CheckRun.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates a check run for a specific commit in a repository.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/checks/runs#update-a-check-run" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CheckRun?> PatchAsync(WithCheck_run_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CheckRun> PatchAsync(WithCheck_run_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<CheckRun>(requestInfo, CheckRun.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a single check run using its `id`.**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates a check run for a specific commit in a repository.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(WithCheck_run_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(WithCheck_run_PatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithCheck_run_ItemRequestBuilder WithUrl(string rawUrl) {
            return new WithCheck_run_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes WithCheck_run_PatchRequestBodyMember1, WithCheck_run_PatchRequestBodyMember2
        /// </summary>
        public class WithCheck_run_PatchRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type WithCheck_run_PatchRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public WithCheck_run_PatchRequestBodyMember1? WithCheckRunPatchRequestBodyMember1 { get; set; }
#nullable restore
#else
            public WithCheck_run_PatchRequestBodyMember1 WithCheckRunPatchRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type WithCheck_run_PatchRequestBodyMember2</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public WithCheck_run_PatchRequestBodyMember2? WithCheckRunPatchRequestBodyMember2 { get; set; }
#nullable restore
#else
            public WithCheck_run_PatchRequestBodyMember2 WithCheckRunPatchRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type WithCheck_run_PatchRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public WithCheck_run_PatchRequestBodyMember1? WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember1 { get; set; }
#nullable restore
#else
            public WithCheck_run_PatchRequestBodyMember1 WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type WithCheck_run_PatchRequestBodyMember2</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public WithCheck_run_PatchRequestBodyMember2? WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember2 { get; set; }
#nullable restore
#else
            public WithCheck_run_PatchRequestBodyMember2 WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember2 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static WithCheck_run_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new WithCheck_run_PatchRequestBody();
                result.WithCheckRunPatchRequestBodyMember1 = new WithCheck_run_PatchRequestBodyMember1();
                result.WithCheckRunPatchRequestBodyMember2 = new WithCheck_run_PatchRequestBodyMember2();
                result.WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember1 = new WithCheck_run_PatchRequestBodyMember1();
                result.WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember2 = new WithCheck_run_PatchRequestBodyMember2();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(WithCheckRunPatchRequestBodyMember1 != null || WithCheckRunPatchRequestBodyMember2 != null || WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember1 != null || WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember2 != null) {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(WithCheckRunPatchRequestBodyMember1, WithCheckRunPatchRequestBodyMember2, WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember1, WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember2);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<WithCheck_run_PatchRequestBodyMember1>(null, WithCheckRunPatchRequestBodyMember1, WithCheckRunPatchRequestBodyMember2, WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember1, WithCheckRunPatchRequestBodyWithCheckRunPatchRequestBodyMember2);
            }
        }
    }
}
