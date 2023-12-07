// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    public class CommunityProfile_files : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Code of Conduct Simple</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableCodeOfConductSimple? CodeOfConduct { get; set; }
#nullable restore
#else
        public NullableCodeOfConductSimple CodeOfConduct { get; set; }
#endif
        /// <summary>The code_of_conduct_file property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableCommunityHealthFile? CodeOfConductFile { get; set; }
#nullable restore
#else
        public NullableCommunityHealthFile CodeOfConductFile { get; set; }
#endif
        /// <summary>The contributing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableCommunityHealthFile? Contributing { get; set; }
#nullable restore
#else
        public NullableCommunityHealthFile Contributing { get; set; }
#endif
        /// <summary>The issue_template property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableCommunityHealthFile? IssueTemplate { get; set; }
#nullable restore
#else
        public NullableCommunityHealthFile IssueTemplate { get; set; }
#endif
        /// <summary>License Simple</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableLicenseSimple? License { get; set; }
#nullable restore
#else
        public NullableLicenseSimple License { get; set; }
#endif
        /// <summary>The pull_request_template property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableCommunityHealthFile? PullRequestTemplate { get; set; }
#nullable restore
#else
        public NullableCommunityHealthFile PullRequestTemplate { get; set; }
#endif
        /// <summary>The readme property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableCommunityHealthFile? Readme { get; set; }
#nullable restore
#else
        public NullableCommunityHealthFile Readme { get; set; }
#endif
        /// <summary>
        /// Instantiates a new communityProfile_files and sets the default values.
        /// </summary>
        public CommunityProfile_files() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CommunityProfile_files CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommunityProfile_files();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code_of_conduct", n => { CodeOfConduct = n.GetObjectValue<NullableCodeOfConductSimple>(NullableCodeOfConductSimple.CreateFromDiscriminatorValue); } },
                {"code_of_conduct_file", n => { CodeOfConductFile = n.GetObjectValue<NullableCommunityHealthFile>(NullableCommunityHealthFile.CreateFromDiscriminatorValue); } },
                {"contributing", n => { Contributing = n.GetObjectValue<NullableCommunityHealthFile>(NullableCommunityHealthFile.CreateFromDiscriminatorValue); } },
                {"issue_template", n => { IssueTemplate = n.GetObjectValue<NullableCommunityHealthFile>(NullableCommunityHealthFile.CreateFromDiscriminatorValue); } },
                {"license", n => { License = n.GetObjectValue<NullableLicenseSimple>(NullableLicenseSimple.CreateFromDiscriminatorValue); } },
                {"pull_request_template", n => { PullRequestTemplate = n.GetObjectValue<NullableCommunityHealthFile>(NullableCommunityHealthFile.CreateFromDiscriminatorValue); } },
                {"readme", n => { Readme = n.GetObjectValue<NullableCommunityHealthFile>(NullableCommunityHealthFile.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<NullableCodeOfConductSimple>("code_of_conduct", CodeOfConduct);
            writer.WriteObjectValue<NullableCommunityHealthFile>("code_of_conduct_file", CodeOfConductFile);
            writer.WriteObjectValue<NullableCommunityHealthFile>("contributing", Contributing);
            writer.WriteObjectValue<NullableCommunityHealthFile>("issue_template", IssueTemplate);
            writer.WriteObjectValue<NullableLicenseSimple>("license", License);
            writer.WriteObjectValue<NullableCommunityHealthFile>("pull_request_template", PullRequestTemplate);
            writer.WriteObjectValue<NullableCommunityHealthFile>("readme", Readme);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
