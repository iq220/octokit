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
namespace Octokit.Client.Users.Item.Ssh_signing_keys {
    /// <summary>
    /// Builds and executes requests for operations under \users\{username}\ssh_signing_keys
    /// </summary>
    public class Ssh_signing_keysRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new Ssh_signing_keysRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Ssh_signing_keysRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/ssh_signing_keys{?per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Ssh_signing_keysRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Ssh_signing_keysRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}/ssh_signing_keys{?per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists the SSH signing keys for a user. This operation is accessible by anyone.
        /// API method documentation <see href="https://docs.github.com/rest/users/ssh-signing-keys#list-ssh-signing-keys-for-a-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<SshSigningKey>?> GetAsync(Action<RequestConfiguration<Ssh_signing_keysRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<SshSigningKey>> GetAsync(Action<RequestConfiguration<Ssh_signing_keysRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<SshSigningKey>(requestInfo, SshSigningKey.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists the SSH signing keys for a user. This operation is accessible by anyone.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Ssh_signing_keysRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Ssh_signing_keysRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public Ssh_signing_keysRequestBuilder WithUrl(string rawUrl) {
            return new Ssh_signing_keysRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the SSH signing keys for a user. This operation is accessible by anyone.
        /// </summary>
        public class Ssh_signing_keysRequestBuilderGetQueryParameters {
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
        public class Ssh_signing_keysRequestBuilderGetRequestConfiguration : RequestConfiguration<Ssh_signing_keysRequestBuilderGetQueryParameters> {
        }
    }
}
