// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Orgs.Item.Actions.Cache;
using Octokit.Client.Orgs.Item.Actions.Oidc;
using Octokit.Client.Orgs.Item.Actions.Permissions;
using Octokit.Client.Orgs.Item.Actions.Runners;
using Octokit.Client.Orgs.Item.Actions.Secrets;
using Octokit.Client.Orgs.Item.Actions.Variables;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Octokit.Client.Orgs.Item.Actions {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\actions
    /// </summary>
    public class ActionsRequestBuilder : BaseRequestBuilder {
        /// <summary>The cache property</summary>
        public CacheRequestBuilder Cache { get =>
            new CacheRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oidc property</summary>
        public OidcRequestBuilder Oidc { get =>
            new OidcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The permissions property</summary>
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The runners property</summary>
        public RunnersRequestBuilder Runners { get =>
            new RunnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secrets property</summary>
        public SecretsRequestBuilder Secrets { get =>
            new SecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The variables property</summary>
        public VariablesRequestBuilder Variables { get =>
            new VariablesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ActionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ActionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions", rawUrl) {
        }
    }
}
