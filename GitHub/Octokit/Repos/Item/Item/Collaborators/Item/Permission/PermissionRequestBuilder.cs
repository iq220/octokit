// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Collaborators.Item.Permission {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\collaborators\{username}\permission
    /// </summary>
    public class PermissionRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new PermissionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/collaborators/{username}/permission", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PermissionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/collaborators/{username}/permission", rawUrl) {
        }
        /// <summary>
        /// Checks the repository permission of a collaborator. The possible repositorypermissions are `admin`, `write`, `read`, and `none`.*Note*: The `permission` attribute provides the legacy base roles of `admin`, `write`, `read`, and `none`, where the`maintain` role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role assigned to thecollaborator, see the `role_name` attribute, which will provide the full role name, including custom roles. The`permissions` hash can also be used to determine which base level of access the collaborator has to the repository.
        /// API method documentation <see href="https://docs.github.com/rest/collaborators/collaborators#get-repository-permissions-for-a-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RepositoryCollaboratorPermission?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RepositoryCollaboratorPermission> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RepositoryCollaboratorPermission>(requestInfo, RepositoryCollaboratorPermission.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Checks the repository permission of a collaborator. The possible repositorypermissions are `admin`, `write`, `read`, and `none`.*Note*: The `permission` attribute provides the legacy base roles of `admin`, `write`, `read`, and `none`, where the`maintain` role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role assigned to thecollaborator, see the `role_name` attribute, which will provide the full role name, including custom roles. The`permissions` hash can also be used to determine which base level of access the collaborator has to the repository.
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
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PermissionRequestBuilder WithUrl(string rawUrl) {
            return new PermissionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class PermissionRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
