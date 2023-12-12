// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>The organization policy for allowing or disallowing Copilot to make suggestions that match public code.</summary>
    public enum CopilotOrganizationDetails_public_code_suggestions {
        [EnumMember(Value = "allow")]
        Allow,
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "unconfigured")]
        Unconfigured,
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}
