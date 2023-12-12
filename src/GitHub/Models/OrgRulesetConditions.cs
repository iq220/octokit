// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Conditions for an organization ruleset. The conditions object should contain both `repository_name` and `ref_name` properties or both `repository_id` and `ref_name` properties.
    /// </summary>
    public class OrgRulesetConditions : IAdditionalDataHolder, IComposedTypeWrapper, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Composed type representation for type RepositoryRulesetConditionsForRepositoryIDs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs? OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryIDs { get; set; }
#nullable restore
#else
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryIDs { get; set; }
#endif
        /// <summary>Composed type representation for type RepositoryRulesetConditionsForRepositoryNames</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryNames? OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryNames { get; set; }
#nullable restore
#else
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryNames OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryNames { get; set; }
#endif
        /// <summary>Composed type representation for type RepositoryRulesetConditionsForRepositoryIDs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs? RepositoryRulesetConditionsForRepositoryIDs { get; set; }
#nullable restore
#else
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs RepositoryRulesetConditionsForRepositoryIDs { get; set; }
#endif
        /// <summary>Composed type representation for type RepositoryRulesetConditionsForRepositoryNames</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryNames? RepositoryRulesetConditionsForRepositoryNames { get; set; }
#nullable restore
#else
        public GitHub.Models.RepositoryRulesetConditionsForRepositoryNames RepositoryRulesetConditionsForRepositoryNames { get; set; }
#endif
        /// <summary>
        /// Instantiates a new orgRulesetConditions and sets the default values.
        /// </summary>
        public OrgRulesetConditions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrgRulesetConditions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
            var result = new OrgRulesetConditions();
            if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryIDs = new GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryNames = new GitHub.Models.RepositoryRulesetConditionsForRepositoryNames();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.RepositoryRulesetConditionsForRepositoryIDs = new GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.RepositoryRulesetConditionsForRepositoryNames = new GitHub.Models.RepositoryRulesetConditionsForRepositoryNames();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            if(OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryIDs != null) {
                return OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryIDs.GetFieldDeserializers();
            }
            else if(OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryNames != null) {
                return OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryNames.GetFieldDeserializers();
            }
            else if(RepositoryRulesetConditionsForRepositoryIDs != null) {
                return RepositoryRulesetConditionsForRepositoryIDs.GetFieldDeserializers();
            }
            else if(RepositoryRulesetConditionsForRepositoryNames != null) {
                return RepositoryRulesetConditionsForRepositoryNames.GetFieldDeserializers();
            }
            return new Dictionary<string, Action<IParseNode>>();
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            if(OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryIDs != null) {
                writer.WriteObjectValue<GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs>(null, OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryIDs);
            }
            else if(OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryNames != null) {
                writer.WriteObjectValue<GitHub.Models.RepositoryRulesetConditionsForRepositoryNames>(null, OrgRulesetConditionsRepositoryRulesetConditionsForRepositoryNames);
            }
            else if(RepositoryRulesetConditionsForRepositoryIDs != null) {
                writer.WriteObjectValue<GitHub.Models.RepositoryRulesetConditionsForRepositoryIDs>(null, RepositoryRulesetConditionsForRepositoryIDs);
            }
            else if(RepositoryRulesetConditionsForRepositoryNames != null) {
                writer.WriteObjectValue<GitHub.Models.RepositoryRulesetConditionsForRepositoryNames>(null, RepositoryRulesetConditionsForRepositoryNames);
            }
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
