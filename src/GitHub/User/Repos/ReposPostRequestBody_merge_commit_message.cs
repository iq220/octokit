// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.User.Repos {
    /// <summary>The default value for a merge commit message.- `PR_TITLE` - default to the pull request&apos;s title.- `PR_BODY` - default to the pull request&apos;s body.- `BLANK` - default to a blank commit message.</summary>
    public enum ReposPostRequestBody_merge_commit_message
    {
        [EnumMember(Value = "PR_BODY")]
        PR_BODY,
        [EnumMember(Value = "PR_TITLE")]
        PR_TITLE,
        [EnumMember(Value = "BLANK")]
        BLANK,
    }
}
