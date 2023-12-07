// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Orgs.Item.Actions.Oidc.Customization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Octokit.Client.Orgs.Item.Actions.Oidc {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\actions\oidc
    /// </summary>
    public class OidcRequestBuilder : BaseRequestBuilder {
        /// <summary>The customization property</summary>
        public CustomizationRequestBuilder Customization { get =>
            new CustomizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new OidcRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OidcRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/oidc", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OidcRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OidcRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/oidc", rawUrl) {
        }
    }
}
