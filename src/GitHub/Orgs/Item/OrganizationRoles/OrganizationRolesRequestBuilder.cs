// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.OrganizationRoles.Item;
using GitHub.Orgs.Item.OrganizationRoles.Teams;
using GitHub.Orgs.Item.OrganizationRoles.Users;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.OrganizationRoles {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\organization-roles
    /// </summary>
    public class OrganizationRolesRequestBuilder : BaseRequestBuilder {
        /// <summary>The teams property</summary>
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.orgs.item.organizationRoles.item collection</summary>
        /// <param name="position">The unique identifier of the role.</param>
        public WithRole_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("role_id", position);
            return new WithRole_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the GitHub.orgs.item.organizationRoles.item collection</summary>
        /// <param name="position">The unique identifier of the role.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithRole_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("role_id", position);
            return new WithRole_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new OrganizationRolesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationRolesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/organization-roles", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OrganizationRolesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationRolesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/organization-roles", rawUrl) {
        }
        /// <summary>
        /// Lists the organization roles available in this organization.To use this endpoint, the authenticated user must be one of:- An administrator for the organization.- A user, or a user on a team, with the fine-grained permissions of `read_organization_custom_org_role` in the organization.The authenticated user needs an access token with `admin:org` scope or a fine-grained personal access token with the `organization_custom_roles:read` permission to use this endpoint.GitHub Apps must have the `organization_custom_org_roles:read` organization permission to use this endpoint.For more information on organization roles, see &quot;[Managing people&apos;s access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/orgs/organization-roles#get-all-organization-roles-for-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationRolesGetResponse?> GetAsOrganizationRolesGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OrganizationRolesGetResponse> GetAsOrganizationRolesGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationRolesGetResponse>(requestInfo, OrganizationRolesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the organization roles available in this organization.To use this endpoint, the authenticated user must be one of:- An administrator for the organization.- A user, or a user on a team, with the fine-grained permissions of `read_organization_custom_org_role` in the organization.The authenticated user needs an access token with `admin:org` scope or a fine-grained personal access token with the `organization_custom_roles:read` permission to use this endpoint.GitHub Apps must have the `organization_custom_org_roles:read` organization permission to use this endpoint.For more information on organization roles, see &quot;[Managing people&apos;s access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/orgs/organization-roles#get-all-organization-roles-for-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsOrganizationRolesGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationRolesResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OrganizationRolesResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationRolesResponse>(requestInfo, OrganizationRolesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a custom organization role that can be assigned to users and teams, granting them specific permissions over the organization.To use this endpoint, the authenticated user must be one of:- An administrator for the organization.- A user, or a user on a team, with the fine-grained permissions of `write_organization_custom_org_role` in the organization.The authenticated user needs an access token with `admin:org` scope or a fine-grained personal access token with the `organization_custom_roles:write` permission to use this endpoint.GitHub Apps must have the `organization_custom_org_roles:write` organization permission to use this endpoint.For more information on custom organization roles, see &quot;[Managing people&apos;s access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/orgs/organization-roles#create-a-custom-organization-role" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationRole?> PostAsync(OrganizationRolesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OrganizationRole> PostAsync(OrganizationRolesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"409", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationRole>(requestInfo, OrganizationRole.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the organization roles available in this organization.To use this endpoint, the authenticated user must be one of:- An administrator for the organization.- A user, or a user on a team, with the fine-grained permissions of `read_organization_custom_org_role` in the organization.The authenticated user needs an access token with `admin:org` scope or a fine-grained personal access token with the `organization_custom_roles:read` permission to use this endpoint.GitHub Apps must have the `organization_custom_org_roles:read` organization permission to use this endpoint.For more information on organization roles, see &quot;[Managing people&apos;s access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles).&quot;
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a custom organization role that can be assigned to users and teams, granting them specific permissions over the organization.To use this endpoint, the authenticated user must be one of:- An administrator for the organization.- A user, or a user on a team, with the fine-grained permissions of `write_organization_custom_org_role` in the organization.The authenticated user needs an access token with `admin:org` scope or a fine-grained personal access token with the `organization_custom_roles:write` permission to use this endpoint.GitHub Apps must have the `organization_custom_org_roles:write` organization permission to use this endpoint.For more information on custom organization roles, see &quot;[Managing people&apos;s access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles).&quot;
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(OrganizationRolesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(OrganizationRolesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OrganizationRolesRequestBuilder WithUrl(string rawUrl) {
            return new OrganizationRolesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OrganizationRolesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OrganizationRolesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
