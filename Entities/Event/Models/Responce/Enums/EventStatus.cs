using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Responce.Enums
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
        Hasheded,
        CompletedByTheUserBeforeTheStart,
        StartedWithNoUsersAndFinished,
        RejectedByModerator,
        Completed
    }
}