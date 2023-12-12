// <auto-generated/>
using GitHub.Orgs.Item.OrganizationRoles.Teams.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Orgs.Item.OrganizationRoles.Teams {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\organization-roles\teams
    /// </summary>
    public class TeamsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.orgs.item.organizationRoles.teams.item collection</summary>
        /// <param name="position">The slug of the team name.</param>
        public WithTeam_slugItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("team_slug", position);
            return new WithTeam_slugItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new TeamsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/organization-roles/teams", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TeamsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/organization-roles/teams", rawUrl) {
        }
    }
}
