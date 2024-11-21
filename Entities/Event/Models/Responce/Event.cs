namespace FG.Server.Api.Clients.Entities.Event.Models.Responce
{
	public class Event
	{
		public Guid Id { get; set; }
		public Guid OrganizationId { get; set; }
		public Responce.Enums.EventStatus Status { get; set; }
		public Responce.EventInform EventInform { get; set; } = new Responce.EventInform();
		public ICollection<Booking> Bookings { get; set; } = [];
		public ICollection<Responce.Member> Members { get; set; } = [];
	}
}