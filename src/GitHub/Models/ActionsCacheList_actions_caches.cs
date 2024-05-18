// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    #pragma warning disable CS1591
    public class ActionsCacheList_actions_caches : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The last_accessed_at property</summary>
        public DateTimeOffset? LastAccessedAt { get; set; }
        /// <summary>The ref property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>The size_in_bytes property</summary>
        public int? SizeInBytes { get; set; }
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ActionsCacheList_actions_caches"/> and sets the default values.
        /// </summary>
        public ActionsCacheList_actions_caches()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActionsCacheList_actions_caches"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ActionsCacheList_actions_caches CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionsCacheList_actions_caches();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "last_accessed_at", n => { LastAccessedAt = n.GetDateTimeOffsetValue(); } },
                { "ref", n => { Ref = n.GetStringValue(); } },
                { "size_in_bytes", n => { SizeInBytes = n.GetIntValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("key", Key);
            writer.WriteDateTimeOffsetValue("last_accessed_at", LastAccessedAt);
            writer.WriteStringValue("ref", Ref);
            writer.WriteIntValue("size_in_bytes", SizeInBytes);
            writer.WriteStringValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
