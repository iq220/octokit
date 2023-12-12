// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Codespaces.Devcontainers {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\codespaces\devcontainers
    /// </summary>
    public class DevcontainersRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new DevcontainersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DevcontainersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codespaces/devcontainers{?per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DevcontainersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DevcontainersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codespaces/devcontainers{?per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists the devcontainer.json files associated with a specified repository and the authenticated user. These filesspecify launchpoint configurations for codespaces created within the repository.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/codespaces/codespaces#list-devcontainer-configurations-in-a-repository-for-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DevcontainersGetResponse?> GetAsDevcontainersGetResponseAsync(Action<RequestConfiguration<DevcontainersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DevcontainersGetResponse> GetAsDevcontainersGetResponseAsync(Action<RequestConfiguration<DevcontainersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", BasicError.CreateFromDiscriminatorValue},
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DevcontainersGetResponse>(requestInfo, DevcontainersGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the devcontainer.json files associated with a specified repository and the authenticated user. These filesspecify launchpoint configurations for codespaces created within the repository.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/codespaces/codespaces#list-devcontainer-configurations-in-a-repository-for-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsDevcontainersGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DevcontainersResponse?> GetAsync(Action<RequestConfiguration<DevcontainersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DevcontainersResponse> GetAsync(Action<RequestConfiguration<DevcontainersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", BasicError.CreateFromDiscriminatorValue},
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DevcontainersResponse>(requestInfo, DevcontainersResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the devcontainer.json files associated with a specified repository and the authenticated user. These filesspecify launchpoint configurations for codespaces created within the repository.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DevcontainersRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DevcontainersRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public DevcontainersRequestBuilder WithUrl(string rawUrl) {
            return new DevcontainersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the devcontainer.json files associated with a specified repository and the authenticated user. These filesspecify launchpoint configurations for codespaces created within the repository.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.
        /// </summary>
        public class DevcontainersRequestBuilderGetQueryParameters {
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
        public class DevcontainersRequestBuilderGetRequestConfiguration : RequestConfiguration<DevcontainersRequestBuilderGetQueryParameters> {
        }
    }
}
