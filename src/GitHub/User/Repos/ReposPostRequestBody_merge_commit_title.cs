// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.User.Repos {
    /// <summary>The default value for a merge commit title.- `PR_TITLE` - default to the pull request&apos;s title.- `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).</summary>
    public enum ReposPostRequestBody_merge_commit_title {
        [EnumMember(Value = "PR_TITLE")]
        PR_TITLE,
        [EnumMember(Value = "MERGE_MESSAGE")]
        MERGE_MESSAGE,
    }
}
