// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Teams.Item.Projects.Item {
    /// <summary>The permission to grant to the team for this project. Default: the team&apos;s `permission` attribute will be used to determine what permission to grant the team on this project. Note that, if you choose not to pass any parameters, you&apos;ll need to set `Content-Length` to zero when calling this endpoint. For more information, see &quot;[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method).&quot;</summary>
    public enum WithProject_PutRequestBody_permission
    {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write,
        [EnumMember(Value = "admin")]
        Admin,
    }
}
