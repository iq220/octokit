// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Orgs.Item.Members.Item.Codespaces.Item {
    [Obsolete("This class is obsolete. Use WithCodespace_nameDeleteResponse instead.")]
    public class WithCodespace_nameResponse : WithCodespace_nameDeleteResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WithCodespace_nameResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithCodespace_nameResponse();
        }
    }
}
