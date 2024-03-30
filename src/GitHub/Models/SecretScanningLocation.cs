// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class SecretScanningLocation : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecretScanningLocation_details? Details { get; set; }
#nullable restore
#else
        public SecretScanningLocation_details Details { get; set; }
#endif
        /// <summary>The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.</summary>
        public SecretScanningLocation_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="SecretScanningLocation"/> and sets the default values.
        /// </summary>
        public SecretScanningLocation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SecretScanningLocation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecretScanningLocation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecretScanningLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"details", n => { Details = n.GetObjectValue<SecretScanningLocation_details>(SecretScanningLocation_details.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<SecretScanningLocation_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SecretScanningLocation_details>("details", Details);
            writer.WriteEnumValue<SecretScanningLocation_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="SecretScanningLocationCommit"/>, <see cref="SecretScanningLocationDiscussionBody"/>, <see cref="SecretScanningLocationDiscussionComment"/>, <see cref="SecretScanningLocationDiscussionTitle"/>, <see cref="SecretScanningLocationIssueBody"/>, <see cref="SecretScanningLocationIssueComment"/>, <see cref="SecretScanningLocationIssueTitle"/>, <see cref="SecretScanningLocationPullRequestBody"/>, <see cref="SecretScanningLocationPullRequestComment"/>, <see cref="SecretScanningLocationPullRequestReview"/>, <see cref="SecretScanningLocationPullRequestReviewComment"/>, <see cref="SecretScanningLocationPullRequestTitle"/>, <see cref="SecretScanningLocationWikiCommit"/>
        /// </summary>
        public class SecretScanningLocation_details : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationCommit"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationCommit? SecretScanningLocationCommit { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationCommit SecretScanningLocationCommit { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationDiscussionBody"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationDiscussionBody? SecretScanningLocationDiscussionBody { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationDiscussionBody SecretScanningLocationDiscussionBody { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationDiscussionComment"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationDiscussionComment? SecretScanningLocationDiscussionComment { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationDiscussionComment SecretScanningLocationDiscussionComment { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationDiscussionTitle"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationDiscussionTitle? SecretScanningLocationDiscussionTitle { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationDiscussionTitle SecretScanningLocationDiscussionTitle { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationIssueBody"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationIssueBody? SecretScanningLocationIssueBody { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationIssueBody SecretScanningLocationIssueBody { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationIssueComment"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationIssueComment? SecretScanningLocationIssueComment { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationIssueComment SecretScanningLocationIssueComment { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationIssueTitle"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationIssueTitle? SecretScanningLocationIssueTitle { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationIssueTitle SecretScanningLocationIssueTitle { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationPullRequestBody"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationPullRequestBody? SecretScanningLocationPullRequestBody { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationPullRequestBody SecretScanningLocationPullRequestBody { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationPullRequestComment"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationPullRequestComment? SecretScanningLocationPullRequestComment { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationPullRequestComment SecretScanningLocationPullRequestComment { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationPullRequestReview"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationPullRequestReview? SecretScanningLocationPullRequestReview { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationPullRequestReview SecretScanningLocationPullRequestReview { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationPullRequestReviewComment"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationPullRequestReviewComment? SecretScanningLocationPullRequestReviewComment { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationPullRequestReviewComment SecretScanningLocationPullRequestReviewComment { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationPullRequestTitle"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationPullRequestTitle? SecretScanningLocationPullRequestTitle { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationPullRequestTitle SecretScanningLocationPullRequestTitle { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="GitHub.Models.SecretScanningLocationWikiCommit"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.SecretScanningLocationWikiCommit? SecretScanningLocationWikiCommit { get; set; }
#nullable restore
#else
            public GitHub.Models.SecretScanningLocationWikiCommit SecretScanningLocationWikiCommit { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="SecretScanningLocation_details"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static SecretScanningLocation_details CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new SecretScanningLocation_details();
                if("secret-scanning-location-commit".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationCommit = new GitHub.Models.SecretScanningLocationCommit();
                }
                else if("secret-scanning-location-discussion-body".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationDiscussionBody = new GitHub.Models.SecretScanningLocationDiscussionBody();
                }
                else if("secret-scanning-location-discussion-comment".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationDiscussionComment = new GitHub.Models.SecretScanningLocationDiscussionComment();
                }
                else if("secret-scanning-location-discussion-title".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationDiscussionTitle = new GitHub.Models.SecretScanningLocationDiscussionTitle();
                }
                else if("secret-scanning-location-issue-body".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationIssueBody = new GitHub.Models.SecretScanningLocationIssueBody();
                }
                else if("secret-scanning-location-issue-comment".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationIssueComment = new GitHub.Models.SecretScanningLocationIssueComment();
                }
                else if("secret-scanning-location-issue-title".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationIssueTitle = new GitHub.Models.SecretScanningLocationIssueTitle();
                }
                else if("secret-scanning-location-pull-request-body".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationPullRequestBody = new GitHub.Models.SecretScanningLocationPullRequestBody();
                }
                else if("secret-scanning-location-pull-request-comment".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationPullRequestComment = new GitHub.Models.SecretScanningLocationPullRequestComment();
                }
                else if("secret-scanning-location-pull-request-review".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationPullRequestReview = new GitHub.Models.SecretScanningLocationPullRequestReview();
                }
                else if("secret-scanning-location-pull-request-review-comment".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationPullRequestReviewComment = new GitHub.Models.SecretScanningLocationPullRequestReviewComment();
                }
                else if("secret-scanning-location-pull-request-title".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationPullRequestTitle = new GitHub.Models.SecretScanningLocationPullRequestTitle();
                }
                else if("secret-scanning-location-wiki-commit".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SecretScanningLocationWikiCommit = new GitHub.Models.SecretScanningLocationWikiCommit();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(SecretScanningLocationCommit != null)
                {
                    return SecretScanningLocationCommit.GetFieldDeserializers();
                }
                else if(SecretScanningLocationDiscussionBody != null)
                {
                    return SecretScanningLocationDiscussionBody.GetFieldDeserializers();
                }
                else if(SecretScanningLocationDiscussionComment != null)
                {
                    return SecretScanningLocationDiscussionComment.GetFieldDeserializers();
                }
                else if(SecretScanningLocationDiscussionTitle != null)
                {
                    return SecretScanningLocationDiscussionTitle.GetFieldDeserializers();
                }
                else if(SecretScanningLocationIssueBody != null)
                {
                    return SecretScanningLocationIssueBody.GetFieldDeserializers();
                }
                else if(SecretScanningLocationIssueComment != null)
                {
                    return SecretScanningLocationIssueComment.GetFieldDeserializers();
                }
                else if(SecretScanningLocationIssueTitle != null)
                {
                    return SecretScanningLocationIssueTitle.GetFieldDeserializers();
                }
                else if(SecretScanningLocationPullRequestBody != null)
                {
                    return SecretScanningLocationPullRequestBody.GetFieldDeserializers();
                }
                else if(SecretScanningLocationPullRequestComment != null)
                {
                    return SecretScanningLocationPullRequestComment.GetFieldDeserializers();
                }
                else if(SecretScanningLocationPullRequestReview != null)
                {
                    return SecretScanningLocationPullRequestReview.GetFieldDeserializers();
                }
                else if(SecretScanningLocationPullRequestReviewComment != null)
                {
                    return SecretScanningLocationPullRequestReviewComment.GetFieldDeserializers();
                }
                else if(SecretScanningLocationPullRequestTitle != null)
                {
                    return SecretScanningLocationPullRequestTitle.GetFieldDeserializers();
                }
                else if(SecretScanningLocationWikiCommit != null)
                {
                    return SecretScanningLocationWikiCommit.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(SecretScanningLocationCommit != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationCommit>(null, SecretScanningLocationCommit);
                }
                else if(SecretScanningLocationDiscussionBody != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationDiscussionBody>(null, SecretScanningLocationDiscussionBody);
                }
                else if(SecretScanningLocationDiscussionComment != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationDiscussionComment>(null, SecretScanningLocationDiscussionComment);
                }
                else if(SecretScanningLocationDiscussionTitle != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationDiscussionTitle>(null, SecretScanningLocationDiscussionTitle);
                }
                else if(SecretScanningLocationIssueBody != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationIssueBody>(null, SecretScanningLocationIssueBody);
                }
                else if(SecretScanningLocationIssueComment != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationIssueComment>(null, SecretScanningLocationIssueComment);
                }
                else if(SecretScanningLocationIssueTitle != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationIssueTitle>(null, SecretScanningLocationIssueTitle);
                }
                else if(SecretScanningLocationPullRequestBody != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationPullRequestBody>(null, SecretScanningLocationPullRequestBody);
                }
                else if(SecretScanningLocationPullRequestComment != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationPullRequestComment>(null, SecretScanningLocationPullRequestComment);
                }
                else if(SecretScanningLocationPullRequestReview != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationPullRequestReview>(null, SecretScanningLocationPullRequestReview);
                }
                else if(SecretScanningLocationPullRequestReviewComment != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationPullRequestReviewComment>(null, SecretScanningLocationPullRequestReviewComment);
                }
                else if(SecretScanningLocationPullRequestTitle != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationPullRequestTitle>(null, SecretScanningLocationPullRequestTitle);
                }
                else if(SecretScanningLocationWikiCommit != null)
                {
                    writer.WriteObjectValue<GitHub.Models.SecretScanningLocationWikiCommit>(null, SecretScanningLocationWikiCommit);
                }
            }
        }
    }
}
