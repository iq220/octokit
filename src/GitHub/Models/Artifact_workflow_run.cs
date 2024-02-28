// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class Artifact_workflow_run : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The head_branch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadBranch { get; set; }
#nullable restore
#else
        public string HeadBranch { get; set; }
#endif
        /// <summary>The head_repository_id property</summary>
        public int? HeadRepositoryId { get; set; }
        /// <summary>The head_sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadSha { get; set; }
#nullable restore
#else
        public string HeadSha { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The repository_id property</summary>
        public int? RepositoryId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Artifact_workflow_run"/> and sets the default values.
        /// </summary>
        public Artifact_workflow_run() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Artifact_workflow_run"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Artifact_workflow_run CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Artifact_workflow_run();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"head_branch", n => { HeadBranch = n.GetStringValue(); } },
                {"head_repository_id", n => { HeadRepositoryId = n.GetIntValue(); } },
                {"head_sha", n => { HeadSha = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"repository_id", n => { RepositoryId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("head_branch", HeadBranch);
            writer.WriteIntValue("head_repository_id", HeadRepositoryId);
            writer.WriteStringValue("head_sha", HeadSha);
            writer.WriteIntValue("id", Id);
            writer.WriteIntValue("repository_id", RepositoryId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
