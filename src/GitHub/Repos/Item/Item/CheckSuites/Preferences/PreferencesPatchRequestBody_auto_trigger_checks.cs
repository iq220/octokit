// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.CheckSuites.Preferences {
    public class PreferencesPatchRequestBody_auto_trigger_checks : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The `id` of the GitHub App.</summary>
        public int? AppId { get; set; }
        /// <summary>Set to `true` to enable automatic creation of CheckSuite events upon pushes to the repository, or `false` to disable them.</summary>
        public bool? Setting { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PreferencesPatchRequestBody_auto_trigger_checks"/> and sets the default values.
        /// </summary>
        public PreferencesPatchRequestBody_auto_trigger_checks() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PreferencesPatchRequestBody_auto_trigger_checks"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PreferencesPatchRequestBody_auto_trigger_checks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PreferencesPatchRequestBody_auto_trigger_checks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"app_id", n => { AppId = n.GetIntValue(); } },
                {"setting", n => { Setting = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("app_id", AppId);
            writer.WriteBoolValue("setting", Setting);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
