// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Pages {
    /// <summary>
    /// Update the source for the repository. Must include the branch name and path.
    /// </summary>
    public class PagesPutRequestBody_sourceMember1 : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The repository branch used to publish your site&apos;s source files.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Branch { get; set; }
#nullable restore
#else
        public string Branch { get; set; }
#endif
        /// <summary>The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.</summary>
        public PagesPutRequestBody_sourceMember1_path? Path { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PagesPutRequestBody_sourceMember1"/> and sets the default values.
        /// </summary>
        public PagesPutRequestBody_sourceMember1() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PagesPutRequestBody_sourceMember1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PagesPutRequestBody_sourceMember1 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PagesPutRequestBody_sourceMember1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"branch", n => { Branch = n.GetStringValue(); } },
                {"path", n => { Path = n.GetEnumValue<PagesPutRequestBody_sourceMember1_path>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("branch", Branch);
            writer.WriteEnumValue<PagesPutRequestBody_sourceMember1_path>("path", Path);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
