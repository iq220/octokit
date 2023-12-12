// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class RateLimitOverview_resources : IAdditionalDataHolder, IParsable {
        /// <summary>The actions_runner_registration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? ActionsRunnerRegistration { get; set; }
#nullable restore
#else
        public RateLimit ActionsRunnerRegistration { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The code_scanning_upload property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? CodeScanningUpload { get; set; }
#nullable restore
#else
        public RateLimit CodeScanningUpload { get; set; }
#endif
        /// <summary>The code_search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? CodeSearch { get; set; }
#nullable restore
#else
        public RateLimit CodeSearch { get; set; }
#endif
        /// <summary>The core property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? Core { get; set; }
#nullable restore
#else
        public RateLimit Core { get; set; }
#endif
        /// <summary>The dependency_snapshots property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? DependencySnapshots { get; set; }
#nullable restore
#else
        public RateLimit DependencySnapshots { get; set; }
#endif
        /// <summary>The graphql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? Graphql { get; set; }
#nullable restore
#else
        public RateLimit Graphql { get; set; }
#endif
        /// <summary>The integration_manifest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? IntegrationManifest { get; set; }
#nullable restore
#else
        public RateLimit IntegrationManifest { get; set; }
#endif
        /// <summary>The scim property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? Scim { get; set; }
#nullable restore
#else
        public RateLimit Scim { get; set; }
#endif
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? Search { get; set; }
#nullable restore
#else
        public RateLimit Search { get; set; }
#endif
        /// <summary>The source_import property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimit? SourceImport { get; set; }
#nullable restore
#else
        public RateLimit SourceImport { get; set; }
#endif
        /// <summary>
        /// Instantiates a new rateLimitOverview_resources and sets the default values.
        /// </summary>
        public RateLimitOverview_resources() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RateLimitOverview_resources CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RateLimitOverview_resources();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actions_runner_registration", n => { ActionsRunnerRegistration = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"code_scanning_upload", n => { CodeScanningUpload = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"code_search", n => { CodeSearch = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"core", n => { Core = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"dependency_snapshots", n => { DependencySnapshots = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"graphql", n => { Graphql = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"integration_manifest", n => { IntegrationManifest = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"scim", n => { Scim = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"search", n => { Search = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
                {"source_import", n => { SourceImport = n.GetObjectValue<RateLimit>(RateLimit.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RateLimit>("actions_runner_registration", ActionsRunnerRegistration);
            writer.WriteObjectValue<RateLimit>("code_scanning_upload", CodeScanningUpload);
            writer.WriteObjectValue<RateLimit>("code_search", CodeSearch);
            writer.WriteObjectValue<RateLimit>("core", Core);
            writer.WriteObjectValue<RateLimit>("dependency_snapshots", DependencySnapshots);
            writer.WriteObjectValue<RateLimit>("graphql", Graphql);
            writer.WriteObjectValue<RateLimit>("integration_manifest", IntegrationManifest);
            writer.WriteObjectValue<RateLimit>("scim", Scim);
            writer.WriteObjectValue<RateLimit>("search", Search);
            writer.WriteObjectValue<RateLimit>("source_import", SourceImport);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
