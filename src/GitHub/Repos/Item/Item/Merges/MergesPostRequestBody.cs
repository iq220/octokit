// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Merges {
    public class MergesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the base branch that the head will be merged into.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Base { get; set; }
#nullable restore
#else
        public string Base { get; set; }
#endif
        /// <summary>Commit message to use for the merge commit. If omitted, a default message will be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitMessage { get; set; }
#nullable restore
#else
        public string CommitMessage { get; set; }
#endif
        /// <summary>The head to merge. This can be a branch name or a commit SHA1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Head { get; set; }
#nullable restore
#else
        public string Head { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MergesPostRequestBody"/> and sets the default values.
        /// </summary>
        public MergesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MergesPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MergesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MergesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"base", n => { Base = n.GetStringValue(); } },
                {"commit_message", n => { CommitMessage = n.GetStringValue(); } },
                {"head", n => { Head = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("base", Base);
            writer.WriteStringValue("commit_message", CommitMessage);
            writer.WriteStringValue("head", Head);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
