// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Models;
using Octokit.Client.Notifications.Threads;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Octokit.Client.Notifications {
    /// <summary>
    /// Builds and executes requests for operations under \notifications
    /// </summary>
    public class NotificationsRequestBuilder : BaseRequestBuilder {
        /// <summary>The threads property</summary>
        public ThreadsRequestBuilder Threads { get =>
            new ThreadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new NotificationsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NotificationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notifications{?all*,participating*,since*,before*,page*,per_page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new NotificationsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NotificationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notifications{?all*,participating*,since*,before*,page*,per_page*}", rawUrl) {
        }
        /// <summary>
        /// List all notifications for the current user, sorted by most recently updated.
        /// API method documentation <see href="https://docs.github.com/rest/activity/notifications#list-notifications-for-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<ThreadObject>?> GetAsync(Action<RequestConfiguration<NotificationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<ThreadObject>> GetAsync(Action<RequestConfiguration<NotificationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<ThreadObject>(requestInfo, ThreadObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Marks all notifications as &quot;read&quot; for the current user. If the number of notifications is too large to complete in one request, you will receive a `202 Accepted` status and GitHub will run an asynchronous process to mark notifications as &quot;read.&quot; To check whether any &quot;unread&quot; notifications remain, you can use the [List notifications for the authenticated user](https://docs.github.com/rest/activity/notifications#list-notifications-for-the-authenticated-user) endpoint and pass the query parameter `all=false`.
        /// API method documentation <see href="https://docs.github.com/rest/activity/notifications#mark-notifications-as-read" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<NotificationsPutResponse?> PutAsNotificationsPutResponseAsync(NotificationsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<NotificationsPutResponse> PutAsNotificationsPutResponseAsync(NotificationsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<NotificationsPutResponse>(requestInfo, NotificationsPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Marks all notifications as &quot;read&quot; for the current user. If the number of notifications is too large to complete in one request, you will receive a `202 Accepted` status and GitHub will run an asynchronous process to mark notifications as &quot;read.&quot; To check whether any &quot;unread&quot; notifications remain, you can use the [List notifications for the authenticated user](https://docs.github.com/rest/activity/notifications#list-notifications-for-the-authenticated-user) endpoint and pass the query parameter `all=false`.
        /// API method documentation <see href="https://docs.github.com/rest/activity/notifications#mark-notifications-as-read" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PutAsNotificationsPutResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<NotificationsResponse?> PutAsync(NotificationsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<NotificationsResponse> PutAsync(NotificationsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<NotificationsResponse>(requestInfo, NotificationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all notifications for the current user, sorted by most recently updated.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<NotificationsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<NotificationsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Marks all notifications as &quot;read&quot; for the current user. If the number of notifications is too large to complete in one request, you will receive a `202 Accepted` status and GitHub will run an asynchronous process to mark notifications as &quot;read.&quot; To check whether any &quot;unread&quot; notifications remain, you can use the [List notifications for the authenticated user](https://docs.github.com/rest/activity/notifications#list-notifications-for-the-authenticated-user) endpoint and pass the query parameter `all=false`.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(NotificationsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(NotificationsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public NotificationsRequestBuilder WithUrl(string rawUrl) {
            return new NotificationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List all notifications for the current user, sorted by most recently updated.
        /// </summary>
        public class NotificationsRequestBuilderGetQueryParameters {
            /// <summary>If `true`, show notifications marked as read.</summary>
            [QueryParameter("all")]
            public bool? All { get; set; }
            /// <summary>Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("before")]
            public DateTimeOffset? Before { get; set; }
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>If `true`, only shows notifications in which the user is directly participating or mentioned.</summary>
            [QueryParameter("participating")]
            public bool? Participating { get; set; }
            /// <summary>The number of results per page (max 50).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Only show results that were last updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
            [QueryParameter("since")]
            public DateTimeOffset? Since { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class NotificationsRequestBuilderGetRequestConfiguration : RequestConfiguration<NotificationsRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class NotificationsRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
