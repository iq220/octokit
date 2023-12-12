// <auto-generated/>
using GitHub.Repositories.Item.Environments;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Repositories.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repositories\{repository_id}
    /// </summary>
    public class WithRepository_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The environments property</summary>
        public EnvironmentsRequestBuilder Environments { get =>
            new EnvironmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithRepository_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepository_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repositories/{repository_id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithRepository_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepository_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repositories/{repository_id}", rawUrl) {
        }
    }
}
