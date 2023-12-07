// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Orgs.Item.Actions.Cache.Usage {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\actions\cache\usage
    /// </summary>
    public class UsageRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new UsageRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/cache/usage", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UsageRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/cache/usage", rawUrl) {
        }
        /// <summary>
        /// Gets the total GitHub Actions cache usage for an organization.The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated.You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_admistration:read` permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/cache#get-github-actions-cache-usage-for-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ActionsCacheUsageOrgEnterprise?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ActionsCacheUsageOrgEnterprise> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ActionsCacheUsageOrgEnterprise>(requestInfo, ActionsCacheUsageOrgEnterprise.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the total GitHub Actions cache usage for an organization.The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated.You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_admistration:read` permission to use this endpoint.
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
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UsageRequestBuilder WithUrl(string rawUrl) {
            return new UsageRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UsageRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
