// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    public class PackagesBillingUsage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Free storage space (GB) for GitHub Packages.</summary>
        public int? IncludedGigabytesBandwidth { get; set; }
        /// <summary>Sum of the free and paid storage space (GB) for GitHuub Packages.</summary>
        public int? TotalGigabytesBandwidthUsed { get; set; }
        /// <summary>Total paid storage space (GB) for GitHuub Packages.</summary>
        public int? TotalPaidGigabytesBandwidthUsed { get; set; }
        /// <summary>
        /// Instantiates a new packagesBillingUsage and sets the default values.
        /// </summary>
        public PackagesBillingUsage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PackagesBillingUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PackagesBillingUsage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"included_gigabytes_bandwidth", n => { IncludedGigabytesBandwidth = n.GetIntValue(); } },
                {"total_gigabytes_bandwidth_used", n => { TotalGigabytesBandwidthUsed = n.GetIntValue(); } },
                {"total_paid_gigabytes_bandwidth_used", n => { TotalPaidGigabytesBandwidthUsed = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("included_gigabytes_bandwidth", IncludedGigabytesBandwidth);
            writer.WriteIntValue("total_gigabytes_bandwidth_used", TotalGigabytesBandwidthUsed);
            writer.WriteIntValue("total_paid_gigabytes_bandwidth_used", TotalPaidGigabytesBandwidthUsed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
