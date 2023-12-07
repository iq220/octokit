// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Octokit.Client.Models {
    /// <summary>The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.</summary>
    public enum InteractionGroup {
        [EnumMember(Value = "existing_users")]
        Existing_users,
        [EnumMember(Value = "contributors_only")]
        Contributors_only,
        [EnumMember(Value = "collaborators_only")]
        Collaborators_only,
    }
}
