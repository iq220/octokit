// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Prevent merge commits from being pushed to matching refs.
    /// </summary>
    public class RepositoryRuleRequiredLinearHistory : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type property</summary>
        public RepositoryRuleRequiredLinearHistory_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RepositoryRuleRequiredLinearHistory"/> and sets the default values.
        /// </summary>
        public RepositoryRuleRequiredLinearHistory() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RepositoryRuleRequiredLinearHistory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRuleRequiredLinearHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRuleRequiredLinearHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"type", n => { Type = n.GetEnumValue<RepositoryRuleRequiredLinearHistory_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RepositoryRuleRequiredLinearHistory_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
