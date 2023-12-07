// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Octokit.Client.Marketplace_listing.Accounts.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Octokit.Client.Marketplace_listing.Accounts {
    /// <summary>
    /// Builds and executes requests for operations under \marketplace_listing\accounts
    /// </summary>
    public class AccountsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Octokit.Client.marketplace_listing.accounts.item collection</summary>
        /// <param name="position">account_id parameter</param>
        public WithAccount_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("account_id", position);
            return new WithAccount_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Octokit.Client.marketplace_listing.accounts.item collection</summary>
        /// <param name="position">account_id parameter</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithAccount_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("account_id", position);
            return new WithAccount_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AccountsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/marketplace_listing/accounts", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AccountsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/marketplace_listing/accounts", rawUrl) {
        }
    }
}
