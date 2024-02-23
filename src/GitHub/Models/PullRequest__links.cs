// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class PullRequest__links : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? Comments { get; set; }
#nullable restore
#else
        public Link Comments { get; set; }
#endif
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? Commits { get; set; }
#nullable restore
#else
        public Link Commits { get; set; }
#endif
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? Html { get; set; }
#nullable restore
#else
        public Link Html { get; set; }
#endif
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? Issue { get; set; }
#nullable restore
#else
        public Link Issue { get; set; }
#endif
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? ReviewComment { get; set; }
#nullable restore
#else
        public Link ReviewComment { get; set; }
#endif
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? ReviewComments { get; set; }
#nullable restore
#else
        public Link ReviewComments { get; set; }
#endif
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? Self { get; set; }
#nullable restore
#else
        public Link Self { get; set; }
#endif
        /// <summary>Hypermedia Link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Link? Statuses { get; set; }
#nullable restore
#else
        public Link Statuses { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PullRequest__links"/> and sets the default values.
        /// </summary>
        public PullRequest__links() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PullRequest__links"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullRequest__links CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequest__links();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comments", n => { Comments = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
                {"commits", n => { Commits = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
                {"html", n => { Html = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
                {"issue", n => { Issue = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
                {"review_comment", n => { ReviewComment = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
                {"review_comments", n => { ReviewComments = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
                {"self", n => { Self = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
                {"statuses", n => { Statuses = n.GetObjectValue<Link>(Link.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Link>("comments", Comments);
            writer.WriteObjectValue<Link>("commits", Commits);
            writer.WriteObjectValue<Link>("html", Html);
            writer.WriteObjectValue<Link>("issue", Issue);
            writer.WriteObjectValue<Link>("review_comment", ReviewComment);
            writer.WriteObjectValue<Link>("review_comments", ReviewComments);
            writer.WriteObjectValue<Link>("self", Self);
            writer.WriteObjectValue<Link>("statuses", Statuses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
