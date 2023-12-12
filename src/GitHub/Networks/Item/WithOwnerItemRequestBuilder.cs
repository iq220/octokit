// <auto-generated/>
using GitHub.Networks.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Networks.Item {
    /// <summary>
    /// Builds and executes requests for operations under \networks\{owner}
    /// </summary>
    public class WithOwnerItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.networks.item.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithRepoItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("repo", position);
            return new WithRepoItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithOwnerItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOwnerItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/networks/{owner}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithOwnerItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOwnerItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/networks/{owner}", rawUrl) {
        }
    }
}
