// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// The configuration for GitHub Pages for a repository.
    /// </summary>
    public class Page : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The process in which the Page will be built.</summary>
        public Page_build_type? BuildType { get; set; }
        /// <summary>The Pages site&apos;s custom domain</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cname { get; set; }
#nullable restore
#else
        public string Cname { get; set; }
#endif
        /// <summary>Whether the Page has a custom 404 page.</summary>
        public bool? Custom404 { get; set; }
        /// <summary>The web address the Page can be accessed from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The https_certificate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PagesHttpsCertificate? HttpsCertificate { get; set; }
#nullable restore
#else
        public PagesHttpsCertificate HttpsCertificate { get; set; }
#endif
        /// <summary>Whether https is enabled on the domain</summary>
        public bool? HttpsEnforced { get; set; }
        /// <summary>The timestamp when a pending domain becomes unverified.</summary>
        public DateTimeOffset? PendingDomainUnverifiedAt { get; set; }
        /// <summary>The state if the domain is verified</summary>
        public Page_protected_domain_state? ProtectedDomainState { get; set; }
        /// <summary>Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.</summary>
        public bool? Public { get; set; }
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PagesSourceHash? Source { get; set; }
#nullable restore
#else
        public PagesSourceHash Source { get; set; }
#endif
        /// <summary>The status of the most recent build of the Page.</summary>
        public Page_status? Status { get; set; }
        /// <summary>The API address for accessing this Page resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Page"/> and sets the default values.
        /// </summary>
        public Page() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Page"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Page CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Page();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"build_type", n => { BuildType = n.GetEnumValue<Page_build_type>(); } },
                {"cname", n => { Cname = n.GetStringValue(); } },
                {"custom_404", n => { Custom404 = n.GetBoolValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"https_certificate", n => { HttpsCertificate = n.GetObjectValue<PagesHttpsCertificate>(PagesHttpsCertificate.CreateFromDiscriminatorValue); } },
                {"https_enforced", n => { HttpsEnforced = n.GetBoolValue(); } },
                {"pending_domain_unverified_at", n => { PendingDomainUnverifiedAt = n.GetDateTimeOffsetValue(); } },
                {"protected_domain_state", n => { ProtectedDomainState = n.GetEnumValue<Page_protected_domain_state>(); } },
                {"public", n => { Public = n.GetBoolValue(); } },
                {"source", n => { Source = n.GetObjectValue<PagesSourceHash>(PagesSourceHash.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<Page_status>(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Page_build_type>("build_type", BuildType);
            writer.WriteStringValue("cname", Cname);
            writer.WriteBoolValue("custom_404", Custom404);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteObjectValue<PagesHttpsCertificate>("https_certificate", HttpsCertificate);
            writer.WriteBoolValue("https_enforced", HttpsEnforced);
            writer.WriteDateTimeOffsetValue("pending_domain_unverified_at", PendingDomainUnverifiedAt);
            writer.WriteEnumValue<Page_protected_domain_state>("protected_domain_state", ProtectedDomainState);
            writer.WriteBoolValue("public", Public);
            writer.WriteObjectValue<PagesSourceHash>("source", Source);
            writer.WriteEnumValue<Page_status>("status", Status);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
