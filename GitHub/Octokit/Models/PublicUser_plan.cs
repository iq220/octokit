// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    public class PublicUser_plan : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The collaborators property</summary>
        public int? Collaborators { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The private_repos property</summary>
        public int? PrivateRepos { get; set; }
        /// <summary>The space property</summary>
        public int? Space { get; set; }
        /// <summary>
        /// Instantiates a new publicUser_plan and sets the default values.
        /// </summary>
        public PublicUser_plan() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicUser_plan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicUser_plan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"collaborators", n => { Collaborators = n.GetIntValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"private_repos", n => { PrivateRepos = n.GetIntValue(); } },
                {"space", n => { Space = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("collaborators", Collaborators);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("private_repos", PrivateRepos);
            writer.WriteIntValue("space", Space);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
