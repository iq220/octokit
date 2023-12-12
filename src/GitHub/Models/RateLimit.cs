// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class RateLimit : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The limit property</summary>
        public int? Limit { get; set; }
        /// <summary>The remaining property</summary>
        public int? Remaining { get; set; }
        /// <summary>The reset property</summary>
        public int? Reset { get; set; }
        /// <summary>The used property</summary>
        public int? Used { get; set; }
        /// <summary>
        /// Instantiates a new rateLimit and sets the default values.
        /// </summary>
        public RateLimit() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RateLimit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RateLimit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"limit", n => { Limit = n.GetIntValue(); } },
                {"remaining", n => { Remaining = n.GetIntValue(); } },
                {"reset", n => { Reset = n.GetIntValue(); } },
                {"used", n => { Used = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("limit", Limit);
            writer.WriteIntValue("remaining", Remaining);
            writer.WriteIntValue("reset", Reset);
            writer.WriteIntValue("used", Used);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
