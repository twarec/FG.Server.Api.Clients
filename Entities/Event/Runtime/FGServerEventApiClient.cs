using System;
using FG.Server.Api.Clients.Entities.Event;
using FG.Server.Api.Clients.Entities.Event.Controllers;

namespace FG.Server.Api.Clients.Entities.Event.Runtime
{
    public class FGServerEventApiClient : IFGServerEventApiClient
    {
        private static HttpClient? _client;
        public IBookingController BookingController { get; }
        public IEventController EventController { get; }
        public IMemberController MemberController { get; }

        public FGServerEventApiClient(HttpClient client)
        {
            _client = client;
            BookingController = Refit.RestService.For<IBookingController>(_client);
            EventController = Refit.RestService.For<IEventController>(_client);
            MemberController = Refit.RestService.For<IMemberController>(_client);
        }
    }
}