// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Octokit.Client.User.Migrations.Item.Repos.Item.Lock;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Octokit.Client.User.Migrations.Item.Repos.Item {
    /// <summary>
    /// Builds and executes requests for operations under \user\migrations\{migration_id}\repos\{repo_name}
    /// </summary>
    public class WithRepo_nameItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The lock property</summary>
        public LockRequestBuilder Lock { get =>
            new LockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithRepo_nameItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepo_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/migrations/{migration_id}/repos/{repo_name}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithRepo_nameItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepo_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user/migrations/{migration_id}/repos/{repo_name}", rawUrl) {
        }
    }
}
