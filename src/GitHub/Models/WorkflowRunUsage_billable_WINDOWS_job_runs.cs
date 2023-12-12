// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class WorkflowRunUsage_billable_WINDOWS_job_runs : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The duration_ms property</summary>
        public int? DurationMs { get; set; }
        /// <summary>The job_id property</summary>
        public int? JobId { get; set; }
        /// <summary>
        /// Instantiates a new workflowRunUsage_billable_WINDOWS_job_runs and sets the default values.
        /// </summary>
        public WorkflowRunUsage_billable_WINDOWS_job_runs() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowRunUsage_billable_WINDOWS_job_runs CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowRunUsage_billable_WINDOWS_job_runs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"duration_ms", n => { DurationMs = n.GetIntValue(); } },
                {"job_id", n => { JobId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("duration_ms", DurationMs);
            writer.WriteIntValue("job_id", JobId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
