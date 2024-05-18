// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Api Overview
    /// </summary>
    public class ApiOverview : IAdditionalDataHolder, IParsable
    {
        /// <summary>The actions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Actions { get; set; }
#nullable restore
#else
        public List<string> Actions { get; set; }
#endif
        /// <summary>The actions_macos property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ActionsMacos { get; set; }
#nullable restore
#else
        public List<string> ActionsMacos { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The api property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Api { get; set; }
#nullable restore
#else
        public List<string> Api { get; set; }
#endif
        /// <summary>The dependabot property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Dependabot { get; set; }
#nullable restore
#else
        public List<string> Dependabot { get; set; }
#endif
        /// <summary>The domains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiOverview_domains? Domains { get; set; }
#nullable restore
#else
        public ApiOverview_domains Domains { get; set; }
#endif
        /// <summary>The git property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Git { get; set; }
#nullable restore
#else
        public List<string> Git { get; set; }
#endif
        /// <summary>The github_enterprise_importer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GithubEnterpriseImporter { get; set; }
#nullable restore
#else
        public List<string> GithubEnterpriseImporter { get; set; }
#endif
        /// <summary>The hooks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Hooks { get; set; }
#nullable restore
#else
        public List<string> Hooks { get; set; }
#endif
        /// <summary>The importer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Importer { get; set; }
#nullable restore
#else
        public List<string> Importer { get; set; }
#endif
        /// <summary>The packages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Packages { get; set; }
#nullable restore
#else
        public List<string> Packages { get; set; }
#endif
        /// <summary>The pages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Pages { get; set; }
#nullable restore
#else
        public List<string> Pages { get; set; }
#endif
        /// <summary>The ssh_key_fingerprints property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiOverview_ssh_key_fingerprints? SshKeyFingerprints { get; set; }
#nullable restore
#else
        public ApiOverview_ssh_key_fingerprints SshKeyFingerprints { get; set; }
#endif
        /// <summary>The ssh_keys property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SshKeys { get; set; }
#nullable restore
#else
        public List<string> SshKeys { get; set; }
#endif
        /// <summary>The verifiable_password_authentication property</summary>
        public bool? VerifiablePasswordAuthentication { get; set; }
        /// <summary>The web property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Web { get; set; }
#nullable restore
#else
        public List<string> Web { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ApiOverview"/> and sets the default values.
        /// </summary>
        public ApiOverview()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ApiOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApiOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApiOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actions", n => { Actions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "actions_macos", n => { ActionsMacos = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "api", n => { Api = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "dependabot", n => { Dependabot = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "domains", n => { Domains = n.GetObjectValue<ApiOverview_domains>(ApiOverview_domains.CreateFromDiscriminatorValue); } },
                { "git", n => { Git = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "github_enterprise_importer", n => { GithubEnterpriseImporter = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "hooks", n => { Hooks = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "importer", n => { Importer = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "packages", n => { Packages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "pages", n => { Pages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "ssh_key_fingerprints", n => { SshKeyFingerprints = n.GetObjectValue<ApiOverview_ssh_key_fingerprints>(ApiOverview_ssh_key_fingerprints.CreateFromDiscriminatorValue); } },
                { "ssh_keys", n => { SshKeys = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "verifiable_password_authentication", n => { VerifiablePasswordAuthentication = n.GetBoolValue(); } },
                { "web", n => { Web = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("actions", Actions);
            writer.WriteCollectionOfPrimitiveValues<string>("actions_macos", ActionsMacos);
            writer.WriteCollectionOfPrimitiveValues<string>("api", Api);
            writer.WriteCollectionOfPrimitiveValues<string>("dependabot", Dependabot);
            writer.WriteObjectValue<ApiOverview_domains>("domains", Domains);
            writer.WriteCollectionOfPrimitiveValues<string>("git", Git);
            writer.WriteCollectionOfPrimitiveValues<string>("github_enterprise_importer", GithubEnterpriseImporter);
            writer.WriteCollectionOfPrimitiveValues<string>("hooks", Hooks);
            writer.WriteCollectionOfPrimitiveValues<string>("importer", Importer);
            writer.WriteCollectionOfPrimitiveValues<string>("packages", Packages);
            writer.WriteCollectionOfPrimitiveValues<string>("pages", Pages);
            writer.WriteObjectValue<ApiOverview_ssh_key_fingerprints>("ssh_key_fingerprints", SshKeyFingerprints);
            writer.WriteCollectionOfPrimitiveValues<string>("ssh_keys", SshKeys);
            writer.WriteBoolValue("verifiable_password_authentication", VerifiablePasswordAuthentication);
            writer.WriteCollectionOfPrimitiveValues<string>("web", Web);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
