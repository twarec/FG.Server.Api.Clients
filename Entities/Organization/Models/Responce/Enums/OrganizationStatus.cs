using System;

namespace FG.Server.Organization.Api.Client.Models.Responce.Enums
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