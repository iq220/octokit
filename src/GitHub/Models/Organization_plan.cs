// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class Organization_plan : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The filled_seats property</summary>
        public int? FilledSeats { get; set; }
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
        /// <summary>The seats property</summary>
        public int? Seats { get; set; }
        /// <summary>The space property</summary>
        public int? Space { get; set; }
        /// <summary>
        /// Instantiates a new organization_plan and sets the default values.
        /// </summary>
        public Organization_plan() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Organization_plan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Organization_plan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"filled_seats", n => { FilledSeats = n.GetIntValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"private_repos", n => { PrivateRepos = n.GetIntValue(); } },
                {"seats", n => { Seats = n.GetIntValue(); } },
                {"space", n => { Space = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("filled_seats", FilledSeats);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("private_repos", PrivateRepos);
            writer.WriteIntValue("seats", Seats);
            writer.WriteIntValue("space", Space);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
