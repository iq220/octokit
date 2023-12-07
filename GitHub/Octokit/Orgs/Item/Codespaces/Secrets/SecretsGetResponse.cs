// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Octokit.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Orgs.Item.Codespaces.Secrets {
    public class SecretsGetResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The secrets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CodespacesOrgSecret>? Secrets { get; set; }
#nullable restore
#else
        public List<CodespacesOrgSecret> Secrets { get; set; }
#endif
        /// <summary>The total_count property</summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Instantiates a new secretsGetResponse and sets the default values.
        /// </summary>
        public SecretsGetResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecretsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecretsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"secrets", n => { Secrets = n.GetCollectionOfObjectValues<CodespacesOrgSecret>(CodespacesOrgSecret.CreateFromDiscriminatorValue)?.ToList(); } },
                {"total_count", n => { TotalCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CodespacesOrgSecret>("secrets", Secrets);
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
