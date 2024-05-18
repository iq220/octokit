// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    #pragma warning disable CS1591
    public class ActionsBillingUsage_minutes_used_breakdown : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total minutes used on macOS runner machines.</summary>
        public int? MACOS { get; set; }
        /// <summary>Total minutes used on macOS 12 core runner machines.</summary>
        public int? Macos12Core { get; set; }
        /// <summary>Total minutes used on all runner machines.</summary>
        public int? Total { get; set; }
        /// <summary>Total minutes used on Ubuntu runner machines.</summary>
        public int? UBUNTU { get; set; }
        /// <summary>Total minutes used on Ubuntu 16 core runner machines.</summary>
        public int? Ubuntu16Core { get; set; }
        /// <summary>Total minutes used on Ubuntu 32 core runner machines.</summary>
        public int? Ubuntu32Core { get; set; }
        /// <summary>Total minutes used on Ubuntu 4 core runner machines.</summary>
        public int? Ubuntu4Core { get; set; }
        /// <summary>Total minutes used on Ubuntu 64 core runner machines.</summary>
        public int? Ubuntu64Core { get; set; }
        /// <summary>Total minutes used on Ubuntu 8 core runner machines.</summary>
        public int? Ubuntu8Core { get; set; }
        /// <summary>Total minutes used on Windows runner machines.</summary>
        public int? WINDOWS { get; set; }
        /// <summary>Total minutes used on Windows 16 core runner machines.</summary>
        public int? Windows16Core { get; set; }
        /// <summary>Total minutes used on Windows 32 core runner machines.</summary>
        public int? Windows32Core { get; set; }
        /// <summary>Total minutes used on Windows 4 core runner machines.</summary>
        public int? Windows4Core { get; set; }
        /// <summary>Total minutes used on Windows 64 core runner machines.</summary>
        public int? Windows64Core { get; set; }
        /// <summary>Total minutes used on Windows 8 core runner machines.</summary>
        public int? Windows8Core { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ActionsBillingUsage_minutes_used_breakdown"/> and sets the default values.
        /// </summary>
        public ActionsBillingUsage_minutes_used_breakdown()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActionsBillingUsage_minutes_used_breakdown"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ActionsBillingUsage_minutes_used_breakdown CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionsBillingUsage_minutes_used_breakdown();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "MACOS", n => { MACOS = n.GetIntValue(); } },
                { "macos_12_core", n => { Macos12Core = n.GetIntValue(); } },
                { "total", n => { Total = n.GetIntValue(); } },
                { "UBUNTU", n => { UBUNTU = n.GetIntValue(); } },
                { "ubuntu_16_core", n => { Ubuntu16Core = n.GetIntValue(); } },
                { "ubuntu_32_core", n => { Ubuntu32Core = n.GetIntValue(); } },
                { "ubuntu_4_core", n => { Ubuntu4Core = n.GetIntValue(); } },
                { "ubuntu_64_core", n => { Ubuntu64Core = n.GetIntValue(); } },
                { "ubuntu_8_core", n => { Ubuntu8Core = n.GetIntValue(); } },
                { "WINDOWS", n => { WINDOWS = n.GetIntValue(); } },
                { "windows_16_core", n => { Windows16Core = n.GetIntValue(); } },
                { "windows_32_core", n => { Windows32Core = n.GetIntValue(); } },
                { "windows_4_core", n => { Windows4Core = n.GetIntValue(); } },
                { "windows_64_core", n => { Windows64Core = n.GetIntValue(); } },
                { "windows_8_core", n => { Windows8Core = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("MACOS", MACOS);
            writer.WriteIntValue("macos_12_core", Macos12Core);
            writer.WriteIntValue("total", Total);
            writer.WriteIntValue("UBUNTU", UBUNTU);
            writer.WriteIntValue("ubuntu_16_core", Ubuntu16Core);
            writer.WriteIntValue("ubuntu_32_core", Ubuntu32Core);
            writer.WriteIntValue("ubuntu_4_core", Ubuntu4Core);
            writer.WriteIntValue("ubuntu_64_core", Ubuntu64Core);
            writer.WriteIntValue("ubuntu_8_core", Ubuntu8Core);
            writer.WriteIntValue("WINDOWS", WINDOWS);
            writer.WriteIntValue("windows_16_core", Windows16Core);
            writer.WriteIntValue("windows_32_core", Windows32Core);
            writer.WriteIntValue("windows_4_core", Windows4Core);
            writer.WriteIntValue("windows_64_core", Windows64Core);
            writer.WriteIntValue("windows_8_core", Windows8Core);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
