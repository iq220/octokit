// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models
{
    /// <summary>
    /// Check suite configuration preferences for a repository.
    /// </summary>
    public class CheckSuitePreference : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The preferences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CheckSuitePreference_preferences? Preferences { get; set; }
#nullable restore
#else
        public CheckSuitePreference_preferences Preferences { get; set; }
#endif
        /// <summary>Minimal Repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MinimalRepository? Repository { get; set; }
#nullable restore
#else
        public MinimalRepository Repository { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CheckSuitePreference"/> and sets the default values.
        /// </summary>
        public CheckSuitePreference()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CheckSuitePreference"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CheckSuitePreference CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CheckSuitePreference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "preferences", n => { Preferences = n.GetObjectValue<CheckSuitePreference_preferences>(CheckSuitePreference_preferences.CreateFromDiscriminatorValue); } },
                { "repository", n => { Repository = n.GetObjectValue<MinimalRepository>(MinimalRepository.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CheckSuitePreference_preferences>("preferences", Preferences);
            writer.WriteObjectValue<MinimalRepository>("repository", Repository);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
