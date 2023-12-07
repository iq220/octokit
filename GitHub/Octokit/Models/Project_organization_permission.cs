// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Octokit.Client.Models {
    /// <summary>The baseline permission that all organization members have on this project. Only present if owner is an organization.</summary>
    public enum Project_organization_permission {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write,
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "none")]
        None,
    }
}
