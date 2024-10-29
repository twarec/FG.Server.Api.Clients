using System.Runtime.Serialization;

namespace FG.Server.Api.Clients.Admin.Models
{
    public enum UserRole
    {
        [EnumMember(Value = "Moderator")]
        Moderator,
        [EnumMember(Value = "Analyst")]
        Analyst,
        [EnumMember(Value = "Admin")]
        Admin
    }

    public enum ResponceType
    {
        Enable,
        Disable
    }

    public enum UserStatus
    {
        Enable,
        Disable,
        Blocked
    }
}
