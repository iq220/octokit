// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    public enum PagesHttpsCertificate_state {
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "authorization_created")]
        Authorization_created,
        [EnumMember(Value = "authorization_pending")]
        Authorization_pending,
        [EnumMember(Value = "authorized")]
        Authorized,
        [EnumMember(Value = "authorization_revoked")]
        Authorization_revoked,
        [EnumMember(Value = "issued")]
        Issued,
        [EnumMember(Value = "uploaded")]
        Uploaded,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "errored")]
        Errored,
        [EnumMember(Value = "bad_authz")]
        Bad_authz,
        [EnumMember(Value = "destroy_pending")]
        Destroy_pending,
        [EnumMember(Value = "dns_changed")]
        Dns_changed,
    }
}
