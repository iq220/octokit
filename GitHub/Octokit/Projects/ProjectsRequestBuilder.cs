// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Projects.Columns;
using Octokit.Client.Projects.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Octokit.Client.Projects {
    /// <summary>
    /// Builds and executes requests for operations under \projects
    /// </summary>
    public class ProjectsRequestBuilder : BaseRequestBuilder {
        /// <summary>The columns property</summary>
        public ColumnsRequestBuilder Columns { get =>
            new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Octokit.Client.projects.item collection</summary>
        /// <param name="position">The unique identifier of the project.</param>
        public WithProject_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("project_id", position);
            return new WithProject_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Octokit.Client.projects.item collection</summary>
        /// <param name="position">The unique identifier of the project.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithProject_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("project_id", position);
            return new WithProject_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ProjectsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProjectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ProjectsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProjectsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects", rawUrl) {
        }
    }
}
