// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Teams.Item.Discussions.Item.Comments.Item.Reactions.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item.Teams.Item.Discussions.Item.Comments.Item.Reactions {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\teams\{team_slug}\discussions\{discussion_number}\comments\{comment_number}\reactions
    /// </summary>
    public class ReactionsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.orgs.item.teams.item.discussions.item.comments.item.reactions.item collection</summary>
        /// <param name="position">The unique identifier of the reaction.</param>
        public WithReaction_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("reaction_id", position);
            return new WithReaction_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ReactionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReactionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions{?content*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReactionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReactionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions{?content*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// List the reactions to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment). OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).**Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.
        /// API method documentation <see href="https://docs.github.com/rest/reactions/reactions#list-reactions-for-a-team-discussion-comment" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Reaction>?> GetAsync(Action<RequestConfiguration<ReactionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Reaction>> GetAsync(Action<RequestConfiguration<ReactionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<Reaction>(requestInfo, Reaction.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.**Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.
        /// API method documentation <see href="https://docs.github.com/rest/reactions/reactions#create-reaction-for-a-team-discussion-comment" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Reaction?> PostAsync(ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Reaction> PostAsync(ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<Reaction>(requestInfo, Reaction.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the reactions to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment). OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).**Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReactionsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReactionsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.**Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ReactionsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public ReactionsRequestBuilder WithUrl(string rawUrl) {
            return new ReactionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List the reactions to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment). OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).**Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.
        /// </summary>
        public class ReactionsRequestBuilderGetQueryParameters {
            /// <summary>Returns a single [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions). Omit this parameter to list all reactions to a team discussion comment.</summary>
            [QueryParameter("content")]
            public GetContentQueryParameterType? Content { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
