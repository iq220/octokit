// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class CodeScanningAnalysis : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnalysisKey { get; set; }
#nullable restore
#else
        public string AnalysisKey { get; set; }
#endif
        /// <summary>Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>The SHA of the commit to which the analysis you are uploading relates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitSha { get; set; }
#nullable restore
#else
        public string CommitSha { get; set; }
#endif
        /// <summary>The time that the analysis was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The deletable property</summary>
        public bool? Deletable { get; set; }
        /// <summary>Identifies the variable values associated with the environment in which this analysis was performed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Environment { get; set; }
#nullable restore
#else
        public string Environment { get; set; }
#endif
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Error { get; set; }
#nullable restore
#else
        public string Error { get; set; }
#endif
        /// <summary>Unique identifier for this analysis.</summary>
        public int? Id { get; set; }
        /// <summary>The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,`refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>The total number of results in the analysis.</summary>
        public int? ResultsCount { get; set; }
        /// <summary>The total number of rules used in the analysis.</summary>
        public int? RulesCount { get; set; }
        /// <summary>An identifier for the upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SarifId { get; set; }
#nullable restore
#else
        public string SarifId { get; set; }
#endif
        /// <summary>The tool property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CodeScanningAnalysisTool? Tool { get; set; }
#nullable restore
#else
        public CodeScanningAnalysisTool Tool { get; set; }
#endif
        /// <summary>The REST API URL of the analysis resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>Warning generated when processing the analysis</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Warning { get; set; }
#nullable restore
#else
        public string Warning { get; set; }
#endif
        /// <summary>
        /// Instantiates a new codeScanningAnalysis and sets the default values.
        /// </summary>
        public CodeScanningAnalysis() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodeScanningAnalysis CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodeScanningAnalysis();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"analysis_key", n => { AnalysisKey = n.GetStringValue(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"commit_sha", n => { CommitSha = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"deletable", n => { Deletable = n.GetBoolValue(); } },
                {"environment", n => { Environment = n.GetStringValue(); } },
                {"error", n => { Error = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"ref", n => { Ref = n.GetStringValue(); } },
                {"results_count", n => { ResultsCount = n.GetIntValue(); } },
                {"rules_count", n => { RulesCount = n.GetIntValue(); } },
                {"sarif_id", n => { SarifId = n.GetStringValue(); } },
                {"tool", n => { Tool = n.GetObjectValue<CodeScanningAnalysisTool>(CodeScanningAnalysisTool.CreateFromDiscriminatorValue); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"warning", n => { Warning = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("analysis_key", AnalysisKey);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("commit_sha", CommitSha);
            writer.WriteBoolValue("deletable", Deletable);
            writer.WriteStringValue("environment", Environment);
            writer.WriteStringValue("error", Error);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("ref", Ref);
            writer.WriteIntValue("results_count", ResultsCount);
            writer.WriteIntValue("rules_count", RulesCount);
            writer.WriteStringValue("sarif_id", SarifId);
            writer.WriteObjectValue<CodeScanningAnalysisTool>("tool", Tool);
            writer.WriteStringValue("warning", Warning);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
