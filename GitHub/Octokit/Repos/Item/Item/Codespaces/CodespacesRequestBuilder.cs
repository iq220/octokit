// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Repos.Item.Item.Codespaces.Devcontainers;
using GitHub.Octokit.Repos.Item.Item.Codespaces.Machines;
using GitHub.Octokit.Repos.Item.Item.Codespaces.New;
using GitHub.Octokit.Repos.Item.Item.Codespaces.Permissions_check;
using GitHub.Octokit.Repos.Item.Item.Codespaces.Secrets;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Codespaces {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\codespaces
    /// </summary>
    public class CodespacesRequestBuilder : BaseRequestBuilder {
        /// <summary>The devcontainers property</summary>
        public DevcontainersRequestBuilder Devcontainers { get =>
            new DevcontainersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The machines property</summary>
        public MachinesRequestBuilder Machines { get =>
            new MachinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The new property</summary>
        public NewRequestBuilder New { get =>
            new NewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The permissions_check property</summary>
        public Permissions_checkRequestBuilder Permissions_check { get =>
            new Permissions_checkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secrets property</summary>
        public SecretsRequestBuilder Secrets { get =>
            new SecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CodespacesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodespacesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codespaces{?per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CodespacesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodespacesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codespaces{?per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists the codespaces associated to a specified repository and the authenticated user.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/codespaces/codespaces#list-codespaces-in-a-repository-for-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CodespacesGetResponse?> GetAsCodespacesGetResponseAsync(Action<RequestConfiguration<CodespacesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CodespacesGetResponse> GetAsCodespacesGetResponseAsync(Action<RequestConfiguration<CodespacesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CodespacesGetResponse>(requestInfo, CodespacesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the codespaces associated to a specified repository and the authenticated user.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/codespaces/codespaces#list-codespaces-in-a-repository-for-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsCodespacesGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CodespacesResponse?> GetAsync(Action<RequestConfiguration<CodespacesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CodespacesResponse> GetAsync(Action<RequestConfiguration<CodespacesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CodespacesResponse>(requestInfo, CodespacesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a codespace owned by the authenticated user in the specified repository.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/codespaces/codespaces#create-a-codespace-in-a-repository" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Codespace?> PostAsync(CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Codespace> PostAsync(CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", BasicError.CreateFromDiscriminatorValue},
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"503", Codespace503Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Codespace>(requestInfo, Codespace.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the codespaces associated to a specified repository and the authenticated user.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CodespacesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CodespacesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a codespace owned by the authenticated user in the specified repository.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CodespacesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CodespacesRequestBuilder WithUrl(string rawUrl) {
            return new CodespacesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the codespaces associated to a specified repository and the authenticated user.You must authenticate using an access token with the `codespace` scope to use this endpoint.GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.
        /// </summary>
        public class CodespacesRequestBuilderGetQueryParameters {
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
        public class CodespacesRequestBuilderGetRequestConfiguration : RequestConfiguration<CodespacesRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CodespacesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
