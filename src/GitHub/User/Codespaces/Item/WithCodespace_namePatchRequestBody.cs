// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.User.Codespaces.Item {
    public class WithCodespace_namePatchRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name for this codespace</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>A valid machine to transition this codespace to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Machine { get; set; }
#nullable restore
#else
        public string Machine { get; set; }
#endif
        /// <summary>Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecentFolders { get; set; }
#nullable restore
#else
        public List<string> RecentFolders { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WithCodespace_namePatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithCodespace_namePatchRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WithCodespace_namePatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithCodespace_namePatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithCodespace_namePatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"display_name", n => { DisplayName = n.GetStringValue(); } },
                {"machine", n => { Machine = n.GetStringValue(); } },
                {"recent_folders", n => { RecentFolders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("display_name", DisplayName);
            writer.WriteStringValue("machine", Machine);
            writer.WriteCollectionOfPrimitiveValues<string>("recent_folders", RecentFolders);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
