// <auto-generated/>
using GitHub.User.Email.Visibility;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.User.Email {
    /// <summary>
    /// Builds and executes requests for operations under \user\email
    /// </summary>
    public class EmailRequestBuilder : BaseRequestBuilder {
        /// <summary>The visibility property</summary>
        public VisibilityRequestBuilder Visibility { get =>
            new VisibilityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="EmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/email", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="EmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/email", rawUrl) {
        }
    }
}
