using System;
using FG.Server.Api.Clients.Entities.Controllers;

namespace FG.Server.Api.Clients.Entities
{
    public interface IFGServerEventApiClient
    {
        public IBookingController BookingController { get; }
        public IEventController EventController { get; }
        public IMemberController MemberController { get; }
    }
}