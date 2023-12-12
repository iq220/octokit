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
namespace GitHub.Repos.Item.Item.Codeowners.Errors {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\codeowners\errors
    /// </summary>
    public class ErrorsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ErrorsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ErrorsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codeowners/errors{?ref*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ErrorsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ErrorsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/codeowners/errors{?ref*}", rawUrl) {
        }
        /// <summary>
        /// List any syntax errors that are detected in the CODEOWNERSfile.For more information about the correct CODEOWNERS syntax,see &quot;[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/repos/repos#list-codeowners-errors" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CodeownersErrors?> GetAsync(Action<RequestConfiguration<ErrorsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CodeownersErrors> GetAsync(Action<RequestConfiguration<ErrorsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CodeownersErrors>(requestInfo, CodeownersErrors.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List any syntax errors that are detected in the CODEOWNERSfile.For more information about the correct CODEOWNERS syntax,see &quot;[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).&quot;
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ErrorsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ErrorsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public ErrorsRequestBuilder WithUrl(string rawUrl) {
            return new ErrorsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List any syntax errors that are detected in the CODEOWNERSfile.For more information about the correct CODEOWNERS syntax,see &quot;[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).&quot;
        /// </summary>
        public class ErrorsRequestBuilderGetQueryParameters {
            /// <summary>A branch, tag or commit name used to determine which version of the CODEOWNERS file to use. Default: the repository&apos;s default branch (e.g. `main`)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ref")]
            public string? Ref { get; set; }
#nullable restore
#else
            [QueryParameter("ref")]
            public string Ref { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ErrorsRequestBuilderGetRequestConfiguration : RequestConfiguration<ErrorsRequestBuilderGetQueryParameters> {
        }
    }
}
