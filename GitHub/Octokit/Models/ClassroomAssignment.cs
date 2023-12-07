// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Octokit.Client.Models {
    /// <summary>
    /// A GitHub Classroom assignment
    /// </summary>
    public class ClassroomAssignment : IAdditionalDataHolder, IParsable {
        /// <summary>The number of students that have accepted the assignment.</summary>
        public int? Accepted { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub Classroom classroom</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Octokit.Client.Models.Classroom? Classroom { get; set; }
#nullable restore
#else
        public Octokit.Client.Models.Classroom Classroom { get; set; }
#endif
        /// <summary>The time at which the assignment is due.</summary>
        public DateTimeOffset? Deadline { get; set; }
        /// <summary>The selected editor for the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Editor { get; set; }
#nullable restore
#else
        public string Editor { get; set; }
#endif
        /// <summary>Whether feedback pull request will be created when a student accepts the assignment.</summary>
        public bool? FeedbackPullRequestsEnabled { get; set; }
        /// <summary>Unique identifier of the repository.</summary>
        public int? Id { get; set; }
        /// <summary>Whether the invitation link is enabled. Visiting an enabled invitation link will accept the assignment.</summary>
        public bool? InvitationsEnabled { get; set; }
        /// <summary>The link that a student can use to accept the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InviteLink { get; set; }
#nullable restore
#else
        public string InviteLink { get; set; }
#endif
        /// <summary>The programming language used in the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The maximum allowable members per team.</summary>
        public int? MaxMembers { get; set; }
        /// <summary>The maximum allowable teams for the assignment.</summary>
        public int? MaxTeams { get; set; }
        /// <summary>The number of students that have passed the assignment.</summary>
        public int? Passing { get; set; }
        /// <summary>Whether an accepted assignment creates a public repository.</summary>
        public bool? PublicRepo { get; set; }
        /// <summary>Sluggified name of the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>A GitHub repository view for Classroom</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleClassroomRepository? StarterCodeRepository { get; set; }
#nullable restore
#else
        public SimpleClassroomRepository StarterCodeRepository { get; set; }
#endif
        /// <summary>Whether students are admins on created repository when a student accepts the assignment.</summary>
        public bool? StudentsAreRepoAdmins { get; set; }
        /// <summary>The number of students that have submitted the assignment.</summary>
        public int? Submitted { get; set; }
        /// <summary>Assignment title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>Whether it&apos;s a group assignment or individual assignment.</summary>
        public ClassroomAssignment_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new classroomAssignment and sets the default values.
        /// </summary>
        public ClassroomAssignment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ClassroomAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassroomAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accepted", n => { Accepted = n.GetIntValue(); } },
                {"classroom", n => { Classroom = n.GetObjectValue<Octokit.Client.Models.Classroom>(Octokit.Client.Models.Classroom.CreateFromDiscriminatorValue); } },
                {"deadline", n => { Deadline = n.GetDateTimeOffsetValue(); } },
                {"editor", n => { Editor = n.GetStringValue(); } },
                {"feedback_pull_requests_enabled", n => { FeedbackPullRequestsEnabled = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"invitations_enabled", n => { InvitationsEnabled = n.GetBoolValue(); } },
                {"invite_link", n => { InviteLink = n.GetStringValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"max_members", n => { MaxMembers = n.GetIntValue(); } },
                {"max_teams", n => { MaxTeams = n.GetIntValue(); } },
                {"passing", n => { Passing = n.GetIntValue(); } },
                {"public_repo", n => { PublicRepo = n.GetBoolValue(); } },
                {"slug", n => { Slug = n.GetStringValue(); } },
                {"starter_code_repository", n => { StarterCodeRepository = n.GetObjectValue<SimpleClassroomRepository>(SimpleClassroomRepository.CreateFromDiscriminatorValue); } },
                {"students_are_repo_admins", n => { StudentsAreRepoAdmins = n.GetBoolValue(); } },
                {"submitted", n => { Submitted = n.GetIntValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<ClassroomAssignment_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("accepted", Accepted);
            writer.WriteObjectValue<Octokit.Client.Models.Classroom>("classroom", Classroom);
            writer.WriteDateTimeOffsetValue("deadline", Deadline);
            writer.WriteStringValue("editor", Editor);
            writer.WriteBoolValue("feedback_pull_requests_enabled", FeedbackPullRequestsEnabled);
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("invitations_enabled", InvitationsEnabled);
            writer.WriteStringValue("invite_link", InviteLink);
            writer.WriteStringValue("language", Language);
            writer.WriteIntValue("max_members", MaxMembers);
            writer.WriteIntValue("max_teams", MaxTeams);
            writer.WriteIntValue("passing", Passing);
            writer.WriteBoolValue("public_repo", PublicRepo);
            writer.WriteStringValue("slug", Slug);
            writer.WriteObjectValue<SimpleClassroomRepository>("starter_code_repository", StarterCodeRepository);
            writer.WriteBoolValue("students_are_repo_admins", StudentsAreRepoAdmins);
            writer.WriteIntValue("submitted", Submitted);
            writer.WriteStringValue("title", Title);
            writer.WriteEnumValue<ClassroomAssignment_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
