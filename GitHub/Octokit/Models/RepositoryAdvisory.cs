// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// A repository security advisory.
    /// </summary>
    public class RepositoryAdvisory : IParsable {
        /// <summary>The author of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Author { get; private set; }
#nullable restore
#else
        public SimpleUser Author { get; private set; }
#endif
        /// <summary>The date and time of when the advisory was closed, in ISO 8601 format.</summary>
        public DateTimeOffset? ClosedAt { get; private set; }
        /// <summary>A list of teams that collaborate on the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Team>? CollaboratingTeams { get; set; }
#nullable restore
#else
        public List<Team> CollaboratingTeams { get; set; }
#endif
        /// <summary>A list of users that collaborate on the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? CollaboratingUsers { get; set; }
#nullable restore
#else
        public List<SimpleUser> CollaboratingUsers { get; set; }
#endif
        /// <summary>The date and time of when the advisory was created, in ISO 8601 format.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The credits property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryAdvisory_credits>? Credits { get; set; }
#nullable restore
#else
        public List<RepositoryAdvisory_credits> Credits { get; set; }
#endif
        /// <summary>The credits_detailed property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryAdvisoryCredit>? CreditsDetailed { get; private set; }
#nullable restore
#else
        public List<RepositoryAdvisoryCredit> CreditsDetailed { get; private set; }
#endif
        /// <summary>The Common Vulnerabilities and Exposures (CVE) ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CveId { get; set; }
#nullable restore
#else
        public string CveId { get; set; }
#endif
        /// <summary>The cvss property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryAdvisory_cvss? Cvss { get; set; }
#nullable restore
#else
        public RepositoryAdvisory_cvss Cvss { get; set; }
#endif
        /// <summary>A list of only the CWE IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CweIds { get; set; }
#nullable restore
#else
        public List<string> CweIds { get; set; }
#endif
        /// <summary>The cwes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryAdvisory_cwes>? Cwes { get; private set; }
#nullable restore
#else
        public List<RepositoryAdvisory_cwes> Cwes { get; private set; }
#endif
        /// <summary>A detailed description of what the advisory entails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The GitHub Security Advisory ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GhsaId { get; private set; }
#nullable restore
#else
        public string GhsaId { get; private set; }
#endif
        /// <summary>The URL for the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; private set; }
#nullable restore
#else
        public string HtmlUrl { get; private set; }
#endif
        /// <summary>The identifiers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryAdvisory_identifiers>? Identifiers { get; private set; }
#nullable restore
#else
        public List<RepositoryAdvisory_identifiers> Identifiers { get; private set; }
#endif
        /// <summary>A temporary private fork of the advisory&apos;s repository for collaborating on a fix.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleRepository? PrivateFork { get; private set; }
#nullable restore
#else
        public SimpleRepository PrivateFork { get; private set; }
#endif
        /// <summary>The date and time of when the advisory was published, in ISO 8601 format.</summary>
        public DateTimeOffset? PublishedAt { get; private set; }
        /// <summary>The publisher of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Publisher { get; private set; }
#nullable restore
#else
        public SimpleUser Publisher { get; private set; }
#endif
        /// <summary>The severity of the advisory.</summary>
        public RepositoryAdvisory_severity? Severity { get; set; }
        /// <summary>The state of the advisory.</summary>
        public RepositoryAdvisory_state? State { get; set; }
        /// <summary>The submission property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryAdvisory_submission? Submission { get; private set; }
#nullable restore
#else
        public RepositoryAdvisory_submission Submission { get; private set; }
#endif
        /// <summary>A short summary of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>The date and time of when the advisory was last updated, in ISO 8601 format.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The API URL for the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>The vulnerabilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryAdvisoryVulnerability>? Vulnerabilities { get; set; }
#nullable restore
#else
        public List<RepositoryAdvisoryVulnerability> Vulnerabilities { get; set; }
#endif
        /// <summary>The date and time of when the advisory was withdrawn, in ISO 8601 format.</summary>
        public DateTimeOffset? WithdrawnAt { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryAdvisory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryAdvisory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"author", n => { Author = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                {"collaborating_teams", n => { CollaboratingTeams = n.GetCollectionOfObjectValues<Team>(Team.CreateFromDiscriminatorValue)?.ToList(); } },
                {"collaborating_users", n => { CollaboratingUsers = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"credits", n => { Credits = n.GetCollectionOfObjectValues<RepositoryAdvisory_credits>(RepositoryAdvisory_credits.CreateFromDiscriminatorValue)?.ToList(); } },
                {"credits_detailed", n => { CreditsDetailed = n.GetCollectionOfObjectValues<RepositoryAdvisoryCredit>(RepositoryAdvisoryCredit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cve_id", n => { CveId = n.GetStringValue(); } },
                {"cvss", n => { Cvss = n.GetObjectValue<RepositoryAdvisory_cvss>(RepositoryAdvisory_cvss.CreateFromDiscriminatorValue); } },
                {"cwe_ids", n => { CweIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"cwes", n => { Cwes = n.GetCollectionOfObjectValues<RepositoryAdvisory_cwes>(RepositoryAdvisory_cwes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"ghsa_id", n => { GhsaId = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"identifiers", n => { Identifiers = n.GetCollectionOfObjectValues<RepositoryAdvisory_identifiers>(RepositoryAdvisory_identifiers.CreateFromDiscriminatorValue)?.ToList(); } },
                {"private_fork", n => { PrivateFork = n.GetObjectValue<SimpleRepository>(SimpleRepository.CreateFromDiscriminatorValue); } },
                {"published_at", n => { PublishedAt = n.GetDateTimeOffsetValue(); } },
                {"publisher", n => { Publisher = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"severity", n => { Severity = n.GetEnumValue<RepositoryAdvisory_severity>(); } },
                {"state", n => { State = n.GetEnumValue<RepositoryAdvisory_state>(); } },
                {"submission", n => { Submission = n.GetObjectValue<RepositoryAdvisory_submission>(RepositoryAdvisory_submission.CreateFromDiscriminatorValue); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<RepositoryAdvisoryVulnerability>(RepositoryAdvisoryVulnerability.CreateFromDiscriminatorValue)?.ToList(); } },
                {"withdrawn_at", n => { WithdrawnAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Team>("collaborating_teams", CollaboratingTeams);
            writer.WriteCollectionOfObjectValues<SimpleUser>("collaborating_users", CollaboratingUsers);
            writer.WriteCollectionOfObjectValues<RepositoryAdvisory_credits>("credits", Credits);
            writer.WriteStringValue("cve_id", CveId);
            writer.WriteObjectValue<RepositoryAdvisory_cvss>("cvss", Cvss);
            writer.WriteCollectionOfPrimitiveValues<string>("cwe_ids", CweIds);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<RepositoryAdvisory_severity>("severity", Severity);
            writer.WriteEnumValue<RepositoryAdvisory_state>("state", State);
            writer.WriteStringValue("summary", Summary);
            writer.WriteCollectionOfObjectValues<RepositoryAdvisoryVulnerability>("vulnerabilities", Vulnerabilities);
        }
    }
}
