using System;

namespace FG.Server.Api.Clients.Entities.Models.Response.Enums
{
    public enum OrganizationStatus
    {
        Editable,
        Edited,
        Moderation,
        Active,
        Blocked,
        BlockedModeration,
        Inactive
    }
}