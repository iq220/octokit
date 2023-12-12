// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// The authorization for an OAuth app, GitHub App, or a Personal Access Token.
    /// </summary>
    public class Authorization : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The app property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Authorization_app? App { get; set; }
#nullable restore
#else
        public Authorization_app App { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The expires_at property</summary>
        public DateTimeOffset? ExpiresAt { get; set; }
        /// <summary>The fingerprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint { get; set; }
#nullable restore
#else
        public string Fingerprint { get; set; }
#endif
        /// <summary>The hashed_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HashedToken { get; set; }
#nullable restore
#else
        public string HashedToken { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The installation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableScopedInstallation? Installation { get; set; }
#nullable restore
#else
        public NullableScopedInstallation Installation { get; set; }
#endif
        /// <summary>The note property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The note_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NoteUrl { get; set; }
#nullable restore
#else
        public string NoteUrl { get; set; }
#endif
        /// <summary>A list of scopes that this authorization is in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Scopes { get; set; }
#nullable restore
#else
        public List<string> Scopes { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The token_last_eight property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenLastEight { get; set; }
#nullable restore
#else
        public string TokenLastEight { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? User { get; set; }
#nullable restore
#else
        public NullableSimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new authorization and sets the default values.
        /// </summary>
        public Authorization() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Authorization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Authorization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"app", n => { App = n.GetObjectValue<Authorization_app>(Authorization_app.CreateFromDiscriminatorValue); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"expires_at", n => { ExpiresAt = n.GetDateTimeOffsetValue(); } },
                {"fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                {"hashed_token", n => { HashedToken = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"installation", n => { Installation = n.GetObjectValue<NullableScopedInstallation>(NullableScopedInstallation.CreateFromDiscriminatorValue); } },
                {"note", n => { Note = n.GetStringValue(); } },
                {"note_url", n => { NoteUrl = n.GetStringValue(); } },
                {"scopes", n => { Scopes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"token_last_eight", n => { TokenLastEight = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Authorization_app>("app", App);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteDateTimeOffsetValue("expires_at", ExpiresAt);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteStringValue("hashed_token", HashedToken);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<NullableScopedInstallation>("installation", Installation);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("note_url", NoteUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("scopes", Scopes);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("token_last_eight", TokenLastEight);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
