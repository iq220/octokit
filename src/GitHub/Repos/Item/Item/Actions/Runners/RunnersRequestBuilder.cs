// <auto-generated/>
using GitHub.Repos.Item.Item.Actions.Runners.Downloads;
using GitHub.Repos.Item.Item.Actions.Runners.GenerateJitconfig;
using GitHub.Repos.Item.Item.Actions.Runners.Item;
using GitHub.Repos.Item.Item.Actions.Runners.RegistrationToken;
using GitHub.Repos.Item.Item.Actions.Runners.RemoveToken;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runners {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\actions\runners
    /// </summary>
    public class RunnersRequestBuilder : BaseRequestBuilder {
        /// <summary>The downloads property</summary>
        public DownloadsRequestBuilder Downloads { get =>
            new DownloadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generateJitconfig property</summary>
        public GenerateJitconfigRequestBuilder GenerateJitconfig { get =>
            new GenerateJitconfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The registrationToken property</summary>
        public RegistrationTokenRequestBuilder RegistrationToken { get =>
            new RegistrationTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The removeToken property</summary>
        public RemoveTokenRequestBuilder RemoveToken { get =>
            new RemoveTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.repos.item.item.actions.runners.item collection</summary>
        /// <param name="position">Unique identifier of the self-hosted runner.</param>
        public WithRunner_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("runner_id", position);
            return new WithRunner_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new RunnersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunnersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/runners{?name*,page*,per_page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RunnersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RunnersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/runners{?name*,page*,per_page*}", rawUrl) {
        }
        /// <summary>
        /// Lists all self-hosted runners configured in a repository.Authenticated users must have admin access to the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/self-hosted-runners#list-self-hosted-runners-for-a-repository" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RunnersGetResponse?> GetAsync(Action<RequestConfiguration<RunnersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RunnersGetResponse> GetAsync(Action<RequestConfiguration<RunnersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<RunnersGetResponse>(requestInfo, RunnersGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all self-hosted runners configured in a repository.Authenticated users must have admin access to the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RunnersRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RunnersRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RunnersRequestBuilder WithUrl(string rawUrl) {
            return new RunnersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all self-hosted runners configured in a repository.Authenticated users must have admin access to the repository to use this endpoint.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        public class RunnersRequestBuilderGetQueryParameters {
            /// <summary>The name of a self-hosted runner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
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
