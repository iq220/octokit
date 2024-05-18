// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models
{
    /// <summary>The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see &quot;[About code scanning alerts](https://docs.github.com/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels).&quot;</summary>
    public enum RepositoryRuleParamsCodeScanningTool_security_alerts_threshold
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "critical")]
        #pragma warning disable CS1591
        Critical,
        #pragma warning restore CS1591
        [EnumMember(Value = "high_or_higher")]
        #pragma warning disable CS1591
        High_or_higher,
        #pragma warning restore CS1591
        [EnumMember(Value = "medium_or_higher")]
        #pragma warning disable CS1591
        Medium_or_higher,
        #pragma warning restore CS1591
        [EnumMember(Value = "all")]
        #pragma warning disable CS1591
        All,
        #pragma warning restore CS1591
    }
}
