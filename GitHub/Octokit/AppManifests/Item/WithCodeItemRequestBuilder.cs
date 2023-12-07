// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Octokit.Client.AppManifests.Item.Conversions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Octokit.Client.AppManifests.Item {
    /// <summary>
    /// Builds and executes requests for operations under \app-manifests\{code}
    /// </summary>
    public class WithCodeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The conversions property</summary>
        public ConversionsRequestBuilder Conversions { get =>
            new ConversionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithCodeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCodeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app-manifests/{code}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithCodeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCodeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app-manifests/{code}", rawUrl) {
        }
    }
}
