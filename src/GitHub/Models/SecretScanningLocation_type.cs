// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.</summary>
    public enum SecretScanningLocation_type
    {
        [EnumMember(Value = "commit")]
        #pragma warning disable CS1591
        Commit,
        #pragma warning restore CS1591
        [EnumMember(Value = "wiki_commit")]
        #pragma warning disable CS1591
        Wiki_commit,
        #pragma warning restore CS1591
        [EnumMember(Value = "issue_title")]
        #pragma warning disable CS1591
        Issue_title,
        #pragma warning restore CS1591
        [EnumMember(Value = "issue_body")]
        #pragma warning disable CS1591
        Issue_body,
        #pragma warning restore CS1591
        [EnumMember(Value = "issue_comment")]
        #pragma warning disable CS1591
        Issue_comment,
        #pragma warning restore CS1591
        [EnumMember(Value = "discussion_title")]
        #pragma warning disable CS1591
        Discussion_title,
        #pragma warning restore CS1591
        [EnumMember(Value = "discussion_body")]
        #pragma warning disable CS1591
        Discussion_body,
        #pragma warning restore CS1591
        [EnumMember(Value = "discussion_comment")]
        #pragma warning disable CS1591
        Discussion_comment,
        #pragma warning restore CS1591
        [EnumMember(Value = "pull_request_title")]
        #pragma warning disable CS1591
        Pull_request_title,
        #pragma warning restore CS1591
        [EnumMember(Value = "pull_request_body")]
        #pragma warning disable CS1591
        Pull_request_body,
        #pragma warning restore CS1591
        [EnumMember(Value = "pull_request_comment")]
        #pragma warning disable CS1591
        Pull_request_comment,
        #pragma warning restore CS1591
        [EnumMember(Value = "pull_request_review")]
        #pragma warning disable CS1591
        Pull_request_review,
        #pragma warning restore CS1591
        [EnumMember(Value = "pull_request_review_comment")]
        #pragma warning disable CS1591
        Pull_request_review_comment,
        #pragma warning restore CS1591
    }
}
