// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Teams.Item.Members {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\teams\{team_slug}\members
    /// </summary>
    public class MembersRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new MembersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/members{?role*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MembersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/members{?role*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Team members will include the members of child teams.To list members in a team, the team must be visible to the authenticated user.
        /// API method documentation <see href="https://docs.github.com/rest/teams/members#list-team-members" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<SimpleUser>?> GetAsync(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<SimpleUser>> GetAsync(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<SimpleUser>(requestInfo, SimpleUser.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Team members will include the members of child teams.To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MembersRequestBuilder WithUrl(string rawUrl) {
            return new MembersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Team members will include the members of child teams.To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        public class MembersRequestBuilderGetQueryParameters {
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Filters members returned by their role in the team.</summary>
            [Obsolete("This property is deprecated, use roleAsGetRoleQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("role")]
            public string? Role { get; set; }
#nullable restore
#else
            [QueryParameter("role")]
            public string Role { get; set; }
#endif
            /// <summary>Filters members returned by their role in the team.</summary>
            [QueryParameter("role")]
            public GetRoleQueryParameterType? RoleAsGetRoleQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MembersRequestBuilderGetRequestConfiguration : RequestConfiguration<MembersRequestBuilderGetQueryParameters> {
        }
    }
}
