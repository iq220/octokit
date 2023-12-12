// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class Event_payload : IAdditionalDataHolder, IParsable {
        /// <summary>The action property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Action { get; set; }
#nullable restore
#else
        public string Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Comments provide a way for people to collaborate on an issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueComment? Comment { get; set; }
#nullable restore
#else
        public IssueComment Comment { get; set; }
#endif
        /// <summary>Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Models.Issue? Issue { get; set; }
#nullable restore
#else
        public GitHub.Models.Issue Issue { get; set; }
#endif
        /// <summary>The pages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event_payload_pages>? Pages { get; set; }
#nullable restore
#else
        public List<Event_payload_pages> Pages { get; set; }
#endif
        /// <summary>
        /// Instantiates a new event_payload and sets the default values.
        /// </summary>
        public Event_payload() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Event_payload CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Event_payload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetStringValue(); } },
                {"comment", n => { Comment = n.GetObjectValue<IssueComment>(IssueComment.CreateFromDiscriminatorValue); } },
                {"issue", n => { Issue = n.GetObjectValue<GitHub.Models.Issue>(GitHub.Models.Issue.CreateFromDiscriminatorValue); } },
                {"pages", n => { Pages = n.GetCollectionOfObjectValues<Event_payload_pages>(Event_payload_pages.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("action", Action);
            writer.WriteObjectValue<IssueComment>("comment", Comment);
            writer.WriteObjectValue<GitHub.Models.Issue>("issue", Issue);
            writer.WriteCollectionOfObjectValues<Event_payload_pages>("pages", Pages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
