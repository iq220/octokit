// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Dispatches {
    public class DispatchesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>JSON payload with extra information about the webhook event that your action or workflow may use. The maximum number of top-level properties is 10.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DispatchesPostRequestBody_client_payload? ClientPayload { get; set; }
#nullable restore
#else
        public DispatchesPostRequestBody_client_payload ClientPayload { get; set; }
#endif
        /// <summary>A custom webhook event name. Must be 100 characters or fewer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventType { get; set; }
#nullable restore
#else
        public string EventType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new dispatchesPostRequestBody and sets the default values.
        /// </summary>
        public DispatchesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DispatchesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DispatchesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"client_payload", n => { ClientPayload = n.GetObjectValue<DispatchesPostRequestBody_client_payload>(DispatchesPostRequestBody_client_payload.CreateFromDiscriminatorValue); } },
                {"event_type", n => { EventType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DispatchesPostRequestBody_client_payload>("client_payload", ClientPayload);
            writer.WriteStringValue("event_type", EventType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
