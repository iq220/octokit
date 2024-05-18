// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// A Dependabot alert.
    /// </summary>
    public class DependabotAlert : IParsable
    {
        /// <summary>The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? AutoDismissedAt { get; private set; }
        /// <summary>The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Details for the vulnerable dependency.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DependabotAlert_dependency? Dependency { get; private set; }
#nullable restore
#else
        public DependabotAlert_dependency Dependency { get; private set; }
#endif
        /// <summary>The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? DismissedAt { get; private set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? DismissedBy { get; set; }
#nullable restore
#else
        public NullableSimpleUser DismissedBy { get; set; }
#endif
        /// <summary>An optional comment associated with the alert&apos;s dismissal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DismissedComment { get; set; }
#nullable restore
#else
        public string DismissedComment { get; set; }
#endif
        /// <summary>The reason that the alert was dismissed.</summary>
        public DependabotAlert_dismissed_reason? DismissedReason { get; set; }
        /// <summary>The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? FixedAt { get; private set; }
        /// <summary>The GitHub URL of the alert resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; private set; }
#nullable restore
#else
        public string HtmlUrl { get; private set; }
#endif
        /// <summary>The security alert number.</summary>
        public int? Number { get; private set; }
        /// <summary>Details for the GitHub Security Advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DependabotAlertSecurityAdvisory? SecurityAdvisory { get; private set; }
#nullable restore
#else
        public DependabotAlertSecurityAdvisory SecurityAdvisory { get; private set; }
#endif
        /// <summary>Details pertaining to one vulnerable version range for the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DependabotAlertSecurityVulnerability? SecurityVulnerability { get; private set; }
#nullable restore
#else
        public DependabotAlertSecurityVulnerability SecurityVulnerability { get; private set; }
#endif
        /// <summary>The state of the Dependabot alert.</summary>
        public DependabotAlert_state? State { get; private set; }
        /// <summary>The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The REST API URL of the alert resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DependabotAlert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DependabotAlert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DependabotAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auto_dismissed_at", n => { AutoDismissedAt = n.GetDateTimeOffsetValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "dependency", n => { Dependency = n.GetObjectValue<DependabotAlert_dependency>(DependabotAlert_dependency.CreateFromDiscriminatorValue); } },
                { "dismissed_at", n => { DismissedAt = n.GetDateTimeOffsetValue(); } },
                { "dismissed_by", n => { DismissedBy = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "dismissed_comment", n => { DismissedComment = n.GetStringValue(); } },
                { "dismissed_reason", n => { DismissedReason = n.GetEnumValue<DependabotAlert_dismissed_reason>(); } },
                { "fixed_at", n => { FixedAt = n.GetDateTimeOffsetValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "number", n => { Number = n.GetIntValue(); } },
                { "security_advisory", n => { SecurityAdvisory = n.GetObjectValue<DependabotAlertSecurityAdvisory>(DependabotAlertSecurityAdvisory.CreateFromDiscriminatorValue); } },
                { "security_vulnerability", n => { SecurityVulnerability = n.GetObjectValue<DependabotAlertSecurityVulnerability>(DependabotAlertSecurityVulnerability.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<DependabotAlert_state>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<NullableSimpleUser>("dismissed_by", DismissedBy);
            writer.WriteStringValue("dismissed_comment", DismissedComment);
            writer.WriteEnumValue<DependabotAlert_dismissed_reason>("dismissed_reason", DismissedReason);
        }
    }
}
