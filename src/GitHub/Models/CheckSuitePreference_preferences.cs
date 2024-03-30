// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    public class CheckSuitePreference_preferences : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The auto_trigger_checks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CheckSuitePreference_preferences_auto_trigger_checks>? AutoTriggerChecks { get; set; }
#nullable restore
#else
        public List<CheckSuitePreference_preferences_auto_trigger_checks> AutoTriggerChecks { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CheckSuitePreference_preferences"/> and sets the default values.
        /// </summary>
        public CheckSuitePreference_preferences()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CheckSuitePreference_preferences"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CheckSuitePreference_preferences CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CheckSuitePreference_preferences();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"auto_trigger_checks", n => { AutoTriggerChecks = n.GetCollectionOfObjectValues<CheckSuitePreference_preferences_auto_trigger_checks>(CheckSuitePreference_preferences_auto_trigger_checks.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CheckSuitePreference_preferences_auto_trigger_checks>("auto_trigger_checks", AutoTriggerChecks);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
