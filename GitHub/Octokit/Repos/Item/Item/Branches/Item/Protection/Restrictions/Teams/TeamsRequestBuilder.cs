// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\branches\{branch}\protection\restrictions\teams
    /// </summary>
    public class TeamsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new TeamsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/restrictions/teams", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TeamsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/restrictions/teams", rawUrl) {
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Removes the ability of a team to push to this branch. You can also remove push access for child teams.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#remove-team-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Team>?> DeleteAsync(TeamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Team>> DeleteAsync(TeamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Team>(requestInfo, Team.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists the teams who have push access to this branch. The list includes child teams.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#get-teams-with-access-to-the-protected-branch" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Team>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Team>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Team>(requestInfo, Team.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Grants the specified teams push access for this branch. You can also give push access to child teams.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#add-team-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Team>?> PostAsync(TeamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Team>> PostAsync(TeamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Team>(requestInfo, Team.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Replaces the list of teams that have push access to this branch. This removes all teams that previously had push access and grants push access to the new list of teams. Team restrictions include child teams.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#set-team-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Team>?> PutAsync(TeamsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Team>> PutAsync(TeamsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Team>(requestInfo, Team.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Removes the ability of a team to push to this branch. You can also remove push access for child teams.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(TeamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(TeamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists the teams who have push access to this branch. The list includes child teams.
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
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Grants the specified teams push access for this branch. You can also give push access to child teams.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(TeamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(TeamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Replaces the list of teams that have push access to this branch. This removes all teams that previously had push access and grants push access to the new list of teams. Team restrictions include child teams.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(TeamsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(TeamsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TeamsRequestBuilder WithUrl(string rawUrl) {
            return new TeamsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes string, teamsDeleteRequestBodyMember1
        /// </summary>
        public class TeamsDeleteRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type teamsDeleteRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1? TeamsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1 TeamsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? TeamsDeleteRequestBodyString { get; set; }
#nullable restore
#else
            public string TeamsDeleteRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type teamsDeleteRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1? TeamsDeleteRequestBodyTeamsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1 TeamsDeleteRequestBodyTeamsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static TeamsDeleteRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new TeamsDeleteRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.TeamsDeleteRequestBodyMember1 = new Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.TeamsDeleteRequestBodyTeamsDeleteRequestBodyMember1 = new Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                else if(parseNode.GetStringValue() is string teamsDeleteRequestBodyStringValue) {
                    result.TeamsDeleteRequestBodyString = teamsDeleteRequestBodyStringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(TeamsDeleteRequestBodyMember1 != null) {
                    return TeamsDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                else if(TeamsDeleteRequestBodyTeamsDeleteRequestBodyMember1 != null) {
                    return TeamsDeleteRequestBodyTeamsDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(TeamsDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1>(null, TeamsDeleteRequestBodyMember1);
                }
                else if(TeamsDeleteRequestBodyTeamsDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsDeleteRequestBodyMember1>(null, TeamsDeleteRequestBodyTeamsDeleteRequestBodyMember1);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                else if(TeamsDeleteRequestBodyString != null) {
                    writer.WriteStringValue(null, TeamsDeleteRequestBodyString);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes string, teamsPostRequestBodyMember1
        /// </summary>
        public class TeamsPostRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type teamsPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1? TeamsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1 TeamsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? TeamsPostRequestBodyString { get; set; }
#nullable restore
#else
            public string TeamsPostRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type teamsPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1? TeamsPostRequestBodyTeamsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1 TeamsPostRequestBodyTeamsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static TeamsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new TeamsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.TeamsPostRequestBodyMember1 = new Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.TeamsPostRequestBodyTeamsPostRequestBodyMember1 = new Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                else if(parseNode.GetStringValue() is string teamsPostRequestBodyStringValue) {
                    result.TeamsPostRequestBodyString = teamsPostRequestBodyStringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(TeamsPostRequestBodyMember1 != null) {
                    return TeamsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(TeamsPostRequestBodyTeamsPostRequestBodyMember1 != null) {
                    return TeamsPostRequestBodyTeamsPostRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(TeamsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1>(null, TeamsPostRequestBodyMember1);
                }
                else if(TeamsPostRequestBodyTeamsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPostRequestBodyMember1>(null, TeamsPostRequestBodyTeamsPostRequestBodyMember1);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                else if(TeamsPostRequestBodyString != null) {
                    writer.WriteStringValue(null, TeamsPostRequestBodyString);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes string, teamsPutRequestBodyMember1
        /// </summary>
        public class TeamsPutRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type teamsPutRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1? TeamsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1 TeamsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? TeamsPutRequestBodyString { get; set; }
#nullable restore
#else
            public string TeamsPutRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type teamsPutRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1? TeamsPutRequestBodyTeamsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1 TeamsPutRequestBodyTeamsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static TeamsPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new TeamsPutRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.TeamsPutRequestBodyMember1 = new Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.TeamsPutRequestBodyTeamsPutRequestBodyMember1 = new Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                else if(parseNode.GetStringValue() is string teamsPutRequestBodyStringValue) {
                    result.TeamsPutRequestBodyString = teamsPutRequestBodyStringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(TeamsPutRequestBodyMember1 != null) {
                    return TeamsPutRequestBodyMember1.GetFieldDeserializers();
                }
                else if(TeamsPutRequestBodyTeamsPutRequestBodyMember1 != null) {
                    return TeamsPutRequestBodyTeamsPutRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(TeamsPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1>(null, TeamsPutRequestBodyMember1);
                }
                else if(TeamsPutRequestBodyTeamsPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<Octokit.Client.Repos.Item.Item.Branches.Item.Protection.Restrictions.Teams.TeamsPutRequestBodyMember1>(null, TeamsPutRequestBodyTeamsPutRequestBodyMember1);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                else if(TeamsPutRequestBodyString != null) {
                    writer.WriteStringValue(null, TeamsPutRequestBodyString);
                }
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TeamsRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TeamsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TeamsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TeamsRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
