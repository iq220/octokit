// <auto-generated/>
using GitHub.Repos.Item.Item.DependencyGraph.Compare;
using GitHub.Repos.Item.Item.DependencyGraph.Sbom;
using GitHub.Repos.Item.Item.DependencyGraph.Snapshots;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.DependencyGraph {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\dependency-graph
    /// </summary>
    public class DependencyGraphRequestBuilder : BaseRequestBuilder {
        /// <summary>The compare property</summary>
        public CompareRequestBuilder Compare { get =>
            new CompareRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sbom property</summary>
        public SbomRequestBuilder Sbom { get =>
            new SbomRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The snapshots property</summary>
        public SnapshotsRequestBuilder Snapshots { get =>
            new SnapshotsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DependencyGraphRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DependencyGraphRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/dependency-graph", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DependencyGraphRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DependencyGraphRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/dependency-graph", rawUrl) {
        }
    }
}
