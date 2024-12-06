using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Response.Enums
{
    public enum EventStatus
    {
        Editable,
        Edited,
        UnderConsideration,
        OnPublication,
        Published,
        StartingSoon,
        InProgress,
        FreeSeatsAtTheEvent,
        CanceledNotModeration,
        Hashed,
        CompletedByTheUserBeforeTheStart,
        StartedWithNoUsersAndFinished,
        RejectedByModerator,
        Completed
    }
}