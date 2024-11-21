namespace FG.Server.Api.Clients.Admin.Models.Request
{
	public class ModerationResponceOptions
	{
		public int Id { get; set; }
		public ResponceType Type { get; set; }
		public string Description { get; set; } = string.Empty;
	}
}
