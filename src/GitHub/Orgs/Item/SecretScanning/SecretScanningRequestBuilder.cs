// <auto-generated/>
using GitHub.Orgs.Item.SecretScanning.Alerts;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Orgs.Item.SecretScanning {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\secret-scanning
    /// </summary>
    public class SecretScanningRequestBuilder : BaseRequestBuilder {
        /// <summary>The alerts property</summary>
        public AlertsRequestBuilder Alerts { get =>
            new AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SecretScanningRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecretScanningRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/secret-scanning", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="SecretScanningRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecretScanningRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/secret-scanning", rawUrl) {
        }
    }
}
