using System;

namespace FG.Server.Api.Clients.Entities.Organization.Models.Response.Enums
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