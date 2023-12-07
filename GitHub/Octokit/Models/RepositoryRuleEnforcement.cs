// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Octokit.Client.Models {
    /// <summary>The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).</summary>
    public enum RepositoryRuleEnforcement {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "evaluate")]
        Evaluate,
    }
}
