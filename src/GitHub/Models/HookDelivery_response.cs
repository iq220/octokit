// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class HookDelivery_response : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The response headers received when the delivery was made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HookDelivery_response_headers? Headers { get; set; }
#nullable restore
#else
        public HookDelivery_response_headers Headers { get; set; }
#endif
        /// <summary>The response payload received.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Payload { get; set; }
#nullable restore
#else
        public string Payload { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="HookDelivery_response"/> and sets the default values.
        /// </summary>
        public HookDelivery_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="HookDelivery_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HookDelivery_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HookDelivery_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"headers", n => { Headers = n.GetObjectValue<HookDelivery_response_headers>(HookDelivery_response_headers.CreateFromDiscriminatorValue); } },
                {"payload", n => { Payload = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<HookDelivery_response_headers>("headers", Headers);
            writer.WriteStringValue("payload", Payload);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
