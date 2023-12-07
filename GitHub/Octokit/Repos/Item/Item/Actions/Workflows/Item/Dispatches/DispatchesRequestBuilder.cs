// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Octokit.Client.Repos.Item.Item.Actions.Workflows.Item.Dispatches {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\actions\workflows\{workflow_id}\dispatches
    /// </summary>
    public class DispatchesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new DispatchesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DispatchesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/workflows/{workflow_id}/dispatches", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DispatchesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DispatchesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/workflows/{workflow_id}/dispatches", rawUrl) {
        }
        /// <summary>
        /// You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see &quot;[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch).&quot;You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint. For more information, see &quot;[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/actions/workflows#create-a-workflow-dispatch-event" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(DispatchesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(DispatchesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see &quot;[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch).&quot;You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint. For more information, see &quot;[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line).&quot;
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(DispatchesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(DispatchesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DispatchesRequestBuilder WithUrl(string rawUrl) {
            return new DispatchesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DispatchesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
