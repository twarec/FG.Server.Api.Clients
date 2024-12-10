namespace FG.Server.Notification.Api.Models.Responce;

public class UserResponce
{
	public Guid UserId { get; set; }

	public List<DeviceResponce> Devices { get; set; } = [];
}
