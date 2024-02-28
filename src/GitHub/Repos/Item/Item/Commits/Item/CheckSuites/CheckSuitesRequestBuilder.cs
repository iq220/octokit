// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Commits.Item.CheckSuites {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\commits\{commits-id}\check-suites
    /// </summary>
    public class CheckSuitesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="CheckSuitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckSuitesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/commits/{commits%2Did}/check-suites{?app_id*,check_name*,page*,per_page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="CheckSuitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckSuitesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/commits/{commits%2Did}/check-suites{?app_id*,check_name*,page*,per_page*}", rawUrl) {
        }
        /// <summary>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// API method documentation <see href="https://docs.github.com/rest/checks/suites#list-check-suites-for-a-git-reference" />
        /// </summary>
        /// <returns>A <see cref="CheckSuitesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CheckSuitesGetResponse?> GetAsync(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CheckSuitesGetResponse> GetAsync(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CheckSuitesGetResponse>(requestInfo, CheckSuitesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CheckSuitesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="CheckSuitesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CheckSuitesRequestBuilder WithUrl(string rawUrl) {
            return new CheckSuitesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.**Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        public class CheckSuitesRequestBuilderGetQueryParameters {
            /// <summary>Filters check suites by GitHub App `id`.</summary>
            [QueryParameter("app_id")]
            public int? AppId { get; set; }
            /// <summary>Returns check runs with the specified `name`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("check_name")]
            public string? CheckName { get; set; }
#nullable restore
#else
            [QueryParameter("check_name")]
            public string CheckName { get; set; }
#endif
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
