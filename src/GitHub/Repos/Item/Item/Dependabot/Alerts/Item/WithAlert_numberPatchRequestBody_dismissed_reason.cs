// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Dependabot.Alerts.Item {
    /// <summary>**Required when `state` is `dismissed`.** A reason for dismissing the alert.</summary>
    public enum WithAlert_numberPatchRequestBody_dismissed_reason {
        [EnumMember(Value = "fix_started")]
        Fix_started,
        [EnumMember(Value = "inaccurate")]
        Inaccurate,
        [EnumMember(Value = "no_bandwidth")]
        No_bandwidth,
        [EnumMember(Value = "not_used")]
        Not_used,
        [EnumMember(Value = "tolerable_risk")]
        Tolerable_risk,
    }
}
