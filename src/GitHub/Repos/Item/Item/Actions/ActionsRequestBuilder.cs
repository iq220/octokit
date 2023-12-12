// <auto-generated/>
using GitHub.Repos.Item.Item.Actions.Artifacts;
using GitHub.Repos.Item.Item.Actions.Cache;
using GitHub.Repos.Item.Item.Actions.Caches;
using GitHub.Repos.Item.Item.Actions.Jobs;
using GitHub.Repos.Item.Item.Actions.Oidc;
using GitHub.Repos.Item.Item.Actions.OrganizationSecrets;
using GitHub.Repos.Item.Item.Actions.OrganizationVariables;
using GitHub.Repos.Item.Item.Actions.Permissions;
using GitHub.Repos.Item.Item.Actions.Runners;
using GitHub.Repos.Item.Item.Actions.Runs;
using GitHub.Repos.Item.Item.Actions.Secrets;
using GitHub.Repos.Item.Item.Actions.Variables;
using GitHub.Repos.Item.Item.Actions.Workflows;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.Actions {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\actions
    /// </summary>
    public class ActionsRequestBuilder : BaseRequestBuilder {
        /// <summary>The artifacts property</summary>
        public ArtifactsRequestBuilder Artifacts { get =>
            new ArtifactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cache property</summary>
        public CacheRequestBuilder Cache { get =>
            new CacheRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The caches property</summary>
        public CachesRequestBuilder Caches { get =>
            new CachesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jobs property</summary>
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oidc property</summary>
        public OidcRequestBuilder Oidc { get =>
            new OidcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizationSecrets property</summary>
        public OrganizationSecretsRequestBuilder OrganizationSecrets { get =>
            new OrganizationSecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizationVariables property</summary>
        public OrganizationVariablesRequestBuilder OrganizationVariables { get =>
            new OrganizationVariablesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The permissions property</summary>
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The runners property</summary>
        public RunnersRequestBuilder Runners { get =>
            new RunnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The runs property</summary>
        public RunsRequestBuilder Runs { get =>
            new RunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secrets property</summary>
        public SecretsRequestBuilder Secrets { get =>
            new SecretsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The variables property</summary>
        public VariablesRequestBuilder Variables { get =>
            new VariablesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The workflows property</summary>
        public WorkflowsRequestBuilder Workflows { get =>
            new WorkflowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ActionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ActionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions", rawUrl) {
        }
    }
}
