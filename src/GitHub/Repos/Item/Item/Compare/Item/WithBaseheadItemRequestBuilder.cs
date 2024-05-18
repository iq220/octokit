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
namespace GitHub.Repos.Item.Item.Compare.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\compare\{basehead}
    /// </summary>
    public class WithBaseheadItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="WithBaseheadItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBaseheadItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/compare/{basehead}{?page*,per_page*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithBaseheadItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBaseheadItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/compare/{basehead}{?page*,per_page*}", rawUrl)
        {
        }
        /// <summary>
        /// Compares two commits against one another. You can compare refs (branches or tags) and commit SHAs in the same repository, or you can compare refs and commit SHAs that exist in different repositories within the same repository network, including fork branches. For more information about how to view a repository&apos;s network, see &quot;[Understanding connections between repositories](https://docs.github.com/repositories/viewing-activity-and-data-for-your-repository/understanding-connections-between-repositories).&quot;This endpoint is equivalent to running the `git log BASE..HEAD` command, but it returns commits in a different order. The `git log BASE..HEAD` command returns commits in reverse chronological order, whereas the API returns commits in chronological order.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.diff`**: Returns the diff of the commit.- **`application/vnd.github.patch`**: Returns the patch of the commit. Diffs with binary data will have no `patch` property.The API response includes details about the files that were changed between the two commits. This includes the status of the change (if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a `renamed` status have a `previous_filename` field showing the previous filename of the file, and files with a `modified` status have a `patch` field showing the changes made to the file.When calling this endpoint without any paging parameter (`per_page` or `page`), the returned list is limited to 250 commits, and the last commit in the list is the most recent of the entire comparison.**Working with large comparisons**To process a response with a large number of commits, use a query parameter (`per_page` or `page`) to paginate the results. When using pagination:- The list of changed files is only shown on the first page of results, but it includes all changed files for the entire comparison.- The results are returned in chronological order, but the last commit in the returned list may not be the most recent one in the entire set if there are more pages of results.For more information on working with pagination, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).&quot;**Signature verification object**The response will include a `verification` object that describes the result of verifying the commit&apos;s signature. The `verification` object includes the following fields:| Name | Type | Description || ---- | ---- | ----------- || `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. || `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. || `signature` | `string` | The signature that was extracted from the commit. || `payload` | `string` | The value that was signed. |These are the possible values for `reason` in the `verification` object:| Value | Description || ----- | ----------- || `expired_key` | The key that made the signature is expired. || `not_signing_key` | The &quot;signing&quot; flag is not among the usage flags in the GPG key that made the signature. || `gpgverify_error` | There was an error communicating with the signature verification service. || `gpgverify_unavailable` | The signature verification service is currently unavailable. || `unsigned` | The object does not include a signature. || `unknown_signature_type` | A non-PGP signature was found in the commit. || `no_user` | No user was associated with the `committer` email address in the commit. || `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. || `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. || `unknown_key` | The key that made the signature has not been registered with any user&apos;s account. || `malformed_signature` | There was an error parsing the signature. || `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. || `valid` | None of the above errors applied, so the signature is considered to be verified. |
        /// API method documentation <see href="https://docs.github.com/rest/commits/commits#compare-two-commits" />
        /// </summary>
        /// <returns>A <see cref="CommitComparison"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
        /// <exception cref="CommitComparison503Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CommitComparison?> GetAsync(Action<RequestConfiguration<WithBaseheadItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CommitComparison> GetAsync(Action<RequestConfiguration<WithBaseheadItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", BasicError.CreateFromDiscriminatorValue },
                { "500", BasicError.CreateFromDiscriminatorValue },
                { "503", CommitComparison503Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<CommitComparison>(requestInfo, CommitComparison.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Compares two commits against one another. You can compare refs (branches or tags) and commit SHAs in the same repository, or you can compare refs and commit SHAs that exist in different repositories within the same repository network, including fork branches. For more information about how to view a repository&apos;s network, see &quot;[Understanding connections between repositories](https://docs.github.com/repositories/viewing-activity-and-data-for-your-repository/understanding-connections-between-repositories).&quot;This endpoint is equivalent to running the `git log BASE..HEAD` command, but it returns commits in a different order. The `git log BASE..HEAD` command returns commits in reverse chronological order, whereas the API returns commits in chronological order.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.diff`**: Returns the diff of the commit.- **`application/vnd.github.patch`**: Returns the patch of the commit. Diffs with binary data will have no `patch` property.The API response includes details about the files that were changed between the two commits. This includes the status of the change (if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a `renamed` status have a `previous_filename` field showing the previous filename of the file, and files with a `modified` status have a `patch` field showing the changes made to the file.When calling this endpoint without any paging parameter (`per_page` or `page`), the returned list is limited to 250 commits, and the last commit in the list is the most recent of the entire comparison.**Working with large comparisons**To process a response with a large number of commits, use a query parameter (`per_page` or `page`) to paginate the results. When using pagination:- The list of changed files is only shown on the first page of results, but it includes all changed files for the entire comparison.- The results are returned in chronological order, but the last commit in the returned list may not be the most recent one in the entire set if there are more pages of results.For more information on working with pagination, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).&quot;**Signature verification object**The response will include a `verification` object that describes the result of verifying the commit&apos;s signature. The `verification` object includes the following fields:| Name | Type | Description || ---- | ---- | ----------- || `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. || `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. || `signature` | `string` | The signature that was extracted from the commit. || `payload` | `string` | The value that was signed. |These are the possible values for `reason` in the `verification` object:| Value | Description || ----- | ----------- || `expired_key` | The key that made the signature is expired. || `not_signing_key` | The &quot;signing&quot; flag is not among the usage flags in the GPG key that made the signature. || `gpgverify_error` | There was an error communicating with the signature verification service. || `gpgverify_unavailable` | The signature verification service is currently unavailable. || `unsigned` | The object does not include a signature. || `unknown_signature_type` | A non-PGP signature was found in the commit. || `no_user` | No user was associated with the `committer` email address in the commit. || `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. || `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. || `unknown_key` | The key that made the signature has not been registered with any user&apos;s account. || `malformed_signature` | There was an error parsing the signature. || `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. || `valid` | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithBaseheadItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithBaseheadItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithBaseheadItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithBaseheadItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithBaseheadItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Compares two commits against one another. You can compare refs (branches or tags) and commit SHAs in the same repository, or you can compare refs and commit SHAs that exist in different repositories within the same repository network, including fork branches. For more information about how to view a repository&apos;s network, see &quot;[Understanding connections between repositories](https://docs.github.com/repositories/viewing-activity-and-data-for-your-repository/understanding-connections-between-repositories).&quot;This endpoint is equivalent to running the `git log BASE..HEAD` command, but it returns commits in a different order. The `git log BASE..HEAD` command returns commits in reverse chronological order, whereas the API returns commits in chronological order.This endpoint supports the following custom media types. For more information, see &quot;[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).&quot;- **`application/vnd.github.diff`**: Returns the diff of the commit.- **`application/vnd.github.patch`**: Returns the patch of the commit. Diffs with binary data will have no `patch` property.The API response includes details about the files that were changed between the two commits. This includes the status of the change (if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a `renamed` status have a `previous_filename` field showing the previous filename of the file, and files with a `modified` status have a `patch` field showing the changes made to the file.When calling this endpoint without any paging parameter (`per_page` or `page`), the returned list is limited to 250 commits, and the last commit in the list is the most recent of the entire comparison.**Working with large comparisons**To process a response with a large number of commits, use a query parameter (`per_page` or `page`) to paginate the results. When using pagination:- The list of changed files is only shown on the first page of results, but it includes all changed files for the entire comparison.- The results are returned in chronological order, but the last commit in the returned list may not be the most recent one in the entire set if there are more pages of results.For more information on working with pagination, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).&quot;**Signature verification object**The response will include a `verification` object that describes the result of verifying the commit&apos;s signature. The `verification` object includes the following fields:| Name | Type | Description || ---- | ---- | ----------- || `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. || `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. || `signature` | `string` | The signature that was extracted from the commit. || `payload` | `string` | The value that was signed. |These are the possible values for `reason` in the `verification` object:| Value | Description || ----- | ----------- || `expired_key` | The key that made the signature is expired. || `not_signing_key` | The &quot;signing&quot; flag is not among the usage flags in the GPG key that made the signature. || `gpgverify_error` | There was an error communicating with the signature verification service. || `gpgverify_unavailable` | The signature verification service is currently unavailable. || `unsigned` | The object does not include a signature. || `unknown_signature_type` | A non-PGP signature was found in the commit. || `no_user` | No user was associated with the `committer` email address in the commit. || `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. || `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. || `unknown_key` | The key that made the signature has not been registered with any user&apos;s account. || `malformed_signature` | There was an error parsing the signature. || `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. || `valid` | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        public class WithBaseheadItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
    }
}
