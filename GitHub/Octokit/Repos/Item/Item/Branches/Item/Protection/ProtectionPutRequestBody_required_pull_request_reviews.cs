// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Repos.Item.Item.Branches.Item.Protection {
    /// <summary>
    /// Require at least one approving review on a pull request, before merging. Set to `null` to disable.
    /// </summary>
    public class ProtectionPutRequestBody_required_pull_request_reviews : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Allow specific users, teams, or apps to bypass pull request requirements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectionPutRequestBody_required_pull_request_reviews_bypass_pull_request_allowances? BypassPullRequestAllowances { get; set; }
#nullable restore
#else
        public ProtectionPutRequestBody_required_pull_request_reviews_bypass_pull_request_allowances BypassPullRequestAllowances { get; set; }
#endif
        /// <summary>Specify which users, teams, and apps can dismiss pull request reviews. Pass an empty `dismissal_restrictions` object to disable. User and team `dismissal_restrictions` are only available for organization-owned repositories. Omit this parameter for personal repositories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProtectionPutRequestBody_required_pull_request_reviews_dismissal_restrictions? DismissalRestrictions { get; set; }
#nullable restore
#else
        public ProtectionPutRequestBody_required_pull_request_reviews_dismissal_restrictions DismissalRestrictions { get; set; }
#endif
        /// <summary>Set to `true` if you want to automatically dismiss approving reviews when someone pushes a new commit.</summary>
        public bool? DismissStaleReviews { get; set; }
        /// <summary>Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) review them.</summary>
        public bool? RequireCodeOwnerReviews { get; set; }
        /// <summary>Specify the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers.</summary>
        public int? RequiredApprovingReviewCount { get; set; }
        /// <summary>Whether the most recent push must be approved by someone other than the person who pushed it. Default: `false`.</summary>
        public bool? RequireLastPushApproval { get; set; }
        /// <summary>
        /// Instantiates a new protectionPutRequestBody_required_pull_request_reviews and sets the default values.
        /// </summary>
        public ProtectionPutRequestBody_required_pull_request_reviews() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProtectionPutRequestBody_required_pull_request_reviews CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectionPutRequestBody_required_pull_request_reviews();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bypass_pull_request_allowances", n => { BypassPullRequestAllowances = n.GetObjectValue<ProtectionPutRequestBody_required_pull_request_reviews_bypass_pull_request_allowances>(ProtectionPutRequestBody_required_pull_request_reviews_bypass_pull_request_allowances.CreateFromDiscriminatorValue); } },
                {"dismiss_stale_reviews", n => { DismissStaleReviews = n.GetBoolValue(); } },
                {"dismissal_restrictions", n => { DismissalRestrictions = n.GetObjectValue<ProtectionPutRequestBody_required_pull_request_reviews_dismissal_restrictions>(ProtectionPutRequestBody_required_pull_request_reviews_dismissal_restrictions.CreateFromDiscriminatorValue); } },
                {"require_code_owner_reviews", n => { RequireCodeOwnerReviews = n.GetBoolValue(); } },
                {"require_last_push_approval", n => { RequireLastPushApproval = n.GetBoolValue(); } },
                {"required_approving_review_count", n => { RequiredApprovingReviewCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ProtectionPutRequestBody_required_pull_request_reviews_bypass_pull_request_allowances>("bypass_pull_request_allowances", BypassPullRequestAllowances);
            writer.WriteObjectValue<ProtectionPutRequestBody_required_pull_request_reviews_dismissal_restrictions>("dismissal_restrictions", DismissalRestrictions);
            writer.WriteBoolValue("dismiss_stale_reviews", DismissStaleReviews);
            writer.WriteBoolValue("require_code_owner_reviews", RequireCodeOwnerReviews);
            writer.WriteIntValue("required_approving_review_count", RequiredApprovingReviewCount);
            writer.WriteBoolValue("require_last_push_approval", RequireLastPushApproval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
