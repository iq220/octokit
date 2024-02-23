// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// Information about the seat breakdown and policies set for an organization with a Copilot Business subscription.
    /// </summary>
    public class CopilotOrganizationDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The organization policy for allowing or disallowing organization members to use Copilot within their CLI.</summary>
        public CopilotOrganizationDetails_cli? Cli { get; set; }
        /// <summary>The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.</summary>
        public CopilotOrganizationDetails_ide_chat? IdeChat { get; set; }
        /// <summary>The organization policy for allowing or disallowing organization members to use Copilot features within github.com.</summary>
        public CopilotOrganizationDetails_platform_chat? PlatformChat { get; set; }
        /// <summary>The organization policy for allowing or disallowing Copilot to make suggestions that match public code.</summary>
        public CopilotOrganizationDetails_public_code_suggestions? PublicCodeSuggestions { get; set; }
        /// <summary>The breakdown of Copilot Business seats for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CopilotSeatBreakdown? SeatBreakdown { get; set; }
#nullable restore
#else
        public CopilotSeatBreakdown SeatBreakdown { get; set; }
#endif
        /// <summary>The mode of assigning new seats.</summary>
        public CopilotOrganizationDetails_seat_management_setting? SeatManagementSetting { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="CopilotOrganizationDetails"/> and sets the default values.
        /// </summary>
        public CopilotOrganizationDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CopilotOrganizationDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CopilotOrganizationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopilotOrganizationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cli", n => { Cli = n.GetEnumValue<CopilotOrganizationDetails_cli>(); } },
                {"ide_chat", n => { IdeChat = n.GetEnumValue<CopilotOrganizationDetails_ide_chat>(); } },
                {"platform_chat", n => { PlatformChat = n.GetEnumValue<CopilotOrganizationDetails_platform_chat>(); } },
                {"public_code_suggestions", n => { PublicCodeSuggestions = n.GetEnumValue<CopilotOrganizationDetails_public_code_suggestions>(); } },
                {"seat_breakdown", n => { SeatBreakdown = n.GetObjectValue<CopilotSeatBreakdown>(CopilotSeatBreakdown.CreateFromDiscriminatorValue); } },
                {"seat_management_setting", n => { SeatManagementSetting = n.GetEnumValue<CopilotOrganizationDetails_seat_management_setting>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CopilotOrganizationDetails_cli>("cli", Cli);
            writer.WriteEnumValue<CopilotOrganizationDetails_ide_chat>("ide_chat", IdeChat);
            writer.WriteEnumValue<CopilotOrganizationDetails_platform_chat>("platform_chat", PlatformChat);
            writer.WriteEnumValue<CopilotOrganizationDetails_public_code_suggestions>("public_code_suggestions", PublicCodeSuggestions);
            writer.WriteObjectValue<CopilotSeatBreakdown>("seat_breakdown", SeatBreakdown);
            writer.WriteEnumValue<CopilotOrganizationDetails_seat_management_setting>("seat_management_setting", SeatManagementSetting);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
