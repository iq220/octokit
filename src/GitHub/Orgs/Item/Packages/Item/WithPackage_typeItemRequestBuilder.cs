// <auto-generated/>
using GitHub.Orgs.Item.Packages.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Orgs.Item.Packages.Item {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\packages\{package_type}
    /// </summary>
    public class WithPackage_typeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.orgs.item.packages.item.item collection</summary>
        /// <param name="position">The name of the package.</param>
        public WithPackage_nameItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("package_name", position);
            return new WithPackage_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithPackage_typeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPackage_typeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/packages/{package_type}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithPackage_typeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPackage_typeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/packages/{package_type}", rawUrl) {
        }
    }
}
