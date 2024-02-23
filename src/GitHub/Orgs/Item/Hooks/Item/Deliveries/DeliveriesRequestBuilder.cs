// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Hooks.Item.Deliveries.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Hooks.Item.Deliveries {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\hooks\{hook_id}\deliveries
    /// </summary>
    public class DeliveriesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.orgs.item.hooks.item.deliveries.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="WithDelivery_ItemRequestBuilder"/></returns>
        public WithDelivery_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("delivery_id", position);
            return new WithDelivery_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="DeliveriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeliveriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/hooks/{hook_id}/deliveries{?cursor*,per_page*,redelivery*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="DeliveriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeliveriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/hooks/{hook_id}/deliveries{?cursor*,per_page*,redelivery*}", rawUrl) {
        }
        /// <summary>
        /// Returns a list of webhook deliveries for a webhook configured in an organization.
        /// API method documentation <see href="https://docs.github.com/rest/orgs/webhooks#list-deliveries-for-an-organization-webhook" />
        /// </summary>
        /// <returns>A List&lt;HookDeliveryItem&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 400 status code</exception>
        /// <exception cref="ValidationError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<HookDeliveryItem>?> GetAsync(Action<RequestConfiguration<DeliveriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<HookDeliveryItem>> GetAsync(Action<RequestConfiguration<DeliveriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<HookDeliveryItem>(requestInfo, HookDeliveryItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns a list of webhook deliveries for a webhook configured in an organization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeliveriesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DeliveriesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="DeliveriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeliveriesRequestBuilder WithUrl(string rawUrl) {
            return new DeliveriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of webhook deliveries for a webhook configured in an organization.
        /// </summary>
        public class DeliveriesRequestBuilderGetQueryParameters {
            /// <summary>Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cursor")]
            public string? Cursor { get; set; }
#nullable restore
#else
            [QueryParameter("cursor")]
            public string Cursor { get; set; }
#endif
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            [QueryParameter("redelivery")]
            public bool? Redelivery { get; set; }
        }
    }
}
