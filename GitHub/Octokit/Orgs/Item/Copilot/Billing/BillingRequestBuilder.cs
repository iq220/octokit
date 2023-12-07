// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Models;
using Octokit.Client.Orgs.Item.Copilot.Billing.Seats;
using Octokit.Client.Orgs.Item.Copilot.Billing.Selected_teams;
using Octokit.Client.Orgs.Item.Copilot.Billing.Selected_users;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Octokit.Client.Orgs.Item.Copilot.Billing {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\copilot\billing
    /// </summary>
    public class BillingRequestBuilder : BaseRequestBuilder {
        /// <summary>The seats property</summary>
        public SeatsRequestBuilder Seats { get =>
            new SeatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The selected_teams property</summary>
        public Selected_teamsRequestBuilder Selected_teams { get =>
            new Selected_teamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The selected_users property</summary>
        public Selected_usersRequestBuilder Selected_users { get =>
            new Selected_usersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BillingRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BillingRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing", rawUrl) {
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Gets information about an organization&apos;s Copilot Business subscription, including seat breakdownand code matching policies. To configure these settings, go to your organization&apos;s settings on GitHub.com.For more information, see &quot;[Managing policies for Copilot Business in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-policies-for-copilot-business-in-your-organization)&quot;.Only organization owners can configure and view details about the organization&apos;s Copilot Business subscription. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-business#get-copilot-business-seat-information-and-settings-for-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CopilotOrganizationDetails?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CopilotOrganizationDetails> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CopilotOrganizationDetails>(requestInfo, CopilotOrganizationDetails.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Gets information about an organization&apos;s Copilot Business subscription, including seat breakdownand code matching policies. To configure these settings, go to your organization&apos;s settings on GitHub.com.For more information, see &quot;[Managing policies for Copilot Business in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-policies-for-copilot-business-in-your-organization)&quot;.Only organization owners can configure and view details about the organization&apos;s Copilot Business subscription. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
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
        public BillingRequestBuilder WithUrl(string rawUrl) {
            return new BillingRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BillingRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
