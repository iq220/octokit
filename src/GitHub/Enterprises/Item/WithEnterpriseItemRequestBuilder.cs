// <auto-generated/>
using GitHub.Enterprises.Item.Dependabot;
using GitHub.Enterprises.Item.SecretScanning;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Enterprises.Item {
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}
    /// </summary>
    public class WithEnterpriseItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The dependabot property</summary>
        public DependabotRequestBuilder Dependabot { get =>
            new DependabotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secretScanning property</summary>
        public SecretScanningRequestBuilder SecretScanning { get =>
            new SecretScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithEnterpriseItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnterpriseItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithEnterpriseItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEnterpriseItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}", rawUrl) {
        }
    }
}
