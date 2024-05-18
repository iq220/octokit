// <auto-generated/>
using GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.Item.Repos.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Repos.Item.Item.CodeScanning.Codeql.VariantAnalyses.Item.Repos.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\code-scanning\codeql\variant-analyses\{codeql_variant_analysis_id}\repos\{repo_owner}
    /// </summary>
    public class WithRepo_ownerItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the GitHub.repos.item.item.codeScanning.codeql.variantAnalyses.item.repos.item.item collection</summary>
        /// <param name="position">The name of the variant analysis repository.</param>
        /// <returns>A <see cref="WithRepo_nameItemRequestBuilder"/></returns>
        public WithRepo_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("repo_name", position);
                return new WithRepo_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="WithRepo_ownerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepo_ownerItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/code-scanning/codeql/variant-analyses/{codeql_variant_analysis_id}/repos/{repo_owner}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithRepo_ownerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRepo_ownerItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/code-scanning/codeql/variant-analyses/{codeql_variant_analysis_id}/repos/{repo_owner}", rawUrl)
        {
        }
    }
}
