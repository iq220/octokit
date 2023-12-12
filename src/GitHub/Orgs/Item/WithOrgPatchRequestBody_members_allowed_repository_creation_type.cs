// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Orgs.Item {
    /// <summary>Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud. **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.</summary>
    public enum WithOrgPatchRequestBody_members_allowed_repository_creation_type {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "none")]
        None,
    }
}
