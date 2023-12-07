// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// User Marketplace Purchase
    /// </summary>
    public class UserMarketplacePurchase : IAdditionalDataHolder, IParsable {
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MarketplaceAccount? Account { get; set; }
#nullable restore
#else
        public MarketplaceAccount Account { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The billing_cycle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillingCycle { get; set; }
#nullable restore
#else
        public string BillingCycle { get; set; }
#endif
        /// <summary>The free_trial_ends_on property</summary>
        public DateTimeOffset? FreeTrialEndsOn { get; set; }
        /// <summary>The next_billing_date property</summary>
        public DateTimeOffset? NextBillingDate { get; set; }
        /// <summary>The on_free_trial property</summary>
        public bool? OnFreeTrial { get; set; }
        /// <summary>Marketplace Listing Plan</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MarketplaceListingPlan? Plan { get; set; }
#nullable restore
#else
        public MarketplaceListingPlan Plan { get; set; }
#endif
        /// <summary>The unit_count property</summary>
        public int? UnitCount { get; set; }
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new userMarketplacePurchase and sets the default values.
        /// </summary>
        public UserMarketplacePurchase() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserMarketplacePurchase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserMarketplacePurchase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"account", n => { Account = n.GetObjectValue<MarketplaceAccount>(MarketplaceAccount.CreateFromDiscriminatorValue); } },
                {"billing_cycle", n => { BillingCycle = n.GetStringValue(); } },
                {"free_trial_ends_on", n => { FreeTrialEndsOn = n.GetDateTimeOffsetValue(); } },
                {"next_billing_date", n => { NextBillingDate = n.GetDateTimeOffsetValue(); } },
                {"on_free_trial", n => { OnFreeTrial = n.GetBoolValue(); } },
                {"plan", n => { Plan = n.GetObjectValue<MarketplaceListingPlan>(MarketplaceListingPlan.CreateFromDiscriminatorValue); } },
                {"unit_count", n => { UnitCount = n.GetIntValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MarketplaceAccount>("account", Account);
            writer.WriteStringValue("billing_cycle", BillingCycle);
            writer.WriteDateTimeOffsetValue("free_trial_ends_on", FreeTrialEndsOn);
            writer.WriteDateTimeOffsetValue("next_billing_date", NextBillingDate);
            writer.WriteBoolValue("on_free_trial", OnFreeTrial);
            writer.WriteObjectValue<MarketplaceListingPlan>("plan", Plan);
            writer.WriteIntValue("unit_count", UnitCount);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
