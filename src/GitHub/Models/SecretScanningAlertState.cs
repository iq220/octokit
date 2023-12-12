// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.</summary>
    public enum SecretScanningAlertState {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "resolved")]
        Resolved,
    }
}
