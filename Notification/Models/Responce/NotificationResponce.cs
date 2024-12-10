namespace FG.Server.Notification.Api.Models.Responce;

public class NotificationResponce
{
	public string? Title { get; set; }
	public string? Body { get; set; }
	public string? Badge { get; set; }
	public string? Icon { get; set; }
	public string? Image { get; set; }

	public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
}
