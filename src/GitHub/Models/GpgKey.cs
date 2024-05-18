// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// A unique encryption key
    /// </summary>
    public class GpgKey : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The can_certify property</summary>
        public bool? CanCertify { get; set; }
        /// <summary>The can_encrypt_comms property</summary>
        public bool? CanEncryptComms { get; set; }
        /// <summary>The can_encrypt_storage property</summary>
        public bool? CanEncryptStorage { get; set; }
        /// <summary>The can_sign property</summary>
        public bool? CanSign { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The emails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GpgKey_emails>? Emails { get; set; }
#nullable restore
#else
        public List<GpgKey_emails> Emails { get; set; }
#endif
        /// <summary>The expires_at property</summary>
        public DateTimeOffset? ExpiresAt { get; set; }
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The key_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The primary_key_id property</summary>
        public int? PrimaryKeyId { get; set; }
        /// <summary>The public_key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicKey { get; set; }
#nullable restore
#else
        public string PublicKey { get; set; }
#endif
        /// <summary>The raw_key property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RawKey { get; set; }
#nullable restore
#else
        public string RawKey { get; set; }
#endif
        /// <summary>The revoked property</summary>
        public bool? Revoked { get; set; }
        /// <summary>The subkeys property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GpgKey_subkeys>? Subkeys { get; set; }
#nullable restore
#else
        public List<GpgKey_subkeys> Subkeys { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GpgKey"/> and sets the default values.
        /// </summary>
        public GpgKey()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GpgKey"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GpgKey CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GpgKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "can_certify", n => { CanCertify = n.GetBoolValue(); } },
                { "can_encrypt_comms", n => { CanEncryptComms = n.GetBoolValue(); } },
                { "can_encrypt_storage", n => { CanEncryptStorage = n.GetBoolValue(); } },
                { "can_sign", n => { CanSign = n.GetBoolValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "emails", n => { Emails = n.GetCollectionOfObjectValues<GpgKey_emails>(GpgKey_emails.CreateFromDiscriminatorValue)?.ToList(); } },
                { "expires_at", n => { ExpiresAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "key_id", n => { KeyId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "primary_key_id", n => { PrimaryKeyId = n.GetIntValue(); } },
                { "public_key", n => { PublicKey = n.GetStringValue(); } },
                { "raw_key", n => { RawKey = n.GetStringValue(); } },
                { "revoked", n => { Revoked = n.GetBoolValue(); } },
                { "subkeys", n => { Subkeys = n.GetCollectionOfObjectValues<GpgKey_subkeys>(GpgKey_subkeys.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("can_certify", CanCertify);
            writer.WriteBoolValue("can_encrypt_comms", CanEncryptComms);
            writer.WriteBoolValue("can_encrypt_storage", CanEncryptStorage);
            writer.WriteBoolValue("can_sign", CanSign);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteCollectionOfObjectValues<GpgKey_emails>("emails", Emails);
            writer.WriteDateTimeOffsetValue("expires_at", ExpiresAt);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("primary_key_id", PrimaryKeyId);
            writer.WriteStringValue("public_key", PublicKey);
            writer.WriteStringValue("raw_key", RawKey);
            writer.WriteBoolValue("revoked", Revoked);
            writer.WriteCollectionOfObjectValues<GpgKey_subkeys>("subkeys", Subkeys);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
