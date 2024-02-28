// <auto-generated/>
using GitHub.Repos.Item.Item.Codeowners.Errors;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Codeowners {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\codeowners
    /// </summary>
    public class CodeownersRequestBuilder : BaseRequestBuilder {
        /// <summary>The errors property</summary>
        public ErrorsRequestBuilder Errors { get =>
            new ErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="CodeownersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeownersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codeowners", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="CodeownersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeownersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codeowners", rawUrl) {
        }
    }
}
