// <auto-generated/>
using GitHub.App.Hook.Config;
using GitHub.App.Hook.Deliveries;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.App.Hook {
    /// <summary>
    /// Builds and executes requests for operations under \app\hook
    /// </summary>
    public class HookRequestBuilder : BaseRequestBuilder {
        /// <summary>The config property</summary>
        public ConfigRequestBuilder Config { get =>
            new ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deliveries property</summary>
        public DeliveriesRequestBuilder Deliveries { get =>
            new DeliveriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new HookRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/hook", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new HookRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HookRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/hook", rawUrl) {
        }
    }
}
