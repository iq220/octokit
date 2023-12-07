// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Octokit.Client.Repos.Item.Item.Git.Trees.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\git\trees\{tree_sha}
    /// </summary>
    public class WithTree_shaItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithTree_shaItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTree_shaItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/git/trees/{tree_sha}{?recursive*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithTree_shaItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTree_shaItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/git/trees/{tree_sha}{?recursive*}", rawUrl) {
        }
        /// <summary>
        /// Returns a single tree using the SHA1 value or ref name for that tree.If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.**Note**: The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.
        /// API method documentation <see href="https://docs.github.com/rest/git/trees#get-a-tree" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GitTree?> GetAsync(Action<RequestConfiguration<WithTree_shaItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GitTree> GetAsync(Action<RequestConfiguration<WithTree_shaItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GitTree>(requestInfo, GitTree.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a single tree using the SHA1 value or ref name for that tree.If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.**Note**: The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithTree_shaItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithTree_shaItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public WithTree_shaItemRequestBuilder WithUrl(string rawUrl) {
            return new WithTree_shaItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a single tree using the SHA1 value or ref name for that tree.If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.**Note**: The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.
        /// </summary>
        public class WithTree_shaItemRequestBuilderGetQueryParameters {
            /// <summary>Setting this parameter to any value returns the objects or subtrees referenced by the tree specified in `:tree_sha`. For example, setting `recursive` to any of the following will enable returning objects or subtrees: `0`, `1`, `&quot;true&quot;`, and `&quot;false&quot;`. Omit this parameter to prevent recursively returning objects or subtrees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("recursive")]
            public string? Recursive { get; set; }
#nullable restore
#else
            [QueryParameter("recursive")]
            public string Recursive { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithTree_shaItemRequestBuilderGetRequestConfiguration : RequestConfiguration<WithTree_shaItemRequestBuilderGetQueryParameters> {
        }
    }
}
