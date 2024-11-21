namespace FG.Server.Api.Clients.Entities.Event.Models.Responce
{
	public class WorkTime
	{
		public Guid Id { get; set; }
		public long DayStart { get; set; }
		public long MinuteStart { get; set; }
		public long DayEnd { get; set; }
		public long MinuteEnd { get; set; }
	}
}