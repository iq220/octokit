// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Issues.Item.Assignees;
using GitHub.Repos.Item.Item.Issues.Item.Comments;
using GitHub.Repos.Item.Item.Issues.Item.Events;
using GitHub.Repos.Item.Item.Issues.Item.Labels;
using GitHub.Repos.Item.Item.Issues.Item.Lock;
using GitHub.Repos.Item.Item.Issues.Item.Reactions;
using GitHub.Repos.Item.Item.Issues.Item.Timeline;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Issues.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\issues\{issue_number}
    /// </summary>
    public class WithIssue_numberItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The assignees property</summary>
        public AssigneesRequestBuilder Assignees { get =>
            new AssigneesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comments property</summary>
        public CommentsRequestBuilder Comments { get =>
            new CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The labels property</summary>
        public LabelsRequestBuilder Labels { get =>
            new LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lock property</summary>
        public LockRequestBuilder Lock { get =>
            new LockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reactions property</summary>
        public ReactionsRequestBuilder Reactions { get =>
            new ReactionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timeline property</summary>
        public TimelineRequestBuilder Timeline { get =>
            new TimelineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithIssue_numberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithIssue_numberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/issues/{issue_number}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithIssue_numberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithIssue_numberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/issues/{issue_number}", rawUrl) {
        }
        /// <summary>
        /// The API returns a [`301 Moved Permanently` status](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api#follow-redirects) if the issue was[transferred](https://docs.github.com/articles/transferring-an-issue-to-another-repository/) to another repository. Ifthe issue was transferred to or deleted from a repository where the authenticated user lacks read access, the APIreturns a `404 Not Found` status. If the issue was deleted from a repository where the authenticated user has readaccess, the API returns a `410 Gone` status. To receive webhook events for transferred and deleted issues, subscribeto the [`issues`](https://docs.github.com/webhooks/event-payloads/#issues) webhook.**Note**: GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For thisreason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests bythe `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pullrequest id, use the &quot;[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)&quot; endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/issues/issues#get-an-issue" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Issue?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Issue> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"410", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Issue>(requestInfo, Issue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Issue owners and users with push access can edit an issue.
        /// API method documentation <see href="https://docs.github.com/rest/issues/issues#update-an-issue" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Issue?> PatchAsync(WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Issue> PatchAsync(WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"410", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
                {"503", Issue503Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Issue>(requestInfo, Issue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The API returns a [`301 Moved Permanently` status](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api#follow-redirects) if the issue was[transferred](https://docs.github.com/articles/transferring-an-issue-to-another-repository/) to another repository. Ifthe issue was transferred to or deleted from a repository where the authenticated user lacks read access, the APIreturns a `404 Not Found` status. If the issue was deleted from a repository where the authenticated user has readaccess, the API returns a `410 Gone` status. To receive webhook events for transferred and deleted issues, subscribeto the [`issues`](https://docs.github.com/webhooks/event-payloads/#issues) webhook.**Note**: GitHub&apos;s REST API considers every pull request an issue, but not every issue is a pull request. For thisreason, &quot;Issues&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests bythe `pull_request` key. Be aware that the `id` of a pull request returned from &quot;Issues&quot; endpoints will be an _issue id_. To find out the pullrequest id, use the &quot;[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)&quot; endpoint.
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
        /// Issue owners and users with push access can edit an issue.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(WithIssue_numberPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public WithIssue_numberItemRequestBuilder WithUrl(string rawUrl) {
            return new WithIssue_numberItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithIssue_numberItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithIssue_numberItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
