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
namespace GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\branches\{branch}\protection\restrictions\users
    /// </summary>
    public class UsersRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/restrictions/users", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/restrictions/users", rawUrl) {
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Removes the ability of a user to push to this branch.| Type    | Description                                                                                                                                   || ------- | --------------------------------------------------------------------------------------------------------------------------------------------- || `array` | Usernames of the people who should no longer have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#remove-user-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<SimpleUser>?> DeleteAsync(UsersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<SimpleUser>> DeleteAsync(UsersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<SimpleUser>(requestInfo, SimpleUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists the people who have push access to this branch.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#get-users-with-access-to-the-protected-branch" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<SimpleUser>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<SimpleUser>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<SimpleUser>(requestInfo, SimpleUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Grants the specified people push access for this branch.| Type    | Description                                                                                                                   || ------- | ----------------------------------------------------------------------------------------------------------------------------- || `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#add-user-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<SimpleUser>?> PostAsync(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<SimpleUser>> PostAsync(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<SimpleUser>(requestInfo, SimpleUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Replaces the list of people that have push access to this branch. This removes all people that previously had push access and grants push access to the new list of people.| Type    | Description                                                                                                                   || ------- | ----------------------------------------------------------------------------------------------------------------------------- || `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#set-user-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<SimpleUser>?> PutAsync(UsersPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<SimpleUser>> PutAsync(UsersPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<SimpleUser>(requestInfo, SimpleUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Removes the ability of a user to push to this branch.| Type    | Description                                                                                                                                   || ------- | --------------------------------------------------------------------------------------------------------------------------------------------- || `array` | Usernames of the people who should no longer have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(UsersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(UsersDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists the people who have push access to this branch.
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
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Grants the specified people push access for this branch.| Type    | Description                                                                                                                   || ------- | ----------------------------------------------------------------------------------------------------------------------------- || `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Replaces the list of people that have push access to this branch. This removes all people that previously had push access and grants push access to the new list of people.| Type    | Description                                                                                                                   || ------- | ----------------------------------------------------------------------------------------------------------------------------- || `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(UsersPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(UsersPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public UsersRequestBuilder WithUrl(string rawUrl) {
            return new UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes string, usersDeleteRequestBodyMember1
        /// </summary>
        public class UsersDeleteRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type usersDeleteRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1? UsersDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1 UsersDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? UsersDeleteRequestBodyString { get; set; }
#nullable restore
#else
            public string UsersDeleteRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type usersDeleteRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1? UsersDeleteRequestBodyUsersDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1 UsersDeleteRequestBodyUsersDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static UsersDeleteRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new UsersDeleteRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.UsersDeleteRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.UsersDeleteRequestBodyUsersDeleteRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                else if(parseNode.GetStringValue() is string usersDeleteRequestBodyStringValue) {
                    result.UsersDeleteRequestBodyString = usersDeleteRequestBodyStringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(UsersDeleteRequestBodyMember1 != null) {
                    return UsersDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                else if(UsersDeleteRequestBodyUsersDeleteRequestBodyMember1 != null) {
                    return UsersDeleteRequestBodyUsersDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(UsersDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1>(null, UsersDeleteRequestBodyMember1);
                }
                else if(UsersDeleteRequestBodyUsersDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersDeleteRequestBodyMember1>(null, UsersDeleteRequestBodyUsersDeleteRequestBodyMember1);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                else if(UsersDeleteRequestBodyString != null) {
                    writer.WriteStringValue(null, UsersDeleteRequestBodyString);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes string, usersPostRequestBodyMember1
        /// </summary>
        public class UsersPostRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type usersPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1? UsersPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1 UsersPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? UsersPostRequestBodyString { get; set; }
#nullable restore
#else
            public string UsersPostRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type usersPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1? UsersPostRequestBodyUsersPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1 UsersPostRequestBodyUsersPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static UsersPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new UsersPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.UsersPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.UsersPostRequestBodyUsersPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                else if(parseNode.GetStringValue() is string usersPostRequestBodyStringValue) {
                    result.UsersPostRequestBodyString = usersPostRequestBodyStringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(UsersPostRequestBodyMember1 != null) {
                    return UsersPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(UsersPostRequestBodyUsersPostRequestBodyMember1 != null) {
                    return UsersPostRequestBodyUsersPostRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(UsersPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1>(null, UsersPostRequestBodyMember1);
                }
                else if(UsersPostRequestBodyUsersPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPostRequestBodyMember1>(null, UsersPostRequestBodyUsersPostRequestBodyMember1);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                else if(UsersPostRequestBodyString != null) {
                    writer.WriteStringValue(null, UsersPostRequestBodyString);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes string, usersPutRequestBodyMember1
        /// </summary>
        public class UsersPutRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>Composed type representation for type usersPutRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1? UsersPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1 UsersPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? UsersPutRequestBodyString { get; set; }
#nullable restore
#else
            public string UsersPutRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type usersPutRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1? UsersPutRequestBodyUsersPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1 UsersPutRequestBodyUsersPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static UsersPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new UsersPutRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.UsersPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.UsersPutRequestBodyUsersPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                else if(parseNode.GetStringValue() is string usersPutRequestBodyStringValue) {
                    result.UsersPutRequestBodyString = usersPutRequestBodyStringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(UsersPutRequestBodyMember1 != null) {
                    return UsersPutRequestBodyMember1.GetFieldDeserializers();
                }
                else if(UsersPutRequestBodyUsersPutRequestBodyMember1 != null) {
                    return UsersPutRequestBodyUsersPutRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(UsersPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1>(null, UsersPutRequestBodyMember1);
                }
                else if(UsersPutRequestBodyUsersPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Users.UsersPutRequestBodyMember1>(null, UsersPutRequestBodyUsersPutRequestBodyMember1);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                else if(UsersPutRequestBodyString != null) {
                    writer.WriteStringValue(null, UsersPutRequestBodyString);
                }
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UsersRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UsersRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UsersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UsersRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
