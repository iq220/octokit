// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// A GitHub repository view for Classroom
    /// </summary>
    public class SimpleClassroomRepository : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The default branch for the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultBranch { get; set; }
#nullable restore
#else
        public string DefaultBranch { get; set; }
#endif
        /// <summary>The full, globally unique name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FullName { get; set; }
#nullable restore
#else
        public string FullName { get; set; }
#endif
        /// <summary>The URL to view the repository on GitHub.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>A unique identifier of the repository.</summary>
        public int? Id { get; set; }
        /// <summary>The GraphQL identifier of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>Whether the repository is private.</summary>
        public bool? Private { get; set; }
        /// <summary>
        /// Instantiates a new simpleClassroomRepository and sets the default values.
        /// </summary>
        public SimpleClassroomRepository() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SimpleClassroomRepository CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimpleClassroomRepository();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"default_branch", n => { DefaultBranch = n.GetStringValue(); } },
                {"full_name", n => { FullName = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"private", n => { Private = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("default_branch", DefaultBranch);
            writer.WriteStringValue("full_name", FullName);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteBoolValue("private", Private);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
