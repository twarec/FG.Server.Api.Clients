namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
	public class UpdateEventPrice
	{
		public ulong Amount { get; set; }
		public string Currency { get; set; } = "";
	}
}