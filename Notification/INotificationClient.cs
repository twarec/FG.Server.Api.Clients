using FG.Server.Api.Clients.Notification.Controllers;
using FG.Server.Api.Clients.User.Controllers;

namespace FG.Server.Api.Clients.Notification;

public interface INotificationClient
{
	public Uri? Url { get; }
	public HttpClient HttpClient { get; }

	public  IUserController UserController { get; }
	public INotificationController NotificationController { get; }
	public IDeviceController DeviceController { get; }
}
