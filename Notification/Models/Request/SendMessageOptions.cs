namespace FG.Server.Notification.Api.Models.Request
{
	public class SendMessageOptions
	{
		public byte DeviceType { get; set; }

		public string? Title { get; set; }
		public string? Body { get; set; }

		public Dictionary<string, string>? Metadata { get; set; } = [];
	}
}
