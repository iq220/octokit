// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// Allow specific users, teams, or apps to bypass pull request requirements.
    /// </summary>
    public class ProtectedBranchPullRequestReview_bypass_pull_request_allowances : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of apps allowed to bypass pull request requirements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Integration>? Apps { get; set; }
#nullable restore
#else
        public List<Integration> Apps { get; set; }
#endif
        /// <summary>The list of teams allowed to bypass pull request requirements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Team>? Teams { get; set; }
#nullable restore
#else
        public List<Team> Teams { get; set; }
#endif
        /// <summary>The list of users allowed to bypass pull request requirements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? Users { get; set; }
#nullable restore
#else
        public List<SimpleUser> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new protectedBranchPullRequestReview_bypass_pull_request_allowances and sets the default values.
        /// </summary>
        public ProtectedBranchPullRequestReview_bypass_pull_request_allowances() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProtectedBranchPullRequestReview_bypass_pull_request_allowances CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectedBranchPullRequestReview_bypass_pull_request_allowances();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<Integration>(Integration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"teams", n => { Teams = n.GetCollectionOfObjectValues<Team>(Team.CreateFromDiscriminatorValue)?.ToList(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Integration>("apps", Apps);
            writer.WriteCollectionOfObjectValues<Team>("teams", Teams);
            writer.WriteCollectionOfObjectValues<SimpleUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
