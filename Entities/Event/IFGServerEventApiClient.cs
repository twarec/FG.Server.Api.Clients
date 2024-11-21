using FG.Server.Api.Clients.Entities.Event.Controllers;

namespace FG.Server.Api.Clients.Entities.Event
{
	public interface IFGServerEventApiClient
	{
		public IBookingController BookingController { get; }
		public IEventController EventController { get; }
		public IMemberController MemberController { get; }
	}
}