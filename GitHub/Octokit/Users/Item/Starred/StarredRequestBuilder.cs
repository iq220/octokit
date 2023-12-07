// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Octokit.Client.Users.Item.Starred {
    /// <summary>
    /// Builds and executes requests for operations under \users\{username}\starred
    /// </summary>
    public class StarredRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new StarredRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StarredRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/starred{?sort*,direction*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new StarredRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StarredRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/starred{?sort*,direction*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists repositories a user has starred.You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header: `application/vnd.github.star+json`.
        /// API method documentation <see href="https://docs.github.com/rest/activity/starring#list-repositories-starred-by-a-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<StarredGetResponse?> GetAsStarredGetResponseAsync(Action<RequestConfiguration<StarredRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<StarredGetResponse> GetAsStarredGetResponseAsync(Action<RequestConfiguration<StarredRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<StarredGetResponse>(requestInfo, StarredGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists repositories a user has starred.You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header: `application/vnd.github.star+json`.
        /// API method documentation <see href="https://docs.github.com/rest/activity/starring#list-repositories-starred-by-a-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsStarredGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<StarredResponse?> GetAsync(Action<RequestConfiguration<StarredRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<StarredResponse> GetAsync(Action<RequestConfiguration<StarredRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<StarredResponse>(requestInfo, StarredResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists repositories a user has starred.You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header: `application/vnd.github.star+json`.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StarredRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StarredRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public StarredRequestBuilder WithUrl(string rawUrl) {
            return new StarredRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes repository, starredRepository
        /// </summary>
        public class StarredGetResponse : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<Octokit.Client.Users.Item.Starred.Repository>? Repository { get; set; }
#nullable restore
#else
            public List<Octokit.Client.Users.Item.Starred.Repository> Repository { get; set; }
#endif
            /// <summary>Composed type representation for type starredRepository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<Octokit.Client.Users.Item.Starred.StarredRepository>? StarredRepository { get; set; }
#nullable restore
#else
            public List<Octokit.Client.Users.Item.Starred.StarredRepository> StarredRepository { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static StarredGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new StarredGetResponse();
                if(parseNode.GetCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.Repository>(Octokit.Client.Users.Item.Starred.Repository.CreateFromDiscriminatorValue)?.ToList() is List<Octokit.Client.Users.Item.Starred.Repository> repositoryValue) {
                    result.Repository = repositoryValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.StarredRepository>(Octokit.Client.Users.Item.Starred.StarredRepository.CreateFromDiscriminatorValue)?.ToList() is List<Octokit.Client.Users.Item.Starred.StarredRepository> starredRepositoryValue) {
                    result.StarredRepository = starredRepositoryValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Repository != null) {
                    writer.WriteCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.Repository>(null, Repository);
                }
                else if(StarredRepository != null) {
                    writer.WriteCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.StarredRepository>(null, StarredRepository);
                }
            }
        }
        /// <summary>
        /// Lists repositories a user has starred.You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header: `application/vnd.github.star+json`.
        /// </summary>
        public class StarredRequestBuilderGetQueryParameters {
            /// <summary>The direction to sort the results by.</summary>
            [Obsolete("This property is deprecated, use directionAsGetDirectionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("direction")]
            public string? Direction { get; set; }
#nullable restore
#else
            [QueryParameter("direction")]
            public string Direction { get; set; }
#endif
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to.</summary>
            [Obsolete("This property is deprecated, use sortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class StarredRequestBuilderGetRequestConfiguration : RequestConfiguration<StarredRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Composed type wrapper for classes repository, starredRepository
        /// </summary>
        public class StarredResponse : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<Octokit.Client.Users.Item.Starred.Repository>? Repository { get; set; }
#nullable restore
#else
            public List<Octokit.Client.Users.Item.Starred.Repository> Repository { get; set; }
#endif
            /// <summary>Composed type representation for type starredRepository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<Octokit.Client.Users.Item.Starred.StarredRepository>? StarredRepository { get; set; }
#nullable restore
#else
            public List<Octokit.Client.Users.Item.Starred.StarredRepository> StarredRepository { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static StarredResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new StarredResponse();
                if(parseNode.GetCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.Repository>(Octokit.Client.Users.Item.Starred.Repository.CreateFromDiscriminatorValue)?.ToList() is List<Octokit.Client.Users.Item.Starred.Repository> repositoryValue) {
                    result.Repository = repositoryValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.StarredRepository>(Octokit.Client.Users.Item.Starred.StarredRepository.CreateFromDiscriminatorValue)?.ToList() is List<Octokit.Client.Users.Item.Starred.StarredRepository> starredRepositoryValue) {
                    result.StarredRepository = starredRepositoryValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Repository != null) {
                    writer.WriteCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.Repository>(null, Repository);
                }
                else if(StarredRepository != null) {
                    writer.WriteCollectionOfObjectValues<Octokit.Client.Users.Item.Starred.StarredRepository>(null, StarredRepository);
                }
            }
        }
    }
}
