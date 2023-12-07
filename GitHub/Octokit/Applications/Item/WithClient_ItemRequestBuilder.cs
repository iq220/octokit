// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Applications.Item.Grant;
using Octokit.Client.Applications.Item.Token;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Octokit.Client.Applications.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{client_id}
    /// </summary>
    public class WithClient_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The grant property</summary>
        public GrantRequestBuilder Grant { get =>
            new GrantRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The token property</summary>
        public TokenRequestBuilder Token { get =>
            new TokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithClient_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithClient_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{client_id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithClient_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithClient_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{client_id}", rawUrl) {
        }
    }
}
