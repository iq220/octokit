// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Repos.Item.Item.Git.Tags {
    /// <summary>The type of the object we&apos;re tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.</summary>
    public enum TagsPostRequestBody_type {
        [EnumMember(Value = "commit")]
        Commit,
        [EnumMember(Value = "tree")]
        Tree,
        [EnumMember(Value = "blob")]
        Blob,
    }
}
