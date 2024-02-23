// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class RepositoryAdvisoryCreate : IParsable {
        /// <summary>A list of users receiving credit for their participation in the security advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryAdvisoryCreate_credits>? Credits { get; set; }
#nullable restore
#else
        public List<RepositoryAdvisoryCreate_credits> Credits { get; set; }
#endif
        /// <summary>The Common Vulnerabilities and Exposures (CVE) ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CveId { get; set; }
#nullable restore
#else
        public string CveId { get; set; }
#endif
        /// <summary>The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CvssVectorString { get; set; }
#nullable restore
#else
        public string CvssVectorString { get; set; }
#endif
        /// <summary>A list of Common Weakness Enumeration (CWE) IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CweIds { get; set; }
#nullable restore
#else
        public List<string> CweIds { get; set; }
#endif
        /// <summary>A detailed description of what the advisory impacts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.</summary>
        public RepositoryAdvisoryCreate_severity? Severity { get; set; }
        /// <summary>Whether to create a temporary private fork of the repository to collaborate on a fix.</summary>
        public bool? StartPrivateFork { get; set; }
        /// <summary>A short summary of the advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>A product affected by the vulnerability detailed in a repository security advisory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RepositoryAdvisoryCreate_vulnerabilities>? Vulnerabilities { get; set; }
#nullable restore
#else
        public List<RepositoryAdvisoryCreate_vulnerabilities> Vulnerabilities { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RepositoryAdvisoryCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryAdvisoryCreate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryAdvisoryCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"credits", n => { Credits = n.GetCollectionOfObjectValues<RepositoryAdvisoryCreate_credits>(RepositoryAdvisoryCreate_credits.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cve_id", n => { CveId = n.GetStringValue(); } },
                {"cvss_vector_string", n => { CvssVectorString = n.GetStringValue(); } },
                {"cwe_ids", n => { CweIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<RepositoryAdvisoryCreate_severity>(); } },
                {"start_private_fork", n => { StartPrivateFork = n.GetBoolValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
                {"vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<RepositoryAdvisoryCreate_vulnerabilities>(RepositoryAdvisoryCreate_vulnerabilities.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RepositoryAdvisoryCreate_credits>("credits", Credits);
            writer.WriteStringValue("cve_id", CveId);
            writer.WriteStringValue("cvss_vector_string", CvssVectorString);
            writer.WriteCollectionOfPrimitiveValues<string>("cwe_ids", CweIds);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<RepositoryAdvisoryCreate_severity>("severity", Severity);
            writer.WriteBoolValue("start_private_fork", StartPrivateFork);
            writer.WriteStringValue("summary", Summary);
            writer.WriteCollectionOfObjectValues<RepositoryAdvisoryCreate_vulnerabilities>("vulnerabilities", Vulnerabilities);
        }
    }
}
