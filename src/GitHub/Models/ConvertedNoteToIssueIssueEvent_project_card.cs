// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class ConvertedNoteToIssueIssueEvent_project_card : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The column_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColumnName { get; set; }
#nullable restore
#else
        public string ColumnName { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The previous_column_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviousColumnName { get; set; }
#nullable restore
#else
        public string PreviousColumnName { get; set; }
#endif
        /// <summary>The project_id property</summary>
        public int? ProjectId { get; set; }
        /// <summary>The project_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectUrl { get; set; }
#nullable restore
#else
        public string ProjectUrl { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new convertedNoteToIssueIssueEvent_project_card and sets the default values.
        /// </summary>
        public ConvertedNoteToIssueIssueEvent_project_card() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConvertedNoteToIssueIssueEvent_project_card CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConvertedNoteToIssueIssueEvent_project_card();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"column_name", n => { ColumnName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"previous_column_name", n => { PreviousColumnName = n.GetStringValue(); } },
                {"project_id", n => { ProjectId = n.GetIntValue(); } },
                {"project_url", n => { ProjectUrl = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("column_name", ColumnName);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("previous_column_name", PreviousColumnName);
            writer.WriteIntValue("project_id", ProjectId);
            writer.WriteStringValue("project_url", ProjectUrl);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
