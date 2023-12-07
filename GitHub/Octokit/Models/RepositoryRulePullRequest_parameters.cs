// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    public class RepositoryRulePullRequest_parameters : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>New, reviewable commits pushed will dismiss previous pull request review approvals.</summary>
        public bool? DismissStaleReviewsOnPush { get; set; }
        /// <summary>Require an approving review in pull requests that modify files that have a designated code owner.</summary>
        public bool? RequireCodeOwnerReview { get; set; }
        /// <summary>The number of approving reviews that are required before a pull request can be merged.</summary>
        public int? RequiredApprovingReviewCount { get; set; }
        /// <summary>All conversations on code must be resolved before a pull request can be merged.</summary>
        public bool? RequiredReviewThreadResolution { get; set; }
        /// <summary>Whether the most recent reviewable push must be approved by someone other than the person who pushed it.</summary>
        public bool? RequireLastPushApproval { get; set; }
        /// <summary>
        /// Instantiates a new repositoryRulePullRequest_parameters and sets the default values.
        /// </summary>
        public RepositoryRulePullRequest_parameters() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRulePullRequest_parameters CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRulePullRequest_parameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dismiss_stale_reviews_on_push", n => { DismissStaleReviewsOnPush = n.GetBoolValue(); } },
                {"require_code_owner_review", n => { RequireCodeOwnerReview = n.GetBoolValue(); } },
                {"require_last_push_approval", n => { RequireLastPushApproval = n.GetBoolValue(); } },
                {"required_approving_review_count", n => { RequiredApprovingReviewCount = n.GetIntValue(); } },
                {"required_review_thread_resolution", n => { RequiredReviewThreadResolution = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("dismiss_stale_reviews_on_push", DismissStaleReviewsOnPush);
            writer.WriteBoolValue("require_code_owner_review", RequireCodeOwnerReview);
            writer.WriteIntValue("required_approving_review_count", RequiredApprovingReviewCount);
            writer.WriteBoolValue("required_review_thread_resolution", RequiredReviewThreadResolution);
            writer.WriteBoolValue("require_last_push_approval", RequireLastPushApproval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
