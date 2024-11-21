namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
	public class UpdateEventAddress
	{
		public string Data { get; set; } = "";
		public double Longitude { get; set; }
		public double Latitude { get; set; }
	}
}