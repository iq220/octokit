// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Octokit.Client.Repos.Item.Item.Actions.Runs.Item.Artifacts {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\actions\runs\{run_id}\artifacts
    /// </summary>
    public class ArtifactsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ArtifactsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtifactsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/runs/{run_id}/artifacts{?per_page*,page*,name*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ArtifactsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtifactsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/runs/{run_id}/artifacts{?per_page*,page*,name*}", rawUrl) {
        }
        /// <summary>
        /// Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/artifacts#list-workflow-run-artifacts" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ArtifactsGetResponse?> GetAsArtifactsGetResponseAsync(Action<RequestConfiguration<ArtifactsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ArtifactsGetResponse> GetAsArtifactsGetResponseAsync(Action<RequestConfiguration<ArtifactsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ArtifactsGetResponse>(requestInfo, ArtifactsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/artifacts#list-workflow-run-artifacts" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsArtifactsGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ArtifactsResponse?> GetAsync(Action<RequestConfiguration<ArtifactsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ArtifactsResponse> GetAsync(Action<RequestConfiguration<ArtifactsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ArtifactsResponse>(requestInfo, ArtifactsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ArtifactsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ArtifactsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public ArtifactsRequestBuilder WithUrl(string rawUrl) {
            return new ArtifactsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// </summary>
        public class ArtifactsRequestBuilderGetQueryParameters {
            /// <summary>The name field of an artifact. When specified, only artifacts with this name will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ArtifactsRequestBuilderGetRequestConfiguration : RequestConfiguration<ArtifactsRequestBuilderGetQueryParameters> {
        }
    }
}
