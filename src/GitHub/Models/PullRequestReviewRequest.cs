// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Pull Request Review Request
    /// </summary>
    public class PullRequestReviewRequest : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The teams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Team>? Teams { get; set; }
#nullable restore
#else
        public List<Team> Teams { get; set; }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? Users { get; set; }
#nullable restore
#else
        public List<SimpleUser> Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PullRequestReviewRequest"/> and sets the default values.
        /// </summary>
        public PullRequestReviewRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PullRequestReviewRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullRequestReviewRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequestReviewRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "teams", n => { Teams = n.GetCollectionOfObjectValues<Team>(Team.CreateFromDiscriminatorValue)?.ToList(); } },
                { "users", n => { Users = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Team>("teams", Teams);
            writer.WriteCollectionOfObjectValues<SimpleUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
